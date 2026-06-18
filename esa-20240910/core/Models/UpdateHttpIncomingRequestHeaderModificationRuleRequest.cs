// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpIncomingRequestHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. To obtain this ID, call the ListHttpIncomingRequestHeaderModificationRules API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>419717024278528</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>An array of objects that defines the request header modifications. Supported operations include <c>add</c>, <c>del</c>, and <c>modify</c>.</para>
        /// </summary>
        [NameInMap("RequestHeaderModification")]
        [Validation(Required=false)]
        public List<UpdateHttpIncomingRequestHeaderModificationRuleRequestRequestHeaderModification> RequestHeaderModification { get; set; }
        public class UpdateHttpIncomingRequestHeaderModificationRuleRequestRequestHeaderModification : TeaModel {
            /// <summary>
            /// <para>The name of the request header.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operation to perform on the request header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds a request header.</para>
            /// </description></item>
            /// <item><description><para><c>del</c>: Deletes a request header.</para>
            /// </description></item>
            /// <item><description><para><c>modify</c>: Modifies an existing request header.</para>
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
            /// <para>The type of value. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>static</c>: The value is a fixed, literal string.</para>
            /// </description></item>
            /// <item><description><para><c>dynamic</c>: The value is generated dynamically at runtime.</para>
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
            /// <para>The value of the request header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headerValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The rule expression, a conditional expression that matches user requests. This parameter is not required for a global configuration. You can use this parameter in two ways:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set this value to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, provide a custom expression, such as <c>(http.host eq &quot;video.example.com&quot;)</c>.</para>
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
        /// <para>The name of the rule. This parameter is not required for a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies the rule\&quot;s priority. Rules with a lower value are executed first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the site. To obtain this ID, call the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>568181195163328</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
