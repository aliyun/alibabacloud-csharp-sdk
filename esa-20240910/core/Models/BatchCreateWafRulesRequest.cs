// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of rule configurations. Specifies the detailed configuration for each rule.</para>
        /// <para><b>Required subfields for each phase</b> (applicable only to the two phases supported by this batch operation):</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: You must specify <c>Type</c> and at least one of <c>ManagedList</c> or <c>RateLimit</c>.</description></item>
        /// <item><description><c>http_bot</c>: You must specify the advanced mode bots configuration. The subfields are defined in the <c>WafRuleConfig</c> data structure.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: Other phases such as <c>http_custom</c> and <c>http_whitelist</c> cannot use this batch operation. Use the single-rule operation <c>CreateWafRule</c> instead. The subfield constraints are described in the single-rule operation documentation.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If <c>Configs</c> is not specified or required subfields are missing, the service returns <c>InvalidParameter(400)</c> or <c>Rule.Config.Malformed</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Configs { get; set; }

        /// <summary>
        /// <para>The WAF rule execution phase. This <b>batch operation supports only</b> the following two phases. For other phases, use the single-rule operations <c>CreateWafRule</c> or <c>UpdateWafRule</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: scan protection rules</description></item>
        /// <item><description><c>http_bot</c>: advanced mode bots</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The <c>http_anti_scan</c> and <c>http_bot</c> phases <b>support only batch creation</b>. The single-rule operation <c>CreateWafRule</c> does not accept these two values. Conversely, other phases such as <c>http_custom</c> and <c>http_whitelist</c> can be created only by using single-rule operations and cannot use this batch operation.</para>
        /// </remarks>
        /// <para><b>Required constraint</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>required</b> when you call this batch operation. If this parameter is not specified, the service returns <c>InvalidParameter(400)</c>.</para>
        /// <para><b>Plan prerequisite</b>: <c>http_anti_scan</c> requires the site to have a <b>high or higher plan</b>. Calling this operation with a basic plan returns <c>Phase.HttpAntiScan.NotSupport</c>. Verify the site plan before calling this operation.</para>
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
        /// <para>The shared configuration for multiple rules. Specifies the common properties of multiple rules.</para>
        /// <para><b>Conditionally required</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>required</b> when <c>Phase=http_anti_scan</c>. If this parameter is not specified, the service returns <c>InvalidParameter(400)</c>.</para>
        /// <para><b>Subfield requirements</b>: In the <c>http_anti_scan</c> phase, Shared must include shared fields such as <c>Name</c> (rule name) and <c>Action</c> (rule action). For other phases, the required subfields of Shared vary depending on the specific phase.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

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
