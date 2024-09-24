// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp when the backup task ended. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699600611000</para>
        /// </summary>
        [NameInMap("BackupEndTime")]
        [Validation(Required=false)]
        public long? BackupEndTime { get; set; }

        /// <summary>
        /// <para>The timestamp when the backup task started. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699514211000</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public long? BackupStartTime { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The information that you want to use to identify the servers protected by the anti-ransomware policy. You can enter the IP address or ID of a server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The backup task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BACKUP_COMPLETE</b>: The backup task is successful.</description></item>
        /// <item><description><b>BACKUP_FAILED</b>: The backup task failed.</description></item>
        /// <item><description><b>PARTIAL_COMPLETE</b>: The backup task is partially successful.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
