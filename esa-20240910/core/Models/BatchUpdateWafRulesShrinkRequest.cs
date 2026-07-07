// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchUpdateWafRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of rule configurations. Specifies the detailed configuration for each rule.</para>
        /// <para><b>Required subfields for each phase</b> (applicable only to the two phases supported by this batch operation):</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: You must provide <c>Type</c> and at least one of <c>ManagedList</c> or <c>RateLimit</c>.</description></item>
        /// <item><description><c>http_bot</c>: You must provide the advanced mode bots configuration. The subfields are defined in the <c>WafRuleConfig</c> data structure.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: Other phases such as <c>http_custom</c> and <c>http_whitelist</c> cannot use this batch operation. Use the single-rule operation <c>UpdateWafRule</c> instead. The subfield constraints for those phases are described in the single-rule operation documentation.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Important: If <c>Configs</c> is missing or subfields are incomplete, the server returns <c>InvalidParameter(400)</c> or <c>Rule.Config.Malformed</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string ConfigsShrink { get; set; }

        /// <summary>
        /// <para>The WAF rule execution phase. This <b>batch operation supports only</b> the following two phases. For other phases, use the single-rule operation <c>UpdateWafRule</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: scan protection rules</description></item>
        /// <item><description><c>http_bot</c>: advanced mode bots</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The <c>http_anti_scan</c> and <c>http_bot</c> phases <b>support only batch updates</b>. The single-rule operation <c>UpdateWafRule</c> does not accept these two values. Conversely, other phases such as <c>http_custom</c> and <c>http_whitelist</c> can be updated only by using the single-rule operation, not this batch operation.</para>
        /// </remarks>
        /// <para><b>Required constraint</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>required</b> when you call this batch operation. The server cannot determine the target ruleset without the Phase parameter and returns <c>InvalidParameter(400)</c> if it is not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The ID of the WAF ruleset. You can call the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation to obtain the ruleset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The shared configuration for multiple rules. Specifies the common properties shared across multiple rules.</para>
        /// <para><b>Conditionally required</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>required</b> when <c>Phase=http_anti_scan</c>. The server returns <c>InvalidParameter(400)</c> if it is not provided.</para>
        /// <para><b>Subfield requirements</b>: When the phase is <c>http_anti_scan</c>, Shared must include the <c>Name</c> (rule name), <c>Expression</c> (match expression), and <c>Action</c> (rule action) shared fields. For other phases, the required subfields of Shared vary depending on the specific phase.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public string SharedShrink { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with version management enabled, you can use this parameter to specify the site version on which the configuration takes effect. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
