// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateNetworkAclEntriesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EgressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestEgressAclEntries> EgressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestEgressAclEntries : TeaModel {
            /// <summary>
            /// The description of the outbound rule.
            /// 
            /// The description must be 1 to 256 characters in length, and cannot start with `http://` or `https://`.
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
            /// The type of the rule. Set the value to **custom**, which specifies custom rules.
            /// </summary>
            [NameInMap("EntryType")]
            [Validation(Required=false)]
            public string EntryType { get; set; }

            /// <summary>
            /// The ID of the outbound rule.
            /// 
            /// Valid values of **N**: **0** to **29**. You can update at most 30 outbound rules.
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// The name of the outbound rule.
            /// 
            /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
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
            /// *   If **Protocol** of the outbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which specifies all ports.
            /// *   If **Protocol** of the outbound rule is set to **tcp** or **udp**, set the port range in the following format: **1/200** or **80/80**, which specifies port 1 to port 200 or port 80. Valid values for a port: **1** to **65535**.
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

        }

        [NameInMap("IngressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestIngressAclEntries> IngressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestIngressAclEntries : TeaModel {
            /// <summary>
            /// The description of the inbound rule.
            /// 
            /// The description must be 1 to 256 characters in length, and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The type of the rule. Set the value to **custom**, which specifies custom rules.
            /// </summary>
            [NameInMap("EntryType")]
            [Validation(Required=false)]
            public string EntryType { get; set; }

            /// <summary>
            /// The ID of the inbound rule.
            /// 
            /// Valid values of **N**: **0** to **29**. You can update at most 30 inbound rules.
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// The name of the inbound rule.
            /// 
            /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
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
            /// The source port range of the inbound rule.
            /// 
            /// *   If **Protocol** of the inbound rule is set to **all**, **icmp**, or **gre**, the port range is **-1/-1**, which specifies all ports.
            /// *   If **Protocol** of the inbound rule is set to **tcp** or **udp**, set the port range in the following format: **1/200** or **80/80**, which specifies port 1 to port 200 or port 80. Valid values for a port: **1** to **65535**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The protocol type. Valid values:
            /// 
            /// *   **icmp**: Internet Control Message Protocol (ICMP)
            /// *   **gre**: Generic Routing Encapsulation (GRE)
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

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the network ACL.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to update outbound rules. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("UpdateEgressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateEgressAclEntries { get; set; }

        /// <summary>
        /// Specifies whether to update inbound rules. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("UpdateIngressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateIngressAclEntries { get; set; }

    }

}
