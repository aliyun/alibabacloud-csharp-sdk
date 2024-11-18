// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListBackupDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>redundant</para>
        /// </summary>
        [NameInMap("backupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hgprecn-cn-wwoxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
