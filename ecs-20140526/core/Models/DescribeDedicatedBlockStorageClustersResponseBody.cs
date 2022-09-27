// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedBlockStorageClustersResponseBody : TeaModel {
        [NameInMap("DedicatedBlockStorageClusters")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters DedicatedBlockStorageClusters { get; set; }
        public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClusters : TeaModel {
            [NameInMap("DedicatedBlockStorageCluster")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageCluster> DedicatedBlockStorageCluster { get; set; }
            public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageCluster : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DedicatedBlockStorageClusterCapacity")]
                [Validation(Required=false)]
                public DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterDedicatedBlockStorageClusterCapacity DedicatedBlockStorageClusterCapacity { get; set; }
                public class DescribeDedicatedBlockStorageClustersResponseBodyDedicatedBlockStorageClustersDedicatedBlockStorageClusterDedicatedBlockStorageClusterCapacity : TeaModel {
                    [NameInMap("AvailableCapacity")]
                    [Validation(Required=false)]
                    public long? AvailableCapacity { get; set; }

                    [NameInMap("TotalCapacity")]
                    [Validation(Required=false)]
                    public long? TotalCapacity { get; set; }

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

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
