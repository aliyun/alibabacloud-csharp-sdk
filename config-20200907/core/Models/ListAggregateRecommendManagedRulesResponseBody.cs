// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateRecommendManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("RecommendedManagedRules")]
        [Validation(Required=false)]
        public ListAggregateRecommendManagedRulesResponseBodyRecommendedManagedRules RecommendedManagedRules { get; set; }
        public class ListAggregateRecommendManagedRulesResponseBodyRecommendedManagedRules : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>If the return results are truncated, you can use NextToken to initiate another request to retrieve the remaining results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zXZXbg4Mra0kOrhpwl21****</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The list of managed rules.</para>
            /// </summary>
            [NameInMap("RecommendedManagedRuleList")]
            [Validation(Required=false)]
            public List<ListAggregateRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList> RecommendedManagedRuleList { get; set; }
            public class ListAggregateRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList : TeaModel {
                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ram-policy-in-use-check</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>If the permission policy is bound to one or more RAM user groups, RAM roles, or RAM users, the configuration is considered compliant.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ram-policy-in-use-check</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::RAM::Policy</para>
                /// </summary>
                [NameInMap("ResourceTypeScope")]
                [Validation(Required=false)]
                public string ResourceTypeScope { get; set; }

            }

            /// <summary>
            /// <para>The total number of rule templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CE4ABA1-9A57-41A9-8EA9-E8B17D46****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
