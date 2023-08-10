// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationProvisioningScopeResponseBody : TeaModel {
        /// <summary>
        /// The scope of account synchronization.
        /// </summary>
        [NameInMap("ApplicationProvisioningScope")]
        [Validation(Required=false)]
        public GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope ApplicationProvisioningScope { get; set; }
        public class GetApplicationProvisioningScopeResponseBodyApplicationProvisioningScope : TeaModel {
            /// <summary>
            /// The list of organizational units that are authorized for account synchronization.
            /// </summary>
            [NameInMap("OrganizationalUnitIds")]
            [Validation(Required=false)]
            public List<string> OrganizationalUnitIds { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
