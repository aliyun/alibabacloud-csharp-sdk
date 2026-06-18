// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetHttpResponseHeaderModificationRuleResponseBody : TeaModel {
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
        /// <item><description><para><c>global</c>: global configuration.</para>
        /// </description></item>
        /// <item><description><para><c>rule</c>: rule configuration.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of modifications to apply to the response header.</para>
        /// </summary>
        [NameInMap("ResponseHeaderModification")]
        [Validation(Required=false)]
        public List<GetHttpResponseHeaderModificationRuleResponseBodyResponseHeaderModification> ResponseHeaderModification { get; set; }
        public class GetHttpResponseHeaderModificationRuleResponseBodyResponseHeaderModification : TeaModel {
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
            /// <para>The operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds a header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes a header.</para>
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
            /// <item><description><para><c>static</c>: static mode.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: dynamic mode.</para>
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
        /// <para>The rule content, a conditional expression used to match user requests. This parameter applies only to rule configurations. The expression can be:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Matches all incoming requests.</para>
        /// </description></item>
        /// <item><description><para>A custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>: Matches specific requests.</para>
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
        /// <para>The rule switch. This parameter applies only to rule configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: The rule is disabled.</para>
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
        /// <para>The rule name. This parameter applies only to rule configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The version of the site configuration. If configuration versioning is enabled for the site, this parameter specifies the version to which this configuration applies. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
