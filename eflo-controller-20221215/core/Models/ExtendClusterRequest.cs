// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ExtendClusterRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15b480fbd2fcdbc2869cd80</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip failed nodes. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The combined IP allocation policies. Each policy supports only one policy type, and multiple policies can be combined.</para>
        /// </summary>
        [NameInMap("IpAllocationPolicy")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestIpAllocationPolicy> IpAllocationPolicy { get; set; }
        public class ExtendClusterRequestIpAllocationPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies the cluster subnet ID based on the bond name.</para>
            /// </summary>
            [NameInMap("BondPolicy")]
            [Validation(Required=false)]
            public ExtendClusterRequestIpAllocationPolicyBondPolicy BondPolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyBondPolicy : TeaModel {
                /// <summary>
                /// <para>The default bond cluster subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-3od2fe</para>
                /// </summary>
                [NameInMap("BondDefaultSubnet")]
                [Validation(Required=false)]
                public string BondDefaultSubnet { get; set; }

                /// <summary>
                /// <para>The bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyBondPolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>The bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The source cluster subnet for IP addresses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-3od2fe</para>
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
            public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicy : TeaModel {
                /// <summary>
                /// <para>The bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>The bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The source cluster subnet for IP addresses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>The machine type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efg1.nvga1</para>
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
            public List<ExtendClusterRequestIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyNodePolicy : TeaModel {
                /// <summary>
                /// <para>The bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyNodePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>The bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The source cluster subnet for IP addresses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a100-xa5dza28-0085</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-3fdodw2</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

        }

        /// <summary>
        /// <para>The node groups.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ExtendClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>The number of nodes to purchase. Valid values: 0 to 500. If the Amount parameter is set to 0, no nodes are purchased, and existing nodes are used for scaling. If the Amount parameter is set to a value from 1 to 500, a specified number of nodes are purchased and used for scaling. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the purchased node. This parameter takes effect only when the Amount parameter is not set to 0 and the ChargeType parameter is set to PREPAY or POSTPAY. Valid values: True: Auto-renewal is enabled. False: Auto-renewal is disabled. Default value: False.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing method of the node. This parameter does not take effect when the Amount parameter is set to 0. Valid values: PREPAY: subscription; POSTPAY: pay-as-you-go. Default value: PREPAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The hostnames of the purchased nodes. This parameter does not take effect when the Amount parameter is set to 0.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The list of hypernodes.</para>
            /// </summary>
            [NameInMap("HyperNodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsHyperNodes> HyperNodes { get; set; }
            public class ExtendClusterRequestNodeGroupsHyperNodes : TeaModel {
                /// <summary>
                /// <para>The list of disk information.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestNodeGroupsHyperNodesDataDisk> DataDisk { get; set; }
                public class ExtendClusterRequestNodeGroupsHyperNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable burstable performance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>The disk category. Valid values:</para>
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
                    /// <para>Specifies whether the data cloud disk is deleted when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The device name of the data cloud disk. This parameter applies only to full image scenarios. You can use this parameter to set the device name of the data cloud disk to match the source data cloud disk in the full image, and modify the properties of the corresponding data cloud disk. For non-full image scaling, the Device parameter is set by the system by default. When you use full image scaling:</para>
                    /// <list type="bullet">
                    /// <item><description>Regardless of whether the data cloud disk parameters are explicitly set, the system restores the data cloud disks from the source image. The content is consistent with the source image data cloud disks.</description></item>
                    /// <item><description>If the data cloud disk is explicitly specified but the Device parameter is not set, additional empty data cloud disks are created. The quantity and properties are specified by the data cloud disk parameters provided by the user.</description></item>
                    /// <item><description>If the data cloud disk Device is explicitly specified but does not match the Device of the source image data cloud disk, additional empty data cloud disks are created. The quantity and properties are specified by the data cloud disk parameters provided by the user.</description></item>
                    /// <item><description>If multiple data cloud disks and their Devices are explicitly specified, but all Devices point to the device of a single data cloud disk in the source image, only one of the specified data cloud disks matches and overwrites the source image data cloud disk. The other specified data cloud disks are silently discarded, and no additional empty data cloud disks are created.</description></item>
                    /// <item><description>If the data cloud disk Device is explicitly specified and matches the Device of the source image data cloud disk, no additional empty data cloud disks are created. The data cloud disks specified by the user correspond one-to-one with the source image data cloud disks. If the Size of the data cloud disk set by the user is less than the Size of the source image data cloud disk, HTTP status code 417 and the error message &quot;Data disk Size can not be less than the image data disk snapshot size for Device &quot;/dev/xvdb&quot;&quot; are returned.</description></item>
                    /// <item><description>Total number of data cloud disks = Number of data cloud disks mounted on the node + Number of data cloud disks restored from the image. For standard cloud disk groups, the maximum is 16. If CPFS is enabled, the maximum is 4.</description></item>
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
                    /// <item><description>true: Encrypted.</description></item>
                    /// <item><description>false: Not encrypted.</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// <para><notice>When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must set the Encrypted request parameter to true for the cloud disk to ensure that the created cloud disk uses the recipient&quot;s own key.</notice></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// <para>The KMS key ID for the data cloud disk.</para>
                    /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                    /// <list type="bullet">
                    /// <item><description>If the cloud disk is created from an unshared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
                    /// <item><description>If the cloud disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
                    /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled: The specified account-level key is used by default.</description></item>
                    /// <item><description>In other cases: The service key is used by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>69dfe996-ae32-4d61-a4aa-914aff3fc3a0</para>
                    /// </summary>
                    [NameInMap("KMSKeyId")]
                    [Validation(Required=false)]
                    public string KMSKeyId { get; set; }

                    /// <summary>
                    /// <para>The performance level of the ESSD when it is used as the system cloud disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
                    /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL1</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>The read and write IOPS of the provisioned performance for a single ESSD AutoPL cloud disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9600</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>The disk size. Unit: GiB.</para>
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
                /// <para>liliang-rmn7stf7-0000</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The hypernode ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-2r42tmj4z02</para>
                /// </summary>
                [NameInMap("HyperNodeId")]
                [Validation(Required=false)]
                public string HyperNodeId { get; set; }

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
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf68xu2102avz7pl3t5d</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vbobo4cvzsygw98f4j6b</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl8gs7qmx89739e210dn</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The logon password of the purchased node. This parameter does not take effect when the Amount parameter is set to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skkO(*89Y</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i16d4883a46cbadeb4bc9</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The node tags.</para>
            /// </summary>
            [NameInMap("NodeTag")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodeTag> NodeTag { get; set; }
            public class ExtendClusterRequestNodeGroupsNodeTag : TeaModel {
                /// <summary>
                /// <para>The tag key of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key_my</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value_my</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ExtendClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <para>The data cloud disk specifications.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class ExtendClusterRequestNodeGroupsNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable burstable performance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
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
                    /// <para>Specifies whether the data cloud disk is deleted when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The device name of the data cloud disk. This parameter applies only to full image scenarios. You can use this parameter to set the device name of the data cloud disk to match the source data cloud disk in the full image, and modify the properties of the corresponding data cloud disk. For non-full image scaling, the Device parameter is set by the system by default. When you use full image scaling:</para>
                    /// <list type="bullet">
                    /// <item><description>Regardless of whether the data cloud disk parameters are explicitly set, the system restores the data cloud disks from the source image. The content is consistent with the source image data cloud disks.</description></item>
                    /// <item><description>If the data cloud disk is explicitly specified but the Device parameter is not set, additional empty data cloud disks are created. The quantity and properties are specified by the data cloud disk parameters provided by the user.</description></item>
                    /// <item><description>If the data cloud disk Device is explicitly specified but does not match the Device of the source image data cloud disk, additional empty data cloud disks are created. The quantity and properties are specified by the data cloud disk parameters provided by the user.</description></item>
                    /// <item><description>If multiple data cloud disks and their Devices are explicitly specified, but all Devices point to the device of a single data cloud disk in the source image, only one of the specified data cloud disks matches and overwrites the source image data cloud disk. The other specified data cloud disks are silently discarded, and no additional empty data cloud disks are created.</description></item>
                    /// <item><description>If the data cloud disk Device is explicitly specified and matches the Device of the source image data cloud disk, no additional empty data cloud disks are created. The data cloud disks specified by the user correspond one-to-one with the source image data cloud disks. If the Size of the data cloud disk set by the user is less than the Size of the source image data cloud disk, HTTP status code 417 and the error message &quot;Data disk Size can not be less than the image data disk snapshot size for Device &quot;/dev/xvdb&quot;&quot; are returned.</description></item>
                    /// <item><description>Total number of data cloud disks = Number of data cloud disks mounted on the node + Number of data cloud disks restored from the image. For standard cloud disk groups, the maximum is 16. If CPFS is enabled, the maximum is 4.</description></item>
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
                    /// <item><description>true: Encrypted.</description></item>
                    /// <item><description>false: Not encrypted.</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// <para><notice>When you use a shared encrypted image to create a cloud disk based on an encrypted snapshot, you must set the Encrypted request parameter to true for the cloud disk to ensure that the created cloud disk uses the recipient&quot;s own key.</notice></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// <para>The KMS key ID for the data cloud disk.</para>
                    /// <para>If Encrypted is set to true and KMSKeyId is not specified, the default key is used for encryption, and the KMSKeyId value is returned after the instance is created.</para>
                    /// <list type="bullet">
                    /// <item><description>If the cloud disk is created from an unshared encrypted snapshot: The encryption key used by the snapshot is used by default.</description></item>
                    /// <item><description>If the cloud disk is created from a shared encrypted snapshot: The service key is used by default.</description></item>
                    /// <item><description>If the cloud disk is created in a region where account-level default encryption for Block Storage is enabled: The specified account-level key is used by default.</description></item>
                    /// <item><description>In other cases: The service key is used by default.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>719e7359-1a44-4bab-a520-6d4648b610d0</para>
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
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>The hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d044d220-33fd-11ed-86a6</para>
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
                /// <para>e01-cn-zvp2zdpy601</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf68xu2102avz7pl3t5d</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

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
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jlasms92fdxqd3wlf8ny</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The subscription period of the node. Unit: months. Valid values: 1, 6, 12, 24, 36, and 48. This parameter takes effect only when the Amount parameter is not set to 0 and the ChargeType parameter is set to PREPAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The savings plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spn-25e985acAWbrwEBJ</para>
            /// </summary>
            [NameInMap("SavingsPlanId")]
            [Validation(Required=false)]
            public string SavingsPlanId { get; set; }

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
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf65m8xqjgy55xj9jw92n</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jl3b0c0ukydlfezr13n6</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
        /// <para>The zone ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("VSwitchZoneId")]
        [Validation(Required=false)]
        public string VSwitchZoneId { get; set; }

        /// <summary>
        /// <para>The list of cluster subnets.</para>
        /// </summary>
        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public List<string> VpdSubnets { get; set; }

    }

}
