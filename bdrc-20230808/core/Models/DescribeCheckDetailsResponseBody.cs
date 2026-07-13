// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeCheckDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCheckDetailsResponseBodyData Data { get; set; }
        public class DescribeCheckDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The collection of records returned by this request.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeCheckDetailsResponseBodyDataContent> Content { get; set; }
            public class DescribeCheckDetailsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The check status. Valid values: NOT_CHECKED, PASSED, FAILED, CHECKING, and CHECK_FAILED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// <para>The time when the check was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1701725715</para>
                /// </summary>
                [NameInMap("CheckTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <para>The check details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;ecsAutoSnapshotPolicyIds&quot;:[],&quot;hbrBackupPlans&quot;:[{&quot;planId&quot;:&quot;po-xxxxxxxx&quot;,&quot;sourceType&quot;:&quot;UDM_ECS&quot;}]}</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <para>The type of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The globally unique Alibaba Cloud Resource Name (ARN) of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ecs:123<em><b>890:cn-shanghai:instance/i-001</b></em>90</para>
                /// </summary>
                [NameInMap("ResourceArn")]
                [Validation(Required=false)]
                public string ResourceArn { get; set; }

                /// <summary>
                /// <para>The unique ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-xxxxxxxx</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test server</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The ID of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123***7890</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public long? ResourceOwnerId { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The unique ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule-xxxxxxxx</para>
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

            }

            /// <summary>
            /// <para>The maximum number of entries returned in this response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to retrieve the next page of results. If this parameter is empty, it indicates that all data has been retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAOTzWWYAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM4NzA3NTcwMzY2MjMwNzY2ODcyMzAzMTY2Nzg3ODY5MzY=</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the query conditions. This parameter is optional and is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92793A50-0B97-59F1-BAEA-EAED83BA1998</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
