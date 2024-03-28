/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class AddEntriesToAclRequest : TeaModel {
        /// <summary>
        /// The IP addresses or CIDR blocks that you want to add to the ACL. You can add at most 20 entries in each request.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<AddEntriesToAclRequestAclEntries> AclEntries { get; set; }
        public class AddEntriesToAclRequestAclEntries : TeaModel {
            /// <summary>
            /// The IP address (192.168.XX.XX) or CIDR block (10.0.XX.XX/24) that you want to add to the ACL. You can add at most 20 entries in each request.
            /// 
            /// > This parameter is required.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// The description of the entry.
            /// 
            /// You can add the descriptions of up to 20 entries in each request.
            /// 
            /// The description must be 1 to 256 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_).
            /// </summary>
            [NameInMap("EntryDescription")]
            [Validation(Required=false)]
            public string EntryDescription { get; set; }

        }

        /// <summary>
        /// The ACL ID.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

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
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
