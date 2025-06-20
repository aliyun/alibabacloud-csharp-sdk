// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The cluster description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster description</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lite</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The components (software instance).</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateClusterRequestComponents> Components { get; set; }
        public class CreateClusterRequestComponents : TeaModel {
            /// <summary>
            /// <para>The component configurations.</para>
            /// </summary>
            [NameInMap("ComponentConfig")]
            [Validation(Required=false)]
            public CreateClusterRequestComponentsComponentConfig ComponentConfig { get; set; }
            public class CreateClusterRequestComponentsComponentConfig : TeaModel {
                /// <summary>
                /// <para>The basic parameters of the component.</para>
                /// 
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

                /// <summary>
                /// <para>The node pool configurations, which are used to establish the mappings between node groups and node pools. This parameter is required when ComponentType is set to ACKEdge. Otherwise, this parameter is left empty.</para>
                /// </summary>
                [NameInMap("NodeUnits")]
                [Validation(Required=false)]
                public List<object> NodeUnits { get; set; }

            }

            /// <summary>
            /// <para>The component type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ARMS</description></item>
            /// <item><description>ACKEdge</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACKEdge</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        /// <summary>
        /// <para>The cluster number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow skipping failed nodes. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The network information.</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public CreateClusterRequestNetworks Networks { get; set; }
        public class CreateClusterRequestNetworks : TeaModel {
            /// <summary>
            /// <para>The IP allocation policy.</para>
            /// </summary>
            [NameInMap("IpAllocationPolicy")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNetworksIpAllocationPolicy> IpAllocationPolicy { get; set; }
            public class CreateClusterRequestNetworksIpAllocationPolicy : TeaModel {
                /// <summary>
                /// <para>The bond policy.</para>
                /// </summary>
                [NameInMap("BondPolicy")]
                [Validation(Required=false)]
                public CreateClusterRequestNetworksIpAllocationPolicyBondPolicy BondPolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyBondPolicy : TeaModel {
                    /// <summary>
                    /// <para>The default bond subnet for the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.168.0.0/24</para>
                    /// </summary>
                    [NameInMap("BondDefaultSubnet")]
                    [Validation(Required=false)]
                    public string BondDefaultSubnet { get; set; }

                    /// <summary>
                    /// <para>The bond information.</para>
                    /// </summary>
                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyBondPolicyBonds : TeaModel {
                        /// <summary>
                        /// <para>The bond name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bond0</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The cluster subnet from which the IP address originates.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>172.16.0.0/24</para>
                        /// </summary>
                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                }

                /// <summary>
                /// <para>The allocation policy for the instance type.</para>
                /// </summary>
                [NameInMap("MachineTypePolicy")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicy : TeaModel {
                    /// <summary>
                    /// <para>The bond information.</para>
                    /// </summary>
                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
                        /// <summary>
                        /// <para>The bond name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bond0</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The cluster subnet from which the IP address originates.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.0/24</para>
                        /// </summary>
                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>efg1.nvga8n</para>
                    /// </summary>
                    [NameInMap("MachineType")]
                    [Validation(Required=false)]
                    public string MachineType { get; set; }

                }

                /// <summary>
                /// <para>The node allocation policy.</para>
                /// </summary>
                [NameInMap("NodePolicy")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
                public class CreateClusterRequestNetworksIpAllocationPolicyNodePolicy : TeaModel {
                    /// <summary>
                    /// <para>The bond information.</para>
                    /// </summary>
                    [NameInMap("Bonds")]
                    [Validation(Required=false)]
                    public List<CreateClusterRequestNetworksIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                    public class CreateClusterRequestNetworksIpAllocationPolicyNodePolicyBonds : TeaModel {
                        /// <summary>
                        /// <para>The bond name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>bond0</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The cluster subnet from which the IP address originates.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.0.0.0/24</para>
                        /// </summary>
                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e01-cn-2r42vq62001</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                }

            }

            /// <summary>
            /// <para>The virtual private domain (VPD) configuration information.</para>
            /// </summary>
            [NameInMap("NewVpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksNewVpdInfo NewVpdInfo { get; set; }
            public class CreateClusterRequestNetworksNewVpdInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-1gb1eftc5qp2ao75fo</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The CIDR block for Cloud Link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/24</para>
                /// </summary>
                [NameInMap("CloudLinkCidr")]
                [Validation(Required=false)]
                public string CloudLinkCidr { get; set; }

                /// <summary>
                /// <para>The Cloud Link ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-c4dtycm5i08</para>
                /// </summary>
                [NameInMap("CloudLinkId")]
                [Validation(Required=false)]
                public string CloudLinkId { get; set; }

                /// <summary>
                /// <para>The VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl2x45apm6odc2c10h25</para>
                /// </summary>
                [NameInMap("MonitorVpcId")]
                [Validation(Required=false)]
                public string MonitorVpcId { get; set; }

                /// <summary>
                /// <para>The vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-0jl2w3ffbghkss0x2foff</para>
                /// </summary>
                [NameInMap("MonitorVswitchId")]
                [Validation(Required=false)]
                public string MonitorVswitchId { get; set; }

                /// <summary>
                /// <para>The CIDR block for the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("VpdCidr")]
                [Validation(Required=false)]
                public string VpdCidr { get; set; }

                /// <summary>
                /// <para>The cluster subnet.</para>
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksNewVpdInfoVpdSubnets> VpdSubnets { get; set; }
                public class CreateClusterRequestNetworksNewVpdInfoVpdSubnets : TeaModel {
                    /// <summary>
                    /// <para>The subnet CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.1.8/24</para>
                    /// </summary>
                    [NameInMap("SubnetCidr")]
                    [Validation(Required=false)]
                    public string SubnetCidr { get; set; }

                    /// <summary>
                    /// <para>The subnet type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.0.2.8/24</para>
                    /// </summary>
                    [NameInMap("SubnetType")]
                    [Validation(Required=false)]
                    public string SubnetType { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-wulanchabu-b</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1d3dvbh9by7j5rujax</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IP version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("TailIpVersion")]
            [Validation(Required=false)]
            public string TailIpVersion { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-asjdfklj</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the vSwitch belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("VSwitchZoneId")]
            [Validation(Required=false)]
            public string VSwitchZoneId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jl36lqzmc06qogy0t5ll</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPD information.</para>
            /// </summary>
            [NameInMap("VpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksVpdInfo VpdInfo { get; set; }
            public class CreateClusterRequestNetworksVpdInfo : TeaModel {
                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-vfuz6ejv</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>The IDs of the subnets for a cluster.</para>
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<string> VpdSubnets { get; set; }

            }

        }

        /// <summary>
        /// <para>The node vSwitch.</para>
        /// </summary>
        [NameInMap("NimizVSwitches")]
        [Validation(Required=false)]
        public List<string> NimizVSwitches { get; set; }

        /// <summary>
        /// <para>The node groups.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<CreateClusterRequestNodeGroups> NodeGroups { get; set; }
        public class CreateClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>Specifies whether to support file system mounting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The system image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190297201634099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-key</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The node group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node group description</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>The node group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-default</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class CreateClusterRequestNodeGroupsNodes : TeaModel {
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class CreateClusterRequestNodeGroupsNodesDataDisk : TeaModel {
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8d13b784-17a9-11ed-bc7b-acde48001122</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The logon password.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01poc-cn-i7m2wnivf0d</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp169pi5fj151rrms4sia</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jlasms92fdxqd3wlf8ny</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The system disk information.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateClusterRequestNodeGroupsSystemDisk SystemDisk { get; set; }
            public class CreateClusterRequestNodeGroupsSystemDisk : TeaModel {
                /// <summary>
                /// <para>The disk category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_essd</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD that is used as the system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>Unit: GB</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The user data of the instance. The user data must be Base64-encoded. The raw data can be up to 16 KB in size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the elastic network interface (ENI) supports the Jumbo Frames feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenEniJumboFrame")]
        [Validation(Required=false)]
        public bool? OpenEniJumboFrame { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2xdkc6icwfha</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
