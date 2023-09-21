// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ExtendClusterRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("IpAllocationPolicy")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestIpAllocationPolicy> IpAllocationPolicy { get; set; }
        public class ExtendClusterRequestIpAllocationPolicy : TeaModel {
            [NameInMap("BondPolicy")]
            [Validation(Required=false)]
            public ExtendClusterRequestIpAllocationPolicyBondPolicy BondPolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyBondPolicy : TeaModel {
                [NameInMap("BondDefaultSubnet")]
                [Validation(Required=false)]
                public string BondDefaultSubnet { get; set; }

                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyBondPolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyBondPolicyBonds : TeaModel {
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
            public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicy> MachineTypePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicy : TeaModel {
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyMachineTypePolicyBonds : TeaModel {
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
            public List<ExtendClusterRequestIpAllocationPolicyNodePolicy> NodePolicy { get; set; }
            public class ExtendClusterRequestIpAllocationPolicyNodePolicy : TeaModel {
                [NameInMap("Bonds")]
                [Validation(Required=false)]
                public List<ExtendClusterRequestIpAllocationPolicyNodePolicyBonds> Bonds { get; set; }
                public class ExtendClusterRequestIpAllocationPolicyNodePolicyBonds : TeaModel {
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

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ExtendClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ExtendClusterRequestNodeGroups : TeaModel {
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ExtendClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ExtendClusterRequestNodeGroupsNodes : TeaModel {
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

        }

        [NameInMap("VpdSubnets")]
        [Validation(Required=false)]
        public List<string> VpdSubnets { get; set; }

    }

}
