// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CancelRestoreJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the restore job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-*********************</para>
        /// </summary>
        [NameInMap("RestoreId")]
        [Validation(Required=false)]
        public string RestoreId { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
