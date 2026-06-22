// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordRequest : TeaModel {
        /// <summary>
        /// <para>The backup end time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699600611000</para>
        /// </summary>
        [NameInMap("BackupEndTime")]
        [Validation(Required=false)]
        public long? BackupEndTime { get; set; }

        /// <summary>
        /// <para>The backup start time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699514211000</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public long? BackupStartTime { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates the first page.</para>
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
        /// <para>The maximum number of entries per page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
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
        /// <item><description><b>BACKUP_COMPLETE</b>: backup succeeded</description></item>
        /// <item><description><b>BACKUP_FAILED</b>: backup failed</description></item>
        /// <item><description><b>PARTIAL_COMPLETE</b>: partial backup succeeded.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
