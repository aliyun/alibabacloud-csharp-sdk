// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceBillResponseBody : TeaModel {
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
        public DescribeInstanceBillResponseBodyData Data { get; set; }
        public class DescribeInstanceBillResponseBodyData : TeaModel {
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
            /// The billing cycle in the YYYY-MM format.
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// The details of the bill.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceBillResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceBillResponseBodyDataItems : TeaModel {
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
                /// The billing date. This parameter is returned only if the Granularity parameter is set to DAILY. Format: YYYY-MM-DD.
                /// </summary>
                [NameInMap("BillingDate")]
                [Validation(Required=false)]
                public string BillingDate { get; set; }

                /// <summary>
                /// The billable item. A value is returned only if the IsBillingItem parameter is set to true.
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
                /// The type of business.
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
                /// The code of the commodity. The code is the same as that in Cost Center.
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
                /// The type of currency. Valid values:
                /// 
                /// *   CNY
                /// *   USD
                /// *   JPY
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
                /// The amount deducted with resource plans. This parameter is valid only when the isBillingItem parameter is set to true.
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
                /// The type of the bill.
                /// 
                /// *   SubscriptionOrder: the subscription bill.
                /// *   PayAsYouGoBill: the pay-as-you-go bill,
                /// *   Refund: the refund.
                /// *   Adjustment: the adjustment bill.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The name of the project.
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// The unit price of the service. This parameter is valid only when the isBillingItem parameter is set to true.
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public string ListPrice { get; set; }

                /// <summary>
                /// The unit of the unit price. This parameter is valid only when the isBillingItem parameter is set to true.
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
                /// The unsettled amount.
                /// </summary>
                [NameInMap("OutstandingAmount")]
                [Validation(Required=false)]
                public float? OutstandingAmount { get; set; }

                /// <summary>
                /// The ID of the account that owns the resource. This parameter is returned in multi-account payment scenario.
                /// </summary>
                [NameInMap("OwnerID")]
                [Validation(Required=false)]
                public string OwnerID { get; set; }

                /// <summary>
                /// The amount paid in cash. The amount deducted with credit refund is not included.
                /// </summary>
                [NameInMap("PaymentAmount")]
                [Validation(Required=false)]
                public float? PaymentAmount { get; set; }

                /// <summary>
                /// The code of the service. The code is the same as that in Cost Center.
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
                /// The service duration.
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
                /// The billing method. Valid values:
                /// 
                /// *   Subscription: the subscription billing method.
                /// *   PayAsYouGo: the pay-as-you-go billing method.
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// The tag of the resource.
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// The usage of the service. This parameter is valid only when the isBillingItem parameter is set to true. The usage is the total usage in all bills in the billing cycle, not the amount that you purchase. For example, if 1 GB of storage is used and bills are generated every hour, the usage is 1 GB per hour. In this case, the usage is 24 GB per day.
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// The unit of usage. This parameter is valid only when the isBillingItem parameter is set to true.
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

            /// <summary>
            /// The maximum number of entries returned.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The position where the query stopped. If this parameter is left empty, all the results are returned. If you perform another call, you must set the NextToken parameter to the value of this parameter.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of returned entries.
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
