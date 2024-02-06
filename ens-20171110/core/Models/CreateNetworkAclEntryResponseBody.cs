// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkAclEntryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclEntryId")]
        [Validation(Required=false)]
        public string NetworkAclEntryId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
