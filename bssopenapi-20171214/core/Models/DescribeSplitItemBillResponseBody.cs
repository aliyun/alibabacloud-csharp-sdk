// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSplitItemBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSplitItemBillResponseBodyData Data { get; set; }
        public class DescribeSplitItemBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185xxxx3489</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The billing cycle. Format: YYYY-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The details of the bill.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeSplitItemBillResponseBodyDataItems> Items { get; set; }
            public class DescribeSplitItemBillResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The amount deducted with credit refund.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AdjustAmount")]
                [Validation(Required=false)]
                public float? AdjustAmount { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>185xxxx3489</para>
                /// </summary>
                [NameInMap("BillAccountID")]
                [Validation(Required=false)]
                public string BillAccountID { get; set; }

                /// <summary>
                /// <para>The name of the account to which the bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("BillAccountName")]
                [Validation(Required=false)]
                public string BillAccountName { get; set; }

                /// <summary>
                /// <para>The billing date. Format: YYYY-MM-DD. This parameter is not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-20</para>
                /// </summary>
                [NameInMap("BillingDate")]
                [Validation(Required=false)]
                public string BillingDate { get; set; }

                /// <summary>
                /// <para>The billable item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bandwidth</para>
                /// </summary>
                [NameInMap("BillingItem")]
                [Validation(Required=false)]
                public string BillingItem { get; set; }

                /// <summary>
                /// <para>The code of the billable item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk</para>
                /// </summary>
                [NameInMap("BillingItemCode")]
                [Validation(Required=false)]
                public string BillingItemCode { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Other</para>
                /// </summary>
                [NameInMap("BillingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// <para>The type of the business.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trusteeship</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The amount paid in cash. The amount deducted with credit refund is not included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CashAmount")]
                [Validation(Required=false)]
                public float? CashAmount { get; set; }

                /// <summary>
                /// <para>The code of the commodity. The code is the same as that displayed in the Split Bill module of the User Center console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Not allocated</para>
                /// </summary>
                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                /// <summary>
                /// <para>The type of currency. Valid values: CNY, USD, and JPY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The amount deducted with vouchers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted with coupons.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCoupons { get; set; }

                /// <summary>
                /// <para>The amount deducted with prepaid cards.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public float? DeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The amount deducted with resource plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByResourcePackage")]
                [Validation(Required=false)]
                public string DeductedByResourcePackage { get; set; }

                /// <summary>
                /// <para>The configurations of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU:12</para>
                /// </summary>
                [NameInMap("InstanceConfig")]
                [Validation(Required=false)]
                public string InstanceConfig { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-kjhdskjgshfdlkjfdh</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.sn1ne.3xlarge</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34.xx.x.x</para>
                /// </summary>
                [NameInMap("InternetIP")]
                [Validation(Required=false)]
                public string InternetIP { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.xx.xx.xx</para>
                /// </summary>
                [NameInMap("IntranetIP")]
                [Validation(Required=false)]
                public string IntranetIP { get; set; }

                /// <summary>
                /// <para>The discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public float? InvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The type of the bill. Valid values: SubscriptionOrder: the subscription bill. PayAsYouGoBill: the pay-as-you-go bill. Refund: the refund. Adjustment: the adjustment bill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGoBill</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The name of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iZ28bycvyb4Z</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The unit price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public string ListPrice { get; set; }

                /// <summary>
                /// <para>The unit of the unit price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY/GB</para>
                /// </summary>
                [NameInMap("ListPriceUnit")]
                [Validation(Required=false)]
                public string ListPriceUnit { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nick</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The amount that is unsettled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("OutstandingAmount")]
                [Validation(Required=false)]
                public float? OutstandingAmount { get; set; }

                /// <summary>
                /// <para>The ID of the account that owns the resource. This parameter is returned in multi-account scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>169***013</para>
                /// </summary>
                [NameInMap("OwnerID")]
                [Validation(Required=false)]
                public string OwnerID { get; set; }

                /// <summary>
                /// <para>The amount paid in cash. The amount deducted with credit refund is included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PaymentAmount")]
                [Validation(Required=false)]
                public float? PaymentAmount { get; set; }

                /// <summary>
                /// <para>The code of the service. The code is the same as that displayed in the Split Bill module of the User Center console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("PipCode")]
                [Validation(Required=false)]
                public string PipCode { get; set; }

                /// <summary>
                /// <para>The pretax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public float? PretaxAmount { get; set; }

                /// <summary>
                /// <para>The pretax gross amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public float? PretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The code of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The details of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The type of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The duration of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ServicePeriod")]
                [Validation(Required=false)]
                public string ServicePeriod { get; set; }

                /// <summary>
                /// <para>The unit of the service duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hour</para>
                /// </summary>
                [NameInMap("ServicePeriodUnit")]
                [Validation(Required=false)]
                public string ServicePeriodUnit { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the split bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**122</para>
                /// </summary>
                [NameInMap("SplitAccountID")]
                [Validation(Required=false)]
                public string SplitAccountID { get; set; }

                /// <summary>
                /// <para>The name of the account to which the split item belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test**1122</para>
                /// </summary>
                [NameInMap("SplitAccountName")]
                [Validation(Required=false)]
                public string SplitAccountName { get; set; }

                /// <summary>
                /// <para>The billing cycle in which the bill is split.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06</para>
                /// </summary>
                [NameInMap("SplitBillingCycle")]
                [Validation(Required=false)]
                public string SplitBillingCycle { get; set; }

                /// <summary>
                /// <para>The day on which the bill is split.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-01</para>
                /// </summary>
                [NameInMap("SplitBillingDate")]
                [Validation(Required=false)]
                public string SplitBillingDate { get; set; }

                /// <summary>
                /// <para>The code of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SplitCommodityCode")]
                [Validation(Required=false)]
                public string SplitCommodityCode { get; set; }

                /// <summary>
                /// <para>The ID of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-28bycvyb4</para>
                /// </summary>
                [NameInMap("SplitItemID")]
                [Validation(Required=false)]
                public string SplitItemID { get; set; }

                /// <summary>
                /// <para>The name of the split item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iZ28bycvyb4Z</para>
                /// </summary>
                [NameInMap("SplitItemName")]
                [Validation(Required=false)]
                public string SplitItemName { get; set; }

                /// <summary>
                /// <para>The details of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("SplitProductDetail")]
                [Validation(Required=false)]
                public string SplitProductDetail { get; set; }

                /// <summary>
                /// <para>The billing method. Valid values: Subscription: the subscription billing method. PayAsYouGo: the pay-as-you-go billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// <para>The tag of the resource. If tags added to resources change, the bills generated during the period in which resources and tags are associated are returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key:testKey value:testValue; key:testKey1 value:testValues1</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The amount of resource usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// <para>The unit of usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("UsageUnit")]
                [Validation(Required=false)]
                public string UsageUnit { get; set; }

                /// <summary>
                /// <para>The zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qingdao Zone B</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token used for the next query. If this parameter is empty, all the results are returned. When you perform the next query, you must set the NextToken parameter to this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESEgoQCg4K</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
