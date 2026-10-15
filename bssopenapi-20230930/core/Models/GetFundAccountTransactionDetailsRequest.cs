// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The transaction order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023212312321</para>
        /// </summary>
        [NameInMap("BillNumber")]
        [Validation(Required=false)]
        public string BillNumber { get; set; }

        /// <summary>
        /// <para>The payment reference No.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250312334312322</para>
        /// </summary>
        [NameInMap("ChannelTransactionNumber")]
        [Validation(Required=false)]
        public string ChannelTransactionNumber { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end timestamp for the query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735664561000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the fund account. If you do not specify this parameter, the ID of the account owned by the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123221232</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start timestamp for the query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735664461000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of transaction channels. If you specify this parameter, transactions are queried by channel. If you do not specify this parameter, all channels are queried by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACCT_CASH: User balance.</description></item>
        /// <item><description>ALIPAY: Alipay.</description></item>
        /// <item><description>ALIPAY_ZHIFUTONG: Alipay Zhifutong.</description></item>
        /// <item><description>OFFLINE_REMIT: Corporate remittance.</description></item>
        /// <item><description>REFUND: Credit limit refund.</description></item>
        /// <item><description>UNION_PAY_BANK: Online banking.</description></item>
        /// <item><description>CREDIT_CARD: Credit card. Available only on the international site.</description></item>
        /// <item><description>AYPAL: PayPal. Available only on the international site.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TransactionChannelList")]
        [Validation(Required=false)]
        public List<string> TransactionChannelList { get; set; }

        /// <summary>
        /// <para>The direction of the transaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IN</para>
        /// </summary>
        [NameInMap("TransactionDirection")]
        [Validation(Required=false)]
        public string TransactionDirection { get; set; }

        /// <summary>
        /// <para>The transaction number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>543231231</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public long? TransactionNumber { get; set; }

        /// <summary>
        /// <para>The transaction type. If you specify a transaction type, the query returns results of the corresponding type. If no results exist, an empty result is returned. If you do not specify this parameter, all types are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CHARGE: Top-up.</description></item>
        /// <item><description>WITHDRAW: Withdrawal.</description></item>
        /// <item><description>REFUND: Refund.</description></item>
        /// <item><description>PAY: Payment.</description></item>
        /// <item><description>TRANSFER: Transfer.</description></item>
        /// <item><description>ADJUST: Adjustment.</description></item>
        /// <item><description>PAY_FAILED: Refund for failed order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CHARGE</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// <para>The list of transaction types. You can specify multiple parameters for a parameter query.</para>
        /// </summary>
        [NameInMap("TransactionTypeList")]
        [Validation(Required=false)]
        public List<string> TransactionTypeList { get; set; }

    }

}
