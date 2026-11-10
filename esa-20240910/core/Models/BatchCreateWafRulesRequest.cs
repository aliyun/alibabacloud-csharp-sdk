// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of rule configurations, which specifies the detailed configuration of each rule.</para>
        /// <para><b>Required subfields for each phase</b> (only applicable to the two phases supported by this batch operation):</para>
        /// <list type="bullet">
        /// <item><description>http_anti_scan: You must provide Type and at least one of ManagedList or RateLimit.</description></item>
        /// <item><description>http_bot: You must provide configurations related to advanced bots. The subfields are subject to the WafRuleConfig data structure definition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: Other phases such as http_custom and http_whitelist cannot use this batch operation. Use the single-item operation CreateWafRule instead. The subfield constraints are subject to the single-item operation documentation.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: If Configs is missing or subfields are missing, the service returns InvalidParameter(400) or Rule.Config.Malformed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Configs { get; set; }

        /// <summary>
        /// <para>The execution phase of the WAF rule. This <b>batch operation only supports</b> the following two phases. For other phases, use the single-item operations CreateWafRule or UpdateWafRule:</para>
        /// <list type="bullet">
        /// <item><description>http_anti_scan: Scan protection rules.</description></item>
        /// <item><description>http_bot: Advanced bots.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The http_anti_scan and http_bot phases <b>only support batch creation</b>. The single-item operation CreateWafRule does not accept these two values. Conversely, other phases (such as http_custom and http_whitelist) can only be created by using the single-item operation and cannot use this batch operation.</para>
        /// </remarks>
        /// <para><b>Required constraint</b>: Although this parameter is marked as optional (required: false) in the specification, it <b>must be provided</b> when you call this batch operation. If it is not provided, the service returns InvalidParameter(400).</para>
        /// <para><b>Edition prerequisite</b>: http_anti_scan requires the site to have the <b>High edition or higher</b>. Calls from the Basic edition return Phase.HttpAntiScan.NotSupport. Verify the site edition before you call the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The ID of the WAF ruleset. You can obtain the ruleset ID by calling the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The shared configuration for multiple rules, which specifies the common attributes of the rules.</para>
        /// <para><b>Conditionally required</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>actually required</b> when Phase is set to http_anti_scan. If it is not provided, the service returns InvalidParameter(400).</para>
        /// <para><b>Subfield requirements</b>: In the http_anti_scan phase, Shared must include shared fields such as Name (rule name) and Action (rule action). For other phases, the required subfields of Shared depend on the specific phase.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version where the configuration takes effect. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
