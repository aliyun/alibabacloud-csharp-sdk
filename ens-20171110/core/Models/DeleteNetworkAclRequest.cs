// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNetworkAclRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

    }

}
