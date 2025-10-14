// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpIncomingRequestHeaderModificationRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of modifying request headers. You can add, delete, or modify a request header.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RequestHeaderModification")]
        [Validation(Required=false)]
        public string RequestHeaderModificationShrink { get; set; }

        /// <summary>
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description>true: Match all incoming requests.</description></item>
        /// <item><description>Set the value to a custom expression, for example: (http.host eq &quot;video.example.com&quot;): Match the specified request</description></item>
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
        /// <para>478016908379824</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

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
