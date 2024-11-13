// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePoliciesV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that is used to obtain the next page of backup policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The backup policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePoliciesV2ResponseBodyPolicies> Policies { get; set; }
        public class DescribePoliciesV2ResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The time when the backup policy was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650248136</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The number of data sources that are bound to the backup policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PolicyBindingCount")]
            [Validation(Required=false)]
            public long? PolicyBindingCount { get; set; }

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
            /// <para>po-000************bkz</para>
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
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STANDARD</b>: the general backup policy. This type of policy applies to backups other than Elastic Compute Service (ECS) instance backup.</description></item>
            /// <item><description><b>UDM_ECS_ONLY</b>: the ECS instance backup policy. This type of policy applies only to ECS instance backup.</description></item>
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
            public List<DescribePoliciesV2ResponseBodyPoliciesRules> Rules { get; set; }
            public class DescribePoliciesV2ResponseBodyPoliciesRules : TeaModel {
                /// <summary>
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>TRANSITION</b>. This parameter indicates the time when data is dumped from a backup vault to an archive vault. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ArchiveDays")]
                [Validation(Required=false)]
                public long? ArchiveDays { get; set; }

                /// <summary>
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>BACKUP</b>. This parameter indicates the backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("DataSourceFilters")]
                [Validation(Required=false)]
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFilters> DataSourceFilters { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFilters : TeaModel {
                    [NameInMap("DataSourceIds")]
                    [Validation(Required=false)]
                    public List<string> DataSourceIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>UDM_ECS</para>
                    /// </summary>
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                [NameInMap("Immutable")]
                [Validation(Required=false)]
                public bool? Immutable { get; set; }

                /// <summary>
                /// <para>Indicates whether the feature of keeping at least one backup version is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The feature is disabled.</description></item>
                /// <item><description><b>1</b>: The feature is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                /// <summary>
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>REPLICATION</b>. This parameter indicates the ID of the destination region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ReplicationRegionId")]
                [Validation(Required=false)]
                public string ReplicationRegionId { get; set; }

                /// <summary>
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>TRANSITION</b> or <b>REPLICATION</b>.</para>
                /// <list type="bullet">
                /// <item><description>If the value of the <b>RuleType</b> parameter is <b>TRANSITION</b>, this parameter indicates the retention period of the backup data. Minimum value: 1. Unit: days.</description></item>
                /// <item><description>If the value of the <b>RuleType</b> parameter is <b>REPLICATION</b>, this parameter indicates the retention period of remote backups. Minimum value: 1. Unit: days.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>TRANSITION</b>. This parameter indicates the special retention rules.</para>
                /// </summary>
                [NameInMap("RetentionRules")]
                [Validation(Required=false)]
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules> RetentionRules { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules : TeaModel {
                    /// <summary>
                    /// <para>The type of the special retention rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>WEEKLY</b>: weekly backups</description></item>
                    /// <item><description><b>MONTHLY</b>: monthly backups</description></item>
                    /// <item><description><b>YEARLY</b>: yearly backups</description></item>
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
                    /// <para>Indicates which backup is retained based on the special retention rule. Only the first backup can be retained.</para>
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
                /// <para>rule-000************f1e</para>
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
                /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>BACKUP</b>. This parameter indicates the backup schedule settings. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
                /// <list type="bullet">
                /// <item><description>startTime: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
                /// <item><description>interval: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.</description></item>
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
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesTagFilters> TagFilters { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesTagFilters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>env</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EQUAL</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>prod</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>This parameter is returned only if the value of the RuleType parameter is BACKUP. The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-000**************kgm</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

            /// <summary>
            /// <para>The time when the backup policy was updated. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662080404</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
