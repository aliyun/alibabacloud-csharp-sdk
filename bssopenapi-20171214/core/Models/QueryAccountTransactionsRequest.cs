// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the creation time range to query. By default, the transactions in the last month are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2018-01-01T00:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-06T01:55:00Z</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the creation time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2018-01-01T00:00:00Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-05T01:46:09Z</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the order or bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200302</para>
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// <para>The transaction channel. If you specify one of the following transaction channels for this parameter, the results for the specified transaction channel are returned. If the transaction channel that you specify does not belong to the following transaction channels, no result is returned. If you leave this parameter empty, the results for all the following transaction channels are returned by default. Valid values:</para>
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
        /// <para>12342134</para>
        /// </summary>
        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        /// <summary>
        /// <para>The type of the transaction flow. If you specify one of the following types for this parameter, the results for the specified type are returned. If the type that you specify does not belong to the following types, no result is returned. If you leave this parameter empty, the results for the following two types are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Income</description></item>
        /// <item><description>Expense</description></item>
        /// </list>
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
        /// <para>133314076</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// <para>The type of the transaction. If you specify one of the following transaction types for this parameter, the results for the specified transaction type are returned. If the transaction type that you specify does not belong to the following types, no result is returned. If you leave this parameter empty, the results for all the following transaction types are returned by default. Valid values:</para>
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
        /// <para>Payment</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

    }

}
