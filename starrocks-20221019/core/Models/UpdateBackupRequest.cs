// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class UpdateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the cluster is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the backup job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bk-t1232839</para>
        /// </summary>
        [NameInMap("backupTaskId")]
        [Validation(Required=false)]
        public string BackupTaskId { get; set; }

        /// <summary>
        /// <para>The description of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backupTask-desc1</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
