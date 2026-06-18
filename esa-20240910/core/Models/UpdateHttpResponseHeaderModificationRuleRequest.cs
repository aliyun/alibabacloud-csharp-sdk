// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpResponseHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Configuration. You can get this value by calling the <a href="https://help.aliyun.com/document_detail/2867483.html">ListHttpResponseHeaderModificationRules</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>A list of objects, each defining a modification to a Response Header. Supported operations are <c>add</c>, <c>del</c>, and <c>modify</c>.</para>
        /// </summary>
        [NameInMap("ResponseHeaderModification")]
        [Validation(Required=false)]
        public List<UpdateHttpResponseHeaderModificationRuleRequestResponseHeaderModification> ResponseHeaderModification { get; set; }
        public class UpdateHttpResponseHeaderModificationRuleRequestResponseHeaderModification : TeaModel {
            /// <summary>
            /// <para>The name of the Response Header to modify.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation to perform on the Response Header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds the specified Response Header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes the specified Response Header.</para>
            /// </description></item>
            /// <item><description><para><c>modify</c>: Modifies the specified Response Header.</para>
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
            /// <para>The mode for assigning the header <c>Value</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: Static mode. The <c>Value</c> is a fixed string.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: Dynamic mode. The <c>Value</c> is generated dynamically.</para>
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
            /// <para>The new or modified Value for the Response Header. This parameter is required when the <c>Operation</c> is <c>add</c> or <c>modify</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The matching condition for the Rule, written as a Conditional Expression. This parameter is optional for global Configurations. Use cases:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>Specifies whether the rule is enabled. This parameter is optional for a global Configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the Rule.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the Rule.</para>
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
        /// <para>The name of the Rule. This parameter is optional for a global Configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution order for the Rule. A lower value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the Site. You can get this value by calling the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456******</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
