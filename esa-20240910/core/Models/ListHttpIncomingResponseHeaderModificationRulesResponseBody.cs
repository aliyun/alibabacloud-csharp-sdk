// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpIncomingResponseHeaderModificationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configurations for modifying HTTP incoming response headers.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpIncomingResponseHeaderModificationRulesResponseBodyConfigs> Configs { get; set; }
        public class ListHttpIncomingResponseHeaderModificationRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>430559776208896</para>
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
            /// <para>rule</para>
            /// </summary>
            [NameInMap("ConfigType")]
            [Validation(Required=false)]
            public string ConfigType { get; set; }

            /// <summary>
            /// <para>The response header modifications. Three operations are supported: add, delete, and modify.</para>
            /// </summary>
            [NameInMap("ResponseHeaderModification")]
            [Validation(Required=false)]
            public List<ListHttpIncomingResponseHeaderModificationRulesResponseBodyConfigsResponseHeaderModification> ResponseHeaderModification { get; set; }
            public class ListHttpIncomingResponseHeaderModificationRulesResponseBodyConfigsResponseHeaderModification : TeaModel {
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
                /// <para>The operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>add: adds a response header.</description></item>
                /// <item><description>del: deletes a response header.</description></item>
                /// <item><description>modify: modifies a response header.</description></item>
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
            /// <para>The rule content, which uses a conditional expression to match user requests. This parameter does not need to be set when adding a global configuration. Two scenarios are supported:</para>
            /// <list type="bullet">
            /// <item><description>Match all incoming requests: set the value to true.</description></item>
            /// <item><description>Match specified requests: set the value to a custom expression, for example: (http.host eq \&quot;video.example.com\&quot;).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq &quot;video.example.com&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. This parameter does not need to be set when adding a global configuration. Valid values:</para>
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
            /// <para>The rule name. This parameter does not need to be set when adding a global configuration.</para>
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
            /// <para>0</para>
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
        /// <para>The number of entries per page. Default value: 500. Valid values: 1 to 500.</para>
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
        /// <para>CF02C6F6-DB59-5438-8C05-3CE42DFCB0AD</para>
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
