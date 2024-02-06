// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAclsResponseBody : TeaModel {
        /// <summary>
        /// Details of the network ACLs.
        /// </summary>
        [NameInMap("NetworkAcls")]
        [Validation(Required=false)]
        public List<DescribeNetworkAclsResponseBodyNetworkAcls> NetworkAcls { get; set; }
        public class DescribeNetworkAclsResponseBodyNetworkAcls : TeaModel {
            /// <summary>
            /// The time when the network ACL was created. The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the network ACL.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Details of the outbound rules.
            /// </summary>
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries> EgressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsEgressAclEntries : TeaModel {
                /// <summary>
                /// The destination CIDR block.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The description of the outbound rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the outbound rule.
                /// </summary>
                [NameInMap("NetworkAclEntryId")]
                [Validation(Required=false)]
                public string NetworkAclEntryId { get; set; }

                /// <summary>
                /// The name of the outbound rule.
                /// </summary>
                [NameInMap("NetworkAclEntryName")]
                [Validation(Required=false)]
                public string NetworkAclEntryName { get; set; }

                /// <summary>
                /// The action to be performed on network traffic that matches the rule. Valid values:
                /// 
                /// *   **accept**: allows the network traffic.
                /// *   **drop**: blocks the network traffic.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The destination port range of the outbound rule.
                /// 
                /// *   If **Protocol** in the outbound rule is set to **all** or **icmp**, \*\*-1/-1\*\* is returned for this parameter. \*\*-1/-1\*\* indicates all ports.
                /// *   If **Protocol** in the outbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 120/120 indicates port 1 to port 200 and 80/80 indicates port 80. Valid values for a port: **1 to 65535**.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// The priority of the rule. Valid values: **1 to 100**. Default value: **1**.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The protocol. Valid values:
                /// 
                /// *   **icmp**
                /// *   **tcp**
                /// *   **udp**
                /// *   **all**
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   **system**: The rule is created by the system.
                /// *   **custom**: The rule is created by a user.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Details of the inbound rules.
            /// </summary>
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries> IngressAclEntries { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsIngressAclEntries : TeaModel {
                /// <summary>
                /// The source CIDR block.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The description of the inbound rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the inbound rule.
                /// </summary>
                [NameInMap("NetworkAclEntryId")]
                [Validation(Required=false)]
                public string NetworkAclEntryId { get; set; }

                /// <summary>
                /// The name of the inbound rule.
                /// </summary>
                [NameInMap("NetworkAclEntryName")]
                [Validation(Required=false)]
                public string NetworkAclEntryName { get; set; }

                /// <summary>
                /// The action that is performed on network traffic that matches the rule. Valid values:
                /// 
                /// *   **accept**: allows the network traffic.
                /// *   **drop**: blocks the network traffic.
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// The destination port range of the inbound rule.
                /// 
                /// *   If **Protocol** in the inbound rule is set to **all** or **icmp**, \*\*-1/-1\*\* is returned for this parameter. \*\*-1/-1\*\* indicates all ports.
                /// *   If **Protocol** in the inbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 1/200 indicates port 1 to port 200 and 80/80 indicates port 80. Valid values for a port: **1 to 65535**.
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// The priority of the rule. Valid values: **1 to 100**. Default value: **1**.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The protocol. Valid values:
                /// 
                /// *   **icmp**
                /// *   **tcp**
                /// *   **udp**
                /// *   **all**
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   **system**: The rule is created by the system.
                /// *   **custom**: The rule is created by a user.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The ID of the network ACL.
            /// </summary>
            [NameInMap("NetworkAclId")]
            [Validation(Required=false)]
            public string NetworkAclId { get; set; }

            /// <summary>
            /// The name of the network ACL.
            /// </summary>
            [NameInMap("NetworkAclName")]
            [Validation(Required=false)]
            public string NetworkAclName { get; set; }

            /// <summary>
            /// Details of the associated resources.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsResources> Resources { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsResources : TeaModel {
                /// <summary>
                /// The ID of the ENS node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The ID of the associated resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the associated resource.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The association status of the resource. Valid values:
                /// 
                /// *   **BINDED**: The resource is associated with the network ACL.
                /// *   **BINDING**: The resource is being associated with the network ACL.
                /// *   **UNBINDING**: The resource is being disassociated from the network ACL.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The status of the network ACL. Valid values:
            /// 
            /// *   **Available**: The network ACL is available.
            /// *   **Modifying**: The network ACL is being configured.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
