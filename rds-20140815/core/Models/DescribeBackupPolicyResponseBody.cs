// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("AdvancedBackupPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AdvancedBackupPolicyEnabled { get; set; }

        [NameInMap("AdvancedDataPolicies")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAdvancedDataPolicies AdvancedDataPolicies { get; set; }
        public class DescribeBackupPolicyResponseBodyAdvancedDataPolicies : TeaModel {
            [NameInMap("AdvancedDataPolicy")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy> AdvancedDataPolicy { get; set; }
            public class DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy : TeaModel {
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

        }

        [NameInMap("AdvancedLogPolicies")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAdvancedLogPolicies AdvancedLogPolicies { get; set; }
        public class DescribeBackupPolicyResponseBodyAdvancedLogPolicies : TeaModel {
            [NameInMap("AdvancedLogPolicy")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy> AdvancedLogPolicy { get; set; }
            public class DescribeBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy : TeaModel {
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

        }

        /// <summary>
        /// <para>The number of archived backups retained for the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// <para>The retention cycle of archived backups for the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByMonth</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// <para>The number of days for which archived backups are retained for the <b>MySQL</b> instance.</para>
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
        /// <item><description>For MySQL instances: the <a href="https://help.aliyun.com/document_detail/98818.html">snapshot backup frequency</a> (not the snapshot backup cycle).</description></item>
        /// <item><description>For SQL Server instances: the log backup frequency.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        /// <summary>
        /// <para>Indicates whether log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: enabled</description></item>
        /// <item><description><b>Disabled</b>: disabled</description></item>
        /// </list>
        /// <para><b>For SQL Server instances:</b></para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b> is returned only when instance log backup frequency is <b>every 5 minutes</b>.</description></item>
        /// <item><description>When instance log backup frequency is <b>every 30 minutes</b> or <b>consistent with the data backup cycle</b>, this parameter returns <b>Disabled</b>. <b>Use the value of BackupInterval as the reference</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        /// <summary>
        /// <para>The backup method of the <b>SQL Server instance with cloud disks</b>. Valid values:</para>
        /// <list type="bullet">
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
        /// <para>The backup settings for the secondary instance of an <b>SQL Server Enterprise Cluster Edition</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The secondary instance is preferred.</description></item>
        /// <item><description><b>2</b>: The primary instance is forced.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when SupportModifyBackupPriority is True.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// <para>The number of days for which data backups are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Indicates whether backup within seconds is enabled for the <b>MySQL</b> or <b>PostgreSQL</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: enabled</description></item>
        /// <item><description><b>Standard</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>BackupPolicyMode</b> parameter is set to <b>DataBackupPolicy</b>.</para>
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
        /// <item><description><b>0</b>: no compression</description></item>
        /// <item><description><b>1</b>: zlib compression</description></item>
        /// <item><description><b>2</b>: parallel zlib compression</description></item>
        /// <item><description><b>4</b>: QuickLZ compression with fast restoration for individual databases and tables enabled</description></item>
        /// <item><description><b>8</b>: QuickLZ compression without fast restoration for individual databases and tables supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// <para>Indicates whether log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// <para><b>For SQL Server instances:</b></para>
        /// <list type="bullet">
        /// <item><description><b>1</b> is returned only when instance log backup frequency is <b>every 5 minutes</b>.</description></item>
        /// <item><description>When instance log backup frequency is <b>every 30 minutes</b> or <b>consistent with the data backup cycle</b>, this parameter returns <b>0</b>. <b>Use the value of BackupInterval as the reference</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental backup is enabled for the <b>SQL Server</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: enabled</description></item>
        /// <item><description><b>False</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Indicates whether point-in-time recovery (PITR) is enabled for the <b>MySQL</b> instance. PITR is an upgraded version of log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: enabled</description></item>
        /// <item><description><b>False</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2666046.html">Configure a point-in-time recovery policy</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// <para>Indicates whether binary logs are forcibly deleted when the storage usage of the <b>MySQL</b> instance exceeds 80% or the remaining storage is less than 5 GB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: Binary logs are not deleted.</description></item>
        /// <item><description><b>Enable</b>: Binary logs are deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        [NameInMap("IncBackupInterval")]
        [Validation(Required=false)]
        public int? IncBackupInterval { get; set; }

        /// <summary>
        /// <para>The number of hours for which binary logs are retained on the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum storage usage of binary logs on the <b>MySQL</b> instance, in percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The log backup frequency of the <b>SQL Server</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LogInterval</b>: every 30 minutes.</description></item>
        /// <item><description>Default: consistent with the data backup cycle specified by <b>PreferredBackupPeriod</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LogInterval</para>
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// <para>The number of binary logs retained on the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// <para>The number of days for which log backups are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The number of days for which point-in-time recovery is supported for the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PitrRetentionPeriod")]
        [Validation(Required=false)]
        public int? PitrRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The data backup cycle. Multiple values are separated by commas (,). Valid values:</para>
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
        /// <para>The data backup time. Format: <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The next backup time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-19T15:15Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The archived backup data retention policy for deleted <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: No archived backups are retained.</description></item>
        /// <item><description><b>Lastest</b>: Only the last archived backup is retained.</description></item>
        /// <item><description><b>All</b>: All archived backups are retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B87E2AB3-B7C9-4394-9160-7F639F732031</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the secondary instance backup option can be modified for the <b>SQL Server</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The option can be modified.</description></item>
        /// <item><description><b>False</b>: The option cannot be modified.</description></item>
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
        /// <para>Indicates whether snapshot backup is supported for the <b>SQL Server</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: supported</description></item>
        /// <item><description><b>0</b>: not supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportVolumeShadowCopy")]
        [Validation(Required=false)]
        public int? SupportVolumeShadowCopy { get; set; }

        /// <summary>
        /// <para>Indicates whether the <a href="https://help.aliyun.com/document_detail/95717.html">5-minute log backup feature</a> is supported for the <b>SQL Server</b> instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not supported</description></item>
        /// <item><description><b>1</b>: supported</description></item>
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
