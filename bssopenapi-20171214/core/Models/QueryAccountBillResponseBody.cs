// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBillResponseBody : TeaModel {
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
        public QueryAccountBillResponseBodyData Data { get; set; }
        public class QueryAccountBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1857xxxxx489</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account.</para>
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
            /// <para>The details of the bills.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public QueryAccountBillResponseBodyDataItems Items { get; set; }
            public class QueryAccountBillResponseBodyDataItems : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<QueryAccountBillResponseBodyDataItemsItem> Item { get; set; }
                public class QueryAccountBillResponseBodyDataItemsItem : TeaModel {
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
                    /// <para>The ID of the account to which the bill belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1857xxxxx489</para>
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
                    /// <para>The billing date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-03-01</para>
                    /// </summary>
                    [NameInMap("BillingDate")]
                    [Validation(Required=false)]
                    public string BillingDate { get; set; }

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
                    /// <para>The cost center.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not allocated</para>
                    /// </summary>
                    [NameInMap("CostUnit")]
                    [Validation(Required=false)]
                    public string CostUnit { get; set; }

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
                    /// <para>The unsettled amount or the amount settled with credits.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OutstandingAmount")]
                    [Validation(Required=false)]
                    public float? OutstandingAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the member.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>325434254</para>
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// <para>The name of the member.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aligzncloudtest2</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The amount paid in cash. The amount that was deducted by using credit refunds is included.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public float? PaymentAmount { get; set; }

                    /// <summary>
                    /// <para>The code of the service. The service code is consistent with that displayed in User Center.</para>
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
                    /// <remarks>
                    /// <para>A value is returned only if the <b>IsGroupByProduct</b> parameter is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// <remarks>
                    /// <para>A value is returned only if the <b>IsGroupByProduct</b> parameter is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Subscription: the subscription billing method</description></item>
                    /// <item><description>PayAsYouGo: the pay-as-you-go billing method</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>A value is returned only if the IsGroupByProduct parameter is set to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

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
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>3BFC23FE-A182-4D96-A1E4-7521B30B8E43</para>
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
