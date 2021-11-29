// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterBasicInfoResponseBody : TeaModel {
        [NameInMap("ClusterInfo")]
        [Validation(Required=false)]
        public DescribeClusterBasicInfoResponseBodyClusterInfo ClusterInfo { get; set; }
        public class DescribeClusterBasicInfoResponseBodyClusterInfo : TeaModel {
            [NameInMap("AccessInfo")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfo AccessInfo { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfo : TeaModel {
                [NameInMap("ZKLinks")]
                [Validation(Required=false)]
                public DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfoZKLinks ZKLinks { get; set; }
                public class DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfoZKLinks : TeaModel {
                    [NameInMap("ZKLink")]
                    [Validation(Required=false)]
                    public List<DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfoZKLinksZKLink> ZKLink { get; set; }
                    public class DescribeClusterBasicInfoResponseBodyClusterInfoAccessInfoZKLinksZKLink : TeaModel {
                        public string Link { get; set; }
                        public string Port { get; set; }
                    }
                };

            }
            [NameInMap("AutoScalingAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingAllowed { get; set; }
            [NameInMap("AutoScalingByLoadAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingByLoadAllowed { get; set; }
            [NameInMap("AutoScalingEnable")]
            [Validation(Required=false)]
            public bool? AutoScalingEnable { get; set; }
            [NameInMap("AutoScalingSpotWithLimitAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingSpotWithLimitAllowed { get; set; }
            [NameInMap("AutoScalingVersion")]
            [Validation(Required=false)]
            public string AutoScalingVersion { get; set; }
            [NameInMap("AutoScalingWithGraceAllowed")]
            [Validation(Required=false)]
            public bool? AutoScalingWithGraceAllowed { get; set; }
            [NameInMap("BootstrapActionList")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoBootstrapActionList BootstrapActionList { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoBootstrapActionList : TeaModel {
                [NameInMap("BootstrapAction")]
                [Validation(Required=false)]
                public List<DescribeClusterBasicInfoResponseBodyClusterInfoBootstrapActionListBootstrapAction> BootstrapAction { get; set; }
                public class DescribeClusterBasicInfoResponseBodyClusterInfoBootstrapActionListBootstrapAction : TeaModel {
                    [NameInMap("Arg")]
                    [Validation(Required=false)]
                    public string Arg { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

            }
            [NameInMap("BootstrapFailed")]
            [Validation(Required=false)]
            public bool? BootstrapFailed { get; set; }
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("Configurations")]
            [Validation(Required=false)]
            public string Configurations { get; set; }
            [NameInMap("CoreNodeInService")]
            [Validation(Required=false)]
            public int? CoreNodeInService { get; set; }
            [NameInMap("CoreNodeTotal")]
            [Validation(Required=false)]
            public int? CoreNodeTotal { get; set; }
            [NameInMap("CreateResource")]
            [Validation(Required=false)]
            public string CreateResource { get; set; }
            [NameInMap("CreateType")]
            [Validation(Required=false)]
            public string CreateType { get; set; }
            [NameInMap("DepositType")]
            [Validation(Required=false)]
            public string DepositType { get; set; }
            [NameInMap("EasEnable")]
            [Validation(Required=false)]
            public bool? EasEnable { get; set; }
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoFailReason FailReason { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoFailReason : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }
            [NameInMap("GatewayClusterIds")]
            [Validation(Required=false)]
            public string GatewayClusterIds { get; set; }
            [NameInMap("GatewayClusterInfoList")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoGatewayClusterInfoList GatewayClusterInfoList { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoGatewayClusterInfoList : TeaModel {
                [NameInMap("GatewayClusterInfo")]
                [Validation(Required=false)]
                public List<DescribeClusterBasicInfoResponseBodyClusterInfoGatewayClusterInfoListGatewayClusterInfo> GatewayClusterInfo { get; set; }
                public class DescribeClusterBasicInfoResponseBodyClusterInfoGatewayClusterInfoListGatewayClusterInfo : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }
            [NameInMap("HighAvailabilityEnable")]
            [Validation(Required=false)]
            public bool? HighAvailabilityEnable { get; set; }
            [NameInMap("HostPoolInfo")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoHostPoolInfo HostPoolInfo { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoHostPoolInfo : TeaModel {
                [NameInMap("HpBizId")]
                [Validation(Required=false)]
                public string HpBizId { get; set; }

                [NameInMap("HpName")]
                [Validation(Required=false)]
                public string HpName { get; set; }

            }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public bool? IoOptimized { get; set; }
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }
            [NameInMap("LocalMetaDb")]
            [Validation(Required=false)]
            public bool? LocalMetaDb { get; set; }
            [NameInMap("LogEnable")]
            [Validation(Required=false)]
            public bool? LogEnable { get; set; }
            [NameInMap("LogPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }
            [NameInMap("MasterNodeInService")]
            [Validation(Required=false)]
            public int? MasterNodeInService { get; set; }
            [NameInMap("MasterNodeTotal")]
            [Validation(Required=false)]
            public int? MasterNodeTotal { get; set; }
            [NameInMap("MetaStoreType")]
            [Validation(Required=false)]
            public string MetaStoreType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RelateClusterId")]
            [Validation(Required=false)]
            public string RelateClusterId { get; set; }
            [NameInMap("RelateClusterInfo")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoRelateClusterInfo RelateClusterInfo { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoRelateClusterInfo : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }
            [NameInMap("ResizeDiskEnable")]
            [Validation(Required=false)]
            public bool? ResizeDiskEnable { get; set; }
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public int? RunningTime { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }
            [NameInMap("ShowSoftwareInterface")]
            [Validation(Required=false)]
            public bool? ShowSoftwareInterface { get; set; }
            [NameInMap("SoftwareInfo")]
            [Validation(Required=false)]
            public DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfo SoftwareInfo { get; set; }
            public class DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfo : TeaModel {
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("EmrVer")]
                [Validation(Required=false)]
                public string EmrVer { get; set; }

                [NameInMap("Softwares")]
                [Validation(Required=false)]
                public DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfoSoftwares Softwares { get; set; }
                public class DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfoSoftwares : TeaModel {
                    [NameInMap("Software")]
                    [Validation(Required=false)]
                    public List<DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware> Software { get; set; }
                    public class DescribeClusterBasicInfoResponseBodyClusterInfoSoftwareInfoSoftwaresSoftware : TeaModel {
                        public string DisplayName { get; set; }
                        public string Name { get; set; }
                        public bool? OnlyDisplay { get; set; }
                        public int? StartTpe { get; set; }
                        public string Version { get; set; }
                    }
                };

            }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public long? StopTime { get; set; }
            [NameInMap("TaskNodeInService")]
            [Validation(Required=false)]
            public int? TaskNodeInService { get; set; }
            [NameInMap("TaskNodeTotal")]
            [Validation(Required=false)]
            public int? TaskNodeTotal { get; set; }
            [NameInMap("UserDefinedEmrEcsRole")]
            [Validation(Required=false)]
            public string UserDefinedEmrEcsRole { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
