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
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the request for potential issues, including the AccessKey pair, the permissions of the RAM user, and the required parameters. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The information about the outbound rules.
        /// </summary>
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
            /// The IP version. Valid values:
            /// 
            /// *   **IPv4** (default)
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The ID of the outbound rule.
            /// 
            /// Valid values of **N**: **0** to **99**. You can specify at most 100 outbound rules.
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// The name of the outbound rule.
            /// 
            /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// The action to be performed on network traffic that matches the rule. Valid values:
            /// 
            /// *   **accept**
            /// *   **drop**
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The destination port range of the outbound traffic.
            /// 
            /// *   If the **protocol** of the outbound rule is set to **all**, **icmp**, or **gre**, the port range is -1/-1, which specified all ports.
            /// *   If the **protocol** of the outbound rule is set to **tcp** or **udp**, set the port range in the following format: **1/200** or **80/80**, which specifies port 1 to port 200 or port 80. Valid values for a port: **1** to **65535**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The protocol. Valid values:
            /// 
            /// *   **icmp**
            /// *   **gre**
            /// *   **tcp**
            /// *   **udp**
            /// *   **all**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// The information about the inbound rule.
        /// </summary>
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
            /// The IP version. Valid values:
            /// 
            /// *   **IPv4** (default)
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The ID of the inbound rule.
            /// 
            /// Valid values of **N**: **0** to **99**. You can specify at most 100 inbound rules.
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// The name of the inbound rule.
            /// 
            /// The name must be 1 to 128 characters in length and cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// The action to be performed on network traffic that matches the rule. Valid values:
            /// 
            /// *   **accept**
            /// *   **drop**
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The source port range of the inbound rule.
            /// 
            /// *   If the **protocol** of the inbound rule is set to **all**, **icmp**, or **gre**, the port range is -1/-1, which specifies all ports.
            /// *   If the **protocol** of the inbound rule is set to **tcp** or **udp**, set the port range in the following format: **1/200** or **80/80**, which specifies port 1 to port 200 or port 80. Valid ports: **1** to **65535**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The protocol. Valid values:
            /// 
            /// *   **icmp**
            /// *   **gre**
            /// *   **tcp**
            /// *   **udp**
            /// *   **all**
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the network ACL.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// >  This parameter cannot be used to add outbound rules to ACLs. If you want to add more outbound rules to ACLs, specify both the existing rule and the rule that you want to add when you call this API operation. If you specify only the rule that you want to add, it overwrites the existing rule.
        /// </summary>
        [NameInMap("UpdateEgressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateEgressAclEntries { get; set; }

        /// <summary>
        /// Specifies whether to update inbound rules. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// >  This parameter cannot be used to add inbound rules to ACLs. If you want to add more inbound rules to ACLs, you must specify both the existing rule and the rule that you want to add when you call this API operation. If you specify only the rule that you want to add, it overwrites the existing rule.
        /// </summary>
        [NameInMap("UpdateIngressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateIngressAclEntries { get; set; }

    }

}
