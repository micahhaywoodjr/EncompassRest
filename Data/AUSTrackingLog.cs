
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class AUSTrackingLog
{
public string log_UnderwritingRiskAssessType { get; set; }
public string log_UnderwritingRiskAssessOther { get; set; }
public DateTime? log_SubmissionDate { get; set; }
public DateTime? log_FirstSubmissionDate { get; set; }
public string log_SubmissionNumber { get; set; }
public string log_AUSRecommendation { get; set; }
public string log_DUCaseIDorLPAUSKey { get; set; }
public string log_SubmittedBy { get; set; }
public string log_AUSVersion { get; set; }
public string log_FreddieDocClass { get; set; }
public decimal? log_LTV { get; set; }
public decimal? log_CuredLTV { get; set; }
public decimal? log_CLTV { get; set; }
public decimal? log_CuredCLTV { get; set; }
public decimal? log_HLCTV { get; set; }
public decimal? log_HousingExpenseRatio { get; set; }
public decimal? log_CuredHousingExpenseRatio { get; set; }
public decimal? log_TotalExpenseRatio { get; set; }
public decimal? log_CuredTotalExpenseRatio { get; set; }
public decimal? log_TotalLoanAmount { get; set; }
public decimal? log_CuredTotalLoanAmount { get; set; }
public decimal? log_SalesPrice { get; set; }
public int? log_AppraisedValue { get; set; }
public int? log_CuredAppraisedValue { get; set; }
public decimal? log_NoteRate { get; set; }
public decimal? log_CuredNoteRate { get; set; }
public string log_LoanType { get; set; }
public string log_CuredLoanType { get; set; }
public int? log_LoanTerm { get; set; }
public int? log_CuredLoanTerm { get; set; }
public string log_AmortizationType { get; set; }
public string log_CuredAmortizationType { get; set; }
public string log_LoanPurpose { get; set; }
public string log_CuredLoanPurpose { get; set; }
public string log_RefinancePurpose { get; set; }
public string log_CuredRefinancePurpose { get; set; }
public decimal? log_FirstPandI { get; set; }
public decimal? log_SecondPandI { get; set; }
public decimal? log_ProposedHazardInsurance { get; set; }
public decimal? log_ProposedTaxes { get; set; }
public decimal? log_ProposedMortgageInsurance { get; set; }
public decimal? log_ProposedHOAFees { get; set; }
public decimal? log_ProposedOtherPayment { get; set; }
public decimal? log_ProposedTotalHousingPayment { get; set; }
public decimal? log_CuredProposedTotalHousingPayment { get; set; }
public decimal? log_ProposedTotalMonthlyDebt { get; set; }
public decimal? log_IncomeAssetBase { get; set; }
public decimal? log_IncomeAssetCommission { get; set; }
public decimal? log_IncomeAssetBonus { get; set; }
public decimal? log_IncomeAssetOvertime { get; set; }
public decimal? log_IncomeAssetOther { get; set; }
public decimal? log_IncomeAssetPositiveNetRental { get; set; }
public decimal? log_IncomeAssetPosCashFlow { get; set; }
public decimal? log_TotalMonthlyIncome { get; set; }
public decimal? log_CuredTotalMonthlyIncome { get; set; }
public decimal? log_TotalAsset { get; set; }
public string log_eFolderGUID { get; set; }
public string log_BorrowerName { get; set; }
public string log_LenderLoan { get; set; }
public string log_CoborrowerName { get; set; }
public string log_PropertyAddress { get; set; }
public string log_PropertyCity { get; set; }
public string log_PropertyState { get; set; }
public string log_PropertyZipcode { get; set; }
public string log_DUPropertyType { get; set; }
public int? log_NoUnits { get; set; }
public string log_OccupancyStatus { get; set; }
public string log_Balloon { get; set; }
public string log_CommunityLending { get; set; }
public int? log_PaymentFrequency { get; set; }
public string log_LienType { get; set; }
public decimal? log_AmtSubordinateFin { get; set; }
public decimal? log_OwnerExistingMtg { get; set; }
public string log_Buydown { get; set; }
public decimal? log_LoanAmount { get; set; }
public decimal? log_FinancedMIAmount { get; set; }
public decimal? log_PandI { get; set; }
public decimal? log_QualifyingRate { get; set; }
public decimal? log_BoughtDownRate { get; set; }
public decimal? log_HousingExpense { get; set; }
public decimal? log_TotalExpense { get; set; }
public string log_IncludingLess10Mos { get; set; }
public string log_WithUndisclosedDebt { get; set; }
public decimal? log_NegativeNetRental { get; set; }
public decimal? log_SubjNegCashFlow { get; set; }
public decimal? log_AllOtherPayments { get; set; }
public decimal? log_TotalExpensePmt { get; set; }
public decimal? log_PresentPrincipalHousingPayment { get; set; }
public decimal? log_FundsRequiredClose { get; set; }
public decimal? log_ReservesRequiredVerified { get; set; }
public decimal? log_TotalFundsVerified { get; set; }
public decimal? log_CashBack { get; set; }
public decimal? log_NetCashBack { get; set; }
public decimal? log_ExcessAvailableAssetsNoVerified { get; set; }
public string log_Code1 { get; set; }
public string log_CodeDescription1 { get; set; }
public string log_Code2 { get; set; }
public string log_CodeDescription2 { get; set; }
public string log_BorrowerType1 { get; set; }
public string log_CreditAgency1 { get; set; }
public string log_CreditReportID1 { get; set; }
public DateTime? log_CreditReportDate1 { get; set; }
public string log_BorrowerType2 { get; set; }
public string log_CreditAgency2 { get; set; }
public string log_CreditReportID2 { get; set; }
public DateTime? log_CreditReportDate2 { get; set; }
public string log_BorrowerScoreName { get; set; }
public string log_BorrowerCreditScore1 { get; set; }
public string log_BorrowerCreditScore2 { get; set; }
public string log_BorrowerCreditScore3 { get; set; }
public string log_CoBorrowerScoreName { get; set; }
public string log_CoBorrowerCreditScore1 { get; set; }
public string log_CoBorrowerCreditScore2 { get; set; }
public string log_CoBorrowerCreditScore3 { get; set; }
public string log_BorrowerIncomeName { get; set; }
public string log_BorrowerIncomeType { get; set; }
public decimal? log_BorrowerIncomeAmount { get; set; }
public string log_CoBorrowerIncomeName { get; set; }
public string log_CoBorrowerIncomeType { get; set; }
public decimal? log_CoBorrowerIncomeAmount { get; set; }
public string log_BorrowerAssetName { get; set; }
public string log_BorrowerAssetType { get; set; }
public string log_BorrowerInstitutionName { get; set; }
public decimal? log_BorrowerAssetAmount { get; set; }
public string log_CoBorrowerAssetName { get; set; }
public string log_CoBorrowerAssetType { get; set; }
public string log_CoBorrowerInstitutionName { get; set; }
public decimal? log_CoBorrowerAssetAmount { get; set; }
public string log_AUSTransactionID { get; set; }
public string log_LoanProspectorID { get; set; }
public string log_TransactionID { get; set; }
public string log_RiskClass { get; set; }
public string log_DocumentationLevel { get; set; }
public string log_MortgageType { get; set; }
public string log_PurchaseEligibility { get; set; }
public string log_AUSStatus { get; set; }
public string log_LoanProcessingStage { get; set; }
public string log_AssessmentType { get; set; }
public string log_LPVersion { get; set; }
public string log_AppraisalTypeMAF { get; set; }
public string log_MIDecision { get; set; }
public string log_AcceptPlusEligible { get; set; }
public string log_IndicatorScore { get; set; }
public string log_SelectedRepository { get; set; }
public string log_SelectedBorrower { get; set; }
public DateTime? log_LPAssmtExpDate { get; set; }
public string log_BorrowerExperianFICO { get; set; }
public string log_BorrowerTransUnionEmpirica { get; set; }
public string log_BorrowerEquifaxBEACON { get; set; }
public string log_CoBorrowerExperianFICO { get; set; }
public string log_CoBorrowerTransUnionEmpirica { get; set; }
public string log_CoBorrowerEquifaxBEACON { get; set; }
public string log_PresentAddress { get; set; }
public string log_PresentAddressCity { get; set; }
public string log_PresentAddressState { get; set; }
public string log_PresentAddressZipCode { get; set; }
public string log_LoanApplicationID { get; set; }
public int? log_BalloonTerm { get; set; }
public int? log_AmortizationMonths { get; set; }
public decimal? log_ARMQualifyingRate { get; set; }
public decimal? log_TLTV { get; set; }
public decimal? log_HTLTV { get; set; }
public decimal? log_HousingRatio { get; set; }
public decimal? log_DebtRatio { get; set; }
public decimal? log_OccupantHousingRatio { get; set; }
public decimal? log_OccupantDebtRatio { get; set; }
public string log_NegAmortizationType { get; set; }
public string log_TemporarySubsidyBuydown { get; set; }
public string log_NewConstruction { get; set; }
public string log_AffordableProductType { get; set; }
public string log_OfferingIdentifier { get; set; }
public string log_IntendedUseofProperty { get; set; }
public decimal? log_CashOutAmount { get; set; }
public decimal? log_Reserves { get; set; }
public decimal? log_ProposedHousingPITI { get; set; }
public decimal? log_PresentHousingExpense { get; set; }
public decimal? log_MaxMortgageLimit { get; set; }
public string log_SalesConcessions { get; set; }
public string log_OriginatingCompany { get; set; }
public string log_SubmittingCompany { get; set; }
public string log_SellerNumber { get; set; }
public string log_TPONumber { get; set; }
public string log_DateTimeRequested { get; set; }
public string log_DateTimeAssessed { get; set; }
public string log_NumberOfSubmissions { get; set; }
public string log_NOTPNumber { get; set; }
public string log_LPPropertyType { get; set; }
public string log_SubmissionTime { get; set; }
public string log_FirstSubmissionTime { get; set; }
public string log_LQADataCompareResult { get; set; }
public string log_LQALPKey { get; set; }
public DateTime? log_LQASubmissionDateTime { get; set; }
public string log_LQADataCompareFieldName { get; set; }
public string log_LQADataCompareFieldConclusion { get; set; }
public string log_LQARiskAssessmentKey { get; set; }
public string log_LQACreditRiskAssessmentConclusion { get; set; }
public string log_LQAPurchaseEligibilityResult { get; set; }
public string log_LQACollateralRepWarrantyServiceConclusion { get; set; }
public string log_LCLAEvaluatedServiceType1 { get; set; }
public string log_LCLAEvaluatedServiceConclusion1 { get; set; }
public string log_LCLAEvaluatedServiceType2 { get; set; }
public string log_LCLAEvaluatedServiceConclusion2 { get; set; }
public string log_LCLAEvaluatedServiceType3 { get; set; }
public string log_LCLAEvaluatedServiceConclusion3 { get; set; }
public string log_LCLAEvaluatedServiceType4 { get; set; }
public string log_LCLAEvaluatedServiceConclusion4 { get; set; }
public string log_AUSTrackingType { get; set; }
public string id { get; set; }
public int? aUSTrackingLogIndex { get; set; }
public bool? isHistory { get; set; }
public string log_GUID { get; set; }
public DateTime? log_CreatedOn { get; set; }
public string log_RecordType { get; set; }
public bool? isEmpty { get; set; }
public string batchDocumentRefId { get; set; }

    }
}