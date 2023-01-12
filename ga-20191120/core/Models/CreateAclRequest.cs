// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAclRequest : TeaModel {
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<CreateAclRequestAclEntries> AclEntries { get; set; }
        public class CreateAclRequestAclEntries : TeaModel {
            /// <summary>
            /// The IP address or CIDR block that you want to add to the ACL.
            /// 
            /// You can add up to 20 entries in each request.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// The description of the entry that you want to add to the ACL.
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
        /// The name of the ACL. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// The IP version of the ACL. Valid values:
        /// 
        /// *   **IPv4**
        /// *   **IPv6**
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck the request. Default value: false. Valid values:
        /// 
        /// *   **true**: prechecks the request without performing the operation. The system checks the required parameters, request syntax, and limits. If the request fails the precheck, an error message is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
