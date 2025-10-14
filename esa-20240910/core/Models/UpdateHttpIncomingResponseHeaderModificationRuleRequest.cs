// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateHttpIncomingResponseHeaderModificationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. You can call the ListHttpIncomingResponseHeaderModificationRules operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Modifies a response header. You can add, delete, or modify a request header.</para>
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
            /// <para>The action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>add: adds a response header.</description></item>
            /// <item><description>del: deletes a response header.</description></item>
            /// <item><description>modify: modifies a response header.</description></item>
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
            /// <para>The value type of the column. Valid values:</para>
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
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description>true: Match all incoming requests.</description></item>
        /// <item><description>Set the value to a custom expression, for example, (http.host eq &quot;video.example.com&quot;): Match the specified request.</description></item>
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
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
