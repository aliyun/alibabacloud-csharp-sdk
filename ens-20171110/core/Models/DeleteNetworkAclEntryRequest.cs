// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNetworkAclEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the network ACL entry to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nae-5****</para>
        /// </summary>
        [NameInMap("NetworkAclEntryId")]
        [Validation(Required=false)]
        public string NetworkAclEntryId { get; set; }

    }

}
