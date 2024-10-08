// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public long? InstanceUsage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListWafRulesResponseBodyRules> Rules { get; set; }
        public class ListWafRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("CharacteristicsFields")]
            [Validation(Required=false)]
            public List<string> CharacteristicsFields { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public WafRuleConfig Config { get; set; }

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
            /// <para>part</para>
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

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("Timer")]
            [Validation(Required=false)]
            public WafTimer Timer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http_custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SiteUsage")]
        [Validation(Required=false)]
        public long? SiteUsage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
