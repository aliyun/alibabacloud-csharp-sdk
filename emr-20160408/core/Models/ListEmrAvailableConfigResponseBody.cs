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
                                public bool? Mandatory { get; set; }
                                public string ServiceDisplayName { get; set; }
                                public string ServiceName { get; set; }
                                public string ServiceVersion { get; set; }
                            }
                        };

                        [NameInMap("ClusterType")]
                        [Validation(Required=false)]
                        public string ClusterType { get; set; }

                    }

                }
                public bool? EcmVersion { get; set; }
                public string ExtraInfo { get; set; }
                public string MainVersionName { get; set; }
                public bool? OnCloudNative { get; set; }
                public string PublishType { get; set; }
                public string RegionId { get; set; }
                public string StackName { get; set; }
                public string StackVersion { get; set; }
            }
        };

        [NameInMap("KeyPairNameList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodyKeyPairNameList KeyPairNameList { get; set; }
        public class ListEmrAvailableConfigResponseBodyKeyPairNameList : TeaModel {
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public List<string> KeyPairName { get; set; }
        };

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
                public int? AvailableInstanceAmount { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public int? EcsCount { get; set; }
                public string SecurityGroupId { get; set; }
                public string SecurityGroupName { get; set; }
                public string SecurityGroupType { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("VpcInfoList")]
        [Validation(Required=false)]
        public ListEmrAvailableConfigResponseBodyVpcInfoList VpcInfoList { get; set; }
        public class ListEmrAvailableConfigResponseBodyVpcInfoList : TeaModel {
            [NameInMap("VpcInfo")]
            [Validation(Required=false)]
            public List<ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfo> VpcInfo { get; set; }
            public class ListEmrAvailableConfigResponseBodyVpcInfoListVpcInfo : TeaModel {
                public string CidrBlock { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string VRouterId { get; set; }
                public string VpcId { get; set; }
                public string VpcName { get; set; }
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
        };

    }

}
