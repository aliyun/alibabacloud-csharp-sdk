// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateClusterRequestComponents> Components { get; set; }
        public class CreateClusterRequestComponents : TeaModel {
            [NameInMap("ComponentConfig")]
            [Validation(Required=false)]
            public CreateClusterRequestComponentsComponentConfig ComponentConfig { get; set; }
            public class CreateClusterRequestComponentsComponentConfig : TeaModel {
                [NameInMap("BasicArgs")]
                [Validation(Required=false)]
                public object BasicArgs { get; set; }

                [NameInMap("NodeUnits")]
                [Validation(Required=false)]
                public List<object> NodeUnits { get; set; }

            }

            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("Networks")]
        [Validation(Required=false)]
        public CreateClusterRequestNetworks Networks { get; set; }
        public class CreateClusterRequestNetworks : TeaModel {
            [NameInMap("IpAllocationPolicy")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNetworksIpAllocationPolicy> IpAllocationPolicy { get; set; }
            public class CreateClusterRequestNetworksIpAllocationPolicy : TeaModel {
                [NameInMap("BondPolicy")]
                [Validation(Required=false)]
                public CreateClusterRequestNetworksIpAllocationPolicyBondPolicy BondPolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyBondPolicy : TeaModel {
                    [NameInMap("BondDefaultSubnet")]
                    [Validation(Required=false)]
                    public string BondDefaultSubnet { get; set; }

                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyBondPolicyBonds : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                }

                [NameInMap("MachineTypePolicy")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicy : TeaModel {
                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                    [NameInMap("MachineType")]
                    [Validation(Required=false)]
                    public string MachineType { get; set; }

                }

                [NameInMap("NodePolicy")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyNodePolicy : TeaModel {
                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyNodePolicyBonds : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                }

            }

            [NameInMap("NewVpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksNewVpdInfo NewVpdInfo { get; set; }
            public class CreateClusterRequestNetworksNewVpdInfo : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CloudLinkCidr")]
                [Validation(Required=false)]
                public string CloudLinkCidr { get; set; }

                [NameInMap("CloudLinkId")]
                [Validation(Required=false)]
                public string CloudLinkId { get; set; }

                [NameInMap("MonitorVpcId")]
                [Validation(Required=false)]
                public string MonitorVpcId { get; set; }

                [NameInMap("MonitorVswitchId")]
                [Validation(Required=false)]
                public string MonitorVswitchId { get; set; }

                [NameInMap("VpdCidr")]
                [Validation(Required=false)]
                public string VpdCidr { get; set; }

                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksNewVpdInfoVpdSubnets> VpdSubnets { get; set; }
                public class CreateClusterRequestNetworksNewVpdInfoVpdSubnets : TeaModel {
                    [NameInMap("SubnetCidr")]
                    [Validation(Required=false)]
                    public string SubnetCidr { get; set; }

                    [NameInMap("SubnetType")]
                    [Validation(Required=false)]
                    public string SubnetType { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("VSwitchZoneId")]
            [Validation(Required=false)]
            public string VSwitchZoneId { get; set; }

            /// <summary>
            /// 复用VPD信息
            /// </summary>
            [NameInMap("VpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksVpdInfo VpdInfo { get; set; }
            public class CreateClusterRequestNetworksVpdInfo : TeaModel {
                /// <summary>
                /// 专有网络 id
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// 集群子网id列表
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<string> VpdSubnets { get; set; }

            }

        }

        [NameInMap("NimizVSwitches")]
        [Validation(Required=false)]
        public List<string> NimizVSwitches { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<CreateClusterRequestNodeGroups> NodeGroups { get; set; }
        public class CreateClusterRequestNodeGroups : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class CreateClusterRequestNodeGroupsNodes : TeaModel {
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
