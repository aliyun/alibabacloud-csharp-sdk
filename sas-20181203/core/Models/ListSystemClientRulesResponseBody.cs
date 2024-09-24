// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemClientRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSystemClientRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListSystemClientRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C43CA30F-EF67-51BB-8C95-F31B8303****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the system defense rules.</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<ListSystemClientRulesResponseBodyRuleList> RuleList { get; set; }
        public class ListSystemClientRulesResponseBodyRuleList : TeaModel {
            /// <summary>
            /// <para>The name of the aggregation type for the system defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial entry</para>
            /// </summary>
            [NameInMap("AggregationName")]
            [Validation(Required=false)]
            public string AggregationName { get; set; }

            /// <summary>
            /// <para>The description of the system defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Supports alerting or blocking of images that have high-risk vulnerabilities\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the OS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b>: Windows</description></item>
            /// <item><description><b>linux</b>: Linux</description></item>
            /// <item><description><b>all</b>: all types</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>An array that consists of policies.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListSystemClientRulesResponseBodyRuleListPolicies> Policies { get; set; }
            public class ListSystemClientRulesResponseBodyRuleListPolicies : TeaModel {
                /// <summary>
                /// <para>The policy key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system_auto_****</para>
                /// </summary>
                [NameInMap("PolicyKey")]
                [Validation(Required=false)]
                public string PolicyKey { get; set; }

                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System self-starting task\<em>\</em>\<em>\</em></para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the system defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the system defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Rule\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the system defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: alihips, process-specific defense</description></item>
            /// <item><description><b>2</b>: alinet, network-specific defense</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alihips</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// <para>The status of the system defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: enabled</description></item>
            /// <item><description><b>offline</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The switch ID of the system defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-ENABLE-SWITCH-TYPE_****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

    }

}
