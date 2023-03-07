// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsResponseBody : TeaModel {
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
        public QueryAccountTransactionsResponseBodyData Data { get; set; }
        public class QueryAccountTransactionsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of your Alibaba Cloud account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The information about transactions.
            /// </summary>
            [NameInMap("AccountTransactionsList")]
            [Validation(Required=false)]
            public QueryAccountTransactionsResponseBodyDataAccountTransactionsList AccountTransactionsList { get; set; }
            public class QueryAccountTransactionsResponseBodyDataAccountTransactionsList : TeaModel {
                [NameInMap("AccountTransactionsList")]
                [Validation(Required=false)]
                public List<QueryAccountTransactionsResponseBodyDataAccountTransactionsListAccountTransactionsList> AccountTransactionsList { get; set; }
                public class QueryAccountTransactionsResponseBodyDataAccountTransactionsListAccountTransactionsList : TeaModel {
                    /// <summary>
                    /// The amount.
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
                    /// The billing cycle. Format: YYYY-MM.
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// The type of transaction payment. Valid values:
                    /// 
                    /// *   Cash: pay for the transaction in cash.
                    /// *   Deposit: pay for the transaction with deposit.
                    /// *   RegularBankCreditRefund: pay for the transaction with credit refund controlled by a bank.
                    /// *   DirectPay: directly pay for the transaction.
                    /// </summary>
                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    /// <summary>
                    /// The number of the order or bill.
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    /// <summary>
                    /// The remarks on the transaction.
                    /// </summary>
                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    /// <summary>
                    /// The transaction account. For example, the account is a recharge account in Alipay or a transfer account.
                    /// </summary>
                    [NameInMap("TransactionAccount")]
                    [Validation(Required=false)]
                    public string TransactionAccount { get; set; }

                    /// <summary>
                    /// The transaction channel.
                    /// 
                    /// *   AccountBalance
                    /// *   BankTransfer
                    /// *   Alipay
                    /// *   AntCreditPay
                    /// *   OfflineRemittance
                    /// *   RegularBankCreditRefund
                    /// *   CreditCard
                    /// *   MyBankCredit
                    /// *   HuaxiaBankCInstallment
                    /// *   ApplePay
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
                    /// The type of the transaction flow.
                    /// 
                    /// *   Income
                    /// *   Expense
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
                    /// The type of the transaction.
                    /// 
                    /// *   Payment
                    /// *   Withdraw
                    /// *   Refund
                    /// *   Consumption
                    /// *   Transfer
                    /// *   Adjust
                    /// </summary>
                    [NameInMap("TransactionType")]
                    [Validation(Required=false)]
                    public string TransactionType { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
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
