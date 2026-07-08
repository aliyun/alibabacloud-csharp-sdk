// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecRulesResponseBodyData> Data { get; set; }
        public class DescribeApisecRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34933</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The details of the rule. The value is a string that is converted from a JSON object.</para>
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
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: enabled</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>risk</b>: threat detection</para>
            /// </description></item>
            /// <item><description><para><b>event</b>: security event</para>
            /// </description></item>
            /// <item><description><para><b>sensitive_word</b>: sensitive data</para>
            /// </description></item>
            /// <item><description><para><b>auth_flag</b>: authentication credential</para>
            /// </description></item>
            /// <item><description><para><b>api_tag</b>: business purpose</para>
            /// </description></item>
            /// <item><description><para><b>desensitization</b>: data masking</para>
            /// </description></item>
            /// <item><description><para><b>whitelist</b>: whitelist</para>
            /// </description></item>
            /// <item><description><para><b>recognition</b>: API.</para>
            /// </description></item>
            /// <item><description><para><b>offline_api</b>: lifecycle management</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the rule was updated. This value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1721095301</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
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
