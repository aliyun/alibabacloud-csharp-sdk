// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdatePolicyV2Request : TeaModel {
        /// <summary>
        /// <para>The description of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data is backed up at 10:00:00 every day and replicated to the China (Shanghai) region for geo-redundancy.</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The ID of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************viy</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The name of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily Local Backup + Remote Backup</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The rules in the backup policy.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdatePolicyV2RequestRules> Rules { get; set; }
        public class UpdatePolicyV2RequestRules : TeaModel {
            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TRANSITION</b>. This parameter specifies the time when data is dumped from a backup vault to an archive vault. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ArchiveDays")]
            [Validation(Required=false)]
            public long? ArchiveDays { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>BACKUP</b>. This parameter specifies the backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TRANSITION</b>. This parameter specifies the time when data is dumped from a backup vault to a cold archive vault. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("ColdArchiveDays")]
            [Validation(Required=false)]
            public long? ColdArchiveDays { get; set; }

            [NameInMap("DataSourceFilters")]
            [Validation(Required=false)]
            public List<UpdatePolicyV2RequestRulesDataSourceFilters> DataSourceFilters { get; set; }
            public class UpdatePolicyV2RequestRulesDataSourceFilters : TeaModel {
                [NameInMap("DataSourceIds")]
                [Validation(Required=false)]
                public List<string> DataSourceIds { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable the feature of keeping at least one backup version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The feature is disabled.</description></item>
            /// <item><description>1: The feature is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeepLatestSnapshots")]
            [Validation(Required=false)]
            public long? KeepLatestSnapshots { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>REPLICATION</b>. This parameter specifies the ID of the destination region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ReplicationRegionId")]
            [Validation(Required=false)]
            public string ReplicationRegionId { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TRANSITION</b> or <b>REPLICATION</b>.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>RuleType</b> parameter is set to <b>TRANSITION</b>, this parameter specifies the retention period of the backup data. Minimum value: 1. Unit: days.</description></item>
            /// <item><description>If the <b>RuleType</b> parameter is set to <b>REPLICATION</b>, this parameter specifies the retention period of remote backups. Minimum value: 1. Unit: days.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TRANSITION</b>. This parameter specifies the special retention rules.</para>
            /// </summary>
            [NameInMap("RetentionRules")]
            [Validation(Required=false)]
            public List<UpdatePolicyV2RequestRulesRetentionRules> RetentionRules { get; set; }
            public class UpdatePolicyV2RequestRulesRetentionRules : TeaModel {
                /// <summary>
                /// <para>The type of the special retention rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>WEEKLY</b>: retains weekly backups</description></item>
                /// <item><description><b>MONTHLY</b>: retains monthly backups</description></item>
                /// <item><description><b>YEARLY</b>: retains yearly backups</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>YEARLY</para>
                /// </summary>
                [NameInMap("AdvancedRetentionType")]
                [Validation(Required=false)]
                public string AdvancedRetentionType { get; set; }

                /// <summary>
                /// <para>The special retention period of backups. Minimum value: 1. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>Specifies which backup is retained based on the special retention rule. Only the first backup can be retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WhichSnapshot")]
                [Validation(Required=false)]
                public long? WhichSnapshot { get; set; }

            }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-000************rof</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The type of the rule. Each backup policy must have at least one rule of the <b>BACKUP</b> type and only one rule of the <b>TRANSITION</b> type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKUP</b>: backup rule</description></item>
            /// <item><description><b>TRANSITION</b>: lifecycle rule</description></item>
            /// <item><description><b>REPLICATION</b>: replication rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BACKUP</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>BACKUP</b>. This parameter specifies the backup schedule settings. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> specifies that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
            /// <list type="bullet">
            /// <item><description>startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.</description></item>
            /// <item><description>interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, PT1H specifies an interval of 1 hour. P1D specifies an interval of one day.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>I|1648647166|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            [NameInMap("TagFilters")]
            [Validation(Required=false)]
            public List<UpdatePolicyV2RequestRulesTagFilters> TagFilters { get; set; }
            public class UpdatePolicyV2RequestRulesTagFilters : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
