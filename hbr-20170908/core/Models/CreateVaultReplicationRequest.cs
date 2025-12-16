// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateVaultReplicationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ReplicationSourceRegionId")]
        [Validation(Required=false)]
        public string ReplicationSourceRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("ReplicationSourceVaultId")]
        [Validation(Required=false)]
        public string ReplicationSourceVaultId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-*********************</para>
        /// </summary>
        [NameInMap("ReplicationTargetVaultId")]
        [Validation(Required=false)]
        public string ReplicationTargetVaultId { get; set; }

    }

}
