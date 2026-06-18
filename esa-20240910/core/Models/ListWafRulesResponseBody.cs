// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of rules used in this WAF phase for the site\&quot;s instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public long? InstanceUsage { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of rule objects.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListWafRulesResponseBodyRules> Rules { get; set; }
        public class ListWafRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The action to take when a rule matches.</para>
            /// <list type="bullet">
            /// <item><description><para><c>deny</c>: Block the request.</para>
            /// </description></item>
            /// <item><description><para><c>monitor</c>: Log the request without blocking it.</para>
            /// </description></item>
            /// <item><description><para><c>js</c>: Issue a JS challenge.</para>
            /// </description></item>
            /// <item><description><para><c>captcha</c>: Issue a CAPTCHA challenge.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>A list of tracking characteristics for rate limit rules.</para>
            /// </summary>
            [NameInMap("CharacteristicsFields")]
            [Validation(Required=false)]
            public List<string> CharacteristicsFields { get; set; }

            /// <summary>
            /// <para>The rule configuration object.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public WafRuleConfig Config { get; set; }

            /// <summary>
            /// <para>An array of match fields for the rule.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The WAF rule\&quot;s execution phase.</para>
            /// <list type="bullet">
            /// <item><description><para><c>http_whitelist</c>: Whitelist rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_custom</c>: Custom rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_managed</c>: Managed rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_anti_scan</c>: Scan protection rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_ratelimit</c>: Rate limit rule.</para>
            /// </description></item>
            /// <item><description><para><c>ip_access_rule</c>: IP access rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_bot</c>: Advanced bot management rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_security_level_rule</c>: Security level rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The position of the rule within the ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <para>The ID of the ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("RulesetId")]
            [Validation(Required=false)]
            public long? RulesetId { get; set; }

            /// <summary>
            /// <para>The skip behavior for whitelist rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>part</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public string Skip { get; set; }

            /// <summary>
            /// <para>The status of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>An array of WAF phases to skip when the whitelist rule matches.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The effective time configuration for the rule.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public WafTimer Timer { get; set; }

            /// <summary>
            /// <para>The type of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>When the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of rules used by the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SiteUsage")]
        [Validation(Required=false)]
        public long? SiteUsage { get; set; }

        /// <summary>
        /// <para>The total number of filtered rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
