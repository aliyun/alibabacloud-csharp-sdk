// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpResponseHeaderModificationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of HTTP response header modification rules.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpResponseHeaderModificationRulesResponseBodyConfigs> Configs { get; set; }
        public class ListHttpResponseHeaderModificationRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>35281609698****</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The type of configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>global</c>: A global configuration.</para>
            /// </description></item>
            /// <item><description><para><c>rule</c>: A rule configuration.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rule</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The response header modifications. You can add, remove, or modify headers.</para>
            /// </summary>
            [NameInMap("ResponseHeaderModification")]
            [Validation(Required=false)]
            public List<ListHttpResponseHeaderModificationRulesResponseBodyConfigsResponseHeaderModification> ResponseHeaderModification { get; set; }
            public class ListHttpResponseHeaderModificationRulesResponseBodyConfigsResponseHeaderModification : TeaModel {
                /// <summary>
                /// <para>The response header name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>headerName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The modification operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>add</c>: Adds a header.</para>
                /// </description></item>
                /// <item><description><para><c>del</c>: Removes a header.</para>
                /// </description></item>
                /// <item><description><para><c>modify</c>: Modifies a header.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                /// <summary>
                /// <para>The value type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>static</c>: Static mode.</para>
                /// </description></item>
                /// <item><description><para><c>dynamic</c>: Dynamic mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The response header value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>headerValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The conditional expression that matches user requests. This parameter is not required for a global configuration.</para>
            /// <list type="bullet">
            /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
            /// </description></item>
            /// <item><description><para>To match specific requests, set a custom expression. Example: <c>(http.host eq &quot;video.example.com&quot;)</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq &quot;video.example.com&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>Whether the rule is enabled. This parameter is not required for a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>on</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>off</c>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The name of the rule. This parameter is not required for a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution priority of the rule. Rules with smaller values have higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration. For sites with version management enabled, this specifies the version to which the configuration applies. The default is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
