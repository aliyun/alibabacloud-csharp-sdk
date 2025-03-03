// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetFundAccountTransactionDetailsResponseBodyData> Data { get; set; }
        public class GetFundAccountTransactionDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Balance")]
            [Validation(Required=false)]
            public string Balance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2323203243</para>
            /// </summary>
            [NameInMap("BillNumber")]
            [Validation(Required=false)]
            public string BillNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20244389232</para>
            /// </summary>
            [NameInMap("ChannelTransactionNumber")]
            [Validation(Required=false)]
            public string ChannelTransactionNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23473943</para>
            /// </summary>
            [NameInMap("FundAccountEcid")]
            [Validation(Required=false)]
            public string FundAccountEcid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1232121</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public long? FundAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>云某的名称</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32343231</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public long? FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACCT_BOOK</para>
            /// </summary>
            [NameInMap("FundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2684210001</para>
            /// </summary>
            [NameInMap("Nbid")]
            [Validation(Required=false)]
            public string Nbid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>订单备注</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>186****3975</para>
            /// </summary>
            [NameInMap("TransactionAccount")]
            [Validation(Required=false)]
            public string TransactionAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TransactionAmount")]
            [Validation(Required=false)]
            public string TransactionAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("TransactionChannel")]
            [Validation(Required=false)]
            public string TransactionChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IN</para>
            /// </summary>
            [NameInMap("TransactionDirection")]
            [Validation(Required=false)]
            public string TransactionDirection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5423121</para>
            /// </summary>
            [NameInMap("TransactionNumber")]
            [Validation(Required=false)]
            public long? TransactionNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-01 12:00:00</para>
            /// </summary>
            [NameInMap("TransactionTime")]
            [Validation(Required=false)]
            public string TransactionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CHARGE</para>
            /// </summary>
            [NameInMap("TransactionType")]
            [Validation(Required=false)]
            public string TransactionType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D6E068C3-25BC-455A-85FE-45F0B22ECB1F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
