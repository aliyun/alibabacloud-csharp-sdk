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
        public DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters DedicatedHostClusters { get; set; }
        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters : TeaModel {
            [NameInMap("DedicatedHostCluster")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostCluster> DedicatedHostCluster { get; set; }
            public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostCluster : TeaModel {
                public string Description { get; set; }
                public string DedicatedHostClusterId { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags Tags { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity : TeaModel {
                    [NameInMap("LocalStorageCapacities")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities LocalStorageCapacities { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities : TeaModel {
                        [NameInMap("LocalStorageCapacity")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity> LocalStorageCapacity { get; set; }
                        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity : TeaModel {
                            public string DataDiskCategory { get; set; }
                            public int? AvailableDisk { get; set; }
                            public int? TotalDisk { get; set; }
                        }
                    };

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

                }
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds DedicatedHostIds { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds : TeaModel {
                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostId { get; set; }

                }
                public string RegionId { get; set; }
                public string DedicatedHostClusterName { get; set; }
            }
        };

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
