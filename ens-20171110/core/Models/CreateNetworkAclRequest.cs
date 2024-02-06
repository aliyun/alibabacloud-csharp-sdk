// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkAclRequest : TeaModel {
        /// <summary>
        /// The description of the network ACL.
        /// 
        /// The description must be 1 to 256 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Enter a name for the network ACL.
        /// 
        /// The name must be 1 to 128 characters in length and cannot start with http:// or https://.
        /// </summary>
        [NameInMap("NetworkAclName")]
        [Validation(Required=false)]
        public string NetworkAclName { get; set; }

    }

}
