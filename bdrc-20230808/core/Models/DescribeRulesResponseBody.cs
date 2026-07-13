// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRulesResponseBodyData Data { get; set; }
        public class DescribeRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned records.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeRulesResponseBodyDataContent> Content { get; set; }
            public class DescribeRulesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The number of resources for which the check failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckFailedResourceCount")]
                [Validation(Required=false)]
                public long? CheckFailedResourceCount { get; set; }

                /// <summary>
                /// <para>The check status. Valid values: NOT_CHECKED (Not checked), PASSED (Passed), FAILED (Failed), CHECKING (Checking), and CHECK_FAILED (Check failed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates when the check was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1704157635</para>
                /// </summary>
                [NameInMap("CheckTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <para>The product type to which the rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The resource type to which the rule applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The number of at-risk resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskyResourceCount")]
                [Validation(Required=false)]
                public long? RiskyResourceCount { get; set; }

                /// <summary>
                /// <para>The unique ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-bp11ggd8wr762</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The rule template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-backup</para>
                /// </summary>
                [NameInMap("RuleTemplate")]
                [Validation(Required=false)]
                public string RuleTemplate { get; set; }

                /// <summary>
                /// <para>The total number of resources that were checked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0975951c75d7b41464c8d08ae17043ca</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the filter criteria. This parameter is optional and is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86DEBAC9-AB6A-59AB-9E5C-A540E579ECC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
