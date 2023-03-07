// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceGaapCostResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceGaapCostResponseBodyData Data { get; set; }
        public class QueryInstanceGaapCostResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The billing information.
            /// </summary>
            [NameInMap("Modules")]
            [Validation(Required=false)]
            public QueryInstanceGaapCostResponseBodyDataModules Modules { get; set; }
            public class QueryInstanceGaapCostResponseBodyDataModules : TeaModel {
                [NameInMap("Module")]
                [Validation(Required=false)]
                public List<QueryInstanceGaapCostResponseBodyDataModulesModule> Module { get; set; }
                public class QueryInstanceGaapCostResponseBodyDataModulesModule : TeaModel {
                    /// <summary>
                    /// The accounting unit. This parameter is reserved and unavailable now.
                    /// </summary>
                    [NameInMap("AccountingUnit")]
                    [Validation(Required=false)]
                    public string AccountingUnit { get; set; }

                    /// <summary>
                    /// The type of the bill. Valid values:
                    /// 
                    /// *   SubscriptionOrder: subscription order
                    /// *   PayAsYouGoBill: pay-as-you-go bill
                    /// *   Refund: refund
                    /// *   Adjustment: reconciliation
                    /// </summary>
                    [NameInMap("BillType")]
                    [Validation(Required=false)]
                    public string BillType { get; set; }

                    /// <summary>
                    /// The billing cycle, in the YYYY-MM format.
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// The type of the currency. Valid values:
                    /// 
                    /// *   CNY
                    /// *   USD
                    /// *   JPY
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// The amount deducted by using vouchers.
                    /// </summary>
                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using coupons.
                    /// </summary>
                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using prepaid cards.
                    /// </summary>
                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string DeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The allocated amount deducted by using vouchers.
                    /// </summary>
                    [NameInMap("GaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The allocated amount deducted by using coupons.
                    /// </summary>
                    [NameInMap("GaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCoupons { get; set; }

                    /// <summary>
                    /// The allocated amount deducted by using prepaid cards.
                    /// </summary>
                    [NameInMap("GaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string GaapDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The allocated amount paid in cash.
                    /// </summary>
                    [NameInMap("GaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string GaapPaymentAmount { get; set; }

                    /// <summary>
                    /// The allocated pretax amount.
                    /// </summary>
                    [NameInMap("GaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmount { get; set; }

                    /// <summary>
                    /// The allocated pretax amount paid with the local currency.
                    /// </summary>
                    [NameInMap("GaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The allocated pretax gross amount.
                    /// </summary>
                    [NameInMap("GaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The allocated pricing discount.
                    /// </summary>
                    [NameInMap("GaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string GaapPricingDiscount { get; set; }

                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// The amount deducted by using vouchers and allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using coupons and allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using prepaid cards and allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The amount paid in cash and allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPaymentAmount { get; set; }

                    /// <summary>
                    /// The pretax amount allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmount { get; set; }

                    /// <summary>
                    /// The pretax amount paid with the local currency and allocated to the current month (Alibaba Cloud International site).
                    /// </summary>
                    [NameInMap("MonthGaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The pretax gross amount allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The pricing discount allocated to the current month.
                    /// </summary>
                    [NameInMap("MonthGaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string MonthGaapPricingDiscount { get; set; }

                    /// <summary>
                    /// The ID of the order.
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// The type of the order. Valid values:
                    /// 
                    /// *   New
                    /// *   Renewal
                    /// *   Upgrade
                    /// *   Degrade
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    /// <summary>
                    /// The ID of the bill owner.
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// The time when the bill was paid.
                    /// </summary>
                    [NameInMap("PayTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    /// <summary>
                    /// The account of the payer.
                    /// </summary>
                    [NameInMap("PayerAccount")]
                    [Validation(Required=false)]
                    public string PayerAccount { get; set; }

                    /// <summary>
                    /// The amount paid in cash.
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public string PaymentAmount { get; set; }

                    /// <summary>
                    /// The type of the currency (Alibaba Cloud International site).
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// The pretax amount.
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// The allocated pretax amount paid with the local currency (Alibaba Cloud International site).
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The pretax gross amount.
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The pricing discount.
                    /// </summary>
                    [NameInMap("PricingDiscount")]
                    [Validation(Required=false)]
                    public string PricingDiscount { get; set; }

                    /// <summary>
                    /// The code of the service.
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// The type of the service.
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The resource group.
                    /// </summary>
                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    /// <summary>
                    /// The ID of the sub-order.
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// The billing method. Valid values:
                    /// 
                    /// *   Subscription: the subscription billing method
                    /// *   PayAsYouGo: the pay-as-you-go billing method
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// The tag.
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// The unallocated amount deducted by using vouchers.
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The unallocated amount deducted by using coupons.
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCoupons { get; set; }

                    /// <summary>
                    /// The unallocated amount deducted by using prepaid cards.
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The unallocated amount paid in cash.
                    /// </summary>
                    [NameInMap("UnallocatedPaymentAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPaymentAmount { get; set; }

                    /// <summary>
                    /// The unallocated pretax amount.
                    /// </summary>
                    [NameInMap("UnallocatedPretaxAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmount { get; set; }

                    /// <summary>
                    /// The unallocated pretax amount paid with the local currency.
                    /// </summary>
                    [NameInMap("UnallocatedPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// The unallocated pretax gross amount.
                    /// </summary>
                    [NameInMap("UnallocatedPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// The unallocated pricing discount.
                    /// </summary>
                    [NameInMap("UnallocatedPricingDiscount")]
                    [Validation(Required=false)]
                    public string UnallocatedPricingDiscount { get; set; }

                    /// <summary>
                    /// The time when the service usage ended.
                    /// </summary>
                    [NameInMap("UsageEndDate")]
                    [Validation(Required=false)]
                    public string UsageEndDate { get; set; }

                    /// <summary>
                    /// The time when the service usage started.
                    /// </summary>
                    [NameInMap("UsageStartDate")]
                    [Validation(Required=false)]
                    public string UsageStartDate { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
