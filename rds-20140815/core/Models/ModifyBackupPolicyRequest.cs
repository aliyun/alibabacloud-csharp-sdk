// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of archived backup files that are retained. Default value: <b>1</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when <b>ArchiveBackupKeepPolicy</b> is set to <b>ByMonth</b>: <b>1</b> to <b>31</b>.</description></item>
        /// <item><description>Valid values when <b>ArchiveBackupKeepPolicy</b> is set to <b>ByWeek</b>: <b>1</b> to <b>7</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter when <b>ArchiveBackupKeepPolicy</b> is set to <b>KeepAll</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public int? ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// <para>The retention period of archived backup files. The number of archived backup files that can be retained within the specified retention period is specified by <b>ArchiveBackupKeepCount</b>. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ByMonth</b></description></item>
        /// <item><description><b>ByWeek</b></description></item>
        /// <item><description><b>KeepAll</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ByMonth</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// <para>The number of days for which the archived backup is retained. The default value <b>0</b> specifies that the backup archiving feature is disabled. Valid values: <b>30</b> to <b>1095</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The frequency at which you want to perform a snapshot backup on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: No backup frequencies are specified.</description></item>
        /// <item><description><b>30</b>: A snapshot backup is performed every 30 minutes.</description></item>
        /// <item><description><b>60</b>: A snapshot backup is performed every 60 minutes.</description></item>
        /// <item><description><b>120</b>: A snapshot backup is performed every 120 minutes.</description></item>
        /// <item><description><b>240</b>: A snapshot backup is performed every 240 minutes.</description></item>
        /// <item><description><b>480</b>: A snapshot backup is performed every 480 minutes.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can configure a backup policy by using this parameter and the <b>PreferredBackupPeriod</b> parameter. For example, if you set <b>PreferredBackupPeriod</b> to Saturday,Sunday and BackupInterval to \<em>\</em>-1\<em>\</em>, a snapshot backup is performed on every Saturday and Sunday.</description></item>
        /// <item><description>If the instance runs PostgreSQL, BackupInterval is supported only when the instance is equipped with cloud disks.</description></item>
        /// <item><description>If the instance runs SQL Server, BackupInterval is supported only when the snapshot backup feature is enabled for the instance. For more information, see <a href="https://help.aliyun.com/document_detail/211143.html">Enable snapshot backups for an ApsaraDB RDS for SQL Server instance</a>.</description></item>
        /// <item><description>If <b>Category</b> is set to <b>Flash</b>, BackupInterval is invalid.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the log backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: enables the feature.</description></item>
        /// <item><description><b>Disabled</b>: disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>Default value: <b>Physical</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only on instances that run SQL Server with cloud disks.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Physical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The type of the backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DataBackupPolicy</b>: data backup</description></item>
        /// <item><description><b>LogBackupPolicy</b>: log backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataBackupPolicy</para>
        /// </summary>
        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        /// <summary>
        /// <para>Specifies whether the backup settings of a secondary instance are configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: secondary instance preferred</description></item>
        /// <item><description><b>2</b>: primary instance preferred</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is suitable only for instances that run SQL Server on RDS Cluster Edition.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupMethod</b> is set to <b>Physical</b>. If <b>BackupMethod</b> is set to <b>Snapshot</b>, backups are forcefully performed on the primary instance that runs SQL Server on RDS Cluster Edition.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// <para>The number of days for which you want to retain data backup files. Valid values: <b>7 to 730</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the single-digit second backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: enables the feature.</description></item>
        /// <item><description><b>Standard</b>: disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The format that is used to compress backup data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Backups are not compressed.</description></item>
        /// <item><description><b>1</b>: The zlib tool is used to compress backups into .tar.gz files.</description></item>
        /// <item><description><b>2</b>: The zlib tool is used to compress backups in parallel.</description></item>
        /// <item><description><b>4</b>: The QuickLZ tool is used to compress backups into .xb.gz files. This compression format is supported for instances that run MySQL 5.6 or MySQL 5.7. Backups in this compression format can be used to restore individual databases and tables. For more information, see <a href="https://help.aliyun.com/document_detail/103175.html">Restore individual databases and tables of an ApsaraDB RDS for MySQL instance</a>.</description></item>
        /// <item><description><b>8</b>: The QuickLZ tool is used to compress backups into .xb.gz files. This compression format is supported only for instances that run MySQL 8.0. Backups in this compression format cannot be used to restore individual databases and tables.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the log backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b> or <b>1</b>: enables the log backup feature.</description></item>
        /// <item><description><b>False</b> or <b>0</b>: disables the log backup feature.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter when you set the <b>BackupPolicyMode</b> parameter to <b>LogBackupPolicy</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when you set the <b>BackupPolicyMode</b> parameter to <b>LogBackupPolicy</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable incremental backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): disables the feature.</description></item>
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only on instances that run SQL Server with cloud disks.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully delete log backup files from the instance when the storage usage of the instance exceeds 80% or the amount of remaining storage on the instance is less than 5 GB. Valid values: <b>Enable and Disable</b>. You can retain the default value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify this parameter when you set the <b>BackupPolicyMode</b> parameter to <b>LogBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when you set the <b>BackupPolicyMode</b> parameter to <b>LogBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The number of hours for which you want to retain log backup files on the instance. Valid values: <b>0 to 168</b>. The value 0 specifies that log backup files are not retained on the instance. The value 168 is calculated based on the following formula: 7 × 24.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public string LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum storage usage that is allowed for log backup files on the instance. If the storage usage for log backup files on the instance exceeds the value of this parameter, the system deletes earlier log backup files until the storage usage falls below the value of this parameter. Valid values:<b>0 to 50</b>. You can retain the default value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The frequency at which you want to back up the logs of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LogInterval</b>: A log backup is performed every 30 minutes.</description></item>
        /// <item><description>The default value is the same as the data backup frequency.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value <b>LogInterval</b> is supported only for instances that run SQL Server.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LogInterval</para>
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// <para>The number of binary log files that you want to retain on the instance. Default value: <b>60</b>. Valid values: <b>6</b> to <b>100</b>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you set the <b>BackupPolicyMode</b> parameter to <b>LogBackupPolicy</b>.</para>
        /// </description></item>
        /// <item><description><para>If the instance runs MySQL, you can set this parameter to \<em>\</em>-1\<em>\</em>. The value \<em>\</em>-1\<em>\</em> specifies that an unlimited number of binary log files can be retained on the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// <para>The number of days for which the log backup is retained. Valid values: <b>7 to 730</b>. The log backup retention period cannot be longer than the data backup retention period.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you enable the log backup feature, you can specify the log backup retention period. This parameter is supported for instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> or <b>LogBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The backup cycle. Specify at least two days of the week and separate the days with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can configure a backup policy by using this parameter and the <b>BackupInterval</b> parameter. For example, if you set this parameter to Saturday,Sunday and the <b>BackupInterval</b> parameter to 30, a backup is performed every 30 minutes on every Saturday and Sunday.</description></item>
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The time at which you want to perform a backup. Specify the time in the ISO 8601 standard in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter must be specified when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z-01:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The policy that is used to retain archived backup files if the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: No archived backup files are retained.</description></item>
        /// <item><description><b>Lastest</b>: Only the last archived backup file is retained.</description></item>
        /// <item><description><b>All</b>: All archived backup files are retained.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you set the <b>BackupPolicyMode</b> parameter to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>If the instance uses cloud disks and was created on or after February 1, 2024, this parameter is automatically set to <b>Lastest</b>. If the instance uses local disks in the same scenario, this parameter is automatically set to <b>None</b>. For more information, see <a href="https://help.aliyun.com/document_detail/2836955.html">Backup for deleted instances</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
