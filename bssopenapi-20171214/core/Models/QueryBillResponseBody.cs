// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryBillResponseBodyData Data { get; set; }
        public class QueryBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>185xxxxx489</para>
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
            /// <para>2020-02</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The details of the bills.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryBillResponseBodyDataItems Items { get; set; }
            public class QueryBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryBillResponseBodyDataItemsItem> Item { get; set; }
                public class QueryBillResponseBodyDataItemsItem : TeaModel {
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
                    /// <para>The amount paid after tax is deducted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AfterTaxAmount")]
                    [Validation(Required=false)]
                    public float? AfterTaxAmount { get; set; }

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
                    /// <para>The code of the commodity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    /// <summary>
                    /// <para>The type of the currency.</para>
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
                    /// <para>The type of the bill.</para>
                    /// <list type="bullet">
                    /// <item><description>SubscriptionOrder</description></item>
                    /// <item><description>PayAsYouGoBill</description></item>
                    /// <item><description>Refund</description></item>
                    /// <item><description>Adjustment</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SubscriptionOrder</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public string Item { get; set; }

                    /// <summary>
                    /// <para>The unsettled amount of the bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the member. This parameter is returned in a multi-account payment scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3532535235</para>
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// <para>The amount paid with cash.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
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
                    /// <para>The time when the order was paid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-03-11 08:00:00</para>
                    /// </summary>
                    [NameInMap("PaymentTime")]
                    [Validation(Required=false)]
                    public string PaymentTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2O3AADJFEAF2PDKSFAMFCB11918</para>
                    /// </summary>
                    [NameInMap("PaymentTransactionID")]
                    [Validation(Required=false)]
                    public string PaymentTransactionID { get; set; }

                    /// <summary>
                    /// <para>The code of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("PipCode")]
                    [Validation(Required=false)]
                    public string PipCode { get; set; }

                    /// <summary>
                    /// <para>The pretax amount</para>
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
                    /// <para>ApsaraDB RDS (subscription)</para>
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
                    /// <para>The ID of the order or bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020xxxx5912</para>
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

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
                    /// <para>The payment status of the bill. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PayFinish: The bill is paid.</description></item>
                    /// <item><description>PayUnclear: The bill is not cleared.</description></item>
                    /// <item><description>PayUnsettle: The bill is not settled.</description></item>
                    /// <item><description>NoSettle: The bill is free of settlement.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayFinish</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the order corresponding to the bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>325345254353</para>
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Subscription</description></item>
                    /// <item><description>PayAsYouGo</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
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

                    /// <summary>
                    /// <para>The time when the bill ends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-03-11 08:00:00</para>
                    /// </summary>
                    [NameInMap("UsageEndTime")]
                    [Validation(Required=false)]
                    public string UsageEndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the bill starts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-03-11 07:00:00</para>
                    /// </summary>
                    [NameInMap("UsageStartTime")]
                    [Validation(Required=false)]
                    public string UsageStartTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>AE3F4057-DFC9-4B81-8858-F620651010C9</para>
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
