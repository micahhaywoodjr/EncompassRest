﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Token;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public class EncompassRestClient
    {
        public static async Task<EncompassRestClient> CreateFromUserCredentialsAsync(string clientId, string clientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling = TokenExpirationHandling.Default)
        {
            Preconditions.NotNullOrEmpty(instanceId, nameof(instanceId));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));
            Preconditions.NotNullOrEmpty(password, nameof(password));

            var client = tokenExpirationHandling == TokenExpirationHandling.RetrieveNewToken ? new EncompassRestClient(clientId, clientSecret, instanceId, userId, password, tokenExpirationHandling) : new EncompassRestClient(clientId, clientSecret);
            await client.AccessToken.SetTokenWithUserCredentialsAsync(instanceId, userId, password).ConfigureAwait(false);
            return client;
        }

        public static async Task<EncompassRestClient> CreateFromAuthorizationCodeAsync(string clientId, string clientSecret, string redirectUri, string authorizationCode)
        {
            Preconditions.NotNullOrEmpty(redirectUri, nameof(redirectUri));
            Preconditions.NotNullOrEmpty(authorizationCode, nameof(authorizationCode));

            var client = new EncompassRestClient(clientId, clientSecret);
            await client.AccessToken.SetTokenWithAuthorizationCodeAsync(redirectUri, authorizationCode).ConfigureAwait(false);
            return client;
        }

        public static EncompassRestClient CreateFromAccessToken(string clientId, string clientSecret, string accessToken, string tokenType = "Bearer")
        {
            Preconditions.NotNullOrEmpty(accessToken, nameof(accessToken));
            Preconditions.NotNullOrEmpty(tokenType, nameof(tokenType));

            var client = new EncompassRestClient(clientId, clientSecret);
            client.AccessToken.Token = accessToken;
            client.AccessToken.Type = tokenType;
            return client;
        }
        
        private readonly string _instanceId;
        private readonly string _userId;
        private readonly string _password;

        private HttpClient _httpClient;
        private Loans _loans;
        private Schemas _schemas;
        private Webhooks _webhooks;
        private Reports _reports;
        private Pipeline _pipeline;

        #region Properties
        public AccessToken AccessToken { get; }

        public TokenExpirationHandling TokenExpirationHandling { get; }

        public Loans Loans
        {
            get
            {
                Loans loans;
                return _loans ?? Interlocked.CompareExchange(ref _loans, (loans = new Loans(this)), null) ?? loans;
            }
        }

        public Schemas Schemas
        {
            get
            {
                Schemas schemas;
                return _schemas ?? Interlocked.CompareExchange(ref _schemas, (schemas = new Schemas(this)), null) ?? schemas;
            }
        }

        public Webhooks Webhooks
        {
            get
            {
                Webhooks webhooks;
                return _webhooks ?? Interlocked.CompareExchange(ref _webhooks, (webhooks = new Webhooks(this)), null) ?? webhooks;
            }
        }

        public Reports Reports
        {
            get
            {
                Reports reports;
                return _reports ?? Interlocked.CompareExchange(ref _reports, (reports = new Reports(this)), null) ?? reports;
            }
        }

        public Pipeline Pipeline
        {
            get
            {
                Pipeline loans;
                return _pipeline ?? Interlocked.CompareExchange(ref _pipeline, (loans = new Pipeline(this)), null) ?? loans;
            }
        }

        internal HttpClient HttpClient
        {
            get
            {
                var httpClient = _httpClient;
                if (httpClient == null)
                {
                    HttpMessageHandler handler = new HttpClientHandler();
                    if (_userId != null)
                    {
                        handler = new RetryHandler(handler, async () =>
                        {
                            await AccessToken.SetTokenWithUserCredentialsAsync(_instanceId, _userId, _password).ConfigureAwait(false);
                            return httpClient.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
                        });
                    }
                    httpClient = new HttpClient(handler)
                    {
                        BaseAddress = new Uri("https://api.elliemae.com/encompass/v1/")
                    };
                    httpClient.DefaultRequestHeaders.Authorization = GetAuthorizationHeader();
                    httpClient = Interlocked.CompareExchange(ref _httpClient, httpClient, null) ?? httpClient;
                }
                return httpClient;
            }
        }
        #endregion

        private EncompassRestClient(string clientId, string clientSecret)
        {
            AccessToken = new AccessToken(clientId, clientSecret, this);
        }

        private EncompassRestClient(string clientId, string clientSecret, string instanceId, string userId, string password, TokenExpirationHandling tokenExpirationHandling)
            : this(clientId, clientSecret)
        {
            _instanceId = instanceId;
            _userId = userId;
            _password = password;
            TokenExpirationHandling = tokenExpirationHandling;
        }

        public void Dispose()
        {
            AccessToken.Dispose();
            _httpClient?.Dispose();
        }

        private AuthenticationHeaderValue GetAuthorizationHeader() => new AuthenticationHeaderValue(AccessToken.Type, AccessToken.Token);
    }
}