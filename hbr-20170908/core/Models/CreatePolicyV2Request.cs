// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2Request : TeaModel {
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
        /// <para>The name of the backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily Local Backup + Remote Backup</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: the general backup policy. This type of policy applies to backups other than Elastic Compute Service (ECS) instance backup.</description></item>
        /// <item><description><b>UDM_ECS_ONLY</b>: This type of policy applies only to ECS instance backup.</description></item>
        /// </list>
        /// <para>If the policy type is not specified, Cloud Backup automatically sets the policy type based on whether the backup vault is specified in the rules of the policy:</para>
        /// <list type="bullet">
        /// <item><description>If the backup vault is specified, Cloud Backup sets the policy type to <b>STANDARD</b>.</description></item>
        /// <item><description>If the backup vault is not specified, Cloud Backup sets the policy type to <b>UDM_ECS_ONLY</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The rules in the backup policy.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreatePolicyV2RequestRules> Rules { get; set; }
        public class CreatePolicyV2RequestRules : TeaModel {
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
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TAG</b>. This parameter specifies the data source filter rule.</para>
            /// </summary>
            [NameInMap("DataSourceFilters")]
            [Validation(Required=false)]
            public List<CreatePolicyV2RequestRulesDataSourceFilters> DataSourceFilters { get; set; }
            public class CreatePolicyV2RequestRulesDataSourceFilters : TeaModel {
                /// <summary>
                /// <para>This parameter is deprecated.</para>
                /// </summary>
                [NameInMap("DataSourceIds")]
                [Validation(Required=false)]
                public List<string> DataSourceIds { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UDM_ECS</b>: Elastic Compute Service (ECS) instance This type of data source is supported only if the <b>PolicyType</b> parameter is set to <b>UDM_ECS_ONLY</b>.</description></item>
                /// <item><description><b>OSS</b>: Object Storage Service (OSS) bucket This type of data source is supported only if the <b>PolicyType</b> parameter is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>NAS</b>: File Storage NAS (NAS) file system This type of data source is supported only if the <b>PolicyType</b> parameter is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>ECS_FILE</b>: ECS file This type of data source is supported only if the <b>PolicyType</b> parameter is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>OTS</b>: Tablestore instance This type of data source is supported only if the <b>PolicyType</b> parameter is set to <b>STANDARD</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UDM_ECS</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required only if the <b>PolicyType</b> parameter is set to <b>UDM_ECS_ONLY</b>. This parameter specifies whether to enable the immutable backup feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

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
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>BACKUP</b>, <b>TRANSITION</b>, or <b>REPLICATION</b>.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>RuleType</b> parameter is set to <b>BACKUP</b>, this parameter specifies the retention period of the backup data. The priority is lower than the retention period when the <b>RuleType</b> parameter is set to <b>TRANSITION</b>. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
            /// <item><description>If the <b>RuleType</b> parameter is set to <b>TRANSITION</b>, this parameter specifies the retention period of the backup data. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
            /// <item><description>If the <b>RuleType</b> parameter is set to <b>REPLICATION</b>, this parameter specifies the retention period of remote backups. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
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
            public List<CreatePolicyV2RequestRulesRetentionRules> RetentionRules { get; set; }
            public class CreatePolicyV2RequestRulesRetentionRules : TeaModel {
                /// <summary>
                /// <para>The type of the special retention rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DAILY</b>: retains daily backups</description></item>
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
                /// <para>730</para>
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
            /// <para>The type of the rule. Each backup policy must have at least one rule of the <b>BACKUP</b> type and only one rule of the <b>TRANSITION</b> type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKUP</b>: backup rule</description></item>
            /// <item><description><b>TRANSITION</b>: lifecycle rule</description></item>
            /// <item><description><b>REPLICATION</b>: replication rule</description></item>
            /// <item><description><b>TAG</b>: tag-based resource association rule</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BACKUP</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>BACKUP</b>. This parameter specifies the backup schedule settings. Formats:</para>
            /// <list type="bullet">
            /// <item><description><para><c>I|{startTime}|{interval}</c>: The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
            /// <list type="bullet">
            /// <item><description>startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.</description></item>
            /// <item><description>interval: the interval at which the system runs a backup job. The interval must follow the ISO 8601 standard. For example, <c>PT1H</c> specifies an interval of 1 hour. <c>P1D</c> specifies an interval of one day.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><c>C|{startTime}|{crontab}</c>: The system runs backup jobs at a point in time that is specified in the {startTime} parameter based on the {crontab} expression. For example, C|1631685600|0 0 2 ?\* 3,5,7 indicates that the system runs backup jobs at 02:00:00 every Tuesday, Thursday, and Saturday from14:00:00 on September 15, 2021.``</para>
            /// <list type="bullet">
            /// <item><description>startTime: the time at which the system starts to run a backup job. The time must follow the UNIX time format. Unit: seconds.</description></item>
            /// <item><description>crontab: the crontab expression. For example, 0 0 2 ?\* 3,5,7 indicates 02:00:00 every Tuesday, Thursday, and Saturday.``</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1648647166|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>This parameter is required only if the <b>RuleType</b> parameter is set to <b>TAG</b>. This parameter specifies the resource tag filter rule.</para>
            /// </summary>
            [NameInMap("TagFilters")]
            [Validation(Required=false)]
            public List<CreatePolicyV2RequestRulesTagFilters> TagFilters { get; set; }
            public class CreatePolicyV2RequestRulesTagFilters : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag-based matching rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EQUAL</b>: Both the tag key and tag value are matched.</description></item>
                /// <item><description><b>NOT</b>: The tag key is matched and the tag value is not matched.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The tag value. If you leave this parameter empty, the value is any value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required only if the RuleType parameter is set to BACKUP. The ID of the backup vault.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-0001************aseg</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

    }

}
