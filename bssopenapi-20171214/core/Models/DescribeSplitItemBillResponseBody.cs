// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSplitItemBillResponseBodyData Data { get; set; }
        public class DescribeSplitItemBillResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The billing cycle. Format: YYYY-MM.
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// The details of the bill.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSplitItemBillResponseBodyDataItems> Items { get; set; }
            public class DescribeSplitItemBillResponseBodyDataItems : TeaModel {
                /// <summary>
                /// The amount deducted with credit refund.
                /// </summary>
                [NameInMap("AdjustAmount")]
                [Validation(Required=false)]
                public float? AdjustAmount { get; set; }

                /// <summary>
                /// The ID of the account to which the bill belongs.
                /// </summary>
                [NameInMap("BillAccountID")]
                [Validation(Required=false)]
                public string BillAccountID { get; set; }

                /// <summary>
                /// The name of the account to which the bill belongs.
                /// </summary>
                [NameInMap("BillAccountName")]
                [Validation(Required=false)]
                public string BillAccountName { get; set; }

                /// <summary>
                /// The billing date. Format: YYYY-MM-DD. This parameter is not supported.
                /// </summary>
                [NameInMap("BillingDate")]
                [Validation(Required=false)]
                public string BillingDate { get; set; }

                /// <summary>
                /// The billable item.
                /// </summary>
                [NameInMap("BillingItem")]
                [Validation(Required=false)]
                public string BillingItem { get; set; }

                /// <summary>
                /// The code of the billable item.
                /// </summary>
                [NameInMap("BillingItemCode")]
                [Validation(Required=false)]
                public string BillingItemCode { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// The type of the business.
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// The amount paid in cash. The amount deducted with credit refund is not included.
                /// </summary>
                [NameInMap("CashAmount")]
                [Validation(Required=false)]
                public float? CashAmount { get; set; }

                /// <summary>
                /// The code of the commodity. The code is the same as that displayed in the Split Bill module of the User Center console.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The cost center.
                /// </summary>
                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                /// <summary>
                /// The type of currency. Valid values: CNY, USD, and JPY.
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The amount deducted with vouchers.
                /// </summary>
                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCashCoupons { get; set; }

                /// <summary>
                /// The amount deducted with coupons.
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCoupons { get; set; }

                /// <summary>
                /// The amount deducted with prepaid cards.
                /// </summary>
                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public float? DeductedByPrepaidCard { get; set; }

                /// <summary>
                /// The amount deducted with resource plans.
                /// </summary>
                [NameInMap("DeductedByResourcePackage")]
                [Validation(Required=false)]
                public string DeductedByResourcePackage { get; set; }

                /// <summary>
                /// The configurations of the instance.
                /// </summary>
                [NameInMap("InstanceConfig")]
                [Validation(Required=false)]
                public string InstanceConfig { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// The type of the instance.
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// The public IP address.
                /// </summary>
                [NameInMap("InternetIP")]
                [Validation(Required=false)]
                public string InternetIP { get; set; }

                /// <summary>
                /// The private IP address.
                /// </summary>
                [NameInMap("IntranetIP")]
                [Validation(Required=false)]
                public string IntranetIP { get; set; }

                /// <summary>
                /// The discount amount.
                /// </summary>
                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public float? InvoiceDiscount { get; set; }

                /// <summary>
                /// The type of the bill. Valid values: SubscriptionOrder: the subscription bill. PayAsYouGoBill: the pay-as-you-go bill. Refund: the refund. Adjustment: the adjustment bill.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The name of the split item.
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// The unit price.
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public string ListPrice { get; set; }

                /// <summary>
                /// The unit of the unit price.
                /// </summary>
                [NameInMap("ListPriceUnit")]
                [Validation(Required=false)]
                public string ListPriceUnit { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// The amount that is unsettled.
                /// </summary>
                [NameInMap("OutstandingAmount")]
                [Validation(Required=false)]
                public float? OutstandingAmount { get; set; }

                /// <summary>
                /// The ID of the account that owns the resource. This parameter is returned in multi-account scenario.
                /// </summary>
                [NameInMap("OwnerID")]
                [Validation(Required=false)]
                public string OwnerID { get; set; }

                /// <summary>
                /// The amount paid in cash. The amount deducted with credit refund is included.
                /// </summary>
                [NameInMap("PaymentAmount")]
                [Validation(Required=false)]
                public float? PaymentAmount { get; set; }

                /// <summary>
                /// The code of the service. The code is the same as that displayed in the Split Bill module of the User Center console.
                /// </summary>
                [NameInMap("PipCode")]
                [Validation(Required=false)]
                public string PipCode { get; set; }

                /// <summary>
                /// The pretax amount.
                /// </summary>
                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public float? PretaxAmount { get; set; }

                /// <summary>
                /// The pretax gross amount.
                /// </summary>
                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public float? PretaxGrossAmount { get; set; }

                /// <summary>
                /// The code of the service.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// The details of the service.
                /// </summary>
                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// The name of the service.
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

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
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// The duration of the service.
                /// </summary>
                [NameInMap("ServicePeriod")]
                [Validation(Required=false)]
                public string ServicePeriod { get; set; }

                /// <summary>
                /// The unit of the service duration.
                /// </summary>
                [NameInMap("ServicePeriodUnit")]
                [Validation(Required=false)]
                public string ServicePeriodUnit { get; set; }

                /// <summary>
                /// The ID of the account to which the split bill belongs.
                /// </summary>
                [NameInMap("SplitAccountID")]
                [Validation(Required=false)]
                public string SplitAccountID { get; set; }

                /// <summary>
                /// The name of the account to which the split item belongs.
                /// </summary>
                [NameInMap("SplitAccountName")]
                [Validation(Required=false)]
                public string SplitAccountName { get; set; }

                /// <summary>
                /// The billing cycle in which the bill is split.
                /// </summary>
                [NameInMap("SplitBillingCycle")]
                [Validation(Required=false)]
                public string SplitBillingCycle { get; set; }

                /// <summary>
                /// The day on which the bill is split.
                /// </summary>
                [NameInMap("SplitBillingDate")]
                [Validation(Required=false)]
                public string SplitBillingDate { get; set; }

                /// <summary>
                /// The code of the split item.
                /// </summary>
                [NameInMap("SplitCommodityCode")]
                [Validation(Required=false)]
                public string SplitCommodityCode { get; set; }

                /// <summary>
                /// The ID of the split item.
                /// </summary>
                [NameInMap("SplitItemID")]
                [Validation(Required=false)]
                public string SplitItemID { get; set; }

                /// <summary>
                /// The name of the split item.
                /// </summary>
                [NameInMap("SplitItemName")]
                [Validation(Required=false)]
                public string SplitItemName { get; set; }

                /// <summary>
                /// The details of the service.
                /// </summary>
                [NameInMap("SplitProductDetail")]
                [Validation(Required=false)]
                public string SplitProductDetail { get; set; }

                /// <summary>
                /// The billing method. Valid values: Subscription: the subscription billing method. PayAsYouGo: the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// The tag of the resource. If tags added to resources change, the bills generated during the period in which resources and tags are associated are returned.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The amount of resource usage.
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// The unit of usage.
                /// </summary>
                [NameInMap("UsageUnit")]
                [Validation(Required=false)]
                public string UsageUnit { get; set; }

                /// <summary>
                /// The zone.
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token used for the next query. If this parameter is empty, all the results are returned. When you perform the next query, you must set the NextToken parameter to this value.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error message returned.
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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
