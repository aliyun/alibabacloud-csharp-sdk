// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class RemoveEntriesFromAclRequest : TeaModel {
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<RemoveEntriesFromAclRequestAclEntries> AclEntries { get; set; }
        public class RemoveEntriesFromAclRequestAclEntries : TeaModel {
            /// <summary>
            /// The client token that is used to ensure the idempotence of the request.
            /// 
            /// You can use the client to generate the value, but you must ensure that it is unique among all requests. The client token can contain only ASCII characters.
            /// 
            /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// The IP address or CIDR block that you want to delete from the ACL.
        /// 
        /// You can delete at most 20 entries in each request.
        /// 
        /// >  This parameter is required.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// Specifies whether to check the request without performing the operation. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. If the request passes the check, an HTTP 2xx status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the ACL.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
