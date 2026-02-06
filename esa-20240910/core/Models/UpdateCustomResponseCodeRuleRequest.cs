// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCustomResponseCodeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Response page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configurations. Use cases:</para>
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
        /// <para>Specifies whether to enable the rule. Valid values: You do not need to set this parameter when you add global configurations. Valid values:</para>
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
        /// <para>The rule name. You do not need to set this parameter when you add global configurations.</para>
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
        /// <para>437375513708224</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
