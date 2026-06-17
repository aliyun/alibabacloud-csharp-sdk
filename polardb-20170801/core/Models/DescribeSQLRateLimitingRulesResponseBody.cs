// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLRateLimitingRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The result set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSQLRateLimitingRulesResponseBodyData Data { get; set; }
        public class DescribeSQLRateLimitingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<string> RuleList { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for the current request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>If the request is successful, \<c>Successful\\</c> is returned. If the request fails, an error message is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh0vHYf39hc0J5qELgsazkBk</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C0ACF0-DD29-4B67-9190-B7A48C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
