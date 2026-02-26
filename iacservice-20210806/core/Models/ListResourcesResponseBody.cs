// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourcesResponseBody : TeaModel {
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesResponseBodyResources> Resources { get; set; }
        public class ListResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>365845</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-03T02:22:59Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dependsOnResourceIds")]
            [Validation(Required=false)]
            public List<string> DependsOnResourceIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("propertyVariables")]
            [Validation(Required=false)]
            public Dictionary<string, object> PropertyVariables { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:vpc:cn-hangzhou:12345:test</para>
            /// </summary>
            [NameInMap("resourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aekzyqyghofqbxy</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-efegsewrttfd</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("resourcePageUrl")]
            [Validation(Required=false)]
            public string ResourcePageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Task</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesTags> Tags { get; set; }
            public class ListResourcesResponseBodyResourcesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>terraform arn</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_vpc</para>
            /// </summary>
            [NameInMap("terraformArn")]
            [Validation(Required=false)]
            public string TerraformArn { get; set; }

            /// <summary>
            /// <para>terraform code</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicloud_vpc</para>
            /// </summary>
            [NameInMap("terraformCode")]
            [Validation(Required=false)]
            public string TerraformCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67585D9B-EFA5-5E51-BAB1-8FF07DA1B36F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
