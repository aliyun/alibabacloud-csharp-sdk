// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseDataBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSupabaseDataBackupsResponseBodyItems> Items { get; set; }
        public class ListSupabaseDataBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The end time of the backup. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-09T01:24:44Z</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// <para>The local time representation of the backup end time. Format: yyyy-MM-ddTHH:mm:ssZ. The current return value is in Beijing time (UTC+8). The trailing Z is a fixed character in the compatibility format and does not indicate the zero time zone. To parse the time in a standard format, use BackupEndTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-09T09:24:44Z</para>
            /// </summary>
            [NameInMap("BackupEndTimeLocal")]
            [Validation(Required=false)]
            public string BackupEndTimeLocal { get; set; }

            /// <summary>
            /// <para>The backup method. Valid values: Physical: physical backup; Snapshot: snapshot backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Snapshot</para>
            /// </summary>
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            /// <summary>
            /// <para>The backup mode.</para>
            /// <para>Valid values for automatic backups:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: automatic system backup.</description></item>
            /// <item><description><b>Manual</b>: manual backup.</description></item>
            /// </list>
            /// <para>Valid values for restorable points:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: the restorable point after a automatic backup.</description></item>
            /// <item><description><b>Manual</b>: the restorable point manually triggered by the user.</description></item>
            /// <item><description><b>Period</b>: the restorable point triggered periodically based on the backup policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>The ID of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111111111</para>
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            /// <summary>
            /// <para>The size of the backup file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10737418240</para>
            /// </summary>
            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            /// <summary>
            /// <para>The start time of the backup. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-09T01:23:02Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The local time representation of the backup start time. Format: yyyy-MM-ddTHH:mm:ssZ. The current return value is in Beijing time (UTC+8). The trailing Z is a fixed character in the compatibility format and does not indicate the zero time zone. To parse the time in a standard format, use BackupStartTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-09T09:23:02Z</para>
            /// </summary>
            [NameInMap("BackupStartTimeLocal")]
            [Validation(Required=false)]
            public string BackupStartTimeLocal { get; set; }

            /// <summary>
            /// <para>The status of the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: successful.</description></item>
            /// <item><description><b>Failure</b>: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The name of the restorable point or the full backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logic_backup</para>
            /// </summary>
            [NameInMap("BaksetName")]
            [Validation(Required=false)]
            public string BaksetName { get; set; }

            /// <summary>
            /// <para>The consistency point in time. The value is a UNIX timestamp in seconds. For a full backup, this parameter indicates the consistency point in time of the backup. For a restorable point, this parameter indicates the point in time to which data can be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1791508983</para>
            /// </summary>
            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public long? ConsistentTime { get; set; }

            /// <summary>
            /// <para>The backup type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DATA</b>: full backup.</description></item>
            /// <item><description><b>RESTOREPOI</b>: restorable point.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. You can use this value as the NextToken parameter in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of backup sets on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total size of the backup sets. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("TotalBackupSize")]
        [Validation(Required=false)]
        public long? TotalBackupSize { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
