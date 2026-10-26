// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The list of advanced data backup policies.</para>
        /// </summary>
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

            /// <summary>
            /// <para>Specifies whether to retain only one data backup per day.</para>
            /// </summary>
            [NameInMap("OnlyPreserveOneEachDay")]
            [Validation(Required=false)]
            public bool? OnlyPreserveOneEachDay { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain only one data backup per hour.</para>
            /// </summary>
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

        /// <summary>
        /// <para>The list of advanced log backup policies.</para>
        /// </summary>
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
        /// <para>The number of archived backups to retain. Default value: <b>1</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>ByMonth</b>, valid values are <b>1</b> to <b>31</b>.</description></item>
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>ByWeek</b>, valid values are <b>1</b> to <b>7</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <b>ArchiveBackupKeepPolicy</b> is set to <b>KeepAll</b>, you do not need to specify this parameter.</description></item>
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
        /// <para>The retention period of archived backups. The number of archived backups that can be retained within this period is determined by <b>ArchiveBackupKeepCount</b>. Default value: <b>0</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ByMonth</b>: month.</description></item>
        /// <item><description><b>ByWeek</b>: week.</description></item>
        /// <item><description><b>KeepAll</b>: all archived backups are retained.</description></item>
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
        /// <para>The number of days for which archived backups are retained. Default value: <b>0</b>, which indicates that archive backup is disabled. Valid values: <b>30</b> to <b>1095</b>.</para>
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
        /// <item><description>This parameter and the <b>PreferredBackupPeriod</b> parameter determine the backup policy together.</description></item>
        /// <item><description>The MySQL instance must be a cloud disk instance of MySQL 5.7 or 8.0 <b>High-availability Edition</b> or <b>Cluster Edition</b>.</description></item>
        /// <item><description>The PostgreSQL instance must be a cloud disk instance.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/211143.html"><b>Snapshot backup</b></a> must be <b>enabled</b> for the SQL Server instance.</description></item>
        /// <item><description>This parameter does not take effect when <b>Category</b> is set to <b>Flash</b>.</description></item>
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
        /// <item><description><b>Enable</b>: enables log backup.</description></item>
        /// <item><description><b>Disabled</b>: disables log backup.</description></item>
        /// </list>
        /// <para><b>For ApsaraDB RDS for SQL Server instances</b>, log backup is enabled by default and cannot be disabled. However, you can change the log backup frequency as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Every 5 minutes</b>: Set BackupLog to Enable and leave LogBackupFrequency empty. For more information, see <a href="https://help.aliyun.com/document_detail/2861729.html">5-minute log backup</a>. <b>This configuration is not supported when the preferred secondary instance is configured for backup (BackupPriority is set to 1). Otherwise, an error is reported.</b></description></item>
        /// <item><description><b>Every 30 minutes</b>: Leave BackupLog empty and set LogBackupFrequency to LogInterval.</description></item>
        /// <item><description><b>Same as data backup frequency</b>: Leave both BackupLog and LogBackupFrequency empty.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>. It is used to enable or disable log backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// <para>The backup method for <b>ApsaraDB RDS for SQL Server instances with cloud disks</b>. Valid values:</para>
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
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DataBackupPolicy</b>: data backup.</description></item>
        /// <item><description><b>LogBackupPolicy</b>: log backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataBackupPolicy</para>
        /// </summary>
        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        /// <summary>
        /// <para>The backup priority setting for <a href="https://help.aliyun.com/document_detail/95717.html">secondary instance backup</a> of <b>ApsaraDB RDS for SQL Server Cluster Edition</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: prefer secondary instance.</description></item>
        /// <item><description><b>2</b>: force primary instance.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupMethod</b> is set to <b>Physical</b>. If <b>BackupMethod</b> is set to <b>Snapshot</b>, backups are forcibly performed on the primary instance for ApsaraDB RDS for SQL Server Cluster Edition instances.</description></item>
        /// <item><description>After you set the backup priority to <b>prefer secondary instance</b> (BackupPriority is set to 1), the <b>5-minute log backup</b> policy (BackupLog is set to Enable and LogBackupFrequency is left empty) is <b>not supported</b>. Otherwise, an error is reported. Set the log backup frequency to every 30 minutes or the same as the data backup frequency.</description></item>
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
        /// <para>The number of days for which data backups are retained. Valid values: <b>7</b> to <b>730</b>.</para>
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
        /// <item><description><b>Flash</b>: enables backup within seconds.</description></item>
        /// <item><description><b>Standard</b>: disables backup within seconds.</description></item>
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
        /// <item><description><b>0</b>: no compression.</description></item>
        /// <item><description><b>1</b>: zlib compression. The format is tar.gz.</description></item>
        /// <item><description><b>2</b>: parallel zlib compression.</description></item>
        /// <item><description><b>4</b>: quicklz compression. The format is xb.gz. This method applies only to MySQL 5.6 and 5.7. You can use this compression method to <a href="https://help.aliyun.com/document_detail/103175.html">restore individual databases and tables</a>.</description></item>
        /// <item><description><b>8</b>: quicklz compression. The format is xb.gz. This method applies only to MySQL 8.0. Restoration of individual databases and tables is not supported.</description></item>
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
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the advanced backup policy. If you set this parameter to 1, both the advanced data backup policy and the advanced log backup policy are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableAdvancedBackupPolicy")]
        [Validation(Required=false)]
        public int? EnableAdvancedBackupPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup for <b>MySQL</b>, <b>PostgreSQL</b>, and <b>MariaDB</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b> or <b>1</b>: enabled.</description></item>
        /// <item><description><b>False</b> or <b>0</b>: shutdown.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instance log backup is enabled by default and cannot be shut down for <b>SQL Server</b> instances. Therefore, you do not need to configure this parameter for SQL Server instances.</description></item>
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>. It is used to enable or shutdown instance log backup.</description></item>
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
        /// <para>Specifies whether to enable incremental backup for <b>ApsaraDB RDS for SQL Server instances with cloud disks</b> and <b>ApsaraDB RDS for MySQL instances with local SSDs</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>False</b> (default): disables incremental backup.</description></item>
        /// <item><description><b>True</b>: enables incremental backup.</description></item>
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
        /// <para>Specifies whether to enable point-in-time recovery (PITR) for <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: enabled.</description></item>
        /// <item><description><b>False</b>: shutdown.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> and <b>BackupLog</b> is set to <b>Enable</b>. For feature details, see <a href="https://help.aliyun.com/document_detail/2666046.html">Settings for point-in-time recovery policy</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to unconditionally delete binary log files when the storage usage of the <b>ApsaraDB RDS for MySQL</b> instance exceeds 80% or the remaining storage space is less than 5 GB. Valid values: <b>Enable</b> and <b>Disable</b>. By default, this parameter is not modified.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>. In this case, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The high-frequency incremental backup frequency for <b>ApsaraDB RDS for MySQL instances with local SSDs</b>. Valid values:</para>
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
        /// <para>The number of hours for which instance log backups are retained locally on the <b>MySQL</b> instance. Valid values: <b>0</b> to <b>168</b> (7 × 24). A value of 0 indicates that instance log backups are not retained locally.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>. In this case, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public string LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum usage of the local log storage space on the <b>ApsaraDB RDS for MySQL</b> instance. If the usage exceeds this value, the earliest binary log files are deleted until the usage drops below this value. Valid values: <b>0</b> to <b>50</b>. By default, this parameter is not modified.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>. In this case, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The log backup frequency for <b>ApsaraDB RDS for SQL Server</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LogInterval</b>: every 30 minutes.</description></item>
        /// <item><description><b>Empty</b> (no value required): every 5 minutes or same as the data backup frequency.</description></item>
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
        /// <para>The number of binary log files retained locally. Default value: <b>60</b>. Valid values: <b>6</b> to <b>100</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>LogBackupPolicy</b>.</description></item>
        /// <item><description>If the instance is an ApsaraDB RDS for MySQL instance, you can set this parameter to -1, which indicates that the number of locally retained binary log files is not limited.</description></item>
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
        /// <para>The number of days for which log backups are retained. Valid values: <b>7</b> to <b>730</b>. The value cannot be greater than the number of days for which data backups are retained.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When log backup is enabled, you can specify the number of days for which log backup files are retained. This parameter is supported only for ApsaraDB RDS for MySQL and ApsaraDB RDS for PostgreSQL instances.</description></item>
        /// <item><description>This parameter takes effect when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b> or <b>LogBackupPolicy</b>.</description></item>
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
        /// <para>The backup cycle. You must specify at least two days. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday.</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday.</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday.</description></item>
        /// <item><description><b>Thursday</b>: Thursday.</description></item>
        /// <item><description><b>Friday</b>: Friday.</description></item>
        /// <item><description><b>Saturday</b>: Saturday.</description></item>
        /// <item><description><b>Sunday</b>: Sunday.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter and the <b>BackupInterval</b> parameter determine the backup policy together. For example, if you set this parameter to Saturday and Sunday and set <b>BackupInterval</b> to 30 minutes, a backup is performed every 30 minutes on Saturdays and Sundays.</description></item>
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
        /// <para>The time period during which the backup task is executed. Specify the time in the <i>HH:mm</i>Z-<i>HH:mm</i>Z format. The time must be in UTC.</para>
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
        /// <para>The data retention policy for archived backups of deleted <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: does not retain archived backups.</description></item>
        /// <item><description><b>Lastest</b>: retains the last archived backup.</description></item>
        /// <item><description><b>All</b>: retains all archived backups.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>BackupPolicyMode</b> is set to <b>DataBackupPolicy</b>.</description></item>
        /// <item><description>For ApsaraDB RDS for MySQL cloud disk instances purchased on or after February 1, 2024, the default value of ReleasedKeepPolicy is <b>Lastest</b>. For instances with Premium Local SSDs, the default value is <b>None</b>. For feature details, see <a href="https://help.aliyun.com/document_detail/2836955.html">Backups of deleted instances</a>.</description></item>
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
