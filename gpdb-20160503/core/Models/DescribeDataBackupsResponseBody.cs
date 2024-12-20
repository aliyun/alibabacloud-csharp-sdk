// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataBackupsResponseBodyItems> Items { get; set; }
        public class DescribeDataBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The UTC time when the backup ended. The time is in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T12:01:43Z</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// <para>The local time when the backup ended. The time is in the yyyy-MM-dd HH:mm:ss format. The time is your local time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22 20:00:25</para>
            /// </summary>
            [NameInMap("BackupEndTimeLocal")]
            [Validation(Required=false)]
            public string BackupEndTimeLocal { get; set; }

            /// <summary>
            /// <para>The method that is used to generate the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Logical</b>: logical backup</description></item>
            /// <item><description><b>Physical</b>: physical backup</description></item>
            /// <item><description><b>Snapshot</b>: snapshot backup</description></item>
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
            /// <para>Valid values for full backup:</para>
            /// <list type="bullet">
            /// <item><description>Automated: automatic backup</description></item>
            /// <item><description>Manual: manual backup</description></item>
            /// </list>
            /// <para>Valid values for point-in-time backup:</para>
            /// <list type="bullet">
            /// <item><description>Automated: point-in-time backup after full backup</description></item>
            /// <item><description>Manual: manual point-in-time backup</description></item>
            /// <item><description>Period: point-in-time backup that is triggered by a backup policy</description></item>
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
            /// <para>The UTC time when the backup started. The time is in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-22T12:00:25Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The local time when the backup started. The time is in the yyyy-MM-dd HH:mm:ss format. The time is your local time.</para>
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
            /// <item><description>Success</description></item>
            /// <item><description>Failure</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The name of a point-in-time backup set or the full backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adbpgbackup_555*****_20211222200019</para>
            /// </summary>
            [NameInMap("BaksetName")]
            [Validation(Required=false)]
            public string BaksetName { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>For full backup, this parameter indicates the point in time at which the data in the data backup file is consistent.</description></item>
            /// <item><description>For point-in-time backup, this parameter indicates that the returned point in time is a timestamp.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1576506856</para>
            /// </summary>
            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public long? ConsistentTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gp-bp**************-master</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATA: full backup</description></item>
            /// <item><description>RESTOREPOI: point-in-time backup</description></item>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>3E387971-33A5-5019-AD7F-DC**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total backup set size. Unit: Byte.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("TotalBackupSize")]
        [Validation(Required=false)]
        public long? TotalBackupSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
