// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
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
        public QueryBillOverviewResponseBodyData Data { get; set; }
        public class QueryBillOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185766xxxx</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The billing cycle, in the YYYY-MM format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The details of the bills.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryBillOverviewResponseBodyDataItems Items { get; set; }
            public class QueryBillOverviewResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryBillOverviewResponseBodyDataItemsItem> Item { get; set; }
                public class QueryBillOverviewResponseBodyDataItemsItem : TeaModel {
                    /// <summary>
                    /// <para>The amount deducted by using credit refunds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AdjustAmount")]
                    [Validation(Required=false)]
                    public float? AdjustAmount { get; set; }

                    /// <summary>
                    /// <para>The amount paid after the tax is deducted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public float? AfterTaxAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the account to which the bill belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>185766xxxx</para>
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
                    /// <para>The business type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>trusteeship</para>
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// <para>The amount paid in cash. The amount that was deducted by using credit refunds is not included.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CashAmount")]
                    [Validation(Required=false)]
                    public float? CashAmount { get; set; }

                    /// <summary>
                    /// <para>The code of the commodity. The commodity code is the same as that displayed in User Center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The type of the currency. Valid values:</para>
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

                    /// <summary>
                    /// <para>The amount deducted by using vouchers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// <para>The amount deducted by using coupons.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public float? DeductedByCoupons { get; set; }

                    /// <summary>
                    /// <para>The amount deducted by using prepaid cards.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public float? DeductedByPrepaidCard { get; set; }

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
                    /// <para>The type of the bill. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SubscriptionOrder</description></item>
                    /// <item><description>PayAsYouGoBill</description></item>
                    /// <item><description>Refund</description></item>
                    /// <item><description>Adjustment</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGoBill</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public string Item { get; set; }

                    /// <summary>
                    /// <para>The unsettled amount or the amount deducted by using credits. This may be an unsettled amount of a regular user or credits consumed by a credit user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the bill owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1222</para>
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// <para>The amount paid in cash. The amount that was deducted by using credit refunds is included.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    /// <summary>
                    /// <para>The currency used for payment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USD</para>
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// <para>The code of the service. The service code is the same as that displayed in User Center.</para>
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
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public float? PretaxAmount { get; set; }

                    /// <summary>
                    /// <para>The pretax amount paid in local currency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public float? PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <para>The pretax gross amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
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
                    /// <para>NAT Gateway (Pay-As-You-Go)</para>
                    /// </summary>
                    [NameInMap("ProductDetail")]
                    [Validation(Required=false)]
                    public string ProductDetail { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NAT Gateway</para>
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
                    /// <para>The round down discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RoundDownDiscount")]
                    [Validation(Required=false)]
                    public string RoundDownDiscount { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Subscription: the subscription billing method</description></item>
                    /// <item><description>PayAsYouGo: the pay-as-you-go billing method</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Subscription</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// <para>The tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Tax")]
                    [Validation(Required=false)]
                    public float? Tax { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
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
        /// <para>BCB1E1BC-05BF-4217-80EE-BF09A29407BA</para>
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
