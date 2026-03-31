// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBaseSystemRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>80736FA5-FA87-55F6-AA69-C5477C6FE6D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeBaseSystemRulesResponseBodyRules> Rules { get; set; }
        public class DescribeBaseSystemRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CVE-2021-34538</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rule description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sqli</para>
            /// </summary>
            [NameInMap("DetectType")]
            [Validation(Required=false)]
            public string DetectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>super_strict</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public string RuleAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>113089</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>systemRuleTest</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1665460629000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
