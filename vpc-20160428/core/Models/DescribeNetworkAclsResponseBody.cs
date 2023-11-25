// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeNetworkAclsResponseBody : TeaModel {
        /// <summary>
        /// The details about the network ACL.
        /// </summary>
        [NameInMap("NetworkAcls")]
        [Validation(Required=false)]
        public DescribeNetworkAclsResponseBodyNetworkAcls NetworkAcls { get; set; }
        public class DescribeNetworkAclsResponseBodyNetworkAcls : TeaModel {
            [NameInMap("NetworkAcl")]
            [Validation(Required=false)]
            public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAcl> NetworkAcl { get; set; }
            public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAcl : TeaModel {
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
                /// The outbound rules.
                /// </summary>
                [NameInMap("EgressAclEntries")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntries EgressAclEntries { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntries : TeaModel {
                    [NameInMap("EgressAclEntry")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntriesEgressAclEntry> EgressAclEntry { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclEgressAclEntriesEgressAclEntry : TeaModel {
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

                        [NameInMap("EntryType")]
                        [Validation(Required=false)]
                        public string EntryType { get; set; }

                        [NameInMap("IpVersion")]
                        [Validation(Required=false)]
                        public string IpVersion { get; set; }

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
                        /// - If **Protocol** of the outbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which specifies all ports.
                        /// - If **Protocol** of the outbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 1/200 indicates port 1 to port 200. 80/80 indicates port 80. Valid values for a port: **1** to **65535**.
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
                /// The inbound rules.
                /// </summary>
                [NameInMap("IngressAclEntries")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntries IngressAclEntries { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntries : TeaModel {
                    [NameInMap("IngressAclEntry")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntriesIngressAclEntry> IngressAclEntry { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclIngressAclEntriesIngressAclEntry : TeaModel {
                        /// <summary>
                        /// The description of the inbound rule.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("EntryType")]
                        [Validation(Required=false)]
                        public string EntryType { get; set; }

                        [NameInMap("IpVersion")]
                        [Validation(Required=false)]
                        public string IpVersion { get; set; }

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
                        /// *   If **Protocol** of the inbound rule is set to **tcp** or **udp**, the port range is in the following format: **1/200** or **80/80**. 1/200 indicates port 1 to port 200. 80/80 indicates port 80. Valid values for a port: **1** to **65535**.
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
                /// The resources that are associated with the network ACL.
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResources Resources { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResources : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResourcesResource> Resource { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclResourcesResource : TeaModel {
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
                        /// - **BINDED**: associated
                        /// - **BINDING**: being associated
                        /// - **UNBINDING**: disassociated
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The status of the network ACL. Valid values:
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
                public DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTags Tags { get; set; }
                public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTagsTag> Tag { get; set; }
                    public class DescribeNetworkAclsResponseBodyNetworkAclsNetworkAclTagsTag : TeaModel {
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
                /// The ID of the associated VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
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
