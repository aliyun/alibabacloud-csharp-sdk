// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountTransactionDetailsResponseBodyData Data { get; set; }
        public class QueryAccountTransactionDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yidi</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The details of the transactions within the account.</para>
            /// </summary>
            [NameInMap("AccountTransactionsList")]
            [Validation(Required=false)]
            public QueryAccountTransactionDetailsResponseBodyDataAccountTransactionsList AccountTransactionsList { get; set; }
            public class QueryAccountTransactionDetailsResponseBodyDataAccountTransactionsList : TeaModel {
                [NameInMap("AccountTransactionsList")]
                [Validation(Required=false)]
                public List<QueryAccountTransactionDetailsResponseBodyDataAccountTransactionsListAccountTransactionsList> AccountTransactionsList { get; set; }
                public class QueryAccountTransactionDetailsResponseBodyDataAccountTransactionsListAccountTransactionsList : TeaModel {
                    /// <summary>
                    /// <para>The amount of the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.00</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// <para>The balance of the account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Balance")]
                    [Validation(Required=false)]
                    public string Balance { get; set; }

                    /// <summary>
                    /// <para>The billing cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-10</para>
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// <para>The type of transaction payment. Valid values:</para>
                    /// <para>Cash: pay for the transaction in cash. Deposit: pay for the transaction with deposit. RegularBankCreditRefund: pay for the transaction with credit refund controlled by a bank. DirectPay: directly pay for the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cash</para>
                    /// </summary>
                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    /// <summary>
                    /// <para>The ID of the order or bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022120336190912</para>
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    /// <summary>
                    /// <para>The remarks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test</para>
                    /// </summary>
                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    /// <summary>
                    /// <para>The transaction account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:fortune_test@xxx.com">fortune_test@xxx.com</a></para>
                    /// </summary>
                    [NameInMap("TransactionAccount")]
                    [Validation(Required=false)]
                    public string TransactionAccount { get; set; }

                    /// <summary>
                    /// <para>The transaction channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIPAY</para>
                    /// </summary>
                    [NameInMap("TransactionChannel")]
                    [Validation(Required=false)]
                    public string TransactionChannel { get; set; }

                    /// <summary>
                    /// <para>The serial number of the transaction channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123232434343532</para>
                    /// </summary>
                    [NameInMap("TransactionChannelSN")]
                    [Validation(Required=false)]
                    public string TransactionChannelSN { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the transaction is of the income type or the expenditure type. If one of the following types is specified, results for the specific type are returned. If the type that you specified for the parameter does not belong to the following types, no result is returned. If the parameter is left empty, results for transactions of the income and expenditure types are all returned. Valid values:</para>
                    /// <para>Income and Expense.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Income</para>
                    /// </summary>
                    [NameInMap("TransactionFlow")]
                    [Validation(Required=false)]
                    public string TransactionFlow { get; set; }

                    /// <summary>
                    /// <para>The number of the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>43342334</para>
                    /// </summary>
                    [NameInMap("TransactionNumber")]
                    [Validation(Required=false)]
                    public string TransactionNumber { get; set; }

                    /// <summary>
                    /// <para>The time when the transaction was made.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-10-01</para>
                    /// </summary>
                    [NameInMap("TransactionTime")]
                    [Validation(Required=false)]
                    public string TransactionTime { get; set; }

                    /// <summary>
                    /// <para>The type of the transaction. If one of the following transaction types is specified, results for the specified transaction type are returned. If the transaction type that you specified does not belong to the following transaction types, no result is returned. If the parameter is left empty, results for all transaction types are returned. Valid values:</para>
                    /// <para>Payment, Withdraw, Refund, Consumption, Transfer, and Adjust.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Consumption</para>
                    /// </summary>
                    [NameInMap("TransactionType")]
                    [Validation(Required=false)]
                    public string TransactionType { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used for paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASHDADS</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asadadad-edafafafaasd</para>
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
