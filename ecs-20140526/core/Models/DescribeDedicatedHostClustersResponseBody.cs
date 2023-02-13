// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersResponseBody : TeaModel {
        /// <summary>
        /// Details about the dedicated host clusters.
        /// </summary>
        [NameInMap("DedicatedHostClusters")]
        [Validation(Required=false)]
        public DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters DedicatedHostClusters { get; set; }
        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClusters : TeaModel {
            [NameInMap("DedicatedHostCluster")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostCluster> DedicatedHostCluster { get; set; }
            public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostCluster : TeaModel {
                /// <summary>
                /// The capacity of the dedicated host cluster.
                /// </summary>
                [NameInMap("DedicatedHostClusterCapacity")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity : TeaModel {
                    /// <summary>
                    /// The available capacity of the Elastic Compute Service (ECS) instance types in the dedicated host cluster.
                    /// </summary>
                    [NameInMap("AvailableInstanceTypes")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypes : TeaModel {
                        [NameInMap("AvailableInstanceType")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypesAvailableInstanceType> AvailableInstanceType { get; set; }
                        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityAvailableInstanceTypesAvailableInstanceType : TeaModel {
                            /// <summary>
                            /// The available capacity of the ECS instance type.
                            /// </summary>
                            [NameInMap("AvailableInstanceCapacity")]
                            [Validation(Required=false)]
                            public int? AvailableInstanceCapacity { get; set; }

                            /// <summary>
                            /// The ECS instance type.
                            /// </summary>
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                        }

                    }

                    /// <summary>
                    /// The size of available memory. Unit: GiB.
                    /// </summary>
                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public int? AvailableMemory { get; set; }

                    /// <summary>
                    /// The number of available vCPUs.
                    /// </summary>
                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    /// <summary>
                    /// The local storage capacity.
                    /// </summary>
                    [NameInMap("LocalStorageCapacities")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities LocalStorageCapacities { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacities : TeaModel {
                        [NameInMap("LocalStorageCapacity")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity> LocalStorageCapacity { get; set; }
                        public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacityLocalStorageCapacitiesLocalStorageCapacity : TeaModel {
                            /// <summary>
                            /// The available capacity of the local disk. Unit: GiB.
                            /// </summary>
                            [NameInMap("AvailableDisk")]
                            [Validation(Required=false)]
                            public int? AvailableDisk { get; set; }

                            /// <summary>
                            /// The category of the data disk. Valid values:
                            /// 
                            /// - cloud: basic disk
                            /// - cloud_efficiency: ultra disk
                            /// - cloud_ssd: standard SSD
                            /// - ephemeral_ssd: local SSD
                            /// - cloud_essd: enhanced SSD (ESSD)
                            /// </summary>
                            [NameInMap("DataDiskCategory")]
                            [Validation(Required=false)]
                            public string DataDiskCategory { get; set; }

                            /// <summary>
                            /// The total capacity of the local disk. Unit: GiB.
                            /// </summary>
                            [NameInMap("TotalDisk")]
                            [Validation(Required=false)]
                            public int? TotalDisk { get; set; }

                        }

                    }

                    /// <summary>
                    /// The total memory size. Unit: GiB.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public int? TotalMemory { get; set; }

                    /// <summary>
                    /// The total number of vCPUs.
                    /// </summary>
                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                }

                /// <summary>
                /// The ID of the dedicated host cluster.
                /// </summary>
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                /// <summary>
                /// The name of the dedicated host cluster.
                /// </summary>
                [NameInMap("DedicatedHostClusterName")]
                [Validation(Required=false)]
                public string DedicatedHostClusterName { get; set; }

                /// <summary>
                /// The IDs of dedicated hosts in the dedicated host cluster.
                /// </summary>
                [NameInMap("DedicatedHostIds")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds DedicatedHostIds { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostIds : TeaModel {
                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostId { get; set; }

                }

                /// <summary>
                /// The description of the dedicated host cluster.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The region ID of the dedicated host cluster.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the dedicated host cluster belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tags of the dedicated host cluster.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags Tags { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the dedicated host cluster.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the dedicated host cluster.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The zone ID of the dedicated host cluster.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of dedicated host clusters.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
