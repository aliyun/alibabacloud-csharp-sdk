// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsResponseBody : TeaModel {
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
        /// <para>Data list</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetFundAccountTransactionDetailsResponseBodyData> Data { get; set; }
        public class GetFundAccountTransactionDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Balance after the operation</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public string Balance { get; set; }

            /// <summary>
            /// <para>Order number or bill number</para>
            /// 
            /// <b>Example:</b>
            /// <para>2323203243</para>
            /// </summary>
            [NameInMap("BillNumber")]
            [Validation(Required=false)]
            public string BillNumber { get; set; }

            /// <summary>
            /// <para>External transaction serial number</para>
            /// 
            /// <b>Example:</b>
            /// <para>20244389232</para>
            /// </summary>
            [NameInMap("ChannelTransactionNumber")]
            [Validation(Required=false)]
            public string ChannelTransactionNumber { get; set; }

            /// <summary>
            /// <para>Transaction amount currency</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>Enterprise entity ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>23473943</para>
            /// </summary>
            [NameInMap("FundAccountEcid")]
            [Validation(Required=false)]
            public string FundAccountEcid { get; set; }

            /// <summary>
            /// <para>Account ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232121</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public long? FundAccountId { get; set; }

            /// <summary>
            /// <para>Account name</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的名称</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <para>Alibaba Cloud account ID of the account owner</para>
            /// 
            /// <b>Example:</b>
            /// <para>32343231</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public long? FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>Fund type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACCT_BOOK</para>
            /// </summary>
            [NameInMap("FundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            /// <summary>
            /// <para>Primary marketplace</para>
            /// 
            /// <b>Example:</b>
            /// <para>2684210001</para>
            /// </summary>
            [NameInMap("Nbid")]
            [Validation(Required=false)]
            public string Nbid { get; set; }

            /// <summary>
            /// <para>Remarks</para>
            /// 
            /// <b>Example:</b>
            /// <para>订单备注</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Site</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>Corresponding transaction account, such as the Alipay top-up account or the counterparty account for transfers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>186****3975</para>
            /// </summary>
            [NameInMap("TransactionAccount")]
            [Validation(Required=false)]
            public string TransactionAccount { get; set; }

            /// <summary>
            /// <para>Transaction amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TransactionAmount")]
            [Validation(Required=false)]
            public string TransactionAmount { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("TransactionChannel")]
            [Validation(Required=false)]
            public string TransactionChannel { get; set; }

            /// <summary>
            /// <para>Transaction direction: in/out (income/expenditure)</para>
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
            /// <para>5423121</para>
            /// </summary>
            [NameInMap("TransactionNumber")]
            [Validation(Required=false)]
            public long? TransactionNumber { get; set; }

            /// <summary>
            /// <para>Formatted transaction time string</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 12:00:00</para>
            /// </summary>
            [NameInMap("TransactionTime")]
            [Validation(Required=false)]
            public string TransactionTime { get; set; }

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

        }

        /// <summary>
        /// <para>Response structure metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
