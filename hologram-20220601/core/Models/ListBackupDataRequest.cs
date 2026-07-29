// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListBackupDataRequest : TeaModel {
        /// <summary>
        /// <para>The backup type, used to filter snapshots. If you leave this parameter empty, all snapshots are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redundant</para>
        /// </summary>
        [NameInMap("backupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgprecn-cn-wwoxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
