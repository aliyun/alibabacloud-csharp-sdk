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
        /// <para>The WAF ruleset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Ruleset")]
        [Validation(Required=false)]
        public GetUserWafRulesetResponseBodyRuleset Ruleset { get; set; }
        public class GetUserWafRulesetResponseBodyRuleset : TeaModel {
            /// <summary>
            /// <para>The description of the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expression of the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip.src == 1.1.1.1</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The WAF ruleset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The phase in which the WAF rule runs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>http_whitelist: whitelist rule</description></item>
            /// <item><description>http_custom: custom rule</description></item>
            /// <item><description>http_managed: managed rule</description></item>
            /// <item><description>http_anti_scan: scan protection rule</description></item>
            /// <item><description>http_ratelimit: frequency control rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The position of the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <para>The list of rule configurations in the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{}]</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetUserWafRulesetResponseBodyRulesetRules> Rules { get; set; }
            public class GetUserWafRulesetResponseBodyRulesetRules : TeaModel {
                /// <summary>
                /// <para>The action of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>deny: Block.</description></item>
                /// <item><description>monitor: Monitor.</description></item>
                /// <item><description>js: JavaScript Challenge.</description></item>
                /// <item><description>captcha: Slider challenge.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of statistics fields for the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;http.host&quot;]</para>
                /// </summary>
                [NameInMap("CharacteristicsFields")]
                [Validation(Required=false)]
                public List<string> CharacteristicsFields { get; set; }

                /// <summary>
                /// <para>The configuration of the WAF rule.</para>
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
                /// <para>The list of match fields for the WAF rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ip.src&quot;]</para>
                /// </summary>
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                /// <summary>
                /// <para>The WAF rule ID.</para>
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
                /// <para>The phase in which the WAF rule runs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>http_whitelist: whitelist rule</description></item>
                /// <item><description>http_custom: custom rule</description></item>
                /// <item><description>http_managed: managed rule</description></item>
                /// <item><description>http_anti_scan: scan protection rule</description></item>
                /// <item><description>http_ratelimit: frequency control rule</description></item>
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
                /// <para>The WAF ruleset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("RulesetId")]
                [Validation(Required=false)]
                public long? RulesetId { get; set; }

                /// <summary>
                /// <para>The skip mode of the WAF rule.</para>
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
                /// <para>The list of phases to skip for the WAF rule.</para>
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
                /// <para>The time when the WAF rule was last updated.</para>
                /// <para>Format: RFC 3339 / ISO 8601, UTC time zone (ending with Z).</para>
                /// <para>Example: 2025-07-07T15:00:00Z</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-07T15:00:00Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The shared configuration of the WAF ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Shared")]
            [Validation(Required=false)]
            public WafBatchRuleShared Shared { get; set; }

            /// <summary>
            /// <para>The status of the WAF ruleset.</para>
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
