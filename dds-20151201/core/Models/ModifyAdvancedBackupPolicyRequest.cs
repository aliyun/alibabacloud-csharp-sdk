// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAdvancedBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The list of backup policies.</para>
        /// </summary>
        [NameInMap("AdvancedBackupDataPolicies")]
        [Validation(Required=false)]
        public List<ModifyAdvancedBackupPolicyRequestAdvancedBackupDataPolicies> AdvancedBackupDataPolicies { get; set; }
        public class ModifyAdvancedBackupPolicyRequestAdvancedBackupDataPolicies : TeaModel {
            /// <summary>
            /// <para>The action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATE</b>: Creates a policy.</description></item>
            /// <item><description><b>UPDATE</b>: Updates a policy.</description></item>
            /// <item><description><b>DELETE</b>: Deletes a policy. If this value is specified, only the PolicyId parameter is required.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The scheduling type of the advanced policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dayOfWeek: scheduled by week.</description></item>
            /// <item><description>dayOfMonth: scheduled by month.</description></item>
            /// <item><description>dayOfYear: scheduled by year.</description></item>
            /// <item><description>backupInterval: scheduled at a fixed interval (high-frequency backup).</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Multiple high-frequency backup policies are not supported.</description></item>
            /// <item><description>Multiple geo-redundancy backups are not supported, and geo-redundancy policies only support dayOfWeek.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dayOfWeek</para>
            /// </summary>
            [NameInMap("BackupPolicy")]
            [Validation(Required=false)]
            public string BackupPolicy { get; set; }

            /// <summary>
            /// <para>The destination region of the backup policy.</para>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>level1: same-region backup.</description></item>
            /// <item><description>level2Cross: cross-region backup.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>level1</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>The ID of the backup policy.</para>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not CREATE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The backup cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When BackupPolicy is set to dayOfWeek: 1, 2, 3, 4, 5, 6, and 7 represent Monday to Sunday. At least two backups must be performed per week.</description></item>
            /// <item><description>When BackupPolicy is set to dayOfMonth: 1, 3, and -1 represent the 1st, 3rd, and last day of each month. -1 represents the last day of the month.</description></item>
            /// <item><description>When BackupPolicy is set to dayOfYear: 01-07 represents January 7. Only one day can be selected.</description></item>
            /// <item><description>When BackupPolicy is set to backupInterval: specify one of the following numbers in minutes. For sharded clusters, the valid values are 30, 60, 120, 180, 240, 360, 480, and 720. For replica sets, the valid values are 15, 30, 60, 120, 180, 240, 360, 480, and 720.</description></item>
            /// </list>
            /// <para>Note:</para>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.
            /// Geo-redundancy policies only support dayOfWeek.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1,4,6</para>
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable hourly sparse backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: When the backup frequency is in minutes, all snapshots taken within 1 hour from the current time are retained. For snapshots taken more than 1 hour but within 24 hours from the current time, only the first snapshot after the hour is retained.</description></item>
            /// <item><description>false: All snapshots within the retention period of high-frequency backups are retained.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PreserveOneEachHour")]
            [Validation(Required=false)]
            public bool? PreserveOneEachHour { get; set; }

            /// <summary>
            /// <para>The retention period of the backup plan in days. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Same-region backup: 7 to 7300 days.</description></item>
            /// <item><description>Geo-redundancy: 3 to 1825 days.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: Required when RetentionType is set to delay.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("RetentionPeriod")]
            [Validation(Required=false)]
            public int? RetentionPeriod { get; set; }

            /// <summary>
            /// <para>The retention cycle type of the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: long-term retention (LTR).</description></item>
            /// <item><description><b>delay</b>: retention for a fixed number of days.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            /// <summary>
            /// <para>The region where the instance resides.</para>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guangzhou</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The source type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>db: same-region backup.</description></item>
            /// <item><description>level1: cross-region backup.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: Required when ActionType is not DELETE.</para>
            /// </remarks>
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
        public List<ModifyAdvancedBackupPolicyRequestAdvancedBackupLogPolicies> AdvancedBackupLogPolicies { get; set; }
        public class ModifyAdvancedBackupPolicyRequestAdvancedBackupLogPolicies : TeaModel {
            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATE: Creates a policy.</description></item>
            /// <item><description>UPDATE: Updates a policy.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only for geo-redundancy. To delete geo-redundancy, set EnableLogBackup to 0 and set ActionType to UPDATE.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The region where the geo-redundancy log backup is stored.</para>
            /// <remarks>
            /// <para>Required for geo-redundancy.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The destination type of the log backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>level1: same-region backup. </description></item>
            /// <item><description>level2Cross: cross-region backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level1</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable log backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled.</description></item>
            /// <item><description><b>0</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Log backup must be enabled for sharded instances.</description></item>
            /// <item><description>You must enable same-region log backup before you can enable cross-region log backup.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            /// <summary>
            /// <para>The ID of the log backup policy. This parameter is required only for cross-region log backup policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The retention period of the log backup in days. This parameter takes effect when RetentionType is set to delay. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Same-region backup: 7 to 7300 days. </description></item>
            /// <item><description>Geo-redundancy: 3 to 1825 days. The value must be less than the backup retention period of the geo-redundancy policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("RetentionPeriod")]
            [Validation(Required=false)]
            public int? RetentionPeriod { get; set; }

            /// <summary>
            /// <para>The retention cycle type of the log backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: long-term retention (LTR).</description></item>
            /// <item><description><b>delay</b>: retention for a fixed number of days.</description></item>
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
            /// <item><description>db: same-region backup.</description></item>
            /// <item><description>level1: cross-region backup.</description></item>
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
        /// <para>The backup retention policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All backup sets of the instance are deleted immediately when the instance is released.</description></item>
        /// <item><description>1: The last backup set is retained for long-term retention (LTR) when the instance is released.</description></item>
        /// <item><description>2: All backup sets are retained for long-term retention (LTR) when the instance is released.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2zeb2d64cb46xxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time period during which the backup is performed. The format is <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The time range is limited to 1 hour.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: backup within seconds.</description></item>
        /// <item><description><b>Standard</b>: standard backup. This is the default value.</description></item>
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
