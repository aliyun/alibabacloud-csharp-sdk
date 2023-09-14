// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetAclResponseBody : TeaModel {
        /// <summary>
        /// The state of the network ACL. Valid values:
        /// 
        /// *   **init**: The network ACL is being initialized.
        /// *   **active**: The network ACL is available.
        /// *   **configuring**: The network ACL is being configured.
        /// *   **updating**: The network ACL is being updated.
        /// *   **deleting**: The network ACL is being deleted.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyAclEntries> AclEntries { get; set; }
        public class GetAclResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// The list of network ACL entries that are returned. A maximum of 20 network ACL entries can be returned.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// The network ACL entry.
            /// </summary>
            [NameInMap("EntryDescription")]
            [Validation(Required=false)]
            public string EntryDescription { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// The IP version of the network ACL. Valid values:
        /// 
        /// *   **IPv4**
        /// *   **IPv6**
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The description of the network ACL entry.
        /// </summary>
        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyRelatedListeners> RelatedListeners { get; set; }
        public class GetAclResponseBodyRelatedListeners : TeaModel {
            /// <summary>
            /// The type of the network ACL.
            /// 
            /// *   **White**: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists apply to scenarios in which you want to allow only specified IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. After you configure a whitelist for a listener, only requests from the IP addresses that are added to the whitelist are forwarded by the listener. If the whitelist is enabled but no IP addresses are added to the network ACL, the listener does not forward requests.
            /// *   **Black**: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are blocked. Blacklists apply to scenarios in which you want to deny access from specific IP addresses to an application. If the blacklist is enabled but no IP addresses are added to the network ACL, the listener forwards all requests.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The ID of the listener.
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// The listeners that are associated with the network ACL.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

        }

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the network ACL.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetAclResponseBodyTags> Tags { get; set; }
        public class GetAclResponseBodyTags : TeaModel {
            /// <summary>
            /// The tags of the ACL.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag key
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
