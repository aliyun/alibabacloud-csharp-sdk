// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataBackupsResponseBodyItems> Items { get; set; }
        public class DescribeDataBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The end time of the backup. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T12:01:43Z</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// <para>The end time of the backup in local time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22 20:00:25</para>
            /// </summary>
            [NameInMap("BackupEndTimeLocal")]
            [Validation(Required=false)]
            public string BackupEndTimeLocal { get; set; }

            /// <summary>
            /// <para>The backup method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Physical</b>: physical backup.</description></item>
            /// <item><description><b>Snapshot</b>: snapshot backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Physical</para>
            /// </summary>
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            /// <summary>
            /// <para>The backup mode.</para>
            /// <para>Valid values for full backups:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: automatic backup performed by the system.</description></item>
            /// <item><description><b>Manual</b>: manual backup.</description></item>
            /// </list>
            /// <para>Valid values for restorable points:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: restorable point generated after a full backup.</description></item>
            /// <item><description><b>Manual</b>: restorable point manually triggered by the user.</description></item>
            /// <item><description><b>Period</b>: restorable point periodically triggered by the backup policy.</description></item>
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
            /// <para>2167808</para>
            /// </summary>
            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            /// <summary>
            /// <para>The start time of the backup. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format and in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T12:00:25Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The start time of the backup in local time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2011-05-30 03:29:00</para>
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
            /// <para>adbpgbackup_555*****_20211222200019</para>
            /// </summary>
            [NameInMap("BaksetName")]
            [Validation(Required=false)]
            public string BaksetName { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>Full backup: the timestamp of the consistency point in time.</description></item>
            /// <item><description>Restorable point: the timestamp of the restorable point in time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1576506856</para>
            /// </summary>
            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public long? ConsistentTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-bp**************-master</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E387971-33A5-5019-AD7F-DC**********</para>
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
