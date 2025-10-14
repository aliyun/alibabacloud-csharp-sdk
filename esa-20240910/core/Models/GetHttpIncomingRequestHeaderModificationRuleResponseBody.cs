// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetHttpIncomingRequestHeaderModificationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>402411533580288</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The type of the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: the global configuration.</description></item>
        /// <item><description>rule: the rule configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The configurations for modifying request headers. You can add, delete, or edit a request header.</para>
        /// </summary>
        [NameInMap("RequestHeaderModification")]
        [Validation(Required=false)]
        public List<GetHttpIncomingRequestHeaderModificationRuleResponseBodyRequestHeaderModification> RequestHeaderModification { get; set; }
        public class GetHttpIncomingRequestHeaderModificationRuleResponseBodyRequestHeaderModification : TeaModel {
            /// <summary>
            /// <para>The name of the request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The action. Valid values:</para>
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
            /// <item><description>static</description></item>
            /// <item><description>dynamic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CC228B4-7A67-4016-9C9F-4A4133494A91</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description>true: Match all incoming requests.</description></item>
        /// <item><description>Set the value to a custom expression, for example: (http.host eq &quot;video.example.com&quot;): Match the specified request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. Valid values: You do not need to set this parameter when you add global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. You do not need to set this parameter when you add global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The order in which the rule is executed. A smaller value gives priority to the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The version number of the website configurations. You can use this parameter to specify a version of your website to apply the feature settings. By default, version 0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
