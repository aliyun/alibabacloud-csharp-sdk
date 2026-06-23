// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomResponseCodeRuleRequest : TeaModel {
        /// <summary>
        /// <para>The response page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// <para>The rule content. Conditional expressions are used to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: Set the value to true.</description></item>
        /// <item><description>Match specified requests: Set the value to a custom expression, such as (http.host eq &quot;video.example.com&quot;).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The rule switch. You do not need to set this parameter when adding a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. You do not need to set this parameter when adding a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution order of the rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can call <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>805864735361584</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the site version on which the configuration takes effect. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
