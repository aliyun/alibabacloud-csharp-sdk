// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAdvancedBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup policies.</para>
        /// </summary>
        [NameInMap("AdvancedBackupDataPolicies")]
        [Validation(Required=false)]
        public List<DescribeAdvancedBackupPolicyResponseBodyAdvancedBackupDataPolicies> AdvancedBackupDataPolicies { get; set; }
        public class DescribeAdvancedBackupPolicyResponseBodyAdvancedBackupDataPolicies : TeaModel {
            /// <summary>
            /// <para>The action type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The scheduling type of the advanced policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dayOfWeek: weekly scheduling</description></item>
            /// <item><description>dayOfMonth: monthly scheduling</description></item>
            /// <item><description>dayOfYear: yearly scheduling</description></item>
            /// <item><description>backupInterval: fixed-interval scheduling (high-frequency backup)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dayOfWeek</para>
            /// </summary>
            [NameInMap("BackupPolicy")]
            [Validation(Required=false)]
            public string BackupPolicy { get; set; }

            /// <summary>
            /// <para>The destination region of the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>level1: same-region backup</description></item>
            /// <item><description>level2Cross: cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level1</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>The ID of the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The backup cycle. </para>
            /// <list type="bullet">
            /// <item><description>When <b>BackupPolicy</b> is set to <b>dayOfWeek</b>, the values 1, 2, 3, 4, 5, 6, and 7 represent Monday to Sunday.</description></item>
            /// <item><description>When <b>BackupPolicy</b> is set to <b>dayOfMonth</b>, the values 1, 3, and -1 represent the 1st, 3rd, and last day of each month.</description></item>
            /// <item><description>When <b>BackupPolicy</b> is set to <b>dayOfYear</b>, the value 01-07 represents January 7.</description></item>
            /// <item><description>When <b>BackupPolicy</b> is set to <b>backupInterval</b>, the value 30 represents a backup every 30 minutes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3</para>
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable sparse backup within an hour. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: When the backup frequency is minute-level, all snapshots taken within 1 hour from the current time are retained. For snapshots taken more than 1 hour but within 24 hours from the current time, only the first snapshot after each hour is retained.</description></item>
            /// <item><description>false: Sparse backup within an hour is disabled. All snapshots within the retention period of high-frequency backups are retained.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PreserveOneEachHour")]
            [Validation(Required=false)]
            public bool? PreserveOneEachHour { get; set; }

            /// <summary>
            /// <para>The number of days for which backups are retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("RetentionPeriod")]
            [Validation(Required=false)]
            public int? RetentionPeriod { get; set; }

            /// <summary>
            /// <para>The retention epoch type of the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: long-term retention (LTR)</description></item>
            /// <item><description><b>delay</b>: fixed-day retention</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            /// <summary>
            /// <para>The region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The source type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>db: same-region backup</description></item>
            /// <item><description>level1: cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>db</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        /// <summary>
        /// <para>The list of log backup policies.</para>
        /// </summary>
        [NameInMap("AdvancedBackupLogPolicies")]
        [Validation(Required=false)]
        public List<DescribeAdvancedBackupPolicyResponseBodyAdvancedBackupLogPolicies> AdvancedBackupLogPolicies { get; set; }
        public class DescribeAdvancedBackupPolicyResponseBodyAdvancedBackupLogPolicies : TeaModel {
            /// <summary>
            /// <para>The destination region of the log backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination type of the log backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>level1: same-region backup</description></item>
            /// <item><description>level2Cross: cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>Specifies whether log backup is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            /// <summary>
            /// <para>The ID of the log backup policy. This parameter is returned only for cross-region log backup policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The number of days for which log backups are retained. This parameter takes effect only when RetentionType is set to delay.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RetentionPeriod")]
            [Validation(Required=false)]
            public string RetentionPeriod { get; set; }

            /// <summary>
            /// <para>The retention epoch type of log backups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: long-term retention (LTR)</description></item>
            /// <item><description><b>delay</b>: fixed-day retention</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            /// <summary>
            /// <para>The region where the source instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The source type of the log backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>db: same-region backup</description></item>
            /// <item><description>level1: cross-region backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>et</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        /// <summary>
        /// <para>The data retention policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All backup sets of the instance are immediately deleted when the instance is released.</description></item>
        /// <item><description>1: The last backup set is retained for long-term retention (LTR) when the instance is released.</description></item>
        /// <item><description>2: All backup sets are retained for long-term retention (LTR) when the instance is released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp14bf67a76d****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The backup time in the <i>HH:mm</i>Z-<i>HH:mm</i>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The time range for starting a backup. The time is in the <c>HH:mmZ-HH:mmZ</c> format (UTC). Example: 01:00Z-02:00Z. The backup starts within this time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-19T19:11Z</para>
        /// </summary>
        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111E7B16-0A87-4CBA-B271-F34AD61E099F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: backup within seconds</description></item>
        /// <item><description><b>Standard</b>: standard backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

    }

}
