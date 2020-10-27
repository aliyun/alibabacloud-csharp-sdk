// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("DedicatedHostClusters")]
        [Validation(Required=true)]
        public DescribeDedicatedHostClustersResponseDedicatedHostClusters DedicatedHostClusters { get; set; }
        public class DescribeDedicatedHostClustersResponseDedicatedHostClusters : TeaModel {
            [NameInMap("DedicatedHostCluster")]
            [Validation(Required=true)]
            public List<DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostCluster> DedicatedHostCluster { get; set; }
            public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostCluster : TeaModel {
                public string DedicatedHostClusterId { get; set; }
                public string RegionId { get; set; }
                public string ZoneId { get; set; }
                public string DedicatedHostClusterName { get; set; }
                public string Description { get; set; }
                public string ResourceGroupId { get; set; }
                public DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterTags Tags { get; set; }
                public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=true)]
                    public List<DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=true)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=true)]
                        public string TagValue { get; set; }

                    }

                }
                public DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
                public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity : TeaModel {
                    [NameInMap("TotalVcpus")]
                    [Validation(Required=true)]
                    public int? TotalVcpus { get; set; }

                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=true)]
                    public int? AvailableVcpus { get; set; }

                    [NameInMap("TotalMemory")]
                    [Validation(Required=true)]
                    public int? TotalMemory { get; set; }

                    [NameInMap("AvailableMemory")]
                    [Validation(Required=true)]
                    public int? AvailableMemory { get; set; }

                    [NameInMap("LocalStorageCapacities")]
                    [Validation(Required=true)]
                    public DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities LocalStorageCapacities { get; set; }
                    public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities : TeaModel {
                        [NameInMap("LocalStorageCapacity")]
                        [Validation(Required=true)]
                        public List<DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity> LocalStorageCapacity { get; set; }
                        public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity : TeaModel {
                            public int? TotalDisk { get; set; }
                            public int? AvailableDisk { get; set; }
                            public string DataDiskCategory { get; set; }
                        }
                    };

                }
                public DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostIds DedicatedHostIds { get; set; }
                public class DescribeDedicatedHostClustersResponseDedicatedHostClustersDedicatedHostClusterDedicatedHostIds : TeaModel {
                    /// <summary>
                    /// DedicatedHostId
                    /// </summary>
                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=true)]
                    public List<string> DedicatedHostId { get; set; }

                }
            }
        };

    }

}
