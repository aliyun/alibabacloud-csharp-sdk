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
                /// <para>The node pool configuration, which is used to establish the mapping between node groups and node pools. This parameter is required when ComponentType is set to ACKEdge. Leave this parameter empty for other component types.</para>
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
        /// <para>Specifies whether to skip failed nodes. Default value: false.</para>
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
                    /// <para>The default cluster subnet for the bond.</para>
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
                        /// <para>The source cluster subnet for IP addresses.</para>
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
                        /// <para>The source cluster subnet for IP addresses.</para>
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
                        /// <para>The source cluster subnet for IP addresses.</para>
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
                /// <para>The CEN ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-1gb1eftc5qp2ao75fo</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The CIDR block of the cloud link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/24</para>
                /// </summary>
                [NameInMap("CloudLinkCidr")]
                [Validation(Required=false)]
                public string CloudLinkCidr { get; set; }

                /// <summary>
                /// <para>The cloud link ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcc-cn-c4dtycm5i08</para>
                /// </summary>
                [NameInMap("CloudLinkId")]
                [Validation(Required=false)]
                public string CloudLinkId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl2x45apm6odc2c10h25</para>
                /// </summary>
                [NameInMap("MonitorVpcId")]
                [Validation(Required=false)]
                public string MonitorVpcId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
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
                /// <para>The cluster subnets.</para>
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
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jl36lqzmc06qogy0t5ll</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The reused VPD information.</para>
            /// </summary>
            [NameInMap("VpdInfo")]
            [Validation(Required=false)]
            public CreateClusterRequestNetworksVpdInfo VpdInfo { get; set; }
            public class CreateClusterRequestNetworksVpdInfo : TeaModel {
                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpd-vfuz6ejv</para>
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                /// <summary>
                /// <para>The list of cluster subnet IDs. This parameter is required when you use VpdInfo to reuse an existing VPD. If you specify only VpdId and omit this parameter, the API returns InvalidParameter.</para>
                /// </summary>
                [NameInMap("VpdSubnets")]
                [Validation(Required=false)]
                public List<string> VpdSubnets { get; set; }

            }

        }

        /// <summary>
        /// <para>The node vSwitches.</para>
        /// </summary>
        [NameInMap("NimizVSwitches")]
        [Validation(Required=false)]
        public List<string> NimizVSwitches { get; set; }

        /// <summary>
        /// <para>The list of node groups. This parameter is actually required. If it is not provided, the API returns InvalidParameter (NodeGroups field required).</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<CreateClusterRequestNodeGroups> NodeGroups { get; set; }
        public class CreateClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>Specifies whether file system mounting is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The list of hypernodes.</para>
            /// </summary>
            [NameInMap("HyperNodes")]
            [Validation(Required=false)]
            public List<CreateClusterRequestNodeGroupsHyperNodes> HyperNodes { get; set; }
            public class CreateClusterRequestNodeGroupsHyperNodes : TeaModel {
                /// <summary>
                /// <para>The list of data cloud disks.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNodeGroupsHyperNodesDataDisk> DataDisk { get; set; }
                public class CreateClusterRequestNodeGroupsHyperNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the burst (performance burst) feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>The cloud disk category. Valid values:</para>
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
                    /// <para>Specifies whether to delete the data cloud disk when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The device name of the data cloud disk. This parameter is used only in full image scenarios. You can use this parameter to set the device name of the data cloud disk to match the source data cloud disk in the full image, and modify the properties of the corresponding data cloud disk. For non-full image scaling, the Device parameter is set by the system by default. When you use a full image for scaling:</para>
                    /// <list type="bullet">
                    /// <item><description>Regardless of whether the data cloud disk parameters are explicitly set, the system restores the data cloud disks from the source image for the user. The content is consistent with the data cloud disks in the source image.</description></item>
                    /// <item><description>If data cloud disks are explicitly specified but the Device parameter is not set, additional empty data cloud disks are created. The quantity and properties are specified by the user&quot;s data cloud disk parameters.</description></item>
                    /// <item><description>If the Device parameter of the explicitly specified data cloud disk does not match the Device parameter of the source image data cloud disk, additional empty data cloud disks are created. The quantity and properties are specified by the user&quot;s data cloud disk parameters.</description></item>
                    /// <item><description>If multiple data cloud disks and their Device parameters are explicitly specified, but all Device parameters point to the same device of a single data cloud disk in the source image, only one of the user-specified data cloud disks matches and overwrites the source image data cloud disk by device. The other specified data cloud disks are silently discarded, and no additional empty data cloud disks are created.</description></item>
                    /// <item><description>If the Device parameter of the explicitly specified data cloud disk matches the Device parameter of the source image data cloud disk, no additional empty data cloud disks are created. The user-specified data cloud disks correspond one-to-one with the source image data cloud disks by device. If the Size of the user-specified data cloud disk is smaller than the Size of the source image data cloud disk, the system returns HTTP status code 417 and the error message: &quot;Data disk Size can not be less than the image data disk snapshot size for Device &quot;/dev/xvdb&quot;&quot;.</description></item>
                    /// <item><description>The total number of data cloud disks mounted to the node (specified data cloud disks + data cloud disks restored from the image) cannot exceed 16 for standard cloud disk groups, and cannot exceed 4 when Cloud Paralleled File System (CPFS) is enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/xvdb</para>
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Encrypts the data cloud disk.</description></item>
                    /// <item><description>false: Does not encrypt the data cloud disk.</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// <remarks>
                    /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk. This ensures that the created cloud disk uses the key of the shared party.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// <para>The KMS key ID of the data cloud disk.</para>
                    /// <para>If the Encrypted parameter is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                    /// <list type="bullet">
                    /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                    /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                    /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
                    /// <item><description>In other cases, the service key is used by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>57e27f4a-f60f-4e8f-bbae-6c042e9a5ed6</para>
                    /// </summary>
                    [NameInMap("KMSKeyId")]
                    [Validation(Required=false)]
                    public string KMSKeyId { get; set; }

                    /// <summary>
                    /// <para>The performance level of the ESSD used as the data cloud disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PL0: A single disk delivers up to 10,000 random read/write IOPS.</description></item>
                    /// <item><description>PL1: A single disk delivers up to 50,000 random read/write IOPS.</description></item>
                    /// <item><description>PL2: A single disk delivers up to 100,000 random read/write IOPS.</description></item>
                    /// <item><description>PL3: A single disk delivers up to 1,000,000 random read/write IOPS.</description></item>
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
                    /// <para>The read/write IOPS of the provisioned performance for a single ESSD AutoPL cloud disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>The disk size. Unit: GiB.</para>
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
                /// <para>The hypernode ID.</para>
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
                /// <para>The vSwitch ID in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1xn9iq3s3p8218c4qu4</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf689skpx56nk7yfw0jhy</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

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
            /// <para>The name of the key pair. You must specify at least one of LoginPassword and KeyPairName. If neither is specified, the API returns InvalidParameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-keypair</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The logon password. You must specify at least one of LoginPassword and KeyPairName. If neither is specified, the API returns InvalidParameter.</para>
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
                /// <para>The data cloud disk specifications.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<CreateClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class CreateClusterRequestNodeGroupsNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable the burst (performance burst) feature.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>The disk category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to delete the data cloud disk when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The device name of the data cloud disk. This parameter is used only in full image scenarios. You can use this parameter to set the device name of the data cloud disk to match the source data cloud disk in the full image, and modify the properties of the corresponding data cloud disk. For non-full image scaling, the Device parameter is set by the system by default. When you use a full image for scaling:</para>
                    /// <list type="bullet">
                    /// <item><description>Regardless of whether the data cloud disk parameters are explicitly set, the system restores the data cloud disks from the source image for the user. The content is consistent with the data cloud disks in the source image.</description></item>
                    /// <item><description>If data cloud disks are explicitly specified but the Device parameter is not set, additional empty data cloud disks are created. The quantity and properties are specified by the user&quot;s data cloud disk parameters.</description></item>
                    /// <item><description>If the Device parameter of the explicitly specified data cloud disk does not match the Device parameter of the source image data cloud disk, additional empty data cloud disks are created. The quantity and properties are specified by the user&quot;s data cloud disk parameters.</description></item>
                    /// <item><description>If multiple data cloud disks and their Device parameters are explicitly specified, but all Device parameters point to the same device of a single data cloud disk in the source image, only one of the user-specified data cloud disks matches and overwrites the source image data cloud disk by device. The other specified data cloud disks are silently discarded, and no additional empty data cloud disks are created.</description></item>
                    /// <item><description>If the Device parameter of the explicitly specified data cloud disk matches the Device parameter of the source image data cloud disk, no additional empty data cloud disks are created. The user-specified data cloud disks correspond one-to-one with the source image data cloud disks by device. If the Size of the user-specified data cloud disk is smaller than the Size of the source image data cloud disk, the system returns HTTP status code 417 and the error message: &quot;Data disk Size can not be less than the image data disk snapshot size for Device &quot;/dev/xvdb&quot;&quot;.</description></item>
                    /// <item><description>The total number of data cloud disks mounted to the node (specified data cloud disks + data cloud disks restored from the image) cannot exceed 16 for standard cloud disk groups, and cannot exceed 4 when Cloud Paralleled File System (CPFS) is enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/xvdb</para>
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Encrypts the data cloud disk.</description></item>
                    /// <item><description>false: Does not encrypt the data cloud disk.</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// <remarks>
                    /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk. This ensures that the created cloud disk uses the key of the shared party.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// <para>The KMS key ID of the data cloud disk.</para>
                    /// <para>If the Encrypted parameter is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                    /// <list type="bullet">
                    /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                    /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                    /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
                    /// <item><description>In other cases, the service key is used by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3c0655ca-59c8-4878-ac02-e7fb93656504</para>
                    /// </summary>
                    [NameInMap("KMSKeyId")]
                    [Validation(Required=false)]
                    public string KMSKeyId { get; set; }

                    /// <summary>
                    /// <para>The performance parameter of the data cloud disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL0</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>The provisioned performance (IOPS). Valid values: 0 to 50000.</para>
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
                /// <para>Demo****123!</para>
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
            /// <para>The name of the Resource Access Management (RAM) role for the node. You can call the ListRoles operation of RAM to query the RAM roles that you have created. The trusted entity of the specified role must be Lingjun Intelligent Computing.
            /// Note: You cannot clear an existing role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xianwen-test-ram-role</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The system cloud disk information.</para>
            /// </summary>
            [NameInMap("SystemDisk")]
            [Validation(Required=false)]
            public CreateClusterRequestNodeGroupsSystemDisk SystemDisk { get; set; }
            public class CreateClusterRequestNodeGroupsSystemDisk : TeaModel {
                /// <summary>
                /// <para>The cloud disk category. Valid values:</para>
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
                /// <para>Specifies whether to encrypt the system cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Encrypts the system cloud disk.</description></item>
                /// <item><description>false: Does not encrypt the system cloud disk.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// <remarks>
                /// <para>Notice: When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must specify the request parameter Encrypted=true for the cloud disk. This ensures that the created cloud disk uses the key of the shared party.</para>
                /// </remarks>
                /// <remarks>
                /// <para>System cloud disk encryption during instance creation is not supported in Hong Kong (China) Zone D and Singapore Zone A.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The KMS key ID of the system cloud disk.</para>
                /// <para>If the Encrypted parameter is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                /// <list type="bullet">
                /// <item><description>If the cloud disk is created from an unshared encrypted snapshot, the encryption key used for the snapshot is used by default.</description></item>
                /// <item><description>If the cloud disk is created from a shared encrypted snapshot, the service key is used by default.</description></item>
                /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled, the specified account-level key is used by default.</description></item>
                /// <item><description>In other cases, the service key is used by default.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3b424bd2-b120-4185-9665-84e9a312d91a</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD used as the system cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PL0: A single disk delivers up to 10,000 random read/write IOPS.</description></item>
                /// <item><description>PL1: A single disk delivers up to 50,000 random read/write IOPS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The size of the system cloud disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9999</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

            }

            /// <summary>
            /// <para>The custom executable shell script. The script must be Base64-encoded. The maximum size of the raw data is 16 KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable GPU virtualization splitting.</para>
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
