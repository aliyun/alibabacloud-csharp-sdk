// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsResponseBody : TeaModel {
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
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetFundAccountTransactionDetailsResponseBodyData> Data { get; set; }
        public class GetFundAccountTransactionDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The balance after the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public string Balance { get; set; }

            /// <summary>
            /// <para>The order number or bill number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323203243</para>
            /// </summary>
            [NameInMap("BillNumber")]
            [Validation(Required=false)]
            public string BillNumber { get; set; }

            /// <summary>
            /// <para>The external transaction serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20244389232</para>
            /// </summary>
            [NameInMap("ChannelTransactionNumber")]
            [Validation(Required=false)]
            public string ChannelTransactionNumber { get; set; }

            /// <summary>
            /// <para>The currency of the transaction amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23473943</para>
            /// </summary>
            [NameInMap("FundAccountEcid")]
            [Validation(Required=false)]
            public string FundAccountEcid { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232121</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public long? FundAccountId { get; set; }

            /// <summary>
            /// <para>The account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample account name</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the account owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32343231</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public long? FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The fund type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCT_BOOK</para>
            /// </summary>
            [NameInMap("FundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            /// <summary>
            /// <para>The primary marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2684210001</para>
            /// </summary>
            [NameInMap("Nbid")]
            [Validation(Required=false)]
            public string Nbid { get; set; }

            /// <summary>
            /// <para>The remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The corresponding transaction account, such as the Alipay top-up account or the counterparty account for a transfer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>186****3975</para>
            /// </summary>
            [NameInMap("TransactionAccount")]
            [Validation(Required=false)]
            public string TransactionAccount { get; set; }

            /// <summary>
            /// <para>The transaction amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TransactionAmount")]
            [Validation(Required=false)]
            public string TransactionAmount { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("TransactionChannel")]
            [Validation(Required=false)]
            public string TransactionChannel { get; set; }

            /// <summary>
            /// <para>The transaction direction. Valid values: in (income) and out (expense).</para>
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
            /// <para>5423121</para>
            /// </summary>
            [NameInMap("TransactionNumber")]
            [Validation(Required=false)]
            public long? TransactionNumber { get; set; }

            /// <summary>
            /// <para>The formatted string of the transaction time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 12:00:00</para>
            /// </summary>
            [NameInMap("TransactionTime")]
            [Validation(Required=false)]
            public string TransactionTime { get; set; }

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

        }

        /// <summary>
        /// <para>The metadata of the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
