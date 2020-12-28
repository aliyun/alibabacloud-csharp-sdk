// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersResponseBody : TeaModel {
        [NameInMap("DedicatedHostClusters")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters> DedicatedHostClusters { get; set; }
        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersTags> Tags { get; set; }
            public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("DedicatedHostClusterCapacity")]
            [Validation(Required=false)]
            public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
            public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterCapacity : TeaModel {
                [NameInMap("LocalStorageCapacities")]
                [Validation(Required=false)]
                public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterCapacityLocalStorageCapacities> LocalStorageCapacities { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterCapacityLocalStorageCapacities : TeaModel {
                    public string DataDiskCategory { get; set; }
                    public int? AvailableDisk { get; set; }
                    public int? TotalDisk { get; set; }
                }
                [NameInMap("AvailableMemory")]
                [Validation(Required=false)]
                public int? AvailableMemory { get; set; }
                [NameInMap("TotalMemory")]
                [Validation(Required=false)]
                public int? TotalMemory { get; set; }
                [NameInMap("TotalVcpus")]
                [Validation(Required=false)]
                public int? TotalVcpus { get; set; }
                [NameInMap("AvailableVcpus")]
                [Validation(Required=false)]
                public int? AvailableVcpus { get; set; }
            };

            [NameInMap("DedicatedHostIds")]
            [Validation(Required=false)]
            public List<string> DedicatedHostIds { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("DedicatedHostClusterName")]
            [Validation(Required=false)]
            public string DedicatedHostClusterName { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
