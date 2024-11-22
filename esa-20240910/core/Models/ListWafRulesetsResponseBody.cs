// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of WAF rulesets that are used by the instance in the WAF rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public long? InstanceUsage { get; set; }

        /// <summary>
        /// <para>The page number returned.</para>
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
        /// <para>The details of the rulesets.</para>
        /// </summary>
        [NameInMap("Rulesets")]
        [Validation(Required=false)]
        public List<ListWafRulesetsResponseBodyRulesets> Rulesets { get; set; }
        public class ListWafRulesetsResponseBodyRulesets : TeaModel {
            /// <summary>
            /// <para>The matched objects.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            /// <summary>
            /// <para>The ID of the WAF ruleset.<a href="~~2850233~~"></a></para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ruleset name.</para>
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
            /// <para>http_bot</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The ruleset status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the protection target in the http_bot rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The types of rules.</para>
            /// </summary>
            [NameInMap("Types")]
            [Validation(Required=false)]
            public List<string> Types { get; set; }

            /// <summary>
            /// <para>The time when the ruleset was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of WAF rulesets that are used by the website in the WAF rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SiteUsage")]
        [Validation(Required=false)]
        public long? SiteUsage { get; set; }

        /// <summary>
        /// <para>The total number of filtered rulesets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
