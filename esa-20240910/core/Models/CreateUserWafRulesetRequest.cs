// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUserWafRulesetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the WAF ruleset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test ruleset.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expression for the WAF ruleset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src == 1.1.1.1</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-ads11w</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the WAF ruleset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The execution phase of the WAF ruleset.</para>
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
        /// <item><description><para><c>http_bot</c>: advanced bot</para>
        /// </description></item>
        /// <item><description><para><c>http_security_level_rule</c>: security rule</para>
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
        /// <para>A list of rule configurations within the WAF ruleset.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Rules { get; set; }

        /// <summary>
        /// <para>The shared configuration for WAF batch rules.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <para>The status of the WAF ruleset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
