// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule usage of the instance that corresponds to the website in the WAF rule category.</para>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>The rules returned.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListWafRulesResponseBodyRules> Rules { get; set; }
        public class ListWafRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The action triggered when requests match conditions defined in the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The fields in rate limiting rules.</para>
            /// </summary>
            [NameInMap("CharacteristicsFields")]
            [Validation(Required=false)]
            public List<string> CharacteristicsFields { get; set; }

            /// <summary>
            /// <para>The configuration of the rule.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public WafRuleConfig Config { get; set; }

            /// <summary>
            /// <para>The fields in the rule.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The WAF rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The position of the rule in the ruleset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// <para>The ruleset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("RulesetId")]
            [Validation(Required=false)]
            public long? RulesetId { get; set; }

            /// <summary>
            /// <para>The skip scope applied when requests match conditions defined in the whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>part</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public string Skip { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The skipped WAF rule categories when requests match conditions defined in the whitelist rule.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The time when the rule takes effect.</para>
            /// </summary>
            [NameInMap("Timer")]
            [Validation(Required=false)]
            public WafTimer Timer { get; set; }

            /// <summary>
            /// <para>The WAF rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the rule was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The rule usage of the website.</para>
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
