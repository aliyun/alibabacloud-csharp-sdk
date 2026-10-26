// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the advanced backup policy is enabled.</para>
        /// </summary>
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
        /// <para>The number of archived backups retained for a <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        /// <summary>
        /// <para>The retention period for archived backups of a <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ByMonth</para>
        /// </summary>
        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        /// <summary>
        /// <para>The number of days for which archived backups of a <b>MySQL</b> instance are retained.</para>
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
        /// <item><description>For MySQL instances: the <a href="https://help.aliyun.com/document_detail/98818.html">snapshot backup frequency</a>, not the snapshot backup cycle.</description></item>
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
        /// <item><description><b>Enable</b>: yes</description></item>
        /// <item><description><b>Disabled</b>: no</description></item>
        /// </list>
        /// <para><b>For SQL Server instances:</b></para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b> is returned only when instance log backup frequency is <b>every 5 minutes</b>.</description></item>
        /// <item><description><b>Disabled</b> is returned when instance log backup frequency is <b>every 30 minutes</b> or <b>the same as the data backup frequency</b>. <b>Refer to the BackupInterval parameter for the actual frequency</b>.</description></item>
        /// </list>
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
        /// <para>The secondary node backup setting for <b>SQL Server Enterprise Cluster Edition</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: prefer secondary node</description></item>
        /// <item><description><b>2</b>: force primary node</description></item>
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
        /// <para>Indicates whether backup within seconds is enabled for <b>MySQL</b> and <b>PostgreSQL</b> instances. Valid values:</para>
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
        /// <item><description><b>4</b>: quicklz compression with database and table restoration enabled</description></item>
        /// <item><description><b>8</b>: quicklz compression without database and table restoration supported</description></item>
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
        /// <item><description><b>0</b> is returned when instance log backup frequency is <b>every 30 minutes</b> or <b>the same as the data backup frequency</b>. <b>Refer to the BackupInterval parameter for the actual frequency</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental backup is enabled for <b>SQL Server</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: yes</description></item>
        /// <item><description><b>False</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Indicates whether point-in-time recovery (PITR) is enabled for <b>MySQL</b> instances. PITR is an upgraded version of log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: yes</description></item>
        /// <item><description><b>False</b>: no</description></item>
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
        /// <para>Indicates whether binary logs are forcibly deleted when the storage usage of a <b>MySQL</b> instance exceeds 80% or the remaining storage is less than 5 GB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: does not delete binary logs</description></item>
        /// <item><description><b>Enable</b>: deletes binary logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The interval for high-frequency incremental backups. Unit: minutes. Valid values: 60, 120, 240, 360, and 720.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("IncBackupInterval")]
        [Validation(Required=false)]
        public int? IncBackupInterval { get; set; }

        /// <summary>
        /// <para>The number of hours for which binary log backups of a <b>MySQL</b> instance are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum storage usage for binary logs of a <b>MySQL</b> instance.</para>
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
        /// <item><description><b>LogInterval</b>: every 30 minutes</description></item>
        /// <item><description>Default: the same as the data backup cycle specified by <b>PreferredBackupPeriod</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LogInterval</para>
        /// </summary>
        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        /// <summary>
        /// <para>The number of local binary logs retained for a <b>MySQL</b> instance.</para>
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
        /// <para>The number of days for which point-in-time recovery is available for a <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PitrRetentionPeriod")]
        [Validation(Required=false)]
        public int? PitrRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The data backup cycle. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
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
        /// <para>The time of the next backup. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-19T15:15Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The data retention policy for archived backups of deleted <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: no retention</description></item>
        /// <item><description><b>Lastest</b>: retains the last backup</description></item>
        /// <item><description><b>All</b>: retains all backups</description></item>
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
        /// <para>Indicates whether the secondary node backup option can be modified for <b>SQL Server</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: yes</description></item>
        /// <item><description><b>False</b>: no</description></item>
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
        /// <para>Indicates whether snapshot backup is supported for <b>SQL Server</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SupportVolumeShadowCopy")]
        [Validation(Required=false)]
        public int? SupportVolumeShadowCopy { get; set; }

        /// <summary>
        /// <para>Indicates whether the <a href="https://help.aliyun.com/document_detail/95717.html">5-minute log backup feature</a> is supported for <b>SQL Server</b> instances. Valid values:</para>
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
