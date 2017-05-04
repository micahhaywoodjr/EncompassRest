﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class RateLock
    {
        public decimal? totalSubordinateFinancing { get; set; }
        public string currentRateSheetID { get; set; }
        public string currentComments { get; set; }
        public decimal? currentRate { get; set; }
        public List<PriceAdjustment> currentAdjustments { get; set; }
        public decimal? currentRateTotalAdjustment { get; set; }
        public decimal? currentRateRequested { get; set; }
        public decimal? currentPriceRate { get; set; }
        public decimal? currentPriceTotalAdjustment { get; set; }
        public decimal? currentPriceRateRequested { get; set; }
        public decimal? currentMarginRate { get; set; }
        public decimal? currentMarginTotalAdjustment { get; set; }
        public decimal? currentMarginRateRequested { get; set; }
        public string requestRateSheetID { get; set; }
        public string deliveryType { get; set; }
        public bool? isDeliveryType { get; set; }
        public DateTime? requestLockDate { get; set; }
        public int? requestNumberOfDays { get; set; }
        public DateTime? requestLockExpires { get; set; }
        public decimal? requestRate { get; set; }
        public List<PriceAdjustment> lockRequestAdjustments { get; set; }
        public decimal? requestRateTotalAdjustment { get; set; }
        public decimal? requestRateRequested { get; set; }
        public decimal? requestPriceRate { get; set; }
        public decimal? requestPriceTotalAdjustment { get; set; }
        public decimal? requestPriceRateRequested { get; set; }
        public string requestComments { get; set; }
        public decimal? requestMarginRate { get; set; }
        public decimal? requestMarginTotalAdjustment { get; set; }
        public decimal? requestMarginRateRequested { get; set; }
        public decimal? requestMarginSRPPaidOut { get; set; }
        public string requestOnrpLockTime { get; set; }
        public bool? requestOnrpEligible { get; set; }
        public DateTime? requestOnrpLockDate { get; set; }
        public DateTime? buySideOnrpLockDate { get; set; }
        public DateTime? currentLockDate { get; set; }
        public int? currentNumberOfDays { get; set; }
        public DateTime? currentLockExpires { get; set; }
        public string buySideRequestedBy { get; set; }
        public string buySideRateSheetID { get; set; }
        public DateTime? buySideLockDate { get; set; }
        public int? buySideNumberOfDays { get; set; }
        public DateTime? buySideLockExpires { get; set; }
        public decimal? buySideRate { get; set; }
        public List<PriceAdjustment> buySideAdjustments { get; set; }
        public decimal? buySideRateTotalAdjustment { get; set; }
        public decimal? buySideRateNetBuyRate { get; set; }
        public decimal? buySidePriceRate { get; set; }
        public decimal? buySidePriceTotalAdjustment { get; set; }
        public decimal? buySidePriceNetBuyPrice { get; set; }
        public string buySideComments { get; set; }
        public decimal? buySideSRPPaidOut { get; set; }
        public string commitment { get; set; }
        public decimal? buySideMarginRate { get; set; }
        public decimal? buySideMarginTotalAdjustment { get; set; }
        public decimal? buySideMarginNetBuyRate { get; set; }
        public string buySideOnrpLockTime { get; set; }
        public bool? buySideOnrpEligible { get; set; }
        public decimal? sellSideMarginRate { get; set; }
        public List<PriceAdjustment> sellSideAdjustments { get; set; }
        public decimal? sellSideMarginTotalAdjustment { get; set; }
        public decimal? sellSideMarginNetSellRate { get; set; }
        public string sellSideCommitmentContractNumber { get; set; }
        public string sellSideProductName { get; set; }
        public decimal? sellSideMSRValue { get; set; }
        public decimal? netSellPrice { get; set; }
        public decimal? actualSellPrice { get; set; }
        public decimal? diffSellPrice { get; set; }
        public bool? usePoint { get; set; }
        public decimal? netSellAmount { get; set; }
        public decimal? actualSellAmount { get; set; }
        public decimal? diffSellAmount { get; set; }
        public DateTime? dateFirstPaymentToInvestor { get; set; }
        public decimal? sellSideSRP { get; set; }
        public decimal? actualSellSideSRP { get; set; }
        public decimal? diffSellSideSRP { get; set; }
        public decimal? sRPAmount { get; set; }
        public decimal? actualSRPAmount { get; set; }
        public decimal? diffSRPAmount { get; set; }
        public decimal? principle { get; set; }
        public decimal? premium { get; set; }
        public decimal? sRP { get; set; }
        public decimal? amountReceived { get; set; }
        public DateTime? nextPaymentDate { get; set; }
        public decimal? expectedPrinciple { get; set; }
        public decimal? expectedPremium { get; set; }
        public decimal? expectedSRP { get; set; }
        public List<PurchaseAdvicePayout> purchaseAdvicePayouts { get; set; }
        public decimal? expectedAmountReceived { get; set; }
        public decimal? diffPrinciple { get; set; }
        public decimal? diffPremium { get; set; }
        public decimal? diffSRP { get; set; }
        public decimal? diffAmountReceived { get; set; }
        public string prepayPenalty { get; set; }
        public string penaltyTerm { get; set; }
        public decimal? totalBuyPrice { get; set; }
        public string sellSideRequestedBy { get; set; }
        public string sellSideRateSheetID { get; set; }
        public DateTime? sellSideLockDate { get; set; }
        public int? sellSideNumberOfDays { get; set; }
        public DateTime? sellSideLockExpires { get; set; }
        public decimal? sellSideRate { get; set; }
        public decimal? sellSideRateTotalAdjustment { get; set; }
        public decimal? sellSideNetSellRate { get; set; }
        public decimal? sellSidePriceRate { get; set; }
        public decimal? sellSidePriceTotalAdjustment { get; set; }
        public decimal? sellSideNetSellPrice { get; set; }
        public string sellSideComments { get; set; }
        public decimal? sellSideSRPPaidOut { get; set; }
        public decimal? sellSideDiscountYSP { get; set; }
        public string investorName { get; set; }
        public string investorContact { get; set; }
        public string investorPhone { get; set; }
        public string investorEmail { get; set; }
        public string investorAddress { get; set; }
        public string investorCity { get; set; }
        public string investorState { get; set; }
        public string investorPostalCode { get; set; }
        public string investorWebsite { get; set; }
        public string investorCommitment { get; set; }
        public string investorLockType { get; set; }
        public string investorLoanNumber { get; set; }
        public string investorProgramCode { get; set; }
        public string investorMERSNumber { get; set; }
        public DateTime? dateLockedWithInvestor { get; set; }
        public string timeLockedWithInvestor { get; set; }
        public string sellSideLoanProgram { get; set; }
        public DateTime? sellSideCommitmentDate { get; set; }
        public string impoundWavied { get; set; }
        public string impoundType { get; set; }
        public decimal? gainLossTotalBuyPrice { get; set; }
        public decimal? gainLossPercentage { get; set; }
        public DateTime? investorDeliveryDate { get; set; }
        public DateTime? investorTargetDeliveryDate { get; set; }
        public decimal? gainLossPrice { get; set; }
        public string sellSideInvestorStatus { get; set; }
        public string sellSideTradeNumber { get; set; }
        public string sellSideTradeGuid { get; set; }
        public string sellSideMasterContractNumber { get; set; }
        public string sellSideInvestorTradeNumber { get; set; }
        public DateTime? sellSideInvestorStatusDate { get; set; }
        public DateTime? date { get; set; }
        public string firstPaymenTo { get; set; }
        public string confirmedBy { get; set; }
        public string amountDueTo { get; set; }
        public string amountPaidTo { get; set; }
        public decimal? reconciledDiff { get; set; }
        public DateTime? confirmedDate { get; set; }
        public decimal? amountDue { get; set; }
        public decimal? amountPaid { get; set; }
        public string hedging { get; set; }
        public string requestFullfilledDateTime { get; set; }
        public decimal? interest { get; set; }
        public decimal? impounds { get; set; }
        public decimal? expectedInterest { get; set; }
        public int? purchaseAdviceNumberOfDays { get; set; }
        public string perDiemInterestRoundingType { get; set; }
        public decimal? expectedImpounds { get; set; }
        public decimal? diffInterest { get; set; }
        public decimal? diffImpounds { get; set; }
        public string comments { get; set; }
        public bool? loanFor203K { get; set; }
        public decimal? totalForLesserOfSumAsIs { get; set; }
        public string hELOCActualBalance { get; set; }
        public decimal? requestUnDiscountedRate { get; set; }
        public decimal? buySideUnDiscountedRate { get; set; }
        public string loanProgram { get; set; }
        public string loanDocumentationType { get; set; }
        public List<LockRequestBorrower> lockRequestBorrowers { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator1 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator2 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator3 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator4 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator5 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator6 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator7 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator8 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator9 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator10 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator11 { get; set; }
        public bool? employmentBorrowerSelfEmployedIndicator12 { get; set; }
        public string minFICO { get; set; }
        public string minFICO2 { get; set; }
        public string subjectPropertyStreetAddress { get; set; }
        public string subjectPropertyCity { get; set; }
        public string subjectPropertyCounty { get; set; }
        public string subjectPropertyState { get; set; }
        public string subjectPropertyPostalCode { get; set; }
        public string gSEPropertyType { get; set; }
        public int? propertyEstimatedValueAmount { get; set; }
        public int? propertyAppraisedValueAmount { get; set; }
        public string propertyUsageType { get; set; }
        public string lockRequestLoanPurposeType { get; set; }
        public string mortgageType { get; set; }
        public string loanAmortizationType { get; set; }
        public decimal? gPMRate { get; set; }
        public int? gPMYears { get; set; }
        public string fNMProductPlanIdentifier { get; set; }
        public string otherAmortizationTypeDescription { get; set; }
        public string lienPriorityType { get; set; }
        public int? loanAmortizationTermMonths { get; set; }
        public int? balloonLoanMaturityTermMonths { get; set; }
        public string requestImpoundWavied { get; set; }
        public string requestImpoundType { get; set; }
        public string requestPrepayPenalty { get; set; }
        public string requestPenaltyTerm { get; set; }
        public decimal? borrowerRequestedLoanAmount { get; set; }
        public DateTime? loanScheduledClosingDate { get; set; }
        public string loanProgramFile { get; set; }
        public string planCode { get; set; }
        public decimal? baseLoanAmount { get; set; }
        public decimal? fHAUpfrontMIPremiumPercent { get; set; }
        public decimal? fundingAmount { get; set; }
        public bool? lockField { get; set; }
        public bool? roundToNearest50 { get; set; }
        public decimal? mIPPaidInCash { get; set; }
        public decimal? sellerPaidMIPremium { get; set; }
        public bool? firstTimeHomebuyersIndicator { get; set; }
        public int? financedNumberOfUnits { get; set; }
        public bool? twelveMonthMortgageRentalHistoryIndicator { get; set; }
        public bool? lenderPaidMortgageInsuranceIndicator { get; set; }
        public bool? subjectPropertyCondotelIndicator { get; set; }
        public bool? subjectPropertyNonWarrantableProjectIndicator { get; set; }
        public string compSideLoanProgram { get; set; }
        public string compSideComparisonedBy { get; set; }
        public string compSideRateSheetID { get; set; }
        public DateTime? compSideCurrentRateSetDate { get; set; }
        public DateTime? compSideLockDate { get; set; }
        public int? compSideNumberOfDays { get; set; }
        public DateTime? compSideLockExpires { get; set; }
        public decimal? compSideRate { get; set; }
        public List<PriceAdjustment> compSideAdjustments { get; set; }
        public decimal? compSideRateTotalAdjustment { get; set; }
        public decimal? compSideNetCompRate { get; set; }
        public decimal? compSidePriceRate { get; set; }
        public decimal? compSidePriceTotalAdjustment { get; set; }
        public decimal? compSideNetCompPrice { get; set; }
        public decimal? compSideMarginRate { get; set; }
        public decimal? compSideMarginTotalAdjustment { get; set; }
        public decimal? compSideMarginNetCompRate { get; set; }
        public decimal? compSideSRPPaidOut { get; set; }
        public decimal? compSideDiscountYSP { get; set; }
        public string compInvestorName { get; set; }
        public string compInvestorContact { get; set; }
        public string compInvestorPhone { get; set; }
        public string compInvestorEmail { get; set; }
        public string compInvestorAddress { get; set; }
        public string compInvestorCity { get; set; }
        public string compInvestorState { get; set; }
        public string compInvestorPostalCode { get; set; }
        public string compInvestorWebsite { get; set; }
        public string compSideServicingType { get; set; }
        public string compInvestorProgramCode { get; set; }
        public string compInvestorLockType { get; set; }
        public string compSideComments { get; set; }
        public decimal? compGainLossTotalCompPrice { get; set; }
        public decimal? compGainLossPercentage { get; set; }
        public decimal? compGainLossPrice { get; set; }
        public string compInvestorTemplateName { get; set; }
        public string sellSideTradeMgmtPrevConfirmedLockGuid { get; set; }
        public decimal? firstSubordinateAmount { get; set; }
        public decimal? secondSubordinateAmount { get; set; }
        public decimal? otherSubordinateAmount { get; set; }
        public decimal? purchasePriceAmount { get; set; }
        public string pricingUpdated { get; set; }
        public decimal? expectedRemainingBuydownFunds { get; set; }
        public decimal? remainingBuydownFunds { get; set; }
        public decimal? diffRemainingBuydownFunds { get; set; }
        public decimal? lTV { get; set; }
        public decimal? combinedLTV { get; set; }
        public DateTime? requestCurrentRateSetDate { get; set; }
        public DateTime? currentRateSetDate { get; set; }
        public DateTime? buySideCurrentRateSetDate { get; set; }
        public DateTime? sellSideCurrentRateSetDate { get; set; }
        public string investorTemplateName { get; set; }
        public DateTime? dateSold { get; set; }
        public bool? servicingReleaseIndicator { get; set; }
        public DateTime? dateWarehoused { get; set; }
        public DateTime? buySideOriginalLockExpires { get; set; }
        public DateTime? sellSideOriginalLockExpires { get; set; }
        public int? requestDaystoExtend { get; set; }
        public DateTime? requestExtendedLockExpires { get; set; }
        public decimal? requestLockExtendPriceAdjustment { get; set; }
        public int? buySideDaystoExtend { get; set; }
        public DateTime? buySideExtendedLockExpires { get; set; }
        public decimal? buySideLockExtendPriceAdjustment { get; set; }
        public int? sellSideDaystoExtend { get; set; }
        public DateTime? sellSideExtendedLockExpires { get; set; }
        public decimal? sellSideLockExtendPriceAdjustment { get; set; }
        public DateTime? requestOriginalLockExpires { get; set; }
        public string requestLockExtendComment { get; set; }
        public decimal? corporatePrice { get; set; }
        public DateTime? corporateApprovalDate { get; set; }
        public string corporateApprovedby { get; set; }
        public string reasonforCorporateApproval { get; set; }
        public decimal? branchPrice { get; set; }
        public DateTime? branchApprovalDate { get; set; }
        public string branchApprovedby { get; set; }
        public string reasonforBranchApproval { get; set; }
        public decimal? totalPrice { get; set; }
        public int? cumulatedDaystoExtend { get; set; }
        public int? extensionSequenceNumber { get; set; }
        public decimal? profitMarginAdjustedBuyPrice { get; set; }
        public DateTime? requestLockCancellationDate { get; set; }
        public string requestLockCancellationComment { get; set; }
        public string requestLockType { get; set; }
        public string sellSideServicingType { get; set; }
        public string sellSideServicer { get; set; }
        public decimal? sellSideServicingFee { get; set; }
        public decimal? sellSideGuaranteeFee { get; set; }
        public string sellSidePoolNumber { get; set; }
        public string sellSidePoolID { get; set; }
        public DateTime? correspondentDate { get; set; }
        public decimal? correspondentCurrentImpounds { get; set; }
        public DateTime? correspondentPaidToDate { get; set; }
        public DateTime? correspondentFirstPaymentDate { get; set; }
        public decimal? correspondentCurrentPrincipal { get; set; }
        public string correspondentAdjusterDescription1 { get; set; }
        public decimal? correspondentAdjusterAmount1 { get; set; }
        public string correspondentAdjusterDescription2 { get; set; }
        public decimal? correspondentAdjusterAmount2 { get; set; }
        public string correspondentAdjusterDescription3 { get; set; }
        public decimal? correspondentAdjusterAmount3 { get; set; }
        public decimal? correspondentFinalBuyPrice { get; set; }
        public decimal? correspondentPurchasedPrincipal { get; set; }
        public decimal? correspondentInterest { get; set; }
        public int? correspondentInterestDays { get; set; }
        public decimal? correspondentImpounds { get; set; }
        public decimal? correspondentFinalBuyAmount { get; set; }
        public decimal? correspondentSRPAmount { get; set; }
        public decimal? correspondentRemainingBuydownAmount { get; set; }
        public string correspondentReconcilationComments { get; set; }
        public string correspondentAdditionalLineDescription1 { get; set; }
        public decimal? correspondentAdditionalLineAmount1 { get; set; }
        public string correspondentAdditionalLineDescription2 { get; set; }
        public decimal? correspondentAdditionalLineAmount2 { get; set; }
        public string correspondentAdditionalLineDescription3 { get; set; }
        public decimal? correspondentAdditionalLineAmount3 { get; set; }
        public string correspondentAdditionalLineDescription4 { get; set; }
        public decimal? correspondentAdditionalLineAmount4 { get; set; }
        public string correspondentAdditionalLineDescription5 { get; set; }
        public decimal? correspondentAdditionalLineAmount5 { get; set; }
        public string correspondentAdditionalLineDescription6 { get; set; }
        public decimal? correspondentAdditionalLineAmount6 { get; set; }
        public string correspondentAdditionalLineDescription7 { get; set; }
        public decimal? correspondentAdditionalLineAmount7 { get; set; }
        public string correspondentAdditionalLineDescription8 { get; set; }
        public decimal? correspondentAdditionalLineAmount8 { get; set; }
        public string correspondentAdditionalLineDescription9 { get; set; }
        public decimal? correspondentAdditionalLineAmount9 { get; set; }
        public string correspondentAdditionalLineDescription10 { get; set; }
        public decimal? correspondentAdditionalLineAmount10 { get; set; }
        public string correspondentAdditionalLineDescription11 { get; set; }
        public decimal? correspondentAdditionalLineAmount11 { get; set; }
        public string correspondentAdditionalLineDescription12 { get; set; }
        public decimal? correspondentAdditionalLineAmount12 { get; set; }
        public decimal? correspondentAdditionalLineAmount13 { get; set; }
        public decimal? correspondentAdditionalLineTotalAmount { get; set; }
        public string correspondentConfirmedBy { get; set; }
        public DateTime? correspondentConfirmedDate { get; set; }
        public string correspondentWarehouseBankName { get; set; }
        public string correspondentWarehouseBankAcctNum { get; set; }
        public string correspondentWarehouseBankABANum { get; set; }
        public bool? correspondentWarehouseBankWireInstructionsReceivedIndicator { get; set; }
        public bool? correspondentWarehouseBankBaileeLetterReceivedIndicator { get; set; }
        public string correspondentWarehouseBankAddress { get; set; }
        public string correspondentWarehouseBankAddress1 { get; set; }
        public string correspondentWarehouseBankCity { get; set; }
        public string correspondentWarehouseBankState { get; set; }
        public string correspondentWarehouseBankZip { get; set; }
        public string correspondentWarehouseBankDescription { get; set; }
        public bool? correspondentWarehouseBankSelfFunderIndicator { get; set; }
        public bool? correspondentWarehouseBankBaileeLetterReqIndicator { get; set; }
        public DateTime? correspondentWarehouseBankBaileeExpirationDate { get; set; }
        public bool? correspondentWarehouseBankTriPartyContractIndicator { get; set; }
        public string correspondentWarehouseBankContactName { get; set; }
        public string correspondentWarehouseBankContactEmail { get; set; }
        public string correspondentWarehouseBankContactPhone { get; set; }
        public string correspondentWarehouseBankContactFax { get; set; }
        public string correspondentWarehouseBankNotes { get; set; }
        public bool? correspondentWarehouseBankUseDefaultContactIndicator { get; set; }
        public int? correspondentWarehouseBankId { get; set; }
        public decimal? requestStartingAdjRate { get; set; }
        public decimal? buySideStartingAdjRate { get; set; }
        public decimal? requestStartingAdjPoint { get; set; }
        public decimal? buySideStartingAdjPoint { get; set; }
        public bool? noClosingCostOption { get; set; }
        public string buySideCommitmentNumber { get; set; }
        public string buySideMasterCommitmentNumber { get; set; }
        public string buySideTPOName { get; set; }
        public string buySideTPOID { get; set; }
        public string buySideOrgID { get; set; }
        public DateTime? buySideCommitmentDate { get; set; }
        public string buySideCommitmentType { get; set; }
        public string buySideDeliveryType { get; set; }
        public DateTime? buySideExpirationDate { get; set; }
        public DateTime? buySideDeliveryExpirationDate { get; set; }
        public string buySideTradeGuid { get; set; }
        public string buySideTradeNumber { get; set; }
        public decimal? correspondentLateFeePriceAdjustment { get; set; }
        public decimal? correspondentLateFeeAmount { get; set; }
        public string oNRPLock { get; set; }
        public string creditScoreToUse { get; set; }
        public string pricingHistoryData { get; set; }
        public string id { get; set; }
        public List<PriceAdjustment> priceAdjustments { get; set; }
        public string type { get; set; }
        public string rateRequestStatus { get; set; }
        public decimal? buySideStartingAdjPrice { get; set; }
        public int? compSideDaystoExtend { get; set; }
        public DateTime? compSideExtendedLockExpires { get; set; }
        public string compSideInvestorStatus { get; set; }
        public DateTime? compSideInvestorStatusDate { get; set; }
        public string compSideInvestorTradeNumber { get; set; }
        public decimal? compSideLockExtendPriceAdjustment { get; set; }
        public string compSideMasterContractNumber { get; set; }
        public DateTime? compSideOriginalLockExpires { get; set; }
        public string compSideRequestedBy { get; set; }
        public string compSideTradeGuid { get; set; }
        public string compSideTradeNumber { get; set; }
        public decimal? compGainLossTotalBuyPrice { get; set; }
        public string compInvestorCommitment { get; set; }
        public string isCancelled { get; set; }
        public string rateStatus { get; set; }
        public string requestPending { get; set; }
        public string requestType { get; set; }
        public string extensionRequestPending { get; set; }
        public string cancellationRequestPending { get; set; }
        public string reLockRequestPending { get; set; }

    }
}
