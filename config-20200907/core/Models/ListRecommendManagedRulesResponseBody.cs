// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRecommendManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("RecommendedManagedRules")]
        [Validation(Required=false)]
        public ListRecommendManagedRulesResponseBodyRecommendedManagedRules RecommendedManagedRules { get; set; }
        public class ListRecommendManagedRulesResponseBodyRecommendedManagedRules : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to initiate the next query.</para>
            /// <remarks>
            /// <para>If this parameter is left empty, no more results are returned.</para>
            /// </remarks>
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
            public List<ListRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList> RecommendedManagedRuleList { get; set; }
            public class ListRecommendManagedRulesResponseBodyRecommendedManagedRulesRecommendedManagedRuleList : TeaModel {
                /// <summary>
                /// <para>The rule name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket-referer-limit</para>
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// <para>The description of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>If the hotlink protection feature is enabled for the OSS bucket and the Referer is added to a specified whitelist, the configuration is considered compliant.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The rule identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket-referer-limit</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::OSS::Bucket</para>
                /// </summary>
                [NameInMap("ResourceTypeScope")]
                [Validation(Required=false)]
                public string ResourceTypeScope { get; set; }

            }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC300244-FCE3-5061-8214-C27ECB66****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
