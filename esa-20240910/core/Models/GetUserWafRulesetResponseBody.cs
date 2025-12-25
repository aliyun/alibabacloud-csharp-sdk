// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserWafRulesetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Ruleset")]
        [Validation(Required=false)]
        public GetUserWafRulesetResponseBodyRuleset Ruleset { get; set; }
        public class GetUserWafRulesetResponseBodyRuleset : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ip.src == 1.1.1.1</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{}]</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<GetUserWafRulesetResponseBodyRulesetRules> Rules { get; set; }
            public class GetUserWafRulesetResponseBodyRulesetRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;http.host&quot;]</para>
                /// </summary>
                [NameInMap("CharacteristicsFields")]
                [Validation(Required=false)]
                public List<string> CharacteristicsFields { get; set; }

                /// <summary>
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
                /// <b>Example:</b>
                /// <para>[&quot;ip.src&quot;]</para>
                /// </summary>
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http_custom</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000001</para>
                /// </summary>
                [NameInMap("RulesetId")]
                [Validation(Required=false)]
                public long? RulesetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public string Skip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;http_custom&quot;]</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-07-07T15:00:00Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Shared")]
            [Validation(Required=false)]
            public WafBatchRuleShared Shared { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
