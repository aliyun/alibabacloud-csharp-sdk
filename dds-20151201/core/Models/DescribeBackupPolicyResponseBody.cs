// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The frequency at which high-frequency backup is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: High-frequency backup is disabled.</description></item>
        /// <item><description><b>15</b>: every 15 minutes.</description></item>
        /// <item><description><b>30</b>: every 30 minutes.</description></item>
        /// <item><description><b>60</b>: every hour.</description></item>
        /// <item><description><b>120</b>: every 2 hours.</description></item>
        /// <item><description><b>180</b>: every 3 hours.</description></item>
        /// <item><description><b>240</b>: every 4 hours.</description></item>
        /// <item><description><b>360</b>: every 6 hours.</description></item>
        /// <item><description><b>480</b>: every 8 hours.</description></item>
        /// <item><description><b>720</b>: every 12 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        /// <summary>
        /// <para>The retention period of the backup data. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup retention policy configured for the instance. Valid values:</para>
        /// <ol>
        /// <item><description>0: All backup sets are immediately deleted when the instance is released.</description></item>
        /// <item><description>1: Automatic backup is performed and the backup set is retained for a long period of time when the instance is released.</description></item>
        /// <item><description>2: Automatic backup is performed and all backup sets are retained for a long period of time when the instance is released.</description></item>
        /// </ol>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2779111.html">Retain the backup files of an ApsaraDB for MongoDB instance for a long period of time</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The retention period of Cross-regional backup.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("CrossBackupPeriod")]
        [Validation(Required=false)]
        public string CrossBackupPeriod { get; set; }

        /// <summary>
        /// <para>The retention type of Cross-regional  log backup.</para>
        /// <list type="bullet">
        /// <item><description>delay : retain the backup for a period of time.</description></item>
        /// <item><description>never : retain the backup permanently.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossLogRetentionType")]
        [Validation(Required=false)]
        public string CrossLogRetentionType { get; set; }

        /// <summary>
        /// <para>The retention time of Cross-regional log backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossLogRetentionValue")]
        [Validation(Required=false)]
        public int? CrossLogRetentionValue { get; set; }

        /// <summary>
        /// <para>The retention type of Cross-regional backup.</para>
        /// <list type="bullet">
        /// <item><description>delay : retain the backup for a period of time.</description></item>
        /// <item><description>never : retain the backup permanently.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>delay</para>
        /// </summary>
        [NameInMap("CrossRetentionType")]
        [Validation(Required=false)]
        public string CrossRetentionType { get; set; }

        /// <summary>
        /// <para>The retention time of Cross-regional backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CrossRetentionValue")]
        [Validation(Required=false)]
        public int? CrossRetentionValue { get; set; }

        /// <summary>
        /// <para>The region ID of the cross-regional backup..</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): The log backup feature is disabled.</description></item>
        /// <item><description><b>1</b>: The log backup feature is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Whether to turn on cross-regional log backup.</para>
        /// <list type="bullet">
        /// <item><description>1: turn on . Used for sharded cluster.</description></item>
        /// <item><description>0: turn off. Used for replicate set.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrossLogBackup")]
        [Validation(Required=false)]
        public int? EnableCrossLogBackup { get; set; }

        /// <summary>
        /// <para>The retention period of high-frequency backups. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighFrequencyBackupRetention")]
        [Validation(Required=false)]
        public string HighFrequencyBackupRetention { get; set; }

        /// <summary>
        /// <para>The number of days for which log backups are retained. Valid values: 7 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The day of a week on which to back up data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time range during which the backup was created. The time follows the ISO 8601 standard in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time of next standard backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-19T19:11Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        [NameInMap("PreserveOneEachHour")]
        [Validation(Required=false)]
        public bool? PreserveOneEachHour { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A9464CA-F7DC-5434-90B1-DF7F197C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: single-digit second backup</description></item>
        /// <item><description><b>Standard</b> (default): standard backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
