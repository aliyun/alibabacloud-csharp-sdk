// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateHttpRequestHeaderModificationRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>An array of objects that define Request Header modifications. Supported operations include add, del, and modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RequestHeaderModification")]
        [Validation(Required=false)]
        public string RequestHeaderModificationShrink { get; set; }

        /// <summary>
        /// <para>The content of the Rule, which uses a Conditional Expression to match user requests. This parameter is not required when you add a global configuration. Supports two Use Cases:</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to true.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, for example, (http.host eq &quot;video.example.com&quot;).</para>
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
        /// <para>Specifies whether to enable the Rule. This parameter is not required when you add a global configuration. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enables the Rule.</para>
        /// </description></item>
        /// <item><description><para>off: Disables the Rule.</para>
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
        /// <para>The name of the Rule. This parameter is not required when you add a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The execution order of the Rule. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The ID of the Site. You can get this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The Version of the Site configuration. For a Site with configuration versioning enabled, this parameter specifies the configuration\&quot;s target Version. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
