// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchUpdateWafRulesRequest : TeaModel {
        /// <summary>
        /// <para>A list of configurations for individual rules.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Configs { get; set; }

        /// <summary>
        /// <para>The WAF rule runtime phase.</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: scan protection rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: rate limiting rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: advanced bot rule</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: security rule</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The ID of the WAF ruleset. You can call the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The configuration properties that are shared by all rules in this batch update.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version of the site configuration. For sites that have configuration version management enabled, this parameter specifies the version to which the configuration applies. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
