// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ExtendClusterRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15b480fbd2fcdbc2869cd80</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Whether to allow skipping failed nodes. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>Combined policy for IP allocation. Each policy can only select one policy type, and multiple policies can be combined.</para>
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
                /// <para>Default bond cluster subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-3od2fe</para>
                /// </summary>
                [NameInMap("BondDefaultSubnet")]
                [Validation(Required=false)]
                public string BondDefaultSubnet { get; set; }

                /// <summary>
                /// <para>Bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyBondPolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet.</para>
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
            /// <para>Machine type allocation policy.</para>
            /// </summary>
            [NameInMap("MachineTypePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicy : TeaModel {
                /// <summary>
                /// <para>Bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>Machine type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efg1.nvga1</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

            }

            /// <summary>
            /// <para>Node allocation policy.</para>
            /// </summary>
            [NameInMap("NodePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyNodePolicy : TeaModel {
                /// <summary>
                /// <para>Bond information.</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyNodePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>Hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a100-xa5dza28-0085</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
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
        /// <para>Node groups.</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ExtendClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>The number of nodes to purchase. Valid values: 0 to 500. If the Amount parameter is set to 0, no nodes are purchased and existing nodes are used for scale-out. If the Amount parameter is set to a value from 1 to 500, the specified number of nodes are purchased and used for scale-out. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>Whether to enable auto-renewal for the purchased nodes. This parameter takes effect when the Amount parameter is not 0 and ChargeType is set to PREPAY or POSTPAY. Valid values: True: enable auto-renewal. False: disable auto-renewal. Default value: False.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing method of nodes. This parameter does not take effect when the Amount parameter is set to 0. Valid values: PREPAY: subscription. POSTPAY: pay-as-you-go. Default value: PREPAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The hostnames set for the purchased nodes. This parameter does not take effect when the Amount parameter is set to 0.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>HyperNode list.</para>
            /// </summary>
            [NameInMap("HyperNodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsHyperNodes> HyperNodes { get; set; }
            public class ExtendClusterRequestNodeGroupsHyperNodes : TeaModel {
                /// <summary>
                /// <para>Disk information list.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestNodeGroupsHyperNodesDataDisk> DataDisk { get; set; }
                public class ExtendClusterRequestNodeGroupsHyperNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Whether to enable burst (performance bursting).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>Disk type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Whether the data disk is deleted when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>True</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>The performance level of the ESSD cloud disk used as the system disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PL0: maximum random read/write IOPS of 10,000 per disk.</description></item>
                    /// <item><description>PL1: maximum random read/write IOPS of 50,000 per disk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL1</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>Provisioned read/write IOPS of the ESSD AutoPL cloud disk (per disk).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9600</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>Disk size, in GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>Hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liliang-rmn7stf7-0000</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>HyperNode ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-2r42tmj4z02</para>
                /// </summary>
                [NameInMap("HyperNodeId")]
                [Validation(Required=false)]
                public string HyperNodeId { get; set; }

                /// <summary>
                /// <para>Login password.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>Security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf68xu2102avz7pl3t5d</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-8vbobo4cvzsygw98f4j6b</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jl8gs7qmx89739e210dn</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The login password set for the purchased nodes. This parameter does not take effect when the Amount parameter is set to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skkO(*89Y</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>Node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i16d4883a46cbadeb4bc9</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>Node tags.</para>
            /// </summary>
            [NameInMap("NodeTag")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodeTag> NodeTag { get; set; }
            public class ExtendClusterRequestNodeGroupsNodeTag : TeaModel {
                /// <summary>
                /// <para>Node tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key_my</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Node tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value_my</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Node list.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ExtendClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <para>Data disk specifications.</para>
                /// </summary>
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class ExtendClusterRequestNodeGroupsNodesDataDisk : TeaModel {
                    /// <summary>
                    /// <para>Whether to enable burst (performance bursting).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("BurstingEnabled")]
                    [Validation(Required=false)]
                    public bool? BurstingEnabled { get; set; }

                    /// <summary>
                    /// <para>Disk type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Whether the data disk is deleted when the node is unsubscribed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DeleteWithNode")]
                    [Validation(Required=false)]
                    public bool? DeleteWithNode { get; set; }

                    /// <summary>
                    /// <para>Data disk performance level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PL0</para>
                    /// </summary>
                    [NameInMap("PerformanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                    /// <summary>
                    /// <para>Provisioned performance (IOPS). Valid values: 0 to 50000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("ProvisionedIops")]
                    [Validation(Required=false)]
                    public long? ProvisionedIops { get; set; }

                    /// <summary>
                    /// <para>Disk size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public int? Size { get; set; }

                }

                /// <summary>
                /// <para>Hostname.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d044d220-33fd-11ed-86a6</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>Login password.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-zvp2zdpy601</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-uf68xu2102avz7pl3t5d</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp169pi5fj151rrms4sia</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jlasms92fdxqd3wlf8ny</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The subscription duration of nodes (unit: month). Valid values: 1, 6, 12, 24, 36, and 48. This parameter takes effect when the Amount parameter is not 0 and ChargeType is set to PREPAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            [NameInMap("SavingsPlanId")]
            [Validation(Required=false)]
            public string SavingsPlanId { get; set; }

            /// <summary>
            /// <para>Custom data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/sh
            /// echo &quot;Hello World. The time is now $(date -R)!&quot; | tee /root/userdata_test.txt</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf65m8xqjgy55xj9jw92n</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jl3b0c0ukydlfezr13n6</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>Zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>vSwitch zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("VSwitchZoneId")]
        [Validation(Required=false)]
        public string VSwitchZoneId { get; set; }

        /// <summary>
        /// <para>Cluster subnet list.</para>
        /// </summary>
        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public List<string> VpdSubnets { get; set; }

    }

}
