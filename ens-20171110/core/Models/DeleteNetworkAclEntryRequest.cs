// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNetworkAclEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL for which you want to delete a rule.
        /// </summary>
        [NameInMap("NetworkAclEntryId")]
        [Validation(Required=false)]
        public string NetworkAclEntryId { get; set; }

    }

}
