// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of archived backup files that are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// <para>The cycle based on which archived backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByMonth</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// <para>The number of days for which archived backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup interval. Unit: minutes.</para>
        /// <list type="bullet">
        /// <item><description>If the instance runs MySQL, the interval is the same as the value of the Snapshot Backup Start Time parameter rather than the Snapshot Backup Period parameter in the ApsaraDB RDS console. For more information, see <a href="https://help.aliyun.com/document_detail/98818.html">Back up an ApsaraDB RDS for MySQL instance</a>.</description></item>
        /// <item><description>If the instance runs SQL Server, the interval is the same as the log backup frequency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// <para>The backup method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Physical</b>: physical backup</description></item>
        /// <item><description><b>Snapshot</b>: snapshot backup</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the instance runs SQL Server and uses cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Physical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The backup settings of the secondary instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Secondary instance preferred</description></item>
        /// <item><description><b>2</b>: Primary instance preferred</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for instances that run SQL Server on RDS Cluster Edition. This parameter is returned only when SupportModifyBackupPriority is set to True.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// <para>The number of days for which data backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable the single-digit second backup feature. This feature allows ApsaraDB RDS to complete a backup within single-digit seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: The single-digit second backup feature is enabled.</description></item>
        /// <item><description><b>Standard</b>: The single-digit second backup feature is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when you set the <b>BackupPolicyMode</b> parameter to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The method that is used to compress backup data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Backup data is not compressed.</description></item>
        /// <item><description><b>1</b>: Backup data is compressed by using zlib.</description></item>
        /// <item><description><b>2</b>: Backup data is compressed by using zlib that invokes more than one thread in parallel for each backup.</description></item>
        /// <item><description><b>4</b>: Backup data is compressed by using QuickLZ and can be used to restore individual databases or tables.</description></item>
        /// <item><description><b>8</b>: Backup data is compressed by using QuickLZ but cannot be used to restore individual databases or tables.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Incremental backup is enabled.</description></item>
        /// <item><description><b>False</b>: Incremental backup is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Indicates whether the point-in-time restoration (PITR) feature is enabled. The PITR feature is an enhancement of the log backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only when the instance runs MySQL. For more information, see <a href="https://help.aliyun.com/document_detail/2666046.html">Configure the PITR feature</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// <para>Indicates whether the log backup deletion feature is enabled. If the disk usage exceeds 80% or the remaining disk space is less than 5 GB on the instance, this feature deletes binary log files. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b></description></item>
        /// <item><description><b>Enable</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The number of hours for which log backup files are retained on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum storage usage that is allowed for log files on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The backup frequency of logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LogInterval</b>: Log backups are performed every 30 minutes.</description></item>
        /// <item><description>Default value: same as the value of the <b>PreferredBackupPeriod</b> parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only when the instance runs SQL Server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LogInterval</para>
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// <para>The number of binary log files that you want to retain on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// <para>The number of days for which log backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The number of days during which you can restore data of the instance to any point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PitrRetentionPeriod")]
        [Validation(Required=false)]
        public int? PitrRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The cycle based on which you want to perform a backup. Separate multiple values with commas (,). Valid values:</para>
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
        /// <para>Monday,Wednesday,Friday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time when a data backup is performed. The time follows the ISO 8601 standard in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time when the next backup is performed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-19T15:15Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The policy that is used to retain archived backup files if the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: No archived backup files are retained.</description></item>
        /// <item><description><b>Lastest</b>: Only the last archived backup file is retained.</description></item>
        /// <item><description><b>All</b>: All archived backup files are retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B87E2AB3-B7C9-4394-9160-7F639F732031</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the backup settings of a secondary instance can be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b></description></item>
        /// <item><description><b>False</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("SupportModifyBackupPriority")]
        [Validation(Required=false)]
        public bool? SupportModifyBackupPriority { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SupportReleasedKeep")]
        [Validation(Required=false)]
        public int? SupportReleasedKeep { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance supports snapshot backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The instance supports snapshot backups.</description></item>
        /// <item><description><b>0</b>: The instance does not support snapshot backups.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only when the instance runs SQL Server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportVolumeShadowCopy")]
        [Validation(Required=false)]
        public int? SupportVolumeShadowCopy { get; set; }

        /// <summary>
        /// <para>Indicates whether log backups for SQL Server are performed verery five minutes.</para>
        /// <list type="bullet">
        /// <item><description>0: No</description></item>
        /// <item><description>1: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SupportsHighFrequencyBackup")]
        [Validation(Required=false)]
        public long? SupportsHighFrequencyBackup { get; set; }

    }

}
