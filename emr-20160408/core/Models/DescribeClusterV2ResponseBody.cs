// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterV2ResponseBody : TeaModel {
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterV2ResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterV2ResponseBodyClusterInfo : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("LogEnable")]
            [Validation(Required=false)]
            public bool? LogEnable { get; set; }
            [NameInMap("TaskNodeInService")]
            [Validation(Required=false)]
            public int? TaskNodeInService { get; set; }
            [NameInMap("AutoScalingSpotWithLimitAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingSpotWithLimitAllowed { get; set; }
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public long? StopTime { get; set; }
            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }
            [NameInMap("DepositType")]
            [Validation(Required=false)]
            public string DepositType { get; set; }
            [NameInMap("RelateClusterInfo")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoRelateClusterInfo RelateClusterInfo { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoRelateClusterInfo : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

            }
            [NameInMap("RelateClusterId")]
            [Validation(Required=false)]
            public string RelateClusterId { get; set; }
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }
            [NameInMap("ResizeDiskEnable")]
            [Validation(Required=false)]
            public bool? ResizeDiskEnable { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoFailReason FailReason { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoFailReason : TeaModel {
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }
            [NameInMap("UserDefinedEmrEcsRole")]
            [Validation(Required=false)]
            public string UserDefinedEmrEcsRole { get; set; }
            [NameInMap("MetaStoreType")]
            [Validation(Required=false)]
            public string MetaStoreType { get; set; }
            [NameInMap("SoftwareInfo")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoSoftwareInfo SoftwareInfo { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoSoftwareInfo : TeaModel {
                [NameInMap("EmrVer")]
                [Validation(Required=false)]
                public string EmrVer { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("Softwares")]
                [Validation(Required=false)]
                public DescribeClusterV2ResponseBodyClusterInfoSoftwareInfoSoftwares Softwares { get; set; }
                public class DescribeClusterV2ResponseBodyClusterInfoSoftwareInfoSoftwares : TeaModel {
                    [NameInMap("Software")]
                    [Validation(Required=false)]
                    public List<DescribeClusterV2ResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware> Software { get; set; }
                    public class DescribeClusterV2ResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware : TeaModel {
                        public string DisplayName { get; set; }
                        public int? StartTpe { get; set; }
                        public string Version { get; set; }
                        public bool? OnlyDisplay { get; set; }
                        public string Name { get; set; }
                    }
                };

            }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Configurations")]
            [Validation(Required=false)]
            public string Configurations { get; set; }
            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("AutoScalingVersion")]
            [Validation(Required=false)]
            public string AutoScalingVersion { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
            [NameInMap("AccessInfo")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoAccessInfo AccessInfo { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoAccessInfo : TeaModel {
                [NameInMap("ZKLinks")]
                [Validation(Required=false)]
                public DescribeClusterV2ResponseBodyClusterInfoAccessInfoZKLinks ZKLinks { get; set; }
                public class DescribeClusterV2ResponseBodyClusterInfoAccessInfoZKLinks : TeaModel {
                    [NameInMap("ZKLink")]
                    [Validation(Required=false)]
                    public List<DescribeClusterV2ResponseBodyClusterInfoAccessInfoZKLinksZKLink> ZKLink { get; set; }
                    public class DescribeClusterV2ResponseBodyClusterInfoAccessInfoZKLinksZKLink : TeaModel {
                        public string Link { get; set; }
                        public string Port { get; set; }
                    }
                };

            }
            [NameInMap("CreateResource")]
            [Validation(Required=false)]
            public string CreateResource { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public int? RunningTime { get; set; }
            [NameInMap("HighAvailabilityEnable")]
            [Validation(Required=false)]
            public bool? HighAvailabilityEnable { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("AutoScalingAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingAllowed { get; set; }
            [NameInMap("HostGroupList")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoHostGroupList HostGroupList { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoHostGroupList : TeaModel {
                [NameInMap("HostGroup")]
                [Validation(Required=false)]
                public List<DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroup> HostGroup { get; set; }
                public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroup : TeaModel {
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodes Nodes { get; set; }
                    public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodes : TeaModel {
                        [NameInMap("Node")]
                        [Validation(Required=false)]
                        public List<DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNode> Node { get; set; }
                        public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNode : TeaModel {
                            public string Status { get; set; }
                            public bool? SupportIpV6 { get; set; }
                            public string InnerIp { get; set; }
                            public string ExpiredTime { get; set; }
                            public string CreateTime { get; set; }
                            public string ZoneId { get; set; }
                            public string InstanceId { get; set; }
                            public DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDiskInfos DiskInfos { get; set; }
                            public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDiskInfos : TeaModel {
                                [NameInMap("DiskInfo")]
                                [Validation(Required=false)]
                                public List<DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDiskInfosDiskInfo> DiskInfo { get; set; }
                                public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDiskInfosDiskInfo : TeaModel {
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                    [NameInMap("Size")]
                                    [Validation(Required=false)]
                                    public int? Size { get; set; }

                                    [NameInMap("Device")]
                                    [Validation(Required=false)]
                                    public string Device { get; set; }

                                    [NameInMap("DiskName")]
                                    [Validation(Required=false)]
                                    public string DiskName { get; set; }

                                    [NameInMap("DiskId")]
                                    [Validation(Required=false)]
                                    public string DiskId { get; set; }

                                }

                            }
                            public string EmrExpiredTime { get; set; }
                            public string PubIp { get; set; }
                            public DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDaemonInfos DaemonInfos { get; set; }
                            public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDaemonInfos : TeaModel {
                                [NameInMap("DaemonInfo")]
                                [Validation(Required=false)]
                                public List<DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDaemonInfosDaemonInfo> DaemonInfo { get; set; }
                                public class DescribeClusterV2ResponseBodyClusterInfoHostGroupListHostGroupNodesNodeDaemonInfosDaemonInfo : TeaModel {
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                }

                            }
                        }
                    };

                    [NameInMap("LockType")]
                    [Validation(Required=false)]
                    public string LockType { get; set; }

                    [NameInMap("HostGroupType")]
                    [Validation(Required=false)]
                    public string HostGroupType { get; set; }

                    [NameInMap("HostGroupSubType")]
                    [Validation(Required=false)]
                    public string HostGroupSubType { get; set; }

                    [NameInMap("HostGroupChangeStatus")]
                    [Validation(Required=false)]
                    public string HostGroupChangeStatus { get; set; }

                    [NameInMap("ChargeType")]
                    [Validation(Required=false)]
                    public string ChargeType { get; set; }

                    [NameInMap("DiskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public string LockReason { get; set; }

                    [NameInMap("HostGroupId")]
                    [Validation(Required=false)]
                    public string HostGroupId { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("BandWidth")]
                    [Validation(Required=false)]
                    public string BandWidth { get; set; }

                    [NameInMap("DiskCount")]
                    [Validation(Required=false)]
                    public int? DiskCount { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public string Period { get; set; }

                    [NameInMap("DiskCapacity")]
                    [Validation(Required=false)]
                    public int? DiskCapacity { get; set; }

                    [NameInMap("CpuCore")]
                    [Validation(Required=false)]
                    public int? CpuCore { get; set; }

                    [NameInMap("MemoryCapacity")]
                    [Validation(Required=false)]
                    public int? MemoryCapacity { get; set; }

                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    [NameInMap("HostGroupChangeType")]
                    [Validation(Required=false)]
                    public string HostGroupChangeType { get; set; }

                    [NameInMap("HostGroupName")]
                    [Validation(Required=false)]
                    public string HostGroupName { get; set; }

                }

            }
            [NameInMap("MasterNodeInService")]
            [Validation(Required=false)]
            public int? MasterNodeInService { get; set; }
            [NameInMap("AutoScalingEnable")]
            [Validation(Required=false)]
            public bool? AutoScalingEnable { get; set; }
            [NameInMap("AutoScalingWithGraceAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingWithGraceAllowed { get; set; }
            [NameInMap("ShowSoftwareInterface")]
            [Validation(Required=false)]
            public bool? ShowSoftwareInterface { get; set; }
            [NameInMap("CoreNodeInService")]
            [Validation(Required=false)]
            public int? CoreNodeInService { get; set; }
            [NameInMap("AutoScalingByLoadAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingByLoadAllowed { get; set; }
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }
            [NameInMap("LocalMetaDb")]
            [Validation(Required=false)]
            public bool? LocalMetaDb { get; set; }
            [NameInMap("BootstrapActionList")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoBootstrapActionList BootstrapActionList { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoBootstrapActionList : TeaModel {
                [NameInMap("BootstrapAction")]
                [Validation(Required=false)]
                public List<DescribeClusterV2ResponseBodyClusterInfoBootstrapActionListBootstrapAction> BootstrapAction { get; set; }
                public class DescribeClusterV2ResponseBodyClusterInfoBootstrapActionListBootstrapAction : TeaModel {
                    [NameInMap("Arg")]
                    [Validation(Required=false)]
                    public string Arg { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }
            [NameInMap("GatewayClusterInfoList")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoGatewayClusterInfoList GatewayClusterInfoList { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoGatewayClusterInfoList : TeaModel {
                [NameInMap("GatewayClusterInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterV2ResponseBodyClusterInfoGatewayClusterInfoListGatewayClusterInfo> GatewayClusterInfo { get; set; }
                public class DescribeClusterV2ResponseBodyClusterInfoGatewayClusterInfoListGatewayClusterInfo : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                }

            }
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("EasEnable")]
            [Validation(Required=false)]
            public bool? EasEnable { get; set; }
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }
            [NameInMap("HostPoolInfo")]
            [Validation(Required=false)]
            public DescribeClusterV2ResponseBodyClusterInfoHostPoolInfo HostPoolInfo { get; set; }
            public class DescribeClusterV2ResponseBodyClusterInfoHostPoolInfo : TeaModel {
                [NameInMap("HpBizId")]
                [Validation(Required=false)]
                public string HpBizId { get; set; }

                [NameInMap("HpName")]
                [Validation(Required=false)]
                public string HpName { get; set; }

            }
            [NameInMap("MasterNodeTotal")]
            [Validation(Required=false)]
            public int? MasterNodeTotal { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public bool? IoOptimized { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }
            [NameInMap("CoreNodeTotal")]
            [Validation(Required=false)]
            public int? CoreNodeTotal { get; set; }
            [NameInMap("GatewayClusterIds")]
            [Validation(Required=false)]
            public string GatewayClusterIds { get; set; }
            [NameInMap("BootstrapFailed")]
            [Validation(Required=false)]
            public bool? BootstrapFailed { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("TaskNodeTotal")]
            [Validation(Required=false)]
            public int? TaskNodeTotal { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
