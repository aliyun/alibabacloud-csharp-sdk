// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRecommendManagedRulesResponseBody : TeaModel {
        [NameInMap("RecommendedManagedRules")]
        [Validation(Required=false)]
        public ListRecommendManagedRulesResponseBodyRecommendedManagedRules RecommendedManagedRules { get; set; }
        public class ListRecommendManagedRulesResponseBodyRecommendedManagedRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zXZXbg4Mra0kOrhpwl21Lw==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("RecommendedManagedRuleList")]
            [Validation(Required=false)]
            public List<ListRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList> RecommendedManagedRuleList { get; set; }
            public class ListRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList : TeaModel {
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds-instance-expired-check</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACS::RDS::Instance</para>
                /// </summary>
                [NameInMap("ResourceTypeScope")]
                [Validation(Required=false)]
                public string ResourceTypeScope { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC300244-FCE3-5061-8214-C27ECB668487</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
