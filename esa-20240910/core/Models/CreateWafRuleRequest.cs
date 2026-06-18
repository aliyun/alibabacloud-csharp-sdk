// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWafRuleRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configuration of the WAF rule.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public WafRuleConfig Config { get; set; }

        /// <summary>
        /// <para>The phase in which the WAF rule runs.</para>
        /// <list type="bullet">
        /// <item><description><para><c>http_whitelist</c>: whitelist rule</para>
        /// </description></item>
        /// <item><description><para><c>http_custom</c>: custom rule</para>
        /// </description></item>
        /// <item><description><para><c>http_managed</c>: managed rule</para>
        /// </description></item>
        /// <item><description><para><c>http_anti_scan</c>: anti-scan rule</para>
        /// </description></item>
        /// <item><description><para><c>http_ratelimit</c>: rate limit rule</para>
        /// </description></item>
        /// <item><description><para><c>ip_access_rule</c>: IP access rule</para>
        /// </description></item>
        /// <item><description><para><c>http_bot</c>: Advanced Mode Bots</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: Security Rule</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The ID of the WAF ruleset. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2878359.html">ListWafRulesets</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>If version management is enabled for the site, use this parameter to specify the version to which the configuration applies. The default is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
