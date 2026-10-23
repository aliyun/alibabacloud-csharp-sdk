// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogDownloadLinksRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the redo log backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78167430</para>
        /// </summary>
        [NameInMap("BackupLogIds")]
        [Validation(Required=false)]
        public string BackupLogIds { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The validity period of the download links in hours. Valid values: 1 to 596523.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExpireHours")]
        [Validation(Required=false)]
        public int? ExpireHours { get; set; }

    }

}
