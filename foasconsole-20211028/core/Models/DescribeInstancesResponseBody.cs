// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            [NameInMap("AskClusterId")]
            [Validation(Required=false)]
            public string AskClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRE</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterState ClusterState { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterState : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterStage")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateClusterStage ClusterStage { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateClusterStage : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("CurrentStage")]
                    [Validation(Required=false)]
                    public int? CurrentStage { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TotalStageWithWeight")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight> TotalStageWithWeight { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateClusterStageTotalStageWithWeight : TeaModel {
                        [NameInMap("StepIndex")]
                        [Validation(Required=false)]
                        public int? StepIndex { get; set; }

                        [NameInMap("StepName")]
                        [Validation(Required=false)]
                        public string StepName { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("CreateTimeout")]
                [Validation(Required=false)]
                public bool? CreateTimeout { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("UserSlbDto")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto UserSlbDto { get; set; }
                public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDto : TeaModel {
                    [NameInMap("ExistSlb")]
                    [Validation(Required=false)]
                    public bool? ExistSlb { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    [NameInMap("SlbStatus")]
                    [Validation(Required=false)]
                    public string SlbStatus { get; set; }

                    [NameInMap("UserSlbListeners")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners> UserSlbListeners { get; set; }
                    public class DescribeInstancesResponseBodyInstancesClusterStateUserSlbDtoUserSlbListeners : TeaModel {
                        [NameInMap("ListenersStatus")]
                        [Validation(Required=false)]
                        public string ListenersStatus { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                    }

                }

                [NameInMap("VpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            [NameInMap("ClusterUsedResources")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesClusterUsedResources> ClusterUsedResources { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterUsedResources : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Ha")]
                [Validation(Required=false)]
                public bool? Ha { get; set; }

                [NameInMap("HaUsedCpu")]
                [Validation(Required=false)]
                public float? HaUsedCpu { get; set; }

                [NameInMap("HaUsedMemory")]
                [Validation(Required=false)]
                public float? HaUsedMemory { get; set; }

                [NameInMap("HaUsedResource")]
                [Validation(Required=false)]
                public float? HaUsedResource { get; set; }

                [NameInMap("UsedCpu")]
                [Validation(Required=false)]
                public float? UsedCpu { get; set; }

                [NameInMap("UsedMemory")]
                [Validation(Required=false)]
                public float? UsedMemory { get; set; }

                [NameInMap("UsedResource")]
                [Validation(Required=false)]
                public float? UsedResource { get; set; }

            }

            [NameInMap("ClusterUsedStorage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesClusterUsedStorage ClusterUsedStorage { get; set; }
            public class DescribeInstancesResponseBodyInstancesClusterUsedStorage : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("UsedStorage")]
                [Validation(Required=false)]
                public float? UsedStorage { get; set; }

            }

            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            [NameInMap("HaResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesHaResourceSpec HaResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("HaVSwitchIds")]
            [Validation(Required=false)]
            public List<string> HaVSwitchIds { get; set; }

            [NameInMap("HaVSwitchInfo")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesHaVSwitchInfo> HaVSwitchInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaVSwitchInfo : TeaModel {
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public long? AvailableIpAddressCount { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("VSwitchCidr")]
                [Validation(Required=false)]
                public string VSwitchCidr { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            [NameInMap("HaZoneId")]
            [Validation(Required=false)]
            public string HaZoneId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesHostAliases> HostAliases { get; set; }
            public class DescribeInstancesResponseBodyInstancesHostAliases : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("HostNames")]
                [Validation(Required=false)]
                public List<string> HostNames { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f-cn-zvp2q0zik06</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vvp1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("OrderState")]
            [Validation(Required=false)]
            public string OrderState { get; set; }

            [NameInMap("OssInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesOssInfo OssInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesOssInfo : TeaModel {
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("BucketVersioningStatus")]
                [Validation(Required=false)]
                public string BucketVersioningStatus { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("ResourceCreateTime")]
            [Validation(Required=false)]
            public long? ResourceCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1637337600000</para>
            /// </summary>
            [NameInMap("ResourceExpiredTime")]
            [Validation(Required=false)]
            public long? ResourceExpiredTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b3690a1655da47</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesResourceSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesStorage Storage { get; set; }
            public class DescribeInstancesResponseBodyInstancesStorage : TeaModel {
                [NameInMap("FullyManaged")]
                [Validation(Required=false)]
                public bool? FullyManaged { get; set; }

                [NameInMap("OrderState")]
                [Validation(Required=false)]
                public string OrderState { get; set; }

                [NameInMap("Oss")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesStorageOss Oss { get; set; }
                public class DescribeInstancesResponseBodyInstancesStorageOss : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>oss_flink</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>flink</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1838996687368452</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("VSwitchInfo")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesVSwitchInfo> VSwitchInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesVSwitchInfo : TeaModel {
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public string AvailableIpAddressCount { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("VSwitchCidr")]
                [Validation(Required=false)]
                public string VSwitchCidr { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2ze9*******nxfmfcdi</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesVpcInfo VpcInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesVpcInfo : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C8DF2A5B-6FBA-5651-A3D4-960F36640E6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
