// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class RemoveEntriesFromAclRequest : TeaModel {
        /// <summary>
        /// The entries (IP addresses or CIDR blocks) that you want to delete from the ACL. You can delete a maximum of 20 entries at a time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<RemoveEntriesFromAclRequestAclEntries> AclEntries { get; set; }
        public class RemoveEntriesFromAclRequestAclEntries : TeaModel {
            /// <summary>
            /// The IP address (192.168.XX.XX) or CIDR block (10.0.XX.XX/24) that you want to delete from the ACL. You can delete a maximum of 50 entries at a time.
            /// 
            /// >  This parameter is required.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        /// <summary>
        /// The ACL ID.
        /// 
        /// This parameter is required.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
