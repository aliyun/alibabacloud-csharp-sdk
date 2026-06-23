// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>List of data quality rules associated with the data quality monitoring.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public List<UpdateDataQualityEvaluationTaskRequestDataQualityRules> DataQualityRules { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestDataQualityRules : TeaModel {
            /// <summary>
            /// <para>Sample validation settings</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig CheckingConfig { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig : TeaModel {
                /// <summary>
                /// <para>Some threshold types require querying reference samples and then aggregating their values to derive the comparison threshold. An expression is used here to indicate how the reference samples are queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bizdate&quot;: [&quot;-1&quot;]}</para>
                /// </summary>
                [NameInMap("ReferencedSamplesFilter")]
                [Validation(Required=false)]
                public string ReferencedSamplesFilter { get; set; }

                /// <summary>
                /// <para>Validation threshold settings.</para>
                /// </summary>
                [NameInMap("Thresholds")]
                [Validation(Required=false)]
                public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>Threshold settings for critical warnings</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                        /// <summary>
                        /// <para>Threshold expression.</para>
                        /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation rises above 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation drops below 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value-type rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison operator</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>=</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <remarks>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>Threshold value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.01</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Expected threshold settings</para>
                    /// </summary>
                    [NameInMap("Expected")]
                    [Validation(Required=false)]
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
                        /// <summary>
                        /// <para>Threshold expression.</para>
                        /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation rises above 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation drops below 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value-type rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison operator</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>=</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>=</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>Threshold value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Threshold settings for normal warnings</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                        /// <summary>
                        /// <para>Threshold expression.</para>
                        /// <para>Fluctuation-type rules must use an expression to represent the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation rises above 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation drops below 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value-type rules can also use an expression to configure the threshold. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>Comparison operator</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>\&lt;</description></item>
                        /// <item><description>\&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>=</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <remarks>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>Threshold value</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.001</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>Threshold calculation method</para>
                /// <list type="bullet">
                /// <item><description>Fluctation: Fluctuation range validation</description></item>
                /// <item><description>Auto: Intelligent threshold validation</description></item>
                /// <item><description>FluctationDiscreate: Discrete value fluctuation range validation</description></item>
                /// <item><description>Average: Mean fluctuation range validation</description></item>
                /// <item><description>Fixed: Fixed value validation</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Fixed</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Description of the data quality rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI test rules</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Whether the data quality rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Quality rule validation issue handler</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<UpdateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers : TeaModel {
                /// <summary>
                /// <para>For custom SQL rules, the user must specify the SQL to filter problematic data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM ods_d_openapi_log WHERE status = \&quot;Error\&quot;</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>Handler type:</para>
                /// <list type="bullet">
                /// <item><description>SaveErrorData: Retain problematic data</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SaveErrorData</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>ID of the validation rule. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1022171560</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name of the data quality rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI test rules</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Parameters required for sample collection</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public UpdateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig SamplingConfig { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig : TeaModel {
                /// <summary>
                /// <para>Name of the sampling metric</para>
                /// <list type="bullet">
                /// <item><description>Count: Number of rows in the table</description></item>
                /// <item><description>Min: Minimum value of the field</description></item>
                /// <item><description>Max: Maximum value of the field</description></item>
                /// <item><description>Avg: Average value of the field</description></item>
                /// <item><description>DistinctCount: Number of distinct values of the field</description></item>
                /// <item><description>DistinctPercent: Ratio of the number of distinct field values to the total number of rows</description></item>
                /// <item><description>DuplicatedCount: Number of duplicate values of the field</description></item>
                /// <item><description>DuplicatedPercent: Ratio of the number of duplicate field values to the total number of rows</description></item>
                /// <item><description>TableSize: Size of the table</description></item>
                /// <item><description>NullValueCount: Number of rows where the field is null</description></item>
                /// <item><description>NullValuePercent: Proportion of rows where the field is null</description></item>
                /// <item><description>GroupCount: After aggregating by field value, each value and its corresponding number of rows</description></item>
                /// <item><description>CountNotIn: Number of rows whose enum values do not match</description></item>
                /// <item><description>CountDistinctNotIn: Number of distinct values whose enum values do not match</description></item>
                /// <item><description>UserDefinedSql: Sample collection via custom SQL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CountNotIn</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>Parameters required for sample collection</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>Conditions for further filtering of data not of concern during sampling. Maximum 16777215 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status != \&quot;Succeeded\&quot;</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>Runtime parameter setting statements to be inserted and executed before the actual sampling statement. Maximum 1000 characters. Currently only MaxCompute is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.sql.type.system.odps2=True,odps.sql.hive.compatible=True</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <para>Severity level of the rule for the business (corresponds to strong/weak rules on the page). Optional enum values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>High</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>Unique identifier of the rule template referenced by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM:field:null_value:fixed:0</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>Data source ID. You can call <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> to obtain the data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358750</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>Description of the quality monitoring task</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Callback settings</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<UpdateDataQualityEvaluationTaskRequestHooks> Hooks { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestHooks : TeaModel {
            /// <summary>
            /// <para>Hook trigger condition. When this condition is met, the hook action is triggered. Currently, only two types of condition expressions are supported:</para>
            /// <list type="bullet">
            /// <item><description>Specify a single group of rule severity type and rule validation status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means the condition is met when any executed rule with severity High has a validation result of Critical.</description></item>
            /// <item><description>Specify multiple groups of rule severity type and rule validation status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means the condition is met when any executed rule satisfies one of the following: severity High with validation result Critical, severity Normal with validation result Critical, or severity Normal with validation result Error. The severity enum in the condition expression is consistent with the severity enum in DataQualityRule, and the status enum is consistent with the status in DataQualityResult.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>Hook actions executed after data quality validation completes.</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: Block the scheduling task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ByScheduledTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Data quality monitoring ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7227061794</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Name of the quality monitoring task</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Notification subscription configuration</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestNotifications Notifications { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestNotifications : TeaModel {
            /// <summary>
            /// <para>Notification trigger condition. When this condition is met, a message notification is triggered. Currently, only two types of condition expressions are supported:</para>
            /// <list type="bullet">
            /// <item><description>Specify a single group of rule severity type and rule validation status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means the condition is met when any executed rule with severity High has a validation result of Critical.</description></item>
            /// <item><description>Specify multiple groups of rule severity type and rule validation status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means the condition is met when any executed rule satisfies one of the following: severity High with validation result Critical, severity Normal with validation result Critical, or severity Normal with validation result Error. The severity enum in the condition expression is consistent with the severity enum in DataQualityRule, and the status enum is consistent with the status in DataQualityResult.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>Notification settings</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotifications> Notifications { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestNotificationsNotifications : TeaModel {
                /// <summary>
                /// <para>Notification method</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels : TeaModel {
                    /// <summary>
                    /// <para>Notification method</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                }

                /// <summary>
                /// <para>Alert recipient settings</para>
                /// </summary>
                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>Additional parameter settings when sending alerts. JSON format. The supported keys are as follows:</para>
                    /// <list type="bullet">
                    /// <item><description>atAll: Whether to @all members in the group when sending DingTalk alerts. Takes effect when ReceiverType is DingdingUrl.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{  &quot;atAll&quot;: true }</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>Alert recipient type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DingdingUrl</para>
                    /// </summary>
                    [NameInMap("ReceiverType")]
                    [Validation(Required=false)]
                    public string ReceiverType { get; set; }

                    /// <summary>
                    /// <para>Alert recipients</para>
                    /// </summary>
                    [NameInMap("ReceiverValues")]
                    [Validation(Required=false)]
                    public List<string> ReceiverValues { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Workspace ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Extended configuration. A JSON-formatted string. Takes effect only for EMR-type data quality monitoring.</para>
        /// <list type="bullet">
        /// <item><description>queue: The YARN queue used when executing EMR data quality validation. Defaults to the queue configured for the current project.</description></item>
        /// <item><description>sqlEngine: The SQL engine used when executing EMR data validation.<list type="bullet">
        /// <item><description>HIVE_SQL</description></item>
        /// <item><description>SPARK_SQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
        /// </summary>
        [NameInMap("RuntimeConf")]
        [Validation(Required=false)]
        public string RuntimeConf { get; set; }

        /// <summary>
        /// <para>Data quality monitoring object</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestTarget Target { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestTarget : TeaModel {
            /// <summary>
            /// <para>Database type to which the table belongs</para>
            /// <list type="bullet">
            /// <item><description>maxcompute</description></item>
            /// <item><description>hologres</description></item>
            /// <item><description>cdh</description></item>
            /// <item><description>analyticdb_for_mysql</description></item>
            /// <item><description>starrocks</description></item>
            /// <item><description>emr</description></item>
            /// <item><description>analyticdb_for_postgresql</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>Partition settings of the partitioned table</para>
            /// 
            /// <b>Example:</b>
            /// <para>dt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>Unique ID of the table in Data Map</para>
            /// 
            /// <b>Example:</b>
            /// <para>odsp.openapi.ods_d_openapi_log</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

        }

        /// <summary>
        /// <para>Trigger configuration of the data quality validation task</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestTrigger Trigger { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>List of scheduling task IDs. Valid when Type is ByScheduledTaskInstance.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>Trigger type of the quality monitoring task.</para>
            /// <list type="bullet">
            /// <item><description>ByScheduledTaskInstance: Triggered by an associated scheduling task.</description></item>
            /// <item><description>ByManual: Triggered manually.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ByScheduledTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
