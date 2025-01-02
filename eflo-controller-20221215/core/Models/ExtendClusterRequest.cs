// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ExtendClusterRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15b480fbd2fcdbc2869cd80</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Whether to allow skipping failed node tasks, default value is False</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>IP allocation policy combination: Each policy can only choose one type, and multiple policies can be combined</para>
        /// </summary>
        [NameInMap("IpAllocationPolicy")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestIpAllocationPolicy> IpAllocationPolicy { get; set; }
        public class ExtendClusterRequestIpAllocationPolicy : TeaModel {
            /// <summary>
            /// <para>Specify the cluster subnet ID based on the bond name</para>
            /// </summary>
            [NameInMap("BondPolicy")]
            [Validation(Required=false)]
            public ExtendClusterRequestIpAllocationPolicyBondPolicy BondPolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyBondPolicy : TeaModel {
                /// <summary>
                /// <para>Default bond cluster subnet</para>
                /// 
                /// <b>Example:</b>
                /// <para>subnet-3od2fe</para>
                /// </summary>
                [NameInMap("BondDefaultSubnet")]
                [Validation(Required=false)]
                public string BondDefaultSubnet { get; set; }

                /// <summary>
                /// <para>Bond information</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyBondPolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet</para>
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
            /// <para>Machine type allocation policy</para>
            /// </summary>
            [NameInMap("MachineTypePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicy : TeaModel {
                /// <summary>
                /// <para>Bond information</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>Machine Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>efg1.nvga1</para>
                /// </summary>
                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

            }

            /// <summary>
            /// <para>Node allocation policy</para>
            /// </summary>
            [NameInMap("NodePolicy")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyNodePolicy : TeaModel {
                /// <summary>
                /// <para>Bond information</para>
                /// </summary>
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyNodePolicyBonds : TeaModel {
                    /// <summary>
                    /// <para>Bond name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Bond0</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>IP source cluster subnet</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>subnet-fdo3dv</para>
                    /// </summary>
                    [NameInMap("Subnet")]
                    [Validation(Required=false)]
                    public string Subnet { get; set; }

                }

                /// <summary>
                /// <para>Node ID</para>
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
        /// <para>Node Group</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ExtendClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>Node Group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>i16d4883a46cbadeb4bc9</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>List of Nodes</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ExtendClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <para>Hostname</para>
                /// 
                /// <b>Example:</b>
                /// <para>d044d220-33fd-11ed-86a6</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>Login Password</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("LoginPassword")]
                [Validation(Required=false)]
                public string LoginPassword { get; set; }

                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-zvp2zdpy601</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>VSwitch ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp169pi5fj151rrms4sia</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-0jlasms92fdxqd3wlf8ny</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>Custom Data</para>
            /// 
            /// <b>Example:</b>
            /// <para>#!/bin/sh
            /// echo &quot;Hello World. The time is now $(date -R)!&quot; | tee /root/userdata_test.txt</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>Zone ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>VSwitch availability zone ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("VSwitchZoneId")]
        [Validation(Required=false)]
        public string VSwitchZoneId { get; set; }

        /// <summary>
        /// <para>List of cluster subnets</para>
        /// </summary>
        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public List<string> VpdSubnets { get; set; }

    }

}
