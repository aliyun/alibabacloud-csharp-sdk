// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListEmrAvailableConfigResponseBody : TeaModel {
        [NameInMap("EmrMainVersionList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodyEmrMainVersionList EmrMainVersionList { get; set; }
        public class ListEmrAvailableConfigResponseBodyEmrMainVersionList : TeaModel {
            [NameInMap("EmrMainVersion")]
            [Validation(Required=false)]
            public List<ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersion> EmrMainVersion { get; set; }
            public class ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersion : TeaModel {
                [NameInMap("ClusterTypeInfoList")]
                [Validation(Required=false)]
                public ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoList ClusterTypeInfoList { get; set; }
                public class ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoList : TeaModel {
                    [NameInMap("ClusterTypeInfo")]
                    [Validation(Required=false)]
                    public List<ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfo> ClusterTypeInfo { get; set; }
                    public class ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfo : TeaModel {
                        [NameInMap("ClusterServiceInfoList")]
                        [Validation(Required=false)]
                        public ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoClusterServiceInfoList ClusterServiceInfoList { get; set; }
                        public class ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoClusterServiceInfoList : TeaModel {
                            [NameInMap("ClusterServiceInfo")]
                            [Validation(Required=false)]
                            public List<ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoClusterServiceInfoListClusterServiceInfo> ClusterServiceInfo { get; set; }
                            public class ListEmrAvailableConfigResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoClusterServiceInfoListClusterServiceInfo : TeaModel {
                                [NameInMap("Mandatory")]
                                [Validation(Required=false)]
                                public bool? Mandatory { get; set; }

                                [NameInMap("ServiceDisplayName")]
                                [Validation(Required=false)]
                                public string ServiceDisplayName { get; set; }

                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                [NameInMap("ServiceVersion")]
                                [Validation(Required=false)]
                                public string ServiceVersion { get; set; }

                            }

                        }

                        [NameInMap("ClusterType")]
                        [Validation(Required=false)]
                        public string ClusterType { get; set; }

                    }

                }

                [NameInMap("EcmVersion")]
                [Validation(Required=false)]
                public bool? EcmVersion { get; set; }

                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public string ExtraInfo { get; set; }

                [NameInMap("MainVersionName")]
                [Validation(Required=false)]
                public string MainVersionName { get; set; }

                [NameInMap("OnCloudNative")]
                [Validation(Required=false)]
                public bool? OnCloudNative { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StackName")]
                [Validation(Required=false)]
                public string StackName { get; set; }

                [NameInMap("StackVersion")]
                [Validation(Required=false)]
                public string StackVersion { get; set; }

            }

        }

        [NameInMap("KeyPairNameList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodyKeyPairNameList KeyPairNameList { get; set; }
        public class ListEmrAvailableConfigResponseBodyKeyPairNameList : TeaModel {
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public List<string> KeyPairName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroupList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodySecurityGroupList SecurityGroupList { get; set; }
        public class ListEmrAvailableConfigResponseBodySecurityGroupList : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public List<ListEmrAvailableConfigResponseBodySecurityGroupListSecurityGroup> SecurityGroup { get; set; }
            public class ListEmrAvailableConfigResponseBodySecurityGroupListSecurityGroup : TeaModel {
                [NameInMap("AvailableInstanceAmount")]
                [Validation(Required=false)]
                public int? AvailableInstanceAmount { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public int? EcsCount { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

                [NameInMap("SecurityGroupType")]
                [Validation(Required=false)]
                public string SecurityGroupType { get; set; }

                /// <summary>
                /// VPC ID。
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("VpcInfoList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodyVpcInfoList VpcInfoList { get; set; }
        public class ListEmrAvailableConfigResponseBodyVpcInfoList : TeaModel {
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public List<ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfo> VpcInfo { get; set; }
            public class ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfo : TeaModel {
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// VPC ID。
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                [NameInMap("VswitchInfoList")]
                [Validation(Required=false)]
                public ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfoVswitchInfoList VswitchInfoList { get; set; }
                public class ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfoVswitchInfoList : TeaModel {
                    [NameInMap("VswitchInfo")]
                    [Validation(Required=false)]
                    public List<ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfoVswitchInfoListVswitchInfo> VswitchInfo { get; set; }
                    public class ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfoVswitchInfoListVswitchInfo : TeaModel {
                        [NameInMap("AvailableIpAddressCount")]
                        [Validation(Required=false)]
                        public long? AvailableIpAddressCount { get; set; }

                        [NameInMap("CidrBlock")]
                        [Validation(Required=false)]
                        public string CidrBlock { get; set; }

                        [NameInMap("CreationTime")]
                        [Validation(Required=false)]
                        public string CreationTime { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// VPC ID。
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VswitchId")]
                        [Validation(Required=false)]
                        public string VswitchId { get; set; }

                        [NameInMap("VswitchName")]
                        [Validation(Required=false)]
                        public string VswitchName { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

    }

}
