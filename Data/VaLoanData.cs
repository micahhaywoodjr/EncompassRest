﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class VaLoanData
    {
        public bool? rangeOvenIndicator { get; set; }
        public bool? refrigeratorIndicator { get; set; }
        public bool? dishwasherIndicator { get; set; }
        public bool? clothesWasherIndicator { get; set; }
        public bool? dryerIndicator { get; set; }
        public bool? garbageDisposalIndicator { get; set; }
        public bool? ventFanIndicator { get; set; }
        public bool? wWCarpetIndicator { get; set; }
        public string equipmentOtherDescription { get; set; }
        public bool? noEnergyImprovements { get; set; }
        public bool? solarHeatingOrCooling { get; set; }
        public bool? replacementOfSystem { get; set; }
        public bool? energyImprovementsAdditionOfFeature { get; set; }
        public bool? insulation { get; set; }
        public bool? otherImprovements { get; set; }
        public DateTime? dateOfAssignment { get; set; }
        public decimal? acres { get; set; }
        public string buildingType { get; set; }
        public string numberOfBuildings { get; set; }
        public string availableForInspectionDateAndTime { get; set; }
        public string keysAtAddress { get; set; }
        public bool? availableForInspectionAMIndicator { get; set; }
        public string streetAccess { get; set; }
        public string streetMaintenance { get; set; }
        public bool? constructionWarrantyIncluded { get; set; }
        public string nameOfWarrantyProgram { get; set; }
        public DateTime? warrantyProgramExpirationDate { get; set; }
        public DateTime? constructionCompletedDate { get; set; }
        public string nameOfOwner { get; set; }
        public string propertyOccupancyType { get; set; }
        public string rent { get; set; }
        public string nameOfOccupant { get; set; }
        public string occupantTelephone { get; set; }
        public string propertyLegalDescription1 { get; set; }
        public string propertyLegalDescription2 { get; set; }
        public string propertyLegalDescription3 { get; set; }
        public string propertyLegalDescription4 { get; set; }
        public string titleLimitations1 { get; set; }
        public string titleLimitations2 { get; set; }
        public string titleLimitations3 { get; set; }
        public string loanProcedure { get; set; }
        public string militaryBranchOfService { get; set; }
        public string veteranServiceType { get; set; }
        public string purposeOfLoan { get; set; }
        public string typeOfOwnsership { get; set; }
        public string loanCode { get; set; }
        public string typeOfMortgage { get; set; }
        public decimal? amountSpentOnEnergyImprovements { get; set; }
        public string appraisalType { get; set; }
        public string manufacturedHome { get; set; }
        public string typeOfStructure { get; set; }
        public string propertyDesignation { get; set; }
        public string mCRVNumber { get; set; }
        public bool? fundingFeeExempt { get; set; }
        public string inspectionWillBeMadeBy { get; set; }
        public string constructionPlan { get; set; }
        public string plansSubmitted { get; set; }
        public string warrantorName { get; set; }
        public string warrantorAddress { get; set; }
        public string warrantorPhone { get; set; }
        public string specialAssessmentComments1 { get; set; }
        public string specialAssessmentComments2 { get; set; }
        public string specialAssessmentComments3 { get; set; }
        public decimal? annualRealEstateTaxes { get; set; }
        public string mineralRightsReserved { get; set; }
        public string leaseholdType { get; set; }
        public decimal? annualGroundRent { get; set; }
        public bool? proposedSaleContractAttached { get; set; }
        public string contractNoApprovedByVA { get; set; }
        public string lotDimensions { get; set; }
        public int? irregularLotSizeInSquareFeet { get; set; }
        public string utilitiesElectricDescription { get; set; }
        public string utilitiesGasDescription { get; set; }
        public string utilitiesWaterDescription { get; set; }
        public string utilitiesSewerDescription { get; set; }
        public string insuranceType { get; set; }
        public decimal? annualMaintenanceAssessment { get; set; }
        public bool? buyerPurchasingLotSeparately { get; set; }
        public string warrantorCity { get; set; }
        public string warrantorState { get; set; }
        public string warrantorPostalCode { get; set; }
        public string title { get; set; }
        public List<MilitaryService> militaryServices { get; set; }
        public DateTime? applicantBirthDate { get; set; }
        public bool? veteranDischargedIndicator { get; set; }
        public string vAClaimNumber { get; set; }
        public List<PreviousVaLoan> previousVaLoans { get; set; }
        public string mailingAddress { get; set; }
        public string mailingCity { get; set; }
        public string mailingState { get; set; }
        public string mailingPostalCode { get; set; }
        public string vaLoanSummaryApplicantType { get; set; }
        public string applicantFirstNameWithMiddleName { get; set; }
        public string applicantLastNameWithSuffix { get; set; }
        public string applicantTaxIdentificationIdentifier { get; set; }
        public string applicantAddressStreetLine1 { get; set; }
        public string applicantAddressCity { get; set; }
        public string applicantAddressState { get; set; }
        public string applicantAddressPostalCode { get; set; }
        public string applicantEmailAddressText { get; set; }
        public bool? previousVALoanIndicator { get; set; }
        public string loanAnalysisRemarks1 { get; set; }
        public string loanAnalysisRemarks2 { get; set; }
        public string loanAnalysisRemarks3 { get; set; }
        public string loanAnalysisRemarks4 { get; set; }
        public string loanAnalysisRemarks5 { get; set; }
        public string loanAnalysisRemarks6 { get; set; }
        public string loanAnalysisRemarks7 { get; set; }
        public string loanAnalysisRemarks8 { get; set; }
        public string loanAnalysisRemarks9 { get; set; }
        public bool? payoffIndicator1 { get; set; }
        public bool? payoffIndicator2 { get; set; }
        public bool? payoffIndicator3 { get; set; }
        public bool? payoffIndicator4 { get; set; }
        public bool? payoffIndicator5 { get; set; }
        public bool? payoffIndicator6 { get; set; }
        public bool? payoffIndicator7 { get; set; }
        public bool? payoffIndicator8 { get; set; }
        public bool? payoffIndicator9 { get; set; }
        public decimal? totalDebtMonthlyPayment { get; set; }
        public decimal? negativeRents { get; set; }
        public decimal? cashPaymentFromVeteran { get; set; }
        public decimal? finalFundingFeeAmount { get; set; }
        public decimal? totalForMaxLoanAmount { get; set; }
        public decimal? initialTotal { get; set; }
        public decimal? preliminaryDiscountAmount { get; set; }
        public decimal? originationFeeAmount { get; set; }
        public decimal? preliminaryFundingFeeAmount { get; set; }
        public decimal? otherClosingCosts { get; set; }
        public decimal? preliminaryTotal { get; set; }
        public decimal? finalDiscountAmount { get; set; }
        public decimal? discountPercentage { get; set; }
        public int? totalRooms { get; set; }
        public decimal? totalBaths { get; set; }
        public int? totalBedrooms { get; set; }
        public bool? originalValueEstimateChanged { get; set; }
        public string paidInFullVALoanNumber { get; set; }
        public decimal? originalLoanAmount { get; set; }
        public decimal? originalInterestRate { get; set; }
        public string systemUsed { get; set; }
        public int? originalTerm { get; set; }
        public decimal? vAOriginalMonthlyPayment { get; set; }
        public string vAOriginalAmortizationType { get; set; }
        public decimal? vARecoupmentMonthlyDecreaseInPayment { get; set; }
        public decimal? vARecoupmentTotalClosingCosts { get; set; }
        public bool? vARecoupmentExcludePrepaids { get; set; }
        public int? vARecoupmentClosingCosts { get; set; }
        public int? vARecoupmentYears { get; set; }
        public int? vARecoupmentMonths { get; set; }
        public bool? vALatePaymentIn6Months { get; set; }
        public string entitlementCode { get; set; }
        public string riskClasification { get; set; }
        public int? creditScore { get; set; }
        public string typeOfHybridARM { get; set; }
        public string applicantHmdaGenderType { get; set; }
        public bool? vAIsDelinquent30Days { get; set; }
        public string loanSummaryRemarks1 { get; set; }
        public string loanSummaryRemarks2 { get; set; }
        public string loanSummaryRemarks3 { get; set; }
        public bool? loanProcessedUnderAU { get; set; }
        public string loanSummaryRemarks4 { get; set; }
        public string loanSummaryRemarks5 { get; set; }
        public string loanSummaryRemarks6 { get; set; }
        public string loanSummaryRemarks7 { get; set; }
        public string loanSummaryRemarks8 { get; set; }
        public decimal? totalDiscountPointCharged { get; set; }
        public decimal? borrowerPaidDiscountPointsTotalAmount { get; set; }
        public decimal? totalDiscountPointsCharged { get; set; }
        public decimal? discountPoint { get; set; }
        public bool? firstTimeUse { get; set; }
        public string lenderSAR { get; set; }
        public int? propertyGrossLivingArea { get; set; }
        public int? ageOfProperty { get; set; }
        public DateTime? dateSAR { get; set; }
        public string administratorName { get; set; }
        public string administratorContact { get; set; }
        public string administratorAddress { get; set; }
        public string administratorCity { get; set; }
        public string administratorState { get; set; }
        public string administratorPostalCode { get; set; }
        public string vAClaimFolderNumber { get; set; }
        public string serviceNumber { get; set; }
        public bool? currentlyOnMilitaryDuty { get; set; }
        public bool? onMilitaryDutyFollowingSeparation { get; set; }
        public string vABenefitRelatedIndebtedness { get; set; }
        public string claimDisabilityBenefits { get; set; }
        public string typeOfVeteran { get; set; }
        public string priorLoanType { get; set; }
        public bool? automaticProcedure { get; set; }
        public bool? priorApprovalProcedure { get; set; }
        public bool? firstChattelLoanType { get; set; }
        public bool? unsecuredLoanType { get; set; }
        public bool? otherLoanType { get; set; }
        public string otherDescriptionLoanType { get; set; }
        public bool? otherEstateProperty { get; set; }
        public string otherDescriptionEstateProperty { get; set; }
        public decimal? annualSpecialAssessment { get; set; }
        public decimal? totalUnpaidSpecialAssessments { get; set; }
        public string nonrealtyDescription { get; set; }
        public string additionalSecurityDescription { get; set; }
        public DateTime? dateAquiredLand { get; set; }
        public decimal? landPurchasePrice { get; set; }
        public string amountTypeWithheld { get; set; }
        public decimal? amountWithheld { get; set; }
        public bool? reasonableValueCompleted { get; set; }
        public decimal? disabilityAmountCollected { get; set; }
        public decimal? pestReportFee { get; set; }
        public string vATrackingSARName { get; set; }
        public string vATrackingSARID { get; set; }
        public bool? vATrackingIsSARLAPPCertified { get; set; }
        public DateTime? vAAppraisalSentDate { get; set; }
        public DateTime? vANOVDateReceived { get; set; }
        public DateTime? vANOVDateReviewed { get; set; }
        public DateTime? vANOVIssuedDate { get; set; }
        public DateTime? vADateNOVAppraisalMailedToBorrower { get; set; }
        public DateTime? vATrackingOrderedDate { get; set; }
        public DateTime? vATrackingCOEIssueDate { get; set; }
        public string vATrackingCOEIssueHistory { get; set; }
        public DateTime? vATrackingPaidDate { get; set; }
        public bool? vATrackingReceiptReceived { get; set; }
        public DateTime? vATrackingLoanGuaranteeCertReceipt { get; set; }
        public bool? vATrackingGSAExclusionaryListChecked { get; set; }
        public DateTime? vATrackingCertOfCommitmentIssued { get; set; }
        public DateTime? vATrackingMasterCommitmentLockExpired { get; set; }
        public DateTime? vATrackingFinalApprovalCommitmentDate { get; set; }
        public DateTime? vATrackingPurchaseContractDate { get; set; }
        public bool? vATrackingInuranceFloodPolicy { get; set; }
        public bool? vATrackingInuranceHazardPolicy { get; set; }
        public bool? vATrackingInuranceWoodDestroyingPolicy { get; set; }
        public bool? vATrackingInuranceWindOrHailPolicy { get; set; }
        public string vAQualificationCountryRegion { get; set; }
        public string vAQualification2ndTierEntitlement { get; set; }
        public decimal? vAQualificationCountyLimits { get; set; }
        public decimal? totalMonthlyPayment { get; set; }
        public decimal? totalProposedMonthlyPayment { get; set; }
        public bool? excludeTaxesInsuranceIndicator { get; set; }
        public string emailToBeNotifiedWhenUploaded { get; set; }
        public string vABuilderIDNo { get; set; }
        public string pOCName { get; set; }
        public string pOCAddress { get; set; }
        public string pOCCity { get; set; }
        public string pOCState { get; set; }
        public string pOCZipCode { get; set; }
        public string pOCPhone { get; set; }
        public string vABuilderDescription { get; set; }
        public string id { get; set; }
        public bool? isDelinquent30Days { get; set; }
        public string applicantHomePhoneNumber { get; set; }

    }
}
