// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeVaultReplicationRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01W3ZZOQ</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-00030j3c******sn</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        [Obsolete]
        public string VaultId { get; set; }

    }

}
