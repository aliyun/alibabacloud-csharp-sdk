// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the backup. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699600611000</para>
        /// </summary>
        [NameInMap("BackupEndTime")]
        [Validation(Required=false)]
        public long? BackupEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the backup. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699514211000</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public long? BackupStartTime { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The identification information of the server protected by the anti-ransomware policy that you want to query. You can enter the IP address or instance ID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. The default number of entries per page for paging is 20. If the PageSize parameter is empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave the PageSize parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of backup task statuses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BACKUP_COMPLETE</b>: The backup is successful.</description></item>
        /// <item><description><b>BACKUP_FAILED</b>: The backup fails.</description></item>
        /// <item><description><b>PARTIAL_COMPLETE</b>: The backup is partially successful.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
