// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the creation time range. If not specified, the default value is the current time. Example: 2018-01-01T00:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-06T01:55:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the creation time range. If not specified, the default value is one month before the current time. Example: 2018-01-01T00:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-05T01:46:09Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The order or bill number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200302</para>
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// <para>The transaction channel. If you specify a transaction channel, the query returns results of the corresponding type. If no results exist, an empty result is returned. If you do not specify this parameter, all types are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AccountBalance: Account balance.</description></item>
        /// <item><description>BankTransfer: Bank transfer.</description></item>
        /// <item><description>Alipay: Alipay.</description></item>
        /// <item><description>AntCreditPay: Ant Credit Pay.</description></item>
        /// <item><description>OfflineRemittance: Offline remittance.</description></item>
        /// <item><description>RegularBankCreditRefund: Credit-based payment refund.</description></item>
        /// <item><description>CreditCard: Credit card.</description></item>
        /// <item><description>MyBankCredit: MYbank Credit.</description></item>
        /// <item><description>HuaxiaBankCInstallment: Huaxia Bank installment.</description></item>
        /// <item><description>ApplePay: Apple Pay.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AccountBalance</para>
        /// </summary>
        [NameInMap("TransactionChannel")]
        [Validation(Required=false)]
        public string TransactionChannel { get; set; }

        /// <summary>
        /// <para>The payment reference No.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12342134</para>
        /// </summary>
        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        /// <summary>
        /// <para>The income and expense type. If you specify an income and expense type, the query returns results of the corresponding type. If no results exist, an empty result is returned. If you do not specify this parameter, all types are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Income: Income.</description></item>
        /// <item><description>Expense: Expense.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Income</para>
        /// </summary>
        [NameInMap("TransactionFlow")]
        [Validation(Required=false)]
        public string TransactionFlow { get; set; }

        /// <summary>
        /// <para>The transaction number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133314076</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// <para>The transaction type. If you specify a transaction type, the query returns results of the corresponding type. If no results exist, an empty result is returned. If you do not specify this parameter, all types are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Payment: Top-up.</description></item>
        /// <item><description>Withdraw: Withdrawal.</description></item>
        /// <item><description>Refund: Refund.</description></item>
        /// <item><description>Consumption: Consumption.</description></item>
        /// <item><description>Transfer: Transfer.</description></item>
        /// <item><description>Adjust: Adjustment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Payment</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

    }

}
