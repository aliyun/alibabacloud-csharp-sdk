// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserWafRulesetResponseBody : TeaModel {
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
        /// <para>The WAF rule set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Ruleset")]
        [Validation(Required=false)]
        public GetUserWafRulesetResponseBodyRuleset Ruleset { get; set; }
        public class GetUserWafRulesetResponseBodyRuleset : TeaModel {
            /// <summary>
            /// <para>The description of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expression of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip.src == 1.1.1.1</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The ID of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The evaluation phase of the WAF rule set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>http_whitelist</c>: A whitelist rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_custom</c>: A custom rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_managed</c>: A managed rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_anti_scan</c>: A scan protection rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_ratelimit</c>: A rate limiting rule.</para>
            /// </description></item>
            /// <item><description><para><c>ip_access_rule</c>: An IP access rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_bot</c>: A bot management rule.</para>
            /// </description></item>
            /// <item><description><para><c>http_security_level_rule</c>: A security level rule.</para>
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
            /// <para>The position of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <para>A list of rules in the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{}]</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetUserWafRulesetResponseBodyRulesetRules> Rules { get; set; }
            public class GetUserWafRulesetResponseBodyRulesetRules : TeaModel {
                /// <summary>
                /// <para>The action for the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>deny</c>: Blocks the request.</para>
                /// </description></item>
                /// <item><description><para><c>monitor</c>: Monitors the request.</para>
                /// </description></item>
                /// <item><description><para><c>js</c>: Triggers a JS challenge.</para>
                /// </description></item>
                /// <item><description><para><c>captcha</c>: Triggers a CAPTCHA challenge.</para>
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
                /// <para>A list of WAF rule statistics fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;http.host&quot;]</para>
                /// </summary>
                [NameInMap("CharacteristicsFields")]
                [Validation(Required=false)]
                public List<string> CharacteristicsFields { get; set; }

                /// <summary>
                /// <para>The WAF rule configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;Id&quot;: 20000001,
                ///   &quot;Name&quot;: &quot;rule1&quot;,
                ///   &quot;Expression&quot;: &quot;ip.src eq 1.1.1.1&quot;,
                ///   &quot;Action&quot;: &quot;deny&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public WafRuleConfig Config { get; set; }

                /// <summary>
                /// <para>A list of WAF rule match fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ip.src&quot;]</para>
                /// </summary>
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                /// <summary>
                /// <para>The ID of the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The evaluation phase of the WAF rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>http_whitelist</c>: A whitelist rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_custom</c>: A custom rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_managed</c>: A managed rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_anti_scan</c>: A scan protection rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_ratelimit</c>: A rate limiting rule.</para>
                /// </description></item>
                /// <item><description><para><c>ip_access_rule</c>: An IP access rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_bot</c>: A bot management rule.</para>
                /// </description></item>
                /// <item><description><para><c>http_security_level_rule</c>: A security level rule.</para>
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
                /// <para>The position of the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// <para>The ID of the WAF rule set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("RulesetId")]
                [Validation(Required=false)]
                public long? RulesetId { get; set; }

                /// <summary>
                /// <para>The skip mode for the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public string Skip { get; set; }

                /// <summary>
                /// <para>The status of the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The phases that the rule skips.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;http_custom&quot;]</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The type of the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http_ratelimit</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time the WAF rule was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-07T15:00:00Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The shared configuration of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Shared")]
            [Validation(Required=false)]
            public WafBatchRuleShared Shared { get; set; }

            /// <summary>
            /// <para>The status of the WAF rule set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
