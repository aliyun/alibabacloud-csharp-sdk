// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of host group information.</para>
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
                /// <para>The capacity of the host group.</para>
                /// </summary>
                [NameInMap("DedicatedHostClusterCapacity")]
                [Validation(Required=false)]
                public DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity DedicatedHostClusterCapacity { get; set; }
                public class DescribeDedicatedHostClustersResponseBodyDedicatedHostClustersDedicatedHostClusterDedicatedHostClusterCapacity : TeaModel {
                    /// <summary>
                    /// <para>The available capacity of ECS instances in the host group.</para>
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
                            /// <para>The available capacity of the ECS instance type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("AvailableInstanceCapacity")]
                            [Validation(Required=false)]
                            public int? AvailableInstanceCapacity { get; set; }

                            /// <summary>
                            /// <para>The ECS instance type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ecs.c6.26xlarge</para>
                            /// </summary>
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The size of available memory. Unit: GiB</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public int? AvailableMemory { get; set; }

                    /// <summary>
                    /// <para>The number of available vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    /// <summary>
                    /// <para>The local storage capacity.</para>
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
                            /// <para>The available capacity of the local disk. Unit: GiB</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>20</para>
                            /// </summary>
                            [NameInMap("AvailableDisk")]
                            [Validation(Required=false)]
                            public int? AvailableDisk { get; set; }

                            /// <summary>
                            /// <para>The category of data disks. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>cloud: basic disk</description></item>
                            /// <item><description>cloud_efficiency: ultra disk</description></item>
                            /// <item><description>cloud_ssd: standard SSD</description></item>
                            /// <item><description>ephemeral_ssd: local SSD</description></item>
                            /// <item><description>cloud_essd: Enterprise SSD (ESSD)</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>cloud</para>
                            /// </summary>
                            [NameInMap("DataDiskCategory")]
                            [Validation(Required=false)]
                            public string DataDiskCategory { get; set; }

                            /// <summary>
                            /// <para>The total capacity of the local disk. Unit: GiB</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>40</para>
                            /// </summary>
                            [NameInMap("TotalDisk")]
                            [Validation(Required=false)]
                            public int? TotalDisk { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The total memory size. Unit: GiB</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public int? TotalMemory { get; set; }

                    /// <summary>
                    /// <para>The total number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                }

                /// <summary>
                /// <para>The ID of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dc-bp12wlf6am0vz9v2****</para>
                /// </summary>
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                /// <summary>
                /// <para>The name of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myDDHCluster</para>
                /// </summary>
                [NameInMap("DedicatedHostClusterName")]
                [Validation(Required=false)]
                public string DedicatedHostClusterName { get; set; }

                /// <summary>
                /// <para>The IDs of dedicated hosts in the host group.</para>
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
                /// <para>The description of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This-is-my-DDHCluster</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The region ID of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The resource group ID of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags of the host group.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The zone ID of the host group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-f</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>214A2187-B06F-4E49-A081-4D053466A8C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of dedicated host clusters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
