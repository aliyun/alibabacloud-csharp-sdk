// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreatePolicyV2Request : TeaModel {
        /// <summary>
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Backup once every day at 10:00 AM, with cross-region backup to Shanghai.</para>
        /// </summary>
        [NameInMap("PolicyDescription")]
        [Validation(Required=false)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily local backup + geo-redundancy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: general backup policy. Supports backing up data sources other than ECS instances.</description></item>
        /// <item><description><b>UDM_ECS_ONLY</b>: ECS instance backup policy. Supports backing up only ECS instances.</description></item>
        /// </list>
        /// <para>If you do not specify the policy type, Cloud Backup automatically sets the policy type based on whether a backup vault is specified in the policy rules:</para>
        /// <list type="bullet">
        /// <item><description>A backup vault is specified in the policy rules: <b>STANDARD</b></description></item>
        /// <item><description>No backup vault is specified in the policy rules: <b>UDM_ECS_ONLY</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The list of policy rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreatePolicyV2RequestRules> Rules { get; set; }
        public class CreatePolicyV2RequestRules : TeaModel {
            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TRANSITION</b>. The number of days after which a backup is automatically moved to the archive tier. Backups must be retained in the standard tier for at least 30 days and in the archive tier for at least 60 days. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("ArchiveDays")]
            [Validation(Required=false)]
            public long? ArchiveDays { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>BACKUP</b>. The backup type. Set the value to <b>COMPLETE</b>, which specifies full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TAG</b>. The data source filter rules.</para>
            /// </summary>
            [NameInMap("DataSourceFilters")]
            [Validation(Required=false)]
            public List<CreatePolicyV2RequestRulesDataSourceFilters> DataSourceFilters { get; set; }
            public class CreatePolicyV2RequestRulesDataSourceFilters : TeaModel {
                [NameInMap("AccountScope")]
                [Validation(Required=false)]
                public string AccountScope { get; set; }

                [NameInMap("Accounts")]
                [Validation(Required=false)]
                public List<CreatePolicyV2RequestRulesDataSourceFiltersAccounts> Accounts { get; set; }
                public class CreatePolicyV2RequestRulesDataSourceFiltersAccounts : TeaModel {
                    [NameInMap("CrossAccountRoleName")]
                    [Validation(Required=false)]
                    public string CrossAccountRoleName { get; set; }

                    [NameInMap("CrossAccountType")]
                    [Validation(Required=false)]
                    public string CrossAccountType { get; set; }

                    [NameInMap("CrossAccountUserId")]
                    [Validation(Required=false)]
                    public long? CrossAccountUserId { get; set; }

                }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>Deprecated.</para>
                /// </summary>
                [NameInMap("DataSourceIds")]
                [Validation(Required=false)]
                [Obsolete]
                public List<string> DataSourceIds { get; set; }

                /// <summary>
                /// <para>The data source type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UDM_ECS</b>: ECS instance backup. This data source type is supported only when <b>PolicyType</b> is set to <b>UDM_ECS_ONLY</b>.</description></item>
                /// <item><description><b>OSS</b>: OSS backup. This data source type is supported only when <b>PolicyType</b> is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup. This data source type is supported only when <b>PolicyType</b> is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition. This data source type is supported only when <b>PolicyType</b> is set to <b>STANDARD</b>.</description></item>
                /// <item><description><b>OTS</b>: Tablestore backup. This data source type is supported only when <b>PolicyType</b> is set to <b>STANDARD</b>.</description></item>
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
            /// <para>This parameter is required only when <b>PolicyType</b> is set to <b>UDM_ECS_ONLY</b> and <b>RuleType</b> is set to <b>SECURITY</b>. Specifies whether to enable backup locking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Immutable")]
            [Validation(Required=false)]
            public bool? Immutable { get; set; }

            /// <summary>
            /// <para>Specifies whether to retain at least one backup version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: do not retain.</description></item>
            /// <item><description>1: retain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeepLatestSnapshots")]
            [Validation(Required=false)]
            public long? KeepLatestSnapshots { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>REPLICATION</b>. The ID of the destination region for replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ReplicationRegionId")]
            [Validation(Required=false)]
            public string ReplicationRegionId { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>BACKUP</b>, <b>TRANSITION</b>, or <b>REPLICATION</b>.</para>
            /// <list type="bullet">
            /// <item><description>If <b>RuleType</b> is set to <b>BACKUP</b>: the retention period of backups. The priority of this parameter is lower than the Retention parameter of the rule whose <b>RuleType</b> is <b>TRANSITION</b>. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
            /// <item><description>If <b>RuleType</b> is set to <b>TRANSITION</b>: the retention period of backups. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
            /// <item><description>If <b>RuleType</b> is set to <b>REPLICATION</b>: the retention period of cross-region backups. Minimum value: 1. Maximum value: 364635. Unit: days.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TRANSITION</b>. The special retention rules.</para>
            /// </summary>
            [NameInMap("RetentionRules")]
            [Validation(Required=false)]
            public List<CreatePolicyV2RequestRulesRetentionRules> RetentionRules { get; set; }
            public class CreatePolicyV2RequestRulesRetentionRules : TeaModel {
                /// <summary>
                /// <para>The type of the special retention rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DAILY</b>: daily backup.</description></item>
                /// <item><description><b>WEEKLY</b>: weekly backup.</description></item>
                /// <item><description><b>MONTHLY</b>: monthly backup.</description></item>
                /// <item><description><b>YEARLY</b>: yearly backup.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>YEARLY</para>
                /// </summary>
                [NameInMap("AdvancedRetentionType")]
                [Validation(Required=false)]
                public string AdvancedRetentionType { get; set; }

                /// <summary>
                /// <para>The special retention period of the backup. Minimum value: 1. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>The backup to which the rule applies. Currently, only the first backup is supported. Set the value to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WhichSnapshot")]
                [Validation(Required=false)]
                public long? WhichSnapshot { get; set; }

            }

            /// <summary>
            /// <para>The rule type. Each policy must have at least one <b>BACKUP</b> rule and exactly one <b>TRANSITION</b> rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKUP</b>: backup rule.</description></item>
            /// <item><description><b>TRANSITION</b>: lifecycle rule.</description></item>
            /// <item><description><b>REPLICATION</b>: replication rule.</description></item>
            /// <item><description><b>TAG</b>: tag-based resource association rule.</description></item>
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
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>BACKUP</b>. The backup schedule settings. Supported formats:</para>
            /// <list type="bullet">
            /// <item><description><para><c>I|{startTime}|{interval}</c>: specifies that a backup job is executed at the specified interval starting from {startTime}. For example, <c>I|1631685600|P1D</c> specifies that a backup job is executed once a day starting from 2021-09-15 14:00:00.</para>
            /// <list type="bullet">
            /// <item><description>startTime: the start time of the backup. This value is a UNIX timestamp. Unit: seconds.</description></item>
            /// <item><description>interval: the ISO 8601 time interval. For example, <c>PT1H</c> specifies an interval of one hour. <c>P1D</c> specifies an interval of one day.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><c>C|{startTime}|{crontab}</c>: specifies that a backup job is executed based on the {crontab} expression starting from {startTime}. For example, <c>C|1631685600|0 0 2 ? * 3,5,7</c> specifies that a backup job is executed at 02:00:00 every Tuesday, Thursday, and Saturday starting from 2021-09-15 14:00:00.</para>
            /// <list type="bullet">
            /// <item><description>startTime: the start time of the backup. This value is a UNIX timestamp. Unit: seconds.</description></item>
            /// <item><description>crontab: the crontab expression. For example, <c>0 0 2 ? * 3,5,7</c> specifies every Tuesday, Thursday, and Saturday at 02:00:00.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>Backup jobs that are missed are not compensated. If the previous backup job is not complete, the next backup job is not triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I|1648647166|P1D</para>
            /// </summary>
            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            /// <summary>
            /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TAG</b>. The resource tag filter rules.</para>
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
                /// <para>The tag matching rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EQUAL</b>: matches both the tag key and tag value.</description></item>
                /// <item><description><b>NOT</b>: matches the tag key but not the tag value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EQUAL</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The tag value. An empty value indicates any value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required only when RuleType is set to BACKUP. The backup vault ID.</para>
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
