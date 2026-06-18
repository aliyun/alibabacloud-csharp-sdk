// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpIncomingResponseHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. You can obtain this ID by calling the <c>ListHttpIncomingResponseHeaderModificationRules</c> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>A list of objects specifying modifications to response headers. Supported operations include <c>add</c>, <c>del</c>, and <c>modify</c>.</para>
        /// </summary>
        [NameInMap("ResponseHeaderModification")]
        [Validation(Required=false)]
        public List<UpdateHttpIncomingResponseHeaderModificationRuleRequestResponseHeaderModification> ResponseHeaderModification { get; set; }
        public class UpdateHttpIncomingResponseHeaderModificationRuleRequestResponseHeaderModification : TeaModel {
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
            /// <para>The operation to perform. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds a response header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes a response header.</para>
            /// </description></item>
            /// <item><description><para><c>modify</c>: Modifies an existing response header.</para>
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
            /// <para>The type of the header value. This parameter is required when <c>Operation</c> is <c>add</c> or <c>modify</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: The value is a fixed string.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: The value is a variable.</para>
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
            /// <para>The value of the response header. This parameter is required when <c>Operation</c> is <c>add</c> or <c>modify</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The condition expression used to match incoming requests. This parameter is not required for a global configuration. You can use this parameter in two ways:</para>
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
        /// <para>The status of the rule. This parameter is not required for a global configuration. Valid values:</para>
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
        /// <para>The name of the rule. This parameter is not required for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Rules with a lower value are executed first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain this ID by calling the <c>ListSites</c> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>498607398028944</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
