// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The policies.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecRulesResponseBodyData> Data { get; set; }
        public class DescribeApisecRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34933</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The details of the policy. The value is a string that consists of multiple parameters in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ext&quot;: &quot;Date&quot;,
            ///     &quot;regex&quot;: &quot;-&quot;,
            ///     &quot;code&quot;: &quot;2009&quot;,
            ///     &quot;level&quot;: &quot;S1&quot;,
            ///     &quot;origin&quot;: &quot;default&quot;,
            ///     &quot;name&quot;: &quot;2009&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>risk</b>: risk detection</description></item>
            /// <item><description><b>event</b>: security event</description></item>
            /// <item><description><b>sensitive_word</b>: sensitive data</description></item>
            /// <item><description><b>auth_flag</b>: authentication credential</description></item>
            /// <item><description><b>api_tag</b>: business purpose</description></item>
            /// <item><description><b>desensitization</b>: data masking</description></item>
            /// <item><description><b>whitelist</b>: whitelist</description></item>
            /// <item><description><b>recognition</b>: API recognition</description></item>
            /// <item><description><b>offline_api</b>: lifecycle management</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the policy was updated. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721095301</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
