// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeIPSRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of rules that have the <c>drop</c> action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>976</para>
        /// </summary>
        [NameInMap("DropCount")]
        [Validation(Required=false)]
        public long? DropCount { get; set; }

        /// <summary>
        /// <para>The number of high-risk rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>518</para>
        /// </summary>
        [NameInMap("HighRiskCount")]
        [Validation(Required=false)]
        public long? HighRiskCount { get; set; }

        /// <summary>
        /// <para>The total number of enabled rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1752</para>
        /// </summary>
        [NameInMap("OpenCount")]
        [Validation(Required=false)]
        public long? OpenCount { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DF55258-1448-5386-B263-4771D081****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeIPSRulesResponseBodyRules> Rules { get; set; }
        public class DescribeIPSRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The target application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMB</para>
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// <para>The attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Exception connection</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            /// <summary>
            /// <para>The current action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("CurrentMode")]
            [Validation(Required=false)]
            public string CurrentMode { get; set; }

            /// <summary>
            /// <para>The CVE ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cve-2024-38816</para>
            /// </summary>
            [NameInMap("Cve")]
            [Validation(Required=false)]
            public string Cve { get; set; }

            /// <summary>
            /// <para>The default action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("DefaultMode")]
            [Validation(Required=false)]
            public string DefaultMode { get; set; }

            /// <summary>
            /// <para>A description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The engine mode.</para>
            /// <para>This parameter takes effect only when <c>DefaultMode</c> is set to <c>drop</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleClass")]
            [Validation(Required=false)]
            public int? RuleClass { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f532f59d-2026-436b-8209-e04d8ebc2****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The rule level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleLevel")]
            [Validation(Required=false)]
            public long? RuleLevel { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Nmap扫描探测</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d401b0cb-dc64-4bbe-bba0-3e7c744****</para>
            /// </summary>
            [NameInMap("RuleUuid")]
            [Validation(Required=false)]
            public string RuleUuid { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp for when the rule was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1775101028</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule is user-defined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserDefined")]
            [Validation(Required=false)]
            public string UserDefined { get; set; }

            /// <summary>
            /// <para>The user-defined status of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public int? UserStatus { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of user-defined rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("UserDefineCount")]
        [Validation(Required=false)]
        public long? UserDefineCount { get; set; }

    }

}
