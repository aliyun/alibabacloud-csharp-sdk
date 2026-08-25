// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribePoliciesV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of results per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message. The value &quot;successful&quot; is returned for a successful request. An error message is returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token required to retrieve the next page of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePoliciesV2ResponseBodyPolicies> Policies { get; set; }
        public class DescribePoliciesV2ResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The user business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The creation time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650248136</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The number of data sources bound to the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PolicyBindingCount")]
            [Validation(Required=false)]
            public long? PolicyBindingCount { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Back up every day at 10:00 AM and replicate to Shanghai</para>
            /// </summary>
            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-000************bkz</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily backup + geo-redundancy backup</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>STANDARD</b>: general backup policy. Supports backing up data sources other than ECS instance backup.</description></item>
            /// <item><description><b>UDM_ECS_ONLY</b>: ECS instance backup policy. Supports backing up only ECS instances.</description></item>
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
            public List<DescribePoliciesV2ResponseBodyPoliciesRules> Rules { get; set; }
            public class DescribePoliciesV2ResponseBodyPoliciesRules : TeaModel {
                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TRANSITION</b>. The number of days after which the backup is converted to archive storage. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ArchiveDays")]
                [Validation(Required=false)]
                public long? ArchiveDays { get; set; }

                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>BACKUP</b>. The backup type. The value is <b>COMPLETE</b>, which indicates a full backup.</para>
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
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFilters> DataSourceFilters { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFilters : TeaModel {
                    [NameInMap("AccountScope")]
                    [Validation(Required=false)]
                    public string AccountScope { get; set; }

                    [NameInMap("Accounts")]
                    [Validation(Required=false)]
                    public List<DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFiltersAccounts> Accounts { get; set; }
                    public class DescribePoliciesV2ResponseBodyPoliciesRulesDataSourceFiltersAccounts : TeaModel {
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
                    /// <item><description><b>UDM_ECS</b>: ECS instance backup.</description></item>
                    /// <item><description><b>OSS</b>: OSS backup.</description></item>
                    /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
                    /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition.</description></item>
                    /// <item><description><b>OTS</b>: Tablestore backup.</description></item>
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
                /// <para>This parameter is valid only when <b>PolicyType</b> is set to <b>UDM_ECS_ONLY</b>. Specifies whether to enable backup locking.</para>
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
                /// <item><description><b>0</b>: Do not retain.</description></item>
                /// <item><description><b>1</b>: Retain.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeepLatestSnapshots")]
                [Validation(Required=false)]
                public long? KeepLatestSnapshots { get; set; }

                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>REPLICATION</b>. The destination region ID for replication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ReplicationRegionId")]
                [Validation(Required=false)]
                public string ReplicationRegionId { get; set; }

                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TRANSITION</b> or <b>REPLICATION</b>.</para>
                /// <list type="bullet">
                /// <item><description><b>RuleType</b> is set to <b>TRANSITION</b>: the retention period of the backup. Minimum value: 1. Unit: days.</description></item>
                /// <item><description><b>RuleType</b> is set to <b>REPLICATION</b>: the retention period of the geo-redundancy backup. Minimum value: 1. Unit: days.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>TRANSITION</b>. The list of special retention rules.</para>
                /// </summary>
                [NameInMap("RetentionRules")]
                [Validation(Required=false)]
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules> RetentionRules { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesRetentionRules : TeaModel {
                    /// <summary>
                    /// <para>The type of the special retention rule. Valid values:</para>
                    /// <list type="bullet">
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
                    /// <para>The backup to which the rule applies. Currently, only the first backup is supported. The value is 1.</para>
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
                /// <para>The rule type. Each policy must have at least one <b>BACKUP</b> rule and exactly one <b>TRANSITION</b> rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BACKUP</b>: backup rule.</description></item>
                /// <item><description><b>TRANSITION</b>: lifecycle rule.</description></item>
                /// <item><description><b>REPLICATION</b>: replication rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BACKUP</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>This parameter is required only when <b>RuleType</b> is set to <b>BACKUP</b>. The backup schedule. Optional format: <c>I|{startTime}|{interval}</c>. This indicates that a backup job is executed at every {interval} starting from {startTime}. Backup jobs for past time periods are not compensated. If the previous backup job is not completed, the next backup job is not triggered. For example, <c>I|1631685600|P1D</c> indicates that a backup is performed once a day starting from 2021-09-15 14:00:00.</para>
                /// <list type="bullet">
                /// <item><description>startTime: the start time of the backup. UNIX timestamp, in seconds.</description></item>
                /// <item><description>interval: the ISO 8601 time interval. For example, PT1H indicates an interval of one hour. P1D indicates an interval of one day.</description></item>
                /// </list>
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
                public List<DescribePoliciesV2ResponseBodyPoliciesRulesTagFilters> TagFilters { get; set; }
                public class DescribePoliciesV2ResponseBodyPoliciesRulesTagFilters : TeaModel {
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
                    /// <item><description><b>EQUAL</b>: matches both the tag key and the tag value.</description></item>
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
                /// <para>v-000**************kgm</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

            /// <summary>
            /// <para>The update time. UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662080404</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
