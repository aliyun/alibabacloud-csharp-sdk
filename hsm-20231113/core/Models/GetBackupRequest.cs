// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetBackupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backup-fdb897sdf****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

    }

}
