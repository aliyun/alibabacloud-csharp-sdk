// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsResponseBody : TeaModel {
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
        public QueryAccountTransactionsResponseBodyData Data { get; set; }
        public class QueryAccountTransactionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of your Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The information about transactions.</para>
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
                    /// <para>The amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
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
                    /// <para>The billing cycle. Format: YYYY-MM.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020-03</para>
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// <para>The type of transaction payment. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Cash: pay for the transaction in cash.</description></item>
                    /// <item><description>Deposit: pay for the transaction with deposit.</description></item>
                    /// <item><description>RegularBankCreditRefund: pay for the transaction with credit refund controlled by a bank.</description></item>
                    /// <item><description>DirectPay: directly pay for the transaction.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cash</para>
                    /// </summary>
                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    /// <summary>
                    /// <para>The number of the order or bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2020030242</para>
                    /// </summary>
                    [NameInMap("RecordID")]
                    [Validation(Required=false)]
                    public string RecordID { get; set; }

                    /// <summary>
                    /// <para>The remarks on the transaction.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NAT_GW</para>
                    /// </summary>
                    [NameInMap("Remarks")]
                    [Validation(Required=false)]
                    public string Remarks { get; set; }

                    /// <summary>
                    /// <para>The transaction account. For example, the account is a recharge account in Alipay or a transfer account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>213562146</para>
                    /// </summary>
                    [NameInMap("TransactionAccount")]
                    [Validation(Required=false)]
                    public string TransactionAccount { get; set; }

                    /// <summary>
                    /// <para>The transaction channel.</para>
                    /// <list type="bullet">
                    /// <item><description>AccountBalance</description></item>
                    /// <item><description>BankTransfer</description></item>
                    /// <item><description>Alipay</description></item>
                    /// <item><description>AntCreditPay</description></item>
                    /// <item><description>OfflineRemittance</description></item>
                    /// <item><description>RegularBankCreditRefund</description></item>
                    /// <item><description>CreditCard</description></item>
                    /// <item><description>MyBankCredit</description></item>
                    /// <item><description>HuaxiaBankCInstallment</description></item>
                    /// <item><description>ApplePay</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AccountBalance</para>
                    /// </summary>
                    [NameInMap("TransactionChannel")]
                    [Validation(Required=false)]
                    public string TransactionChannel { get; set; }

                    /// <summary>
                    /// <para>The serial number of the transaction channel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234354325</para>
                    /// </summary>
                    [NameInMap("TransactionChannelSN")]
                    [Validation(Required=false)]
                    public string TransactionChannelSN { get; set; }

                    /// <summary>
                    /// <para>The type of the transaction flow.</para>
                    /// <list type="bullet">
                    /// <item><description>Income</description></item>
                    /// <item><description>Expense</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Expense</para>
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
                    /// <para>2020-03-10T02:03:20Z</para>
                    /// </summary>
                    [NameInMap("TransactionTime")]
                    [Validation(Required=false)]
                    public string TransactionTime { get; set; }

                    /// <summary>
                    /// <para>The type of the transaction.</para>
                    /// <list type="bullet">
                    /// <item><description>Payment</description></item>
                    /// <item><description>Withdraw</description></item>
                    /// <item><description>Refund</description></item>
                    /// <item><description>Consumption</description></item>
                    /// <item><description>Transfer</description></item>
                    /// <item><description>Adjust</description></item>
                    /// </list>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8634E02D-0942-4B1D-8295-5352FE9A1F39</para>
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
