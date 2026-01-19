// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeHttpDDoSAttackRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4030CD2-0D9D-5E92-B358-421AE58307C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleInfos")]
        [Validation(Required=false)]
        public List<DescribeHttpDDoSAttackRulesResponseBodyRuleInfos> RuleInfos { get; set; }
        public class DescribeHttpDDoSAttackRulesResponseBodyRuleInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("DefaultAction")]
            [Validation(Required=false)]
            public string DefaultAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100010</para>
            /// </summary>
            [NameInMap("LogRuleId")]
            [Validation(Required=false)]
            public int? LogRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The HTTP request\&quot;s Accept header contains invalid features#1</para>
            /// </summary>
            [NameInMap("RuleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20203578</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>global_01_s</para>
            /// </summary>
            [NameInMap("RuleIdInfo")]
            [Validation(Required=false)]
            public string RuleIdInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Illegal request。</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
