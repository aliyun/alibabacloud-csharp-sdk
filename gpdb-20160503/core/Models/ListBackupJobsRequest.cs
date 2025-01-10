// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListBackupJobsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Automated</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
