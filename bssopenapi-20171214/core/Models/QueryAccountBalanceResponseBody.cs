// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBalanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAccountBalanceResponseBodyData Data { get; set; }
        public class QueryAccountBalanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The available credit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000.00</para>
            /// </summary>
            [NameInMap("AvailableAmount")]
            [Validation(Required=false)]
            public string AvailableAmount { get; set; }

            /// <summary>
            /// <para>The available cash balance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000.00</para>
            /// </summary>
            [NameInMap("AvailableCashAmount")]
            [Validation(Required=false)]
            public string AvailableCashAmount { get; set; }

            /// <summary>
            /// <para>The credit limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00</para>
            /// </summary>
            [NameInMap("CreditAmount")]
            [Validation(Required=false)]
            public string CreditAmount { get; set; }

            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CNY: Chinese Yuan</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar</para>
            /// </description></item>
            /// <item><description><para>JPY: Japanese Yen</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The credit limit granted by MYbank.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00</para>
            /// </summary>
            [NameInMap("MybankCreditAmount")]
            [Validation(Required=false)]
            public string MybankCreditAmount { get; set; }

            /// <summary>
            /// <para>The quota limit for ecosystem customers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000.00</para>
            /// </summary>
            [NameInMap("QuotaLimit")]
            [Validation(Required=false)]
            public string QuotaLimit { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16176743-6DC7-4CB3-BB25-A13982D8DFAD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
