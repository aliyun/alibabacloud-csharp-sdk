// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNetworkAclAttributesResponseBody : TeaModel {
        /// <summary>
        /// The details about the network ACL.
        /// </summary>
        [NameInMap("NetworkAclAttribute")]
        [Validation(Required=false)]
        public DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute NetworkAclAttribute { get; set; }
        public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttribute : TeaModel {
            /// <summary>
            /// The time when the network ACL was created.
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
            /// The information about the outbound rules of the network ACL.
            /// </summary>
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries EgressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntries : TeaModel {
                [NameInMap("EgressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry : TeaModel {
                    /// <summary>
                    /// The description of the outbound rule.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The destination CIDR block.
                    /// </summary>
                    [NameInMap("DestinationCidrIp")]
                    [Validation(Required=false)]
                    public string DestinationCidrIp { get; set; }

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
                    /// - **accept**: allows network traffic.
                    /// - **drop**: blocks network traffic.
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// The destination port range of the outbound traffic. 
                    /// 
                    /// - If **Protocol** of the outbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which indicates all ports.
                    /// - If **Protocol** of the outbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**, which indicates port 1 to port 200, or port 80. Valid values for a port: **1** to **65535**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The protocol. Valid values:
                    /// 
                    /// - **icmp**: ICMP
                    /// - **gre**: GRE
                    /// - **tcp**: TCP
                    /// - **udp**: UDP
                    /// - **all**: all protocols
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

            }

            /// <summary>
            /// The information about the inbound rules of the network ACL.
            /// </summary>
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries IngressAclEntries { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntries : TeaModel {
                [NameInMap("IngressAclEntry")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry : TeaModel {
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
                    /// The action to be performed on network traffic that matches the rule. Valid values:
                    /// 
                    /// *   **accept**: allows network traffic.
                    /// *   **drop**: blocks network traffic.
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// The destination port range of the inbound traffic.
                    /// 
                    /// *   If **Protocol** of the inbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which indicates all ports.
                    /// *   If **Protocol** of the inbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**, which indicates port 1 to port 200, or port 80. Valid values for a port: **1** to **65535**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The protocol. Valid values:
                    /// 
                    /// *   **icmp**: ICMP
                    /// *   **gre**: GRE
                    /// *   **tcp**: TCP
                    /// *   **udp**: UDP
                    /// *   **all**: all protocols
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The source CIDR block.
                    /// </summary>
                    [NameInMap("SourceCidrIp")]
                    [Validation(Required=false)]
                    public string SourceCidrIp { get; set; }

                }

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
            /// The ID of the Alibaba Cloud account to which the network ACL belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// The region ID of the network ACL.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The details about the resource that is associated with the network ACL.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources Resources { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResources : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource> Resource { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeResourcesResource : TeaModel {
                    /// <summary>
                    /// The ID of the associated resource.
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// The type of resource with which you want to associate the network ACL. The value is set to **VSwitch**.
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    /// <summary>
                    /// The status of the associated resource. Valid values:
                    /// 
                    /// - **BINDED**: The resource is associated with the network ACL.
                    /// - **BINDING**: The resource is being associated with the network ACL.
                    /// - **UNBINDING**: The resource is disassociated from the network ACL.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// The status of the associated resource. Valid values:
            /// 
            /// *   **Available**
            /// *   **Modifying**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag list.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags Tags { get; set; }
            public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag> Tag { get; set; }
                public class DescribeNetworkAclAttributesResponseBodyNetworkAclAttributeTagsTag : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) with which the network ACL is associated.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
