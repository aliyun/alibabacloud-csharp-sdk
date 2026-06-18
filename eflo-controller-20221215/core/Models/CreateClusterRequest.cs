// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The description of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard cluster test</para>
        /// </summary>
        [NameInMap("ClusterDescription")]
        [Validation(Required=false)]
        public string ClusterDescription { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The type of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Lite</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The components (software instances).</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateClusterRequestComponents> Components { get; set; }
        public class CreateClusterRequestComponents : TeaModel {
            /// <summary>
            /// <para>The component configuration.</para>
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
                /// <para>The node pool configuration. This is used to establish the mapping between node groups and node pools. This parameter is required when ComponentType is set to ACKEdge. Otherwise, leave it empty.</para>
                /// </summary>
                [NameInMap("NodeUnits")]
                [Validation(Required=false)]
                public List<object> NodeUnits { get; set; }

            }

            /// <summary>
            /// <para>The component type.</para>
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
        /// <para>Specifies whether to skip failed nodes. The default value is False.</para>
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
            /// <para>The IP address allocation policy.</para>
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
                    /// <para>The default bond cluster subnet.</para>
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
                        /// <para>The source cluster subnet for the IP address.</para>
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
                /// <para>The machine type allocation policy.</para>
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
                        /// <para>The source cluster subnet for the IP address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.0/24</para>
                        /// </summary>
                        [NameInMap("Subnet")]
                        [Validation(Required=false)]
                        public string Subnet { get; set; }

                    }

                    /// <summary>
                    /// <para>The machine type.</para>
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
                        /// <para>The source cluster subnet for the IP address.</para>
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
            /// <para>The VPD configuration information.</para>
            /// </summary>
            [NameInMap("NewVpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksNewVpdInfo NewVpdInfo { get; set; }
            public class CreateClusterRequestNetworksNewVpdInfo : TeaModel {
                /// <summary>
                /// <para>The Cloud Enterprise Network (CEN) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-1gb1eftc5qp2ao75fo</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The Cloud Link CIDR block.</para>
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
                /// <para>The CIDR block of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("VpdCidr")]
                [Validation(Required=false)]
                public string VpdCidr { get; set; }

                /// <summary>
                /// <para>The subnets of the cluster.</para>
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNetworksNewVpdInfoVpdSubnets> VpdSubnets { get; set; }
                public class CreateClusterRequestNetworksNewVpdInfoVpdSubnets : TeaModel {
                    /// <summary>
                    /// <para>The CIDR block of the subnet.</para>
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
            /// <para>The zone ID of the vSwitch.</para>
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
            /// <para>The information about the reused VPD.</para>
            /// </summary>
            [NameInMap("VpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksVpdInfo VpdInfo { get; set; }
            public class CreateClusterRequestNetworksVpdInfo : TeaModel {
                /// <summary>
                /// <para>The VPD ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-vfuz6ejv</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>The list of cluster subnet IDs.</para>
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<string> VpdSubnets { get; set; }

            }

        }

        /// <summary>
        /// <para>The vSwitches for the node.</para>
        /// </summary>
        [NameInMap("NimizVSwitches")]
        [Validation(Required=false)]
        public List<string> NimizVSwitches { get; set; }

        /// <summary>
        /// <para>The list of node groups.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<CreateClusterRequestNodeGroups> NodeGroups { get; set; }
        public class CreateClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable file system mounting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The list of supernodes.</para>
            /// </summary>
            [NameInMap("HyperNodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsHyperNodes> HyperNodes { get; set; }
            public class CreateClusterRequestNodeGroupsHyperNodes : TeaModel {
                /// <summary>
                /// <para>The list of data disks.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNodeGroupsHyperNodesDataDisk> DataDisk { get; set; }
                public class CreateClusterRequestNodeGroupsHyperNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable performance burst.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>The disk type. Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description>cloud_essd: ESSD.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to delete the data disk when the node is released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The performance level of the ESSD that you create as a data disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>PL0: A single disk delivers up to 10,000 random read/write IOPS.</para>
                    /// </description></item>
                    /// <item><description><para>PL1: A single disk delivers up to 50,000 random read/write IOPS.</para>
                    /// </description></item>
                    /// <item><description><para>PL2: A single disk delivers up to 100,000 random read/write IOPS.</para>
                    /// </description></item>
                    /// <item><description><para>PL3: A single disk delivers up to 1,000,000 random read/write IOPS.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>Default value: PL1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL0</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>The disk size in GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>180</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>q25b01265.cloud.ng152</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The supernode ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-dw72u2c23jk</para>
                /// </summary>
                [NameInMap("HyperNodeId")]
                [Validation(Required=false)]
                public string HyperNodeId { get; set; }

                /// <summary>
                /// <para>The logon password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaadddddfdsfdsfsdffd</para>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1xn9iq3s3p8218c4qu4</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf689skpx56nk7yfw0jhy</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The OS image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i190297201634099844192</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the key pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The logon password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Password</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The machine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The description of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default node group</para>
            /// </summary>
            [NameInMap("NodeGroupDescription")]
            [Validation(Required=false)]
            public string NodeGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-default</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class CreateClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <para>The specifications of the data disk.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class CreateClusterRequestNodeGroupsNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable performance burst.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to delete the data disk when the node is released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The performance metric of the data disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL0</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>The provisioned performance (IOPS). The value must be in the range of 0 to 50,000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>The disk size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
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
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jlasms92fdxqd3wlf8ny</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The name of the RAM role for the node. You can call the ListRoles operation of the RAM API to query the RAM roles that you have created. The trusted entity of the role must be Intelligent Computing LINGJUN.
            /// Note: You cannot clear an existing role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xianwen-test-ram-role</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The information about the system disk.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateClusterRequestNodeGroupsSystemDisk SystemDisk { get; set; }
            public class CreateClusterRequestNodeGroupsSystemDisk : TeaModel {
                /// <summary>
                /// <para>The disk type. Valid value:</para>
                /// <list type="bullet">
                /// <item><description>cloud_essd: enhanced SSD (ESSD).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD that you create as a system disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PL0: A single disk delivers up to 10,000 random read/write input/output operations per second (IOPS).</para>
                /// </description></item>
                /// <item><description><para>PL1: A single disk delivers up to 50,000 random read/write IOPS.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The unit is GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The instance user data. The data must be Base64-encoded. The raw data can be up to 16 KB in size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable GPU virtualization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VirtualGpuEnabled")]
            [Validation(Required=false)]
            public bool? VirtualGpuEnabled { get; set; }

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
        /// <para>Specifies whether the network interface supports jumbo frames.</para>
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
            /// <para>The key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value.</para>
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
