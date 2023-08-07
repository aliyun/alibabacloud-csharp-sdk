// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNetworkAclResponseBody : TeaModel {
        /// <summary>
        /// The attributes of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclAttribute")]
        [Validation(Required=false)]
        public CreateNetworkAclResponseBodyNetworkAclAttribute NetworkAclAttribute { get; set; }
        public class CreateNetworkAclResponseBodyNetworkAclAttribute : TeaModel {
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
            /// The details about the outbound rule.
            /// </summary>
            [NameInMap("EgressAclEntries")]
            [Validation(Required=false)]
            public CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntries EgressAclEntries { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntries : TeaModel {
                [NameInMap("EgressAclEntry")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeEgressAclEntriesEgressAclEntry : TeaModel {
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
                    /// The action that is performed on network traffic that matches the rule. Valid values:
                    /// 
                    /// - **accept**: allows the network traffic.
                    /// - **drop**: blocks the network traffic.
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    /// <summary>
                    /// The destination port range of the outbound rule. 
                    /// 
                    /// - If **Protocol** of the outbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which indicates all ports.
                    /// - If **Protocol** of the outbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 1/200 indicates port 1 to port 200. 80/80 indicates port 80. Valid values for a port: **1** to **65535**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The protocol type. Valid values:
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
            /// The details about the inbound rule.
            /// </summary>
            [NameInMap("IngressAclEntries")]
            [Validation(Required=false)]
            public CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntries IngressAclEntries { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntries : TeaModel {
                [NameInMap("IngressAclEntry")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeIngressAclEntriesIngressAclEntry : TeaModel {
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
                    /// *   If **Protocol** of the inbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which indicates all ports.
                    /// *   If **Protocol** of the inbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 1/200 indicates port 1 to port 200. 80/80 indicates port 80. Valid values for a port: **1** to **65535**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// The protocol type. Valid values:
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
            public CreateNetworkAclResponseBodyNetworkAclAttributeResources Resources { get; set; }
            public class CreateNetworkAclResponseBodyNetworkAclAttributeResources : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<CreateNetworkAclResponseBodyNetworkAclAttributeResourcesResource> Resource { get; set; }
                public class CreateNetworkAclResponseBodyNetworkAclAttributeResourcesResource : TeaModel {
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
            /// The status of the network ACL. Valid values:
            /// 
            /// *   **Available**: The network ACL is available.
            /// *   **Modifying**: The network ACL is being configured.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the VPC to which the network ACL belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
