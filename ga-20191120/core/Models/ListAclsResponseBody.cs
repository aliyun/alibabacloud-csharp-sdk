// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAclsResponseBody : TeaModel {
        /// <summary>
        /// The network ACLs.
        /// </summary>
        [NameInMap("Acls")]
        [Validation(Required=false)]
        public List<ListAclsResponseBodyAcls> Acls { get; set; }
        public class ListAclsResponseBodyAcls : TeaModel {
            /// <summary>
            /// The ID of the network ACL.
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// The name of the network ACL.
            /// </summary>
            [NameInMap("AclName")]
            [Validation(Required=false)]
            public string AclName { get; set; }

            /// <summary>
            /// The status of the network ACL. Valid values:
            /// 
            /// *   **init**: The network ACL is being initialized.
            /// *   **active**: The network ACL is available.
            /// *   **configuring**: The network ACL is being configured.
            /// *   **updating**: The network ACL is being updated.
            /// *   **deleting:** The network ACL is being deleted.
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// The IP version of the network ACL. Valid values:
            /// 
            /// *   **IPv4**
            /// *   **IPv6**
            /// </summary>
            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags of the network ACL.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAclsResponseBodyAclsTags> Tags { get; set; }
            public class ListAclsResponseBodyAclsTags : TeaModel {
                /// <summary>
                /// The tag key of the network ACL.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the network ACL.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is returned, the value is the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        public int? TotalCount { get; set; }

    }

}
