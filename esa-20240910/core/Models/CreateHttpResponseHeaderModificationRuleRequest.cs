// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpResponseHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>An array of objects that specify modifications to the response header. The supported operations are <c>add</c>, <c>del</c>, and <c>modify</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResponseHeaderModification")]
        [Validation(Required=false)]
        public List<CreateHttpResponseHeaderModificationRuleRequestResponseHeaderModification> ResponseHeaderModification { get; set; }
        public class CreateHttpResponseHeaderModificationRuleRequestResponseHeaderModification : TeaModel {
            /// <summary>
            /// <para>The name of the response header.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headername</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The modification to perform on the header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds a header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes a header.</para>
            /// </description></item>
            /// <item><description><para><c>modify</c>: Modifies a header.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
            /// <item><description><para><c>static</c>: Static value.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: Dynamic value.</para>
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
            /// <para>The value to assign to the header. This parameter is not required when the <c>Operation</c> is <c>del</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headervalue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies the conditional expression that an incoming request must match for the rule to apply. This parameter is not required when adding a Global Configuration. You can set the value in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression. For example: <c>(http.host eq &quot;video.example.com&quot;)</c></para>
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
        /// <para>Specifies whether to enable the rule. This parameter is not required when adding a Global Configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the rule.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the rule.</para>
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
        /// <para>The name of the rule. This parameter is not required when adding a Global Configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule\&quot;s execution order. A lower value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The Site ID. You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456******</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the Site configuration. For sites with Configuration Version Management enabled, this parameter specifies the configuration version that the Rule applies to. If omitted, this parameter defaults to version 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
