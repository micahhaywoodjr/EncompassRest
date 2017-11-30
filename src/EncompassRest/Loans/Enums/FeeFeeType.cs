using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FeeFeeType
    {
        Undefined = 0,
        AppraisalFee = 1,
        AssumptionFee = 2,
        AttorneyFee = 3,
        [EnumMember(Value = "City_CountyTax_Stamps")]
        CityCountyTaxStamps = 4,
        ClosingFee = 5,
        CommissionPaid = 6,
        CountyPropertyTaxes = 7,
        CreditReportFee = 8,
        DocPrepFee = 9,
        FloodInsurance = 10,
        FloodInsuranceReserv = 11,
        GuaranteeFee = 12,
        HazardInsurance = 13,
        HazardInsurancePremium = 14,
        LendersInspectionFee = 15,
        LoanDiscountFee = 16,
        LoanOriginationFee = 17,
        MortgageBrokerFee = 18,
        MortgageInspectionFee = 19,
        MortgageInsurance = 20,
        MortgageInsurancePremium = 21,
        NotaryFee = 22,
        PestInspection = 23,
        PrepaidInterest = 24,
        ProcessingFee = 25,
        PropertyTaxes = 26,
        RecordingFee = 27,
        SchoolTaxes = 28,
        [EnumMember(Value = "StateTax_Stamps")]
        StateTaxStamps = 29,
        SurveyFee = 30,
        TaxServiceFee = 31,
        TitleBinder = 32,
        TitleExamination = 33,
        TitleInsurance = 34,
        TitleSearch = 35,
        UnderwritingFee = 36,
        [EnumMember(Value = "UserDefined_1006")]
        UserDefined1006 = 37,
        [EnumMember(Value = "UserDefined_1007")]
        UserDefined1007 = 38,
        [EnumMember(Value = "UserDefined_1008")]
        UserDefined1008 = 39,
        [EnumMember(Value = "UserDefined_1010")]
        UserDefined1010 = 40,
        [EnumMember(Value = "UserDefined_1109")]
        UserDefined1109 = 41,
        [EnumMember(Value = "UserDefined_1110")]
        UserDefined1110 = 42,
        [EnumMember(Value = "UserDefined_1111")]
        UserDefined1111 = 43,
        [EnumMember(Value = "UserDefined_1112")]
        UserDefined1112 = 44,
        [EnumMember(Value = "UserDefined_1113")]
        UserDefined1113 = 45,
        [EnumMember(Value = "UserDefined_1114")]
        UserDefined1114 = 46,
        [EnumMember(Value = "UserDefined_1115")]
        UserDefined1115 = 47,
        [EnumMember(Value = "UserDefined_1116")]
        UserDefined1116 = 48,
        [EnumMember(Value = "UserDefined_1204")]
        UserDefined1204 = 49,
        [EnumMember(Value = "UserDefined_1205")]
        UserDefined1205 = 50,
        [EnumMember(Value = "UserDefined_1206")]
        UserDefined1206 = 51,
        [EnumMember(Value = "UserDefined_1209")]
        UserDefined1209 = 52,
        [EnumMember(Value = "UserDefined_1210")]
        UserDefined1210 = 53,
        [EnumMember(Value = "UserDefined_1303")]
        UserDefined1303 = 54,
        [EnumMember(Value = "UserDefined_1304")]
        UserDefined1304 = 55,
        [EnumMember(Value = "UserDefined_1305")]
        UserDefined1305 = 56,
        [EnumMember(Value = "UserDefined_1306")]
        UserDefined1306 = 57,
        [EnumMember(Value = "UserDefined_1307")]
        UserDefined1307 = 58,
        [EnumMember(Value = "UserDefined_1308")]
        UserDefined1308 = 59,
        [EnumMember(Value = "UserDefined_1309")]
        UserDefined1309 = 60,
        [EnumMember(Value = "UserDefined_906")]
        UserDefined906 = 61,
        [EnumMember(Value = "UserDefined_907")]
        UserDefined907 = 62,
        [EnumMember(Value = "UserDefinedFee_701")]
        UserDefinedFee701 = 63,
        [EnumMember(Value = "UserDefinedFee_702")]
        UserDefinedFee702 = 64,
        [EnumMember(Value = "UserDefinedFee_704")]
        UserDefinedFee704 = 65,
        [EnumMember(Value = "UserDefinedFee_813")]
        UserDefinedFee813 = 66,
        [EnumMember(Value = "UserDefinedFee_814")]
        UserDefinedFee814 = 67,
        [EnumMember(Value = "UserDefinedFee_815")]
        UserDefinedFee815 = 68,
        [EnumMember(Value = "UserDefinedFee_816")]
        UserDefinedFee816 = 69,
        [EnumMember(Value = "UserDefinedFee_817")]
        UserDefinedFee817 = 70,
        [EnumMember(Value = "UserDefinedFee_818")]
        UserDefinedFee818 = 71,
        [EnumMember(Value = "UserDefinedFee_819")]
        UserDefinedFee819 = 72,
        [EnumMember(Value = "UserDefinedFee_820")]
        UserDefinedFee820 = 73,
        [EnumMember(Value = "UserDefinedFee_821")]
        UserDefinedFee821 = 74,
        [EnumMember(Value = "UserDefinedFee_822")]
        UserDefinedFee822 = 75,
        [EnumMember(Value = "UserDefinedFee_823")]
        UserDefinedFee823 = 76,
        VAFundingFee = 77,
        WireTransfer = 78
    }
}