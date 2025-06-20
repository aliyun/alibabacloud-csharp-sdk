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
        /// <para>Specifies whether to allow skipping failed nodes. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The combined policies for assigning IP addresses: Only one policy type can be selected for each policy, and multiple policies can be combined.</para>
        /// </summary>
        [NameInMap("IpAllocationPolicy")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestIpAllocationPolicy> IpAllocationPolicy { get; set; }
        public class ExtendClusterRequestIpAllocationPolicy : TeaModel {
            /// <summary>
            /// <para>The bond policy that you specify the cluster subnet ID based on the bond name.</para>
            /// </summary>
            [NameInMap("BondPolicy")]
            [Validation(Required=false)]
            public ExtendClusterRequestIpAllocationPolicyBondPolicy BondPolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyBondPolicy : TeaModel {
                /// <summary>
                /// <para>The default bond subnet for the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-3od2fe</para>
                /// </summary>
                [NameInMap("BondDefaultSubnet")]
                [Validation(Required=false)]
                public string BondDefaultSubnet { get; set; }

                /// <summary>
                /// <para>The bonds.</para>
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
                    /// <para>The cluster subnet from which the IP address originates.</para>
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
            /// <para>The allocation policies for the instance type.</para>
            /// </summary>
            [NameInMap("MachineTypePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicy : TeaModel {
                /// <summary>
                /// <para>The bonds.</para>
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
                    /// <para>The cluster subnet from which the IP address originates.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efg1.nvga1</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

            }

            /// <summary>
            /// <para>The node allocation policies.</para>
            /// </summary>
            [NameInMap("NodePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyNodePolicy : TeaModel {
                /// <summary>
                /// <para>The bonds.</para>
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
                    /// <para>The cluster subnet from which the IP address originates.</para>
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
                /// <para>i22c11282.eu95sqa</para>
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
            /// <para>The number of nodes to be purchased. Valid values: 0 to 500. If you set the value of the Amount parameter to 0, you do not want to purchase nodes and scale out the cluster by using existing nodes. If you set the value of the Amount parameter to a value ranging from 1 to 500, you want to purchase a certain number of nodes for cluster scale-out. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the purchased nodes. This parameter takes effect only when the Amount parameter is not set to 0 and the ChargeType parameter is set to PrePaid. Valid values: true and false. Default value: False.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The billing method of the node. This parameter does not take effect if you set the Amount parameter to 0. Valid values: PrePaid (subscription) and PostPaid (pay-as-you-go). Default value: PrePaid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The hostname for the purchased node. This parameter does not take effect if you set the Amount parameter to 0.</para>
            /// </summary>
            [NameInMap("Hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>The logon password of the purchased node. This parameter does not take effect if you set the Amount parameter to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Addk(*78</para>
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
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("NodeTag")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodeTag> NodeTag { get; set; }
            public class ExtendClusterRequestNodeGroupsNodeTag : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ExtendClusterRequestNodeGroupsNodes : TeaModel {
                [NameInMap("DataDisk")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestNodeGroupsNodesDataDisk> DataDisk { get; set; }
                public class ExtendClusterRequestNodeGroupsNodesDataDisk : TeaModel {
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
                /// <para>d044d220-33fd-11ed-86a6</para>
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
                /// <para>e01-cn-zvp2zdpy601</para>
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
            /// <para>The duration of the purchased node. Unit: months. Valid values: 1, 6, 12, 24, 36, and 48. This parameter takes effect only when the Amount parameter is not set to 0 and the ChargeType parameter is set to PrePaid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/sh
            /// echo &quot;Hello World. The time is now $(date -R)!&quot; | tee /root/userdata_test.txt</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-0jly2d537ejphyq6h13ke</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-zq1econyv63tvyci5hefw</para>
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
        /// <para>The ID of the zone to which the vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("VSwitchZoneId")]
        [Validation(Required=false)]
        public string VSwitchZoneId { get; set; }

        /// <summary>
        /// <para>The subnets of the cluster.</para>
        /// </summary>
        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public List<string> VpdSubnets { get; set; }

    }

}
