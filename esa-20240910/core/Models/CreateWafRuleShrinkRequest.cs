// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateWafRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The specific configuration of the WAF rule (<c>WafRuleConfig</c> data structure). The required fields vary depending on the Phase value:</para>
        /// <list type="bullet">
        /// <item><description><c>http_custom</c>: <c>Expression</c> (match expression) and <c>Action</c> (action upon match) are required. Setting <c>Name</c> is recommended for easier identification.</description></item>
        /// <item><description><c>http_whitelist</c>: <c>Expression</c> is required. Matched requests are allowed directly (no Action).</description></item>
        /// <item><description><c>http_ratelimit</c>: <c>Expression</c> and <c>RateLimit</c> (rate limiting parameters) are required.</description></item>
        /// <item><description><c>ip_access_rule</c>: <c>Expression</c> (containing IP match) and <c>Action</c> are required.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The complete field definitions are based on the <c>WafRuleConfig</c> data structure. If required fields are missing, the service returns <c>InvalidParameter(400)</c> / <c>Rule.Config.Malformed</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        /// <summary>
        /// <para>The WAF rule execution phase. This <b>single-creation operation</b> supports the following phases (it does not support <c>http_anti_scan</c> or <c>http_bot</c>. For these two phases, use the batch operation <c>BatchCreateWafRules</c>):</para>
        /// <list type="bullet">
        /// <item><description><c>http_whitelist</c>: whitelist rule</description></item>
        /// <item><description><c>http_custom</c>: custom rule</description></item>
        /// <item><description><c>http_managed</c>: managed rule</description></item>
        /// <item><description><c>http_ratelimit</c>: rate limiting rule</description></item>
        /// <item><description><c>ip_access_rule</c>: IP access rule</description></item>
        /// <item><description><c>http_security_level_rule</c>: security rule</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: <c>http_anti_scan</c> and <c>http_bot</c> can only be created through the batch operation. Passing these two values to this operation returns an error.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
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
