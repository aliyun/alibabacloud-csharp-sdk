// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchUpdateWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>The list of rule configurations, which specifies the detailed configuration of each rule.</para>
        /// <para><b>Required sub-fields for each phase</b> (applicable only to the two phases supported by this batch operation):</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: You must provide <c>Type</c>, and at least one of <c>ManagedList</c> or <c>RateLimit</c>.</description></item>
        /// <item><description><c>http_bot</c>: You must provide configurations related to advanced bot management. The sub-fields are subject to the definition of the <c>WafRuleConfig</c> data structure.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: Other phases such as <c>http_custom</c> and <c>http_whitelist</c> cannot be updated by using this batch operation. Use the single-rule operation <c>UpdateWafRule</c> instead. The sub-field constraints are subject to the documentation of the single-rule operation.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Note: If <c>Configs</c> is empty or sub-fields are missing, the server returns an <c>InvalidParameter(400)</c> or <c>Rule.Config.Malformed</c> error.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Configs { get; set; }

        /// <summary>
        /// <para>The execution phase of WAF rules. This <b>batch operation supports only</b> the following two phases. For other phases, use the single-rule operation <c>UpdateWafRule</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>http_anti_scan</c>: scan protection rules</description></item>
        /// <item><description><c>http_bot</c>: advanced bot management rules</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The <c>http_anti_scan</c> and <c>http_bot</c> phases <b>support only batch updates</b>. The single-rule operation <c>UpdateWafRule</c> does not accept these two values. Conversely, other phases (such as <c>http_custom</c> and <c>http_whitelist</c>) can only be updated by using the single-rule operation and cannot be updated by using this batch operation.</para>
        /// </remarks>
        /// <para><b>Required constraint</b>: Although this parameter is marked as optional (required: false) in the specification, it <b>must be specified</b> when you call this batch operation. The server cannot determine the target rule set without the Phase parameter. If this parameter is not provided, an <c>InvalidParameter(400)</c> error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule set. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The shared configuration for multiple rules, which specifies the common properties of multiple rules.</para>
        /// <para><b>Conditional requirement</b>: Although this parameter is marked as optional (required: false) in the specification, it is <b>actually required</b> when <c>Phase</c> is set to <c>http_anti_scan</c>. If this parameter is not provided, the server returns an <c>InvalidParameter(400)</c> error.</para>
        /// <para><b>Sub-field requirements</b>: In the <c>http_anti_scan</c> phase, the Shared parameter must include shared fields such as <c>Name</c> (rule name), <c>Expression</c> (match expression), and <c>Action</c> (rule action). For other phases, the required sub-fields of Shared depend on the specific phase.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the site configuration. For sites with configuration version management enabled, you can use this parameter to specify the site version for which the configuration takes effect. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
