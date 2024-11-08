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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Lite</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///       &quot;EndpointPublicAccess&quot;: false,
                ///       &quot;ContainerCidr&quot;: &quot;10.4.0.0/24&quot;,
                ///       &quot;KeyPair&quot;: &quot;test&quot;,
                ///       &quot;NodeCidrMask&quot;: &quot;25&quot;,
                ///       &quot;ResourceGroupId&quot;: &quot;rg-axsadm3sdzsdvdsndstdisd&quot;,
                ///       &quot;WorkerSystemDiskCategory&quot;: &quot;da&quot;,
                ///       &quot;WorkerSystemDiskSize&quot;: 40,
                ///       &quot;DeletionProtection&quot;: false,
                ///       &quot;KubeProxy&quot;: &quot;iptables&quot;,
                ///       &quot;Name&quot;: &quot;da&quot;,
                ///       &quot;LoadBalancerSpec&quot;: &quot;slb.s1.small&quot;,
                ///       &quot;Runtime&quot;: {
                ///             &quot;Version&quot;: &quot;19.03.15&quot;,
                ///             &quot;Name&quot;: &quot;docker&quot;
                ///       },
                ///       &quot;IsEnterpriseSecurityGroup&quot;: true,
                ///       &quot;Vpcid&quot;: &quot;192.168.23.0/24&quot;,
                ///       &quot;NumOfNodes&quot;: 1,
                ///       &quot;VswitchIds&quot;: [
                ///             &quot;dad&quot;
                ///       ],
                ///       &quot;ServiceCidr&quot;: &quot;10.0.0.0/16&quot;,
                ///       &quot;SnatEntry&quot;: false,
                ///       &quot;kubernetesVersion&quot;: &quot;1.20.11-aliyunedge.1&quot;,
                ///       &quot;WorkerInstanceTypes&quot;: [
                ///             &quot;da&quot;
                ///       ]
                /// }</para>
                /// </summary>
                [NameInMap("BasicArgs")]
                [Validation(Required=false)]
                public object BasicArgs { get; set; }

                [NameInMap("NodeUnits")]
                [Validation(Required=false)]
                public List<object> NodeUnits { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACKEdge</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>cen-1gb1eftc5qp2ao75fo</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>172.16.0.0/24</para>
                /// </summary>
                [NameInMap("CloudLinkCidr")]
                [Validation(Required=false)]
                public string CloudLinkCidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vcc-cn-c4dtycm5i08</para>
                /// </summary>
                [NameInMap("CloudLinkId")]
                [Validation(Required=false)]
                public string CloudLinkId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-0jl2x45apm6odc2c10h25</para>
                /// </summary>
                [NameInMap("MonitorVpcId")]
                [Validation(Required=false)]
                public string MonitorVpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-0jl2w3ffbghkss0x2foff</para>
                /// </summary>
                [NameInMap("MonitorVswitchId")]
                [Validation(Required=false)]
                public string MonitorVswitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
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

            [NameInMap("TailIpVersion")]
            [Validation(Required=false)]
            public string TailIpVersion { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchZoneId")]
            [Validation(Required=false)]
            public string VSwitchZoneId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>复用VPD信息</para>
            /// </summary>
            [NameInMap("VpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksVpdInfo VpdInfo { get; set; }
            public class CreateClusterRequestNetworksVpdInfo : TeaModel {
                /// <summary>
                /// <para>专有网络 id</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-vfuz6ejv</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>集群子网id列表</para>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>i190297201634099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>efg1.nvga1</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>emr-default</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class CreateClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8d13b784-17a9-11ed-bc7b-acde48001122</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e01poc-cn-i7m2wnivf0d</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OpenEniJumboFrame")]
        [Validation(Required=false)]
        public bool? OpenEniJumboFrame { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2xdkc6icwfha</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>env-name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
