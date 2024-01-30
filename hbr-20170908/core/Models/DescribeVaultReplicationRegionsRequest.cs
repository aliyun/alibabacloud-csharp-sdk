// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeVaultReplicationRegionsRequest : TeaModel {
        /// <summary>
        /// The access token.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        [Obsolete]
        public string VaultId { get; set; }

    }

}
