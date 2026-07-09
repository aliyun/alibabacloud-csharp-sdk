// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// <para>Transaction order number</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023212312321</para>
        /// </summary>
        [NameInMap("BillNumber")]
        [Validation(Required=false)]
        public string BillNumber { get; set; }

        /// <summary>
        /// <para>Transaction channel serial number</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250312334312322</para>
        /// </summary>
        [NameInMap("ChannelTransactionNumber")]
        [Validation(Required=false)]
        public string ChannelTransactionNumber { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Query end timestamp (milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735664561000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Fund account ID. If not specified, the account ID owned by the current account (owner) is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123221232</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <para>Page size (maximum 200)</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Query start timestamp (milliseconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735664461000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Transaction channel. If specified, the query filters by transaction channel. If not specified, all channels are queried by default.</para>
        /// <para>User balance: ACCT_CASH.</para>
        /// <para>Alipay: ALIPAY.</para>
        /// <para>Alipay Zhifutong: ALIPAY_ZHIFUTONG.</para>
        /// <para>Offline remittance: OFFLINE_REMIT.</para>
        /// <para>Credit control quota refund: REFUND.</para>
        /// <para>Online banking: UNION_PAY_BANK.</para>
        /// <para>Credit card: CREDIT_CARD. (International site only)</para>
        /// <para>PayPal: PAYPAL. (International site only)</para>
        /// </summary>
        [NameInMap("TransactionChannelList")]
        [Validation(Required=false)]
        public List<string> TransactionChannelList { get; set; }

        /// <summary>
        /// <para>Transaction direction: in/out (fund inflow/outflow)</para>
        /// 
        /// <b>Example:</b>
        /// <para>IN</para>
        /// </summary>
        [NameInMap("TransactionDirection")]
        [Validation(Required=false)]
        public string TransactionDirection { get; set; }

        /// <summary>
        /// <para>Transaction serial number</para>
        /// 
        /// <b>Example:</b>
        /// <para>543231231</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public long? TransactionNumber { get; set; }

        /// <summary>
        /// <para>Transaction type. If a transaction type is specified, only results of that type are returned. If the specified type does not exist, the result is empty. If not specified, all types are returned by default.</para>
        /// <para>Top-up: CHARGE.</para>
        /// <para>Withdrawal: WITHDRAW.</para>
        /// <para>Refund: REFUND.</para>
        /// <para>Payment: PAY.</para>
        /// <para>Transfer: TRANSFER.</para>
        /// <para>Adjustment: ADJUST.</para>
        /// <para>Order expiration refund: PAY_FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHARGE</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// <para>Transaction type list. Supports querying with multiple parameters.</para>
        /// </summary>
        [NameInMap("TransactionTypeList")]
        [Validation(Required=false)]
        public List<string> TransactionTypeList { get; set; }

    }

}
