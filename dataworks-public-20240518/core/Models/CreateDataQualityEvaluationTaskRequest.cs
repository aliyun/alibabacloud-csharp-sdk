// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of data quality rules associated with the data quality monitoring task. If DataQualityRule.Id is specified, the rule corresponding to the ID is associated with the new quality monitoring task. If it is not specified, a new rule is created by using other fields and associated with the new quality monitoring task.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public List<CreateDataQualityEvaluationTaskRequestDataQualityRules> DataQualityRules { get; set; }
        public class CreateDataQualityEvaluationTaskRequestDataQualityRules : TeaModel {
            /// <summary>
            /// <para>The sample verification settings.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig CheckingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig : TeaModel {
                /// <summary>
                /// <para>The expression that represents the query method for reference samples. Some types of thresholds require querying reference samples and aggregating their values to obtain the threshold for comparison.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bizdate&quot;: [&quot;-1&quot;]}</para>
                /// </summary>
                [NameInMap("ReferencedSamplesFilter")]
                [Validation(Required=false)]
                public string ReferencedSamplesFilter { get; set; }

                /// <summary>
                /// <para>The verification threshold settings.</para>
                /// </summary>
                [NameInMap("Thresholds")]
                [Validation(Required=false)]
                public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>The threshold settings for critical warnings.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression. </para>
                        /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                        /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
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
                        /// <para>The threshold value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.01</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The expected threshold settings.</para>
                    /// </summary>
                    [NameInMap("Expected")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression. </para>
                        /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                        /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
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
                        /// <para>The threshold value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The threshold settings for common warnings.</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression. </para>
                        /// <para>For fluctuation rules, you must use an expression to represent the fluctuation threshold. Examples:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01 </description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01 </description></item>
                        /// <item><description>Absolute value of fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$checkValue &gt; 0.01</para>
                        /// </summary>
                        [NameInMap("Expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
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
                        /// <para>The threshold value.</para>
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
                /// <para>The threshold calculation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Fixed</description></item>
                /// <item><description>Fluctation</description></item>
                /// <item><description>FluctationDiscreate</description></item>
                /// <item><description>Auto</description></item>
                /// <item><description>Average</description></item>
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
            /// <para>The description of the data quality rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI test rules</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the quality rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of error handlers for quality rule verification.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers : TeaModel {
                /// <summary>
                /// <para>The SQL statement specified by the user to filter problematic data if the rule is a custom SQL rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM ods_api_log WHERE status = \&quot;Error\&quot;;</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>The handler type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SaveErrorData: Retain problematic data.</description></item>
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
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2176</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the data quality rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI test rules</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameters required for sample collection.</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig SamplingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The name of the sampling metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Count: The number of rows in the table.</description></item>
                /// <item><description>Min: The minimum value of the field.</description></item>
                /// <item><description>Max: The maximum value of the field.</description></item>
                /// <item><description>Avg: The average value of the field.</description></item>
                /// <item><description>DistinctCount: The number of unique values in the field.</description></item>
                /// <item><description>DistinctPercent: The ratio of the number of unique values in the field to the number of data rows.</description></item>
                /// <item><description>DuplicatedCount: The number of duplicate values in the field.</description></item>
                /// <item><description>DuplicatedPercent: The ratio of the number of duplicate values in the field to the number of data rows.</description></item>
                /// <item><description>TableSize: The size of the table.</description></item>
                /// <item><description>NullValueCount: The number of rows where the field is null.</description></item>
                /// <item><description>NullValuePercent: The ratio of rows where the field is null.</description></item>
                /// <item><description>GroupCount: The number of data rows corresponding to each value after aggregation by field value.</description></item>
                /// <item><description>CountNotIn: The number of rows that do not match the enumerated values.</description></item>
                /// <item><description>CountDistinctNotIn: The number of unique values that do not match the enumerated values.</description></item>
                /// <item><description>UserDefinedSql: Sample collection by using custom SQL statements.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NullValueCount</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The parameters required for sample collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>The conditions for secondary filtering of irrelevant data during sampling. The maximum length is 16,777,215 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status != \&quot;Succeeded\&quot;</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>The runtime parameter setting statements inserted before the sampling statements are executed. The maximum length is 1,000 characters. Only MaxCompute is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.sql.type.system.odps2=True,odps.sql.hive.compatible=True</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <para>The severity level of the rule for the business, which corresponds to strong and weak rules on the page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>High</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>High</para>
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The unique identifier of the rule template referenced by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM:field:null_value:fixed:0</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the data source. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the data quality monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI create a data quality monitoring test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook settings.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<CreateDataQualityEvaluationTaskRequestHooks> Hooks { get; set; }
        public class CreateDataQualityEvaluationTaskRequestHooks : TeaModel {
            /// <summary>
            /// <para>The trigger condition for the hook. When this condition is met, the hook action is triggered. Two conditional expressions are supported:</para>
            /// <ol>
            /// <item><description>Specify only one group of rule severity and check status. Example: <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means that among the rules to execute, if the check result of a rule with the High severity is Critical, the condition is met.</description></item>
            /// <item><description>Specify multiple groups of rule severity and check status. Example: <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means that among the rules to execute, if the check result of a rule with the High severity is Critical, the check result of a rule with the Normal severity is Critical, or the check result of a rule with the Normal severity is Error, the condition is met. The valid values of severity in the conditional expression are the same as those in DataQualityRule, and the valid values of status are the same as those in DataQualityResult.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The hook type. Only one type is supported:</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: blocks the scheduled task from continuing to run. If the data quality monitoring task is triggered by a scheduled task, the system determines whether to block the scheduled task based on Hook.Condition after the data quality monitoring task is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BlockTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the data quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI create a data quality monitoring test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification subscription configuration.</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestNotifications Notifications { get; set; }
        public class CreateDataQualityEvaluationTaskRequestNotifications : TeaModel {
            /// <summary>
            /// <para>The trigger condition for notifications. When this condition is met, a message notification is triggered. Two conditional expressions are supported:</para>
            /// <para>Specify only one group of rule severity and check status. Example: <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This means that among the rules to execute, if the check result of a rule with the High severity is Critical, the condition is met.
            /// Specify multiple groups of rule severity and check status. Example: <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This means that among the rules to execute, if the check result of a rule with the High severity is Critical, the check result of a rule with the Normal severity is Critical, or the check result of a rule with the Normal severity is Error, the condition is met. The valid values of severity in the conditional expression are the same as those in DataQualityRule, and the valid values of status are the same as those in DataQualityResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The notification settings.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<CreateDataQualityEvaluationTaskRequestNotificationsNotifications> Notifications { get; set; }
            public class CreateDataQualityEvaluationTaskRequestNotificationsNotifications : TeaModel {
                /// <summary>
                /// <para>The notification methods.</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels : TeaModel {
                    /// <summary>
                    /// <para>The notification methods.</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                }

                /// <summary>
                /// <para>The alert recipient settings.</para>
                /// </summary>
                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>The additional parameter settings in JSON format when an alert is sent. Supported keys:</para>
                    /// <list type="bullet">
                    /// <item><description>atAll: specifies whether to @all in the group when sending a DingTalk alert. This key takes effect only when ReceiverType is set to DingdingUrl.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{  &quot;atAll&quot;: true }</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>The type of the alert recipient. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>WebhookUrl: custom webhook URL</description></item>
                    /// <item><description>FeishuUrl: Lark alert URL</description></item>
                    /// <item><description>DingdingUrl: DingTalk alert URL</description></item>
                    /// <item><description>WeixinUrl: WeCom alert URL</description></item>
                    /// <item><description>AliUid: Alibaba Cloud user ID</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DingdingUrl</para>
                    /// </summary>
                    [NameInMap("ReceiverType")]
                    [Validation(Required=false)]
                    public string ReceiverType { get; set; }

                    /// <summary>
                    /// <para>The alert recipients.</para>
                    /// </summary>
                    [NameInMap("ReceiverValues")]
                    [Validation(Required=false)]
                    public List<string> ReceiverValues { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter is used to determine the DataWorks workspace used to invoke this API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extension configurations in JSON string format. This parameter takes effect only for EMR data quality monitoring tasks.</para>
        /// <list type="bullet">
        /// <item><description>queue: the YARN queue used to execute EMR data validation. Default value: the queue configured for the project.</description></item>
        /// <item><description>sqlEngine: the SQL engine used to execute EMR data validation. Valid values:<list type="bullet">
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
        /// <para>The monitored object for the data quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTarget Target { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTarget : TeaModel {
            /// <summary>
            /// <para>The database type of the table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>maxcompute</description></item>
            /// <item><description>hologres</description></item>
            /// <item><description>cdh</description></item>
            /// <item><description>analyticdb_for_mysql</description></item>
            /// <item><description>starrocks</description></item>
            /// <item><description>emr</description></item>
            /// <item><description>analyticdb_for_postgresql</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The partition settings for the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>The unique ID of the table in DataWorks Data Map.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.api_test.ods_openapi_log_d</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

        }

        /// <summary>
        /// <para>The trigger configuration for the data quality check task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTrigger Trigger { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The list of scheduled task IDs. This parameter takes effect only when Type is set to ByScheduledTaskInstance.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger type for the data quality monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual: triggered manually. This is the default value.</description></item>
            /// <item><description>ByScheduledTaskInstance: triggered by an associated scheduled task.</description></item>
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
