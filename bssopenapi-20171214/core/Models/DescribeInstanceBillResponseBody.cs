// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceBillResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceBillResponseBodyData Data { get; set; }
        public class DescribeInstanceBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The user account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The billing date. Format: YYYY-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The bill details.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceBillResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceBillResponseBodyDataItems : TeaModel {
                [NameInMap("AdjustAmount")]
                [Validation(Required=false)]
                public float? AdjustAmount { get; set; }

                /// <summary>
                /// <para>The amount after discount, including the payable amount after coupon deduction. Calculation rule: Amount after discount = List price - Discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AfterDiscountAmount")]
                [Validation(Required=false)]
                public float? AfterDiscountAmount { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the bill belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
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
                /// <para>The billing date. This parameter has a value only when Granularity is set to DAILY. Format: YYYY-MM-DD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-03-20</para>
                /// </summary>
                [NameInMap("BillingDate")]
                [Validation(Required=false)]
                public string BillingDate { get; set; }

                /// <summary>
                /// <para>The billable item. This parameter has a value only when IsBillingItem is set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bandwidth</para>
                /// </summary>
                [NameInMap("BillingItem")]
                [Validation(Required=false)]
                public string BillingItem { get; set; }

                /// <summary>
                /// <para>The billable item code.</para>
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
                /// <para>The business type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trusteeship</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("CashAmount")]
                [Validation(Required=false)]
                public float? CashAmount { get; set; }

                /// <summary>
                /// <para>The commodity code, which is the same as the product detail code in the User Center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The cost unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unallocated</para>
                /// </summary>
                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                /// <summary>
                /// <para>The currency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CNY</description></item>
                /// <item><description>USD</description></item>
                /// <item><description>JPY</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("DeductedByCashCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCashCoupons { get; set; }

                /// <summary>
                /// <para>The coupon discount amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public float? DeductedByCoupons { get; set; }

                [NameInMap("DeductedByPrepaidCard")]
                [Validation(Required=false)]
                public float? DeductedByPrepaidCard { get; set; }

                /// <summary>
                /// <para>The amount deducted by resource plans. This parameter is valid only when isBillingItem is set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("DeductedByResourcePackage")]
                [Validation(Required=false)]
                public string DeductedByResourcePackage { get; set; }

                /// <summary>
                /// <para>The detailed instance configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU：12</para>
                /// </summary>
                [NameInMap("InstanceConfig")]
                [Validation(Required=false)]
                public string InstanceConfig { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-dadada</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <para>The instance specifications.</para>
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
                /// <para>The internal IP address.</para>
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
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public float? InvoiceDiscount { get; set; }

                /// <summary>
                /// <para>The bill type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SubscriptionOrder: subscription order</description></item>
                /// <item><description>PayAsYouGoBill: pay-as-you-go bill</description></item>
                /// <item><description>Refund: refund</description></item>
                /// <item><description>Adjustment: adjustment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGoBill</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// <para>The item name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iZ28bycvyb4Z</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The unit price. This parameter is valid only when isBillingItem is set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ListPrice")]
                [Validation(Required=false)]
                public string ListPrice { get; set; }

                /// <summary>
                /// <para>The unit of the unit price. This parameter is valid only when isBillingItem is set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("ListPriceUnit")]
                [Validation(Required=false)]
                public string ListPriceUnit { get; set; }

                /// <summary>
                /// <para>The instance nickname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("OutstandingAmount")]
                [Validation(Required=false)]
                public float? OutstandingAmount { get; set; }

                /// <summary>
                /// <para>The account ID of the resource owner in multi-account payment scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("OwnerID")]
                [Validation(Required=false)]
                public string OwnerID { get; set; }

                [NameInMap("PaymentAmount")]
                [Validation(Required=false)]
                public float? PaymentAmount { get; set; }

                /// <summary>
                /// <para>The product code, which is consistent with the product code in the bills of the User Center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("PipCode")]
                [Validation(Required=false)]
                public string PipCode { get; set; }

                /// <summary>
                /// <para>The payable amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public float? PretaxAmount { get; set; }

                /// <summary>
                /// <para>The original amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public float? PretaxGrossAmount { get; set; }

                /// <summary>
                /// <para>The product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The product detail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// <para>The product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApsaraDB RDS</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The product type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default resource group</para>
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <para>The service duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("ServicePeriod")]
                [Validation(Required=false)]
                public string ServicePeriod { get; set; }

                /// <summary>
                /// <para>The unit of the service duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Seconds</para>
                /// </summary>
                [NameInMap("ServicePeriodUnit")]
                [Validation(Required=false)]
                public string ServicePeriodUnit { get; set; }

                /// <summary>
                /// <para>The subscription type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Subscription: subscription</description></item>
                /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// <para>The resource tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key:testKey value:testValue; key:testKey1 value:testValues1</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The usage.</para>
                /// <remarks>
                /// <para>This parameter is valid only when isBillingItem is set to true. The usage data is the sum of usage across all bills within the cycle, not the actual purchased amount. For example, if 1 GB of storage is used and billed hourly, the hourly usage is 1 GB, and the daily aggregated bill usage is 1 GB × 24 = 24 GB.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// <para>The usage unit. This parameter is valid only when isBillingItem is set to true.</para>
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
                /// <para>Hangzhou Zone 1</para>
                /// </summary>
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records returned for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that indicates the position from which the current call resumes reading. An empty value indicates that all data has been read. For the next call, set this value to the NextToken request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESEgoQCg4KCm</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
