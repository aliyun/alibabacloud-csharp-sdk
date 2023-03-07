// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySplitItemBillResponseBody : TeaModel {
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
        public QuerySplitItemBillResponseBodyData Data { get; set; }
        public class QuerySplitItemBillResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The billing cycle, in the YYYY-MM format.
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// The details of the bills.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QuerySplitItemBillResponseBodyDataItems Items { get; set; }
            public class QuerySplitItemBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QuerySplitItemBillResponseBodyDataItemsItem> Item { get; set; }
                public class QuerySplitItemBillResponseBodyDataItemsItem : TeaModel {
                    /// <summary>
                    /// The amount deducted by using credit refunds.
                    /// </summary>
                    [NameInMap("AdjustAmount")]
                    [Validation(Required=false)]
                    public float? AdjustAmount { get; set; }

                    /// <summary>
                    /// The billing date, in the YYYY-MM-DD format.
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
                    /// The billing type.
                    /// </summary>
                    [NameInMap("BillingType")]
                    [Validation(Required=false)]
                    public string BillingType { get; set; }

                    /// <summary>
                    /// The amount paid in cash. The amount that was deducted by using credit refunds is not included.
                    /// </summary>
                    [NameInMap("CashAmount")]
                    [Validation(Required=false)]
                    public float? CashAmount { get; set; }

                    /// <summary>
                    /// The code of the commodity. The commodity code is the same as that displayed in User Center.
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
                    /// The type of the currency. Valid values: CNY, USD, and JPY.
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// The amount deducted by using vouchers.
                    /// </summary>
                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using coupons.
                    /// </summary>
                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCoupons { get; set; }

                    /// <summary>
                    /// The amount deducted by using prepaid cards.
                    /// </summary>
                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public float? DeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// The amount deducted by using resource plans.
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
                    /// The instance type of the instance.
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
                    /// The type of the bill. Valid values: SubscriptionOrder: subscription order PayAsYouGoBill: pay-as-you-go bill Refund: refund Adjustment: reconciliation
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public string Item { get; set; }

                    /// <summary>
                    /// The unit price. This parameter is returned only if the isBillingItem parameter is set to true.
                    /// </summary>
                    [NameInMap("ListPrice")]
                    [Validation(Required=false)]
                    public string ListPrice { get; set; }

                    /// <summary>
                    /// The unit of the unit price. This parameter is returned only if the isBillingItem parameter is set to true.
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
                    /// The unsettled amount of the bill.
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// The ID of the member. This parameter is returned in a multi-account payment scenario.
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// The amount paid in cash.
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    /// <summary>
                    /// The code of the service. The service code is the same as that displayed in User Center.
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
                    /// The resource group.
                    /// </summary>
                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    /// <summary>
                    /// The validity period.
                    /// </summary>
                    [NameInMap("ServicePeriod")]
                    [Validation(Required=false)]
                    public string ServicePeriod { get; set; }

                    /// <summary>
                    /// The unit of the validity period.
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
                    /// The month in which the split item is used.
                    /// </summary>
                    [NameInMap("SplitBillingCycle")]
                    [Validation(Required=false)]
                    public string SplitBillingCycle { get; set; }

                    /// <summary>
                    /// The commodity code of the split item.
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
                    /// The name of the service to which the split item belongs.
                    /// </summary>
                    [NameInMap("SplitProductDetail")]
                    [Validation(Required=false)]
                    public string SplitProductDetail { get; set; }

                    /// <summary>
                    /// The billing method. Valid values: Subscription: subscription PayAsYouGo: pay-as-you-go This parameter is returned together with the ProductCode parameter.
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
                    /// The usage of the split item. This parameter is returned only if the isBillingItem parameter is set to true.
                    /// </summary>
                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                    /// <summary>
                    /// The unit of usage. This parameter is returned only if the isBillingItem parameter is set to true.
                    /// </summary>
                    [NameInMap("UsageUnit")]
                    [Validation(Required=false)]
                    public string UsageUnit { get; set; }

                    /// <summary>
                    /// The ID of the zone.
                    /// </summary>
                    [NameInMap("Zone")]
                    [Validation(Required=false)]
                    public string Zone { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page. Default value: 1.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned on each page. Default value: 20. Maximum value: 300.
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
