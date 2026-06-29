// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpRequestHeaderModificationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of HTTP request header modification configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpRequestHeaderModificationRulesResponseBodyConfigs> Configs { get; set; }
        public class ListHttpRequestHeaderModificationRulesResponseBodyConfigs : TeaModel {
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
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>global: global configuration.</description></item>
            /// <item><description>rule: rule configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The request header modifications, which support add, delete, and modify operations.</para>
            /// </summary>
            [NameInMap("RequestHeaderModification")]
            [Validation(Required=false)]
            public List<ListHttpRequestHeaderModificationRulesResponseBodyConfigsRequestHeaderModification> RequestHeaderModification { get; set; }
            public class ListHttpRequestHeaderModificationRulesResponseBodyConfigsRequestHeaderModification : TeaModel {
                /// <summary>
                /// <para>The request header name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>headerName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>add: adds a header.</description></item>
                /// <item><description>del: deletes a header.</description></item>
                /// <item><description>modify: modifies a header.</description></item>
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
                /// <item><description>static: static pattern.</description></item>
                /// <item><description>dynamic: dynamic schema.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>static</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The request header value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>headerValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The rule content, which uses conditional expressions to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: Set the value to true.</description></item>
            /// <item><description>Match specified requests: Set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq &quot;video.example.com&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. You do not need to set this parameter when adding a global configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: enabled.</description></item>
            /// <item><description>off: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleEnable")]
            [Validation(Required=false)]
            public string RuleEnable { get; set; }

            /// <summary>
            /// <para>The rule name. You do not need to set this parameter when adding a global configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution order of the rule. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. The default value is version 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

        }

        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>500</b>. Valid values: <b>1 to 500</b>.</para>
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
        /// <para>35C66C7B-671H-4297-9187-2C4477247A78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
