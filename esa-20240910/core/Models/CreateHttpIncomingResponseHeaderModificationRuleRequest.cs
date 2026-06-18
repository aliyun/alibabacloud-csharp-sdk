// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpIncomingResponseHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the modifications for a response header. The supported operations are <c>add</c>, <c>del</c>, and <c>modify</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResponseHeaderModification")]
        [Validation(Required=false)]
        public List<CreateHttpIncomingResponseHeaderModificationRuleRequestResponseHeaderModification> ResponseHeaderModification { get; set; }
        public class CreateHttpIncomingResponseHeaderModificationRuleRequestResponseHeaderModification : TeaModel {
            /// <summary>
            /// <para>The name of the response header.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation to perform on the header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds the header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes the header.</para>
            /// </description></item>
            /// <item><description><para><c>modify</c>: Modifies the header.</para>
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
            /// <para>The type of the header value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: The <c>Value</c> is a fixed string.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: The <c>Value</c> can contain variables.</para>
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
            /// <para>The value of the response header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The conditional expression used to match an incoming request. This parameter is not required when adding a Global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, use a custom expression. For example: <c>(http.host eq &quot;video.example.com&quot;)</c></para>
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
        /// <para>Indicates if the Rule is enabled. This parameter is not required when adding a Global configuration. Valid values:</para>
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
        /// <para>The Rule name. This parameter is not required when adding a Global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The Rule execution order. A smaller value indicates a higher priority, and the Rule is executed sooner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The unique identifier for the Site. To get this ID, call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>608665779308176</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The configuration Version for the Site. If version management is enabled, this parameter specifies the target Version. Defaults to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
