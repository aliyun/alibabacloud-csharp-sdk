// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourcesResponseBodyData Data { get; set; }
        public class DescribeResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of returned resources.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeResourcesResponseBodyDataContent> Content { get; set; }
            public class DescribeResourcesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The amount of data in the Archive storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ArchiveDataSize")]
                [Validation(Required=false)]
                public long? ArchiveDataSize { get; set; }

                /// <summary>
                /// <para>The number of failed check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckFailedCount")]
                [Validation(Required=false)]
                public long? CheckFailedCount { get; set; }

                /// <summary>
                /// <para>The amount of data in the Cold Archive storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ColdArchiveDataSize")]
                [Validation(Required=false)]
                public long? ColdArchiveDataSize { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates when the resource was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1697798340</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The data redundancy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LRS</para>
                /// </summary>
                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

                /// <summary>
                /// <para>Indicates whether data protection scoring is enabled for the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EnableCheck")]
                [Validation(Required=false)]
                public bool? EnableCheck { get; set; }

                /// <summary>
                /// <para>The amount of data in the Infrequent Access (IA) storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IaDataSize")]
                [Validation(Required=false)]
                public long? IaDataSize { get; set; }

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
                /// <para>The data protection score of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ProtectionScore")]
                [Validation(Required=false)]
                public int? ProtectionScore { get; set; }

                /// <summary>
                /// <para>The UNIX timestamp that indicates when the score was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ProtectionScoreUpdatedTime")]
                [Validation(Required=false)]
                public long? ProtectionScoreUpdatedTime { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The unique resource ARN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ecs:cn-hangzhou:xxxxxxxx:instance/xxxxx</para>
                /// </summary>
                [NameInMap("ResourceArn")]
                [Validation(Required=false)]
                public string ResourceArn { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
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
                /// <para>The resource owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123***7890</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public long? ResourceOwnerId { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The number of check items with potential risks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public long? RiskCount { get; set; }

                /// <summary>
                /// <para>The amount of data in the Standard storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StandardDataSize")]
                [Validation(Required=false)]
                public long? StandardDataSize { get; set; }

                /// <summary>
                /// <para>The resource status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The total amount of data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public long? TotalDataSize { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of resources to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb836242f4225fa0f0e0257362dfc6dd</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of resources that match the query criteria. This parameter is optional and is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700683DE-0154-56D4-8D76-3B7A2C2C7DF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
