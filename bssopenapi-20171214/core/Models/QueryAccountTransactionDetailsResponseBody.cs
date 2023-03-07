// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionDetailsResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountTransactionDetailsResponseBodyData Data { get; set; }
        public class QueryAccountTransactionDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The details of the transactions within the account.
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
                    /// The amount of the transaction.
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public string Amount { get; set; }

                    /// <summary>
                    /// The balance of the account.
                    /// </summary>
                    [NameInMap("Balance")]
                    [Validation(Required=false)]
                    public string Balance { get; set; }

                    /// <summary>
                    /// The billing cycle.
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// The type of transaction payment. Valid values:
                    /// 
                    /// Cash: pay for the transaction in cash. Deposit: pay for the transaction with deposit. RegularBankCreditRefund: pay for the transaction with credit refund controlled by a bank. DirectPay: directly pay for the transaction.
                    /// </summary>
                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    /// <summary>
                    /// The ID of the order or bill.
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    /// <summary>
                    /// The remarks.
                    /// </summary>
                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    /// <summary>
                    /// The transaction account.
                    /// </summary>
                    [NameInMap("TransactionAccount")]
                    [Validation(Required=false)]
                    public string TransactionAccount { get; set; }

                    /// <summary>
                    /// The transaction channel.
                    /// </summary>
                    [NameInMap("TransactionChannel")]
                    [Validation(Required=false)]
                    public string TransactionChannel { get; set; }

                    /// <summary>
                    /// The serial number of the transaction channel.
                    /// </summary>
                    [NameInMap("TransactionChannelSN")]
                    [Validation(Required=false)]
                    public string TransactionChannelSN { get; set; }

                    /// <summary>
                    /// Indicates whether the transaction is of the income type or the expenditure type. If one of the following types is specified, results for the specific type are returned. If the type that you specified for the parameter does not belong to the following types, no result is returned. If the parameter is left empty, results for transactions of the income and expenditure types are all returned. Valid values:
                    /// 
                    /// Income and Expense.
                    /// </summary>
                    [NameInMap("TransactionFlow")]
                    [Validation(Required=false)]
                    public string TransactionFlow { get; set; }

                    /// <summary>
                    /// The number of the transaction.
                    /// </summary>
                    [NameInMap("TransactionNumber")]
                    [Validation(Required=false)]
                    public string TransactionNumber { get; set; }

                    /// <summary>
                    /// The time when the transaction was made.
                    /// </summary>
                    [NameInMap("TransactionTime")]
                    [Validation(Required=false)]
                    public string TransactionTime { get; set; }

                    /// <summary>
                    /// The type of the transaction. If one of the following transaction types is specified, results for the specified transaction type are returned. If the transaction type that you specified does not belong to the following transaction types, no result is returned. If the parameter is left empty, results for all transaction types are returned. Valid values:
                    /// 
                    /// Payment, Withdraw, Refund, Consumption, Transfer, and Adjust.
                    /// </summary>
                    [NameInMap("TransactionType")]
                    [Validation(Required=false)]
                    public string TransactionType { get; set; }

                }

            }

            /// <summary>
            /// This parameter is invalid.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that is used for paging.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
