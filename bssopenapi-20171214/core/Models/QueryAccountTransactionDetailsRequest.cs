// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-20</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-20</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>An invalid parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The paging token for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABEDSDS124DASA</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The order ID or bill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022120336190912</para>
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// <para>The transaction channel. If you specify one of the following transaction channel types, the query returns results of the specified type. If no results are found, an empty result is returned. If you do not specify this parameter, all types are returned by default.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AccountBalance: account balance</description></item>
        /// <item><description>BankTransfer: bank transfer</description></item>
        /// <item><description>Alipay: Alipay</description></item>
        /// <item><description>AntCreditPay: Ant Credit Pay</description></item>
        /// <item><description>OfflineRemittance: offline remittance</description></item>
        /// <item><description>RegularBankCreditRefund: credit limit refund</description></item>
        /// <item><description>CreditCard: credit card</description></item>
        /// <item><description>MyBankCredit: MYbank credit</description></item>
        /// <item><description>HuaxiaBankCInstallment: Huaxia Bank installment</description></item>
        /// <item><description>ApplePay: Apple Pay</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AccountBalance</para>
        /// </summary>
        [NameInMap("TransactionChannel")]
        [Validation(Required=false)]
        public string TransactionChannel { get; set; }

        /// <summary>
        /// <para>The payment reference No. of the transaction channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022112122001470591458665933</para>
        /// </summary>
        [NameInMap("TransactionChannelSN")]
        [Validation(Required=false)]
        public string TransactionChannelSN { get; set; }

        /// <summary>
        /// <para>The transaction number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410874027490089</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public string TransactionNumber { get; set; }

        /// <summary>
        /// <para>The transaction type. If you specify one of the following transaction types, the query returns results of the specified type. If no results are found, an empty result is returned. If you do not specify this parameter, all types are returned by default.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Payment: top-up</description></item>
        /// <item><description>Withdraw: withdrawal</description></item>
        /// <item><description>Refund: refund</description></item>
        /// <item><description>Consumption: consumption</description></item>
        /// <item><description>Transfer: transfer</description></item>
        /// <item><description>Adjust: adjustment</description></item>
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
