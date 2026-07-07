// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUserWafRulesetShrinkRequest : TeaModel {
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
        /// <para>The match expression of the WAF ruleset. Rules in this ruleset are evaluated only when a request matches this expression.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>http.host eq &quot;example.com&quot;</c> — Only requests with the host example.com enter this ruleset.</description></item>
        /// <item><description><c>starts_with(http.uri.path, &quot;/api/&quot;)</c> — Only requests with the /api/ prefix enter this ruleset.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The complete expression syntax and available field set are subject to the server-side wirefilter dialect.</para>
        /// </remarks>
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
        /// <para><b>Naming suggestion</b>: Use a combination of letters, digits, and underscores for easy reference. The specific character set, maximum length, and uniqueness constraints are subject to the WAF ruleset service naming conventions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phase to which the WAF ruleset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>http_whitelist: whitelist rules</description></item>
        /// <item><description>http_custom: custom rules</description></item>
        /// <item><description>http_managed: managed rules</description></item>
        /// <item><description>http_anti_scan: scan protection rules</description></item>
        /// <item><description>http_ratelimit: rate limiting rules</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: The supported fields (Expression match fields, Action values, and others) vary by phase. For more information, refer to the rule configuration documentation for the corresponding phase.</para>
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
        /// <para>The list of rule configurations in the WAF ruleset. Each element corresponds to a rule.</para>
        /// <list type="bullet">
        /// <item><description>The field structure of each rule is subject to the <c>WafRuleConfig</c> data structure, which includes Expression, Action, Name, and other fields.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

        /// <summary>
        /// <para>The shared fields across multiple rules in this ruleset, such as a unified Action or Name prefix.</para>
        /// <remarks>
        /// <para>The field structure is subject to the <c>WafBatchRuleShared</c> data structure. If you do not need to share properties, you can leave this parameter empty.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public string SharedShrink { get; set; }

        /// <summary>
        /// <para>The status of the WAF ruleset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled. The rules in the ruleset participate in matching and blocking.</description></item>
        /// <item><description>off: Disabled. The ruleset is retained but does not participate in matching.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The complete set of valid values is subject to the server-side enum.</para>
        /// </remarks>
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
