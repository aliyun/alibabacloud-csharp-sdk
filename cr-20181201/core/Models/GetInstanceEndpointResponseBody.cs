// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceEndpointResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the access control list (ACL) feature is enabled.
        /// </summary>
        [NameInMap("AclEnable")]
        [Validation(Required=false)]
        public bool? AclEnable { get; set; }

        /// <summary>
        /// The ACLs.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<GetInstanceEndpointResponseBodyAclEntries> AclEntries { get; set; }
        public class GetInstanceEndpointResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// Remarks for public IP address whitelists.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The public IP address whitelist.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<GetInstanceEndpointResponseBodyDomains> Domains { get; set; }
        public class GetInstanceEndpointResponseBodyDomains : TeaModel {
            /// <summary>
            /// The domain name that is used to access the Container Registry Enterprise Edition instance.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The type of the domain name. Valid values:
            /// 
            /// *   `SYSTEM`: a system domain name.
            /// *   `USER`: a user domain name.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Indicates whether the ACL feature is enabled.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the instance.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
