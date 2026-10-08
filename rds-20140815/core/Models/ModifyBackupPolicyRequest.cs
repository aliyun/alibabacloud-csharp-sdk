// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        [NameInMap("AdvancedDataPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvancedDataPolicies> AdvancedDataPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvancedDataPolicies : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("BakType")]
            [Validation(Required=false)]
            public string BakType { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("OnlyPreserveOneEachDay")]
            [Validation(Required=false)]
            public bool? OnlyPreserveOneEachDay { get; set; }

            [NameInMap("OnlyPreserveOneEachHour")]
            [Validation(Required=false)]
            public bool? OnlyPreserveOneEachHour { get; set; }

            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            [NameInMap("RetentionValue")]
            [Validation(Required=false)]
            public int? RetentionValue { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

        }

        [NameInMap("AdvancedLogPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvancedLogPolicies> AdvancedLogPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvancedLogPolicies : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("LogRetentionType")]
            [Validation(Required=false)]
            public string LogRetentionType { get; set; }

            [NameInMap("LogRetentionValue")]
            [Validation(Required=false)]
            public int? LogRetentionValue { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public string StrategyId { get; set; }

        }

        /// <summary>
        /// <para>The number of archived backups to retain. The default value is <b>1</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>ByMonth</b>, valid values are <b>1 to 31</b>.</description></item>
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>ByWeek</b>, valid values are <b>1 to 7</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>KeepAll</b>, this parameter does not need to be specified.</description></item>
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
        /// <para>The retention cycle of archived backups. The number of backups retained within this cycle is determined by <b>ArchiveBackupKeepCount</b>. The default value is <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ByMonth</b>: monthly</description></item>
        /// <item><description><b>ByWeek</b>: weekly</description></item>
        /// <item><description><b>KeepAll</b>: all retained</description></item>
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
        /// <para>The number of days for which archived backups are retained. The default value is <b>0</b>, which indicates that archived backup is not enabled. Valid values: <b>30 to 1095</b>.</para>
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
        /// <para>The snapshot backup frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>15</b>: 15 minutes.</description></item>
        /// <item><description><b>30</b>: 30 minutes.</description></item>
        /// <item><description><b>60</b>: 60 minutes.</description></item>
        /// <item><description><b>120</b>: 120 minutes.</description></item>
        /// <item><description><b>180</b>: 180 minutes.</description></item>
        /// <item><description><b>240</b>: 240 minutes.</description></item>
        /// <item><description><b>360</b>: 360 minutes.</description></item>
        /// <item><description><b>480</b>: 480 minutes.</description></item>
        /// <item><description><b>720</b>: 720 minutes.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter works together with the <b>PreferredBackupPeriod</b> parameter to determine the backup policy.</description></item>
        /// <item><description>MySQL instances must be cloud disk instances running MySQL 5.7 or 8.0 in the <b>high-availability series or Cluster Edition</b>.</description></item>
        /// <item><description>PostgreSQL instances must be cloud disk instances.</description></item>
        /// <item><description>SQL Server instances must have <a href="https://help.aliyun.com/document_detail/211143.html"><b>snapshot backup</b></a> <b>enabled</b>.</description></item>
        /// <item><description>This parameter is invalid when <b>Category</b> is set to <b>Flash</b>.</description></item>
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
        /// <para>Specifies whether to enable log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enable.</description></item>
        /// <item><description><b>Disabled</b>: Disable.</description></item>
        /// </list>
        /// <para><b>For SQL Server instances</b>, log backup is enabled by default and cannot be disabled. However, you can modify the log backup frequency as follows:</para>
        /// <list type="bullet">
        /// <item><description>Log backup frequency of <b>every 5 minutes</b>: Set BackupLog to Enable and leave LogBackupFrequency empty. For more information, see <a href="https://help.aliyun.com/document_detail/2861729.html">5-minute log backup</a>. <b>This configuration is not supported when backup on the secondary instance is preferred (BackupPriority is set to 1). Otherwise, an error is returned.</b></description></item>
        /// <item><description>Log backup frequency of <b>every 30 minutes</b>: Leave BackupLog empty and set LogBackupFrequency to LogInterval.</description></item>
        /// <item><description>Log backup frequency <b>consistent with data backup</b>: Leave both BackupLog and LogBackupFrequency empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> and is used to enable or disable log backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// <para>The backup method for <b>SQL Server instances with cloud disks</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Physical</b> (default): physical backup.</description></item>
        /// <item><description><b>Snapshot</b>: snapshot backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Physical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The type of the backup policy. Valid values:</para>
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
        /// <para>The <a href="https://help.aliyun.com/document_detail/95717.html">backup on secondary instance</a> setting for <b>SQL Server Cluster Edition</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: secondary instance preferred.</description></item>
        /// <item><description><b>2</b>: primary instance forced.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupMethod</b> is set to <b>Physical</b>. If <b>BackupMethod</b> is set to <b>Snapshot</b>, SQL Server Cluster Edition instances are forced to perform backups on the primary instance.</description></item>
        /// <item><description>After you set <b>secondary instance preferred</b> (BackupPriority to 1), the <b>5-minute log backup</b> policy (BackupLog set to Enable and LogBackupFrequency left empty) is <b>not supported</b>. Otherwise, an error is returned. Set the log backup frequency to every 30 minutes or consistent with data backup.</description></item>
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
        /// <para>The number of days for which data backups are retained. Valid values: <b>7 to 730</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
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
        /// <para>Specifies whether to enable backup within seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: Enable.</description></item>
        /// <item><description><b>Standard</b>: Disable.</description></item>
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
        /// <para>The backup compression method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not compressed.</description></item>
        /// <item><description><b>1</b>: zlib compression. The format is tar.gz.</description></item>
        /// <item><description><b>2</b>: parallel zlib compression.</description></item>
        /// <item><description><b>4</b>: quicklz compression. The format is xb.gz. This method is applicable only to MySQL 5.6 and 5.7 and can be used for <a href="https://help.aliyun.com/document_detail/103175.html">individual database and table restoration</a>.</description></item>
        /// <item><description><b>8</b>: quicklz compression. The format is xb.gz. This method is applicable only to MySQL 8.0. Individual database and table restoration is not supported.</description></item>
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
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EnableAdvancedBackupPolicy")]
        [Validation(Required=false)]
        public int? EnableAdvancedBackupPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable instance log backup for <b>MySQL</b>, <b>PostgreSQL</b>, and <b>MariaDB</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b> or <b>1</b>: Enable.</description></item>
        /// <item><description><b>False</b> or <b>0</b>: Disable.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instance log backup for <b>SQL Server</b> instances is enabled by default and cannot be disabled. You do not need to configure this parameter for SQL Server instances.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b> and is used to enable or disable instance log backup.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable incremental backup for <b>SQL Server instances with cloud disks or MySQL instances with local disks</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>False</b> (default): Disable.</description></item>
        /// <item><description><b>True</b>: Enable.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable point-in-time recovery for <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Enable.</description></item>
        /// <item><description><b>False</b>: Disable.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> and <b>BackupLog</b> is set to <b>Enable</b>. For more information, see <a href="https://help.aliyun.com/document_detail/2666046.html">Configure a point-in-time recovery policy</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to unconditionally clean up binary logs when the storage usage of a <b>MySQL</b> instance exceeds 80% or the remaining storage is less than 5 GB. Valid values: <b>Enable | Disable</b>. The default value is not modified.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b> and is required in this case.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The high-frequency incremental backup frequency for <b>MySQL instances with local disks</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>60</b>: 60 minutes.</description></item>
        /// <item><description><b>120</b>: 120 minutes.</description></item>
        /// <item><description><b>240</b>: 240 minutes.</description></item>
        /// <item><description><b>360</b>: 360 minutes.</description></item>
        /// <item><description><b>720</b>: 720 minutes.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>EnableIncrementDataBackup</b> is set to <b>True</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("IncBackupInterval")]
        [Validation(Required=false)]
        public int? IncBackupInterval { get; set; }

        /// <summary>
        /// <para>The number of hours for which instance log backups are retained on the local storage of a <b>MySQL</b> instance. Valid values: <b>0 to 168</b> (7 × 24). A value of 0 indicates that instance logs are not retained locally.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b> and is required in this case.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public string LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum usage of the local log storage space for a <b>MySQL</b> instance. If the usage exceeds this value, the system starts to clean up binary logs from the earliest one until the usage drops below this threshold. Valid values: <b>0 to 50</b>. The default value is not modified.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b> and is required in this case.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The log backup frequency for <b>SQL Server</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LogInterval</b>: every <b>30 minutes</b>.</description></item>
        /// <item><description><b>Empty</b> (no value required): every <b>5 minutes</b> or <b>consistent with data backup</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LogInterval</para>
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// <para>The number of binary logs retained locally. The default value is <b>60</b>. Valid values: <b>6 to 100</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// <item><description>For MySQL instances, you can set this parameter to -1, which indicates that the number of locally retained binary logs is not limited.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// <para>The number of days for which log backups are retained. Valid values: <b>7 to 730</b>. The value cannot be greater than the number of days for which data backups are retained.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When log backup is enabled, you can set the retention period of log backup files. Currently, only MySQL and PostgreSQL instances support this setting.</description></item>
        /// <item><description>This parameter applies when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> or <b>LogBackupPolicy</b>.</description></item>
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
        /// <para>The backup cycle. Specify at least two days. Separate multiple values with commas (,). Valid values:</para>
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
        /// <item><description>This parameter works together with the <b>BackupInterval</b> parameter to determine the backup policy. For example, if you set this parameter to Saturday and Sunday and set <b>BackupInterval</b> to 30 minutes, a backup is performed every 30 minutes on Saturday and Sunday each week.</description></item>
        /// <item><description>This parameter is required when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
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
        /// <para>The time at which to perform a backup task. Format: <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
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
        /// <para>The archived backup data retention policy for deleted <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: not retained.</description></item>
        /// <item><description><b>Lastest</b>: the last backup is retained.</description></item>
        /// <item><description><b>All</b>: all backups are retained.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL cloud disk instances purchased on or after February 1, 2024, the default value of ReleasedKeepPolicy is <b>Lastest</b>. For instances with Premium Local SSDs, the default value is <b>None</b>. For more information about this feature, see <a href="https://help.aliyun.com/document_detail/2836955.html">Backups of deleted instances</a>.</description></item>
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
