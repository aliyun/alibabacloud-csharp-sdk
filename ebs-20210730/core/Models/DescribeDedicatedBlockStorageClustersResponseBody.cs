// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClustersResponseBody : TeaModel {
        [NameInMap("DedicatedBlockStorageClusters")]
        [Validation(Required=false)]
        public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters> DedicatedBlockStorageClusters { get; set; }
        public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DedicatedBlockStorageClusterCapacity")]
            [Validation(Required=false)]
            public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterCapacity : TeaModel {
                [NameInMap("AvailableCapacity")]
                [Validation(Required=false)]
                public long? AvailableCapacity { get; set; }

                [NameInMap("DeliveryCapacity")]
                [Validation(Required=false)]
                public long? DeliveryCapacity { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public long? TotalCapacity { get; set; }

                [NameInMap("UsedCapacity")]
                [Validation(Required=false)]
                public long? UsedCapacity { get; set; }

            }

            [NameInMap("DedicatedBlockStorageClusterId")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterId { get; set; }

            [NameInMap("DedicatedBlockStorageClusterName")]
            [Validation(Required=false)]
            public string DedicatedBlockStorageClusterName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupportedCategory")]
            [Validation(Required=false)]
            public string SupportedCategory { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags> Tags { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
