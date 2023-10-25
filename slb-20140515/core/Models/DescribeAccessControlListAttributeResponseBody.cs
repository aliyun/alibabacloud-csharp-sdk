// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeAccessControlListAttributeResponseBody : TeaModel {
        /// <summary>
        /// The IP entries that you want to remove from the network ACL. Valid values:
        /// 
        /// *   **entry**: the IP address or CIDR block that you want to remove from the network ACL. Separate multiple IP addresses or CIDR blocks with commas (,).
        /// *   **comment**: the description of the network ACL.
        /// </summary>
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyAclEntrys AclEntrys { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyAclEntrys : TeaModel {
            [NameInMap("AclEntry")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry> AclEntry { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyAclEntrysAclEntry : TeaModel {
                /// <summary>
                /// The description of the ACL entry.
                /// </summary>
                [NameInMap("AclEntryComment")]
                [Validation(Required=false)]
                public string AclEntryComment { get; set; }

                /// <summary>
                /// The IP address specified in the ACL entry.
                /// </summary>
                [NameInMap("AclEntryIP")]
                [Validation(Required=false)]
                public string AclEntryIP { get; set; }

            }

        }

        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// The ACL name. The name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), hyphens (-), forward slashes (/), and underscores (\_). The name of each ACL must be unique within a region. Fuzzy match is supported.
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// The IP version. Valid values: **ipv4** and **ipv6**.
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The time when the ACL was created. The time follows the `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The listeners that are associated with the network ACL.
        /// </summary>
        [NameInMap("RelatedListeners")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyRelatedListeners RelatedListeners { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyRelatedListeners : TeaModel {
            [NameInMap("RelatedListener")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener> RelatedListener { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyRelatedListenersRelatedListener : TeaModel {
                /// <summary>
                /// The type of ACL. Valid values:
                /// 
                /// *   **black**
                /// *   **white**
                /// </summary>
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                /// <summary>
                /// The frontend port of the listener with which the ACL is associated.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// The CLB instance ID.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The type of protocol that the associated listener uses.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeAccessControlListAttributeResponseBodyTags Tags { get; set; }
        public class DescribeAccessControlListAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeAccessControlListAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeAccessControlListAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The total number of access control entries.
        /// </summary>
        [NameInMap("TotalAclEntry")]
        [Validation(Required=false)]
        public int? TotalAclEntry { get; set; }

    }

}
