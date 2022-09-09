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
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("dependsOnResourceIds")]
            [Validation(Required=false)]
            public List<string> DependsOnResourceIds { get; set; }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            [NameInMap("propertyVariables")]
            [Validation(Required=false)]
            public Dictionary<string, object> PropertyVariables { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("resourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("resourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesTags> Tags { get; set; }
            public class ListResourcesResponseBodyResourcesTags : TeaModel {
                [NameInMap("tagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("tagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("terraformArn")]
            [Validation(Required=false)]
            public string TerraformArn { get; set; }

            [NameInMap("terraformCode")]
            [Validation(Required=false)]
            public string TerraformCode { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
