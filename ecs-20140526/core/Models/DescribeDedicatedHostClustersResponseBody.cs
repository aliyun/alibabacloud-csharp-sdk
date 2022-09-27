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
                [NameInMap("DedicatedHostClusterCapacity")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity : TeaModel {
                    [NameInMap("AvailableInstanceTypes")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypes : TeaModel {
                        [NameInMap("AvailableInstanceType")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypesAvailableInstanceType> AvailableInstanceType { get; set; }
                        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypesAvailableInstanceType : TeaModel {
                            [NameInMap("AvailableInstanceCapacity")]
                            [Validation(Required=false)]
                            public int? AvailableInstanceCapacity { get; set; }

                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                        }

                    }

                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public int? AvailableMemory { get; set; }

                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    [NameInMap("LocalStorageCapacities")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities LocalStorageCapacities { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities : TeaModel {
                        [NameInMap("LocalStorageCapacity")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity> LocalStorageCapacity { get; set; }
                        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity : TeaModel {
                            [NameInMap("AvailableDisk")]
                            [Validation(Required=false)]
                            public int? AvailableDisk { get; set; }

                            [NameInMap("DataDiskCategory")]
                            [Validation(Required=false)]
                            public string DataDiskCategory { get; set; }

                            [NameInMap("TotalDisk")]
                            [Validation(Required=false)]
                            public int? TotalDisk { get; set; }

                        }

                    }

                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public int? TotalMemory { get; set; }

                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                }

                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                [NameInMap("DedicatedHostClusterName")]
                [Validation(Required=false)]
                public string DedicatedHostClusterName { get; set; }

                [NameInMap("DedicatedHostIds")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds DedicatedHostIds { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds : TeaModel {
                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostId { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags Tags { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

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
        public int? TotalCount { get; set; }

    }

}
