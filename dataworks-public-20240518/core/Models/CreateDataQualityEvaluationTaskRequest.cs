// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of data quality rules associated with the data quality monitor. If DataQualityRule.Id is specified, the rule corresponding to that ID is associated with the newly created quality monitor. If not specified, a new rule is created from the other fields and associated with the newly created quality monitor.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public List<CreateDataQualityEvaluationTaskRequestDataQualityRules> DataQualityRules { get; set; }
        public class CreateDataQualityEvaluationTaskRequestDataQualityRules : TeaModel {
            /// <summary>
            /// <para>The sample validation settings.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig CheckingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig : TeaModel {
                /// <summary>
                /// <para>For some threshold types, reference samples must be queried and aggregated to derive the threshold used for comparison. This field uses an expression to describe how the reference samples are queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bizdate&quot;: [&quot;-1&quot;]}</para>
                /// </summary>
                [NameInMap("ReferencedSamplesFilter")]
                [Validation(Required=false)]
                public string ReferencedSamplesFilter { get; set; }

                /// <summary>
                /// <para>The validation threshold settings.</para>
                /// </summary>
                [NameInMap("Thresholds")]
                [Validation(Required=false)]
                public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>The threshold settings for the critical warning level.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression.</para>
                        /// <para>Fluctuation-type rules must use expressions to specify the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                        /// <para>The threshold expression.</para>
                        /// <para>Fluctuation-type rules must use expressions to specify the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                    /// <para>The threshold settings for the normal warning level.</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                        /// <summary>
                        /// <para>The threshold expression.</para>
                        /// <para>Fluctuation-type rules must use expressions to specify the fluctuation threshold. For example:</para>
                        /// <list type="bullet">
                        /// <item><description>Fluctuation increase greater than 0.01: $checkValue &gt; 0.01</description></item>
                        /// <item><description>Fluctuation decrease greater than 0.01: $checkValue &lt; -0.01</description></item>
                        /// <item><description>Absolute fluctuation rate: abs($checkValue) &gt; 0.01</description></item>
                        /// </list>
                        /// <para>Fixed-value rules can also use expressions to configure thresholds. If both are configured, the expression takes precedence over Operator and Value.</para>
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
                /// <para>The method used to compute the threshold. Valid values:</para>
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
            /// <para>The list of error handlers for issues detected by the quality rule validation.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers : TeaModel {
                /// <summary>
                /// <para>For custom SQL rules, the user must specify a SQL statement to filter the problematic data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM ods_api_log WHERE status = \&quot;Error\&quot;;</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>The type of the handler. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SaveErrorData: retains the problematic data.</description></item>
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
            /// <para>The ID of the rule.</para>
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
            /// <para>The parameters required when collecting samples.</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig SamplingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The name of the sampling metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Count: the number of rows in the table.</description></item>
                /// <item><description>Min: the minimum value of the field.</description></item>
                /// <item><description>Max: the maximum value of the field.</description></item>
                /// <item><description>Avg: the average value of the field.</description></item>
                /// <item><description>DistinctCount: the number of distinct values of the field.</description></item>
                /// <item><description>DistinctPercent: the ratio of the number of distinct values of the field to the number of rows.</description></item>
                /// <item><description>DuplicatedCount: the number of duplicate values of the field.</description></item>
                /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values of the field to the number of rows.</description></item>
                /// <item><description>TableSize: the size of the table.</description></item>
                /// <item><description>NullValueCount: the number of rows in which the field is null.</description></item>
                /// <item><description>NullValuePercent: the ratio of rows in which the field is null.</description></item>
                /// <item><description>GroupCount: after grouping by the field value, the count of rows for each value.</description></item>
                /// <item><description>CountNotIn: the number of rows whose enumeration values do not match.</description></item>
                /// <item><description>CountDistinctNotIn: the number of distinct values whose enumeration values do not match.</description></item>
                /// <item><description>UserDefinedSql: collect samples using a custom SQL statement.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NullValueCount</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The parameters required when collecting samples.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>An additional filter condition applied during sampling to exclude data that is not of interest. The maximum length is 16,777,215 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status != \&quot;Succeeded\&quot;</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>The runtime parameter statements inserted and executed before the sampling statement is executed. The maximum length is 1000 characters. Only MaxCompute is currently supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.sql.type.system.odps2=True,odps.sql.hive.compatible=True</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <para>The business severity level of the rule (corresponding to strong/weak rules in the console). Valid values:</para>
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
            /// <para>The unique identifier of the rule template that the rule references.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM:field:null_value:fixed:0</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the data source. You can call <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> to obtain the ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the quality monitoring task.</para>
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
            /// <para>The trigger condition of the hook. The hook action is triggered when this condition is met. Currently only two forms of expressions are supported:</para>
            /// <ol>
            /// <item><description>Specify a single combination of rule severity and rule validation status, for example <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>, which means the condition is met if among the executed rules there exists a rule whose severity is High and whose validation result is Critical.</description></item>
            /// <item><description>Specify multiple combinations of rule severity and rule validation status, for example <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>, which means the condition is met if among the executed rules there exists a rule whose severity is High and validation result is Critical, or a rule whose severity is Normal and validation result is Critical, or a rule whose severity is Normal and validation result is Error. The enumeration of severity in the expression is the same as severity in DataQualityRule, and the enumeration of status is the same as status in DataQualityResult.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The type of the hook. Currently only one type is supported:</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: blocks the scheduling task from continuing to run. If the data quality monitor is triggered by a scheduling task, after the monitor finishes running, Hook.Condition is evaluated to determine whether to block the scheduling task from continuing to run.</description></item>
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
        /// <para>The name of the quality monitoring task.</para>
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
            /// <para>The trigger condition of the notification. The notification is triggered when this condition is met. Currently only two forms of expressions are supported:</para>
            /// <para>Specify a single combination of rule severity and rule validation status, for example <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>, which means the condition is met if among the executed rules there exists a rule whose severity is High and whose validation result is Critical.
            /// Specify multiple combinations of rule severity and rule validation status, for example <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>, which means the condition is met if among the executed rules there exists a rule whose severity is High and validation result is Critical, or a rule whose severity is Normal and validation result is Critical, or a rule whose severity is Normal and validation result is Error. The enumeration of severity in the expression is the same as severity in DataQualityRule, and the enumeration of status is the same as status in DataQualityResult.</para>
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
                    /// <para>Additional parameters used when sending alerts, in JSON format. Supported keys:</para>
                    /// <list type="bullet">
                    /// <item><description>atAll: whether to mention all members (@all) in the group when sending a DingTalk alert. This key takes effect when ReceiverType is set to DingdingUrl.</description></item>
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
                    /// <item><description>WebhookUrl: a custom webhook URL.</description></item>
                    /// <item><description>FeishuUrl: a Lark (Feishu) alert URL.</description></item>
                    /// <item><description>DingdingUrl: a DingTalk alert URL.</description></item>
                    /// <item><description>WeixinUrl: a WeCom (Enterprise WeChat) alert URL.</description></item>
                    /// <item><description>AliUid: an Alibaba Cloud user ID.</description></item>
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
        /// <para>This parameter specifies the DataWorks workspace used by this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extended configuration, a JSON-formatted string. This setting takes effect only for EMR-type data quality monitors.</para>
        /// <list type="bullet">
        /// <item><description>queue: The YARN queue used when running EMR data quality validation. The default is the queue configured for the current project.</description></item>
        /// <item><description>sqlEngine: The SQL engine used when running EMR data validation.<list type="bullet">
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
        /// <para>The data quality monitoring object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTarget Target { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTarget : TeaModel {
            /// <summary>
            /// <para>The type of the database to which the table belongs. Valid values:</para>
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
            /// <para>The partition settings of the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>The unique ID of the table in Data Map.</para>
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
        /// <para>The trigger configuration of the data quality validation task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTrigger Trigger { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The list of scheduling task IDs. This parameter is valid when Type is set to ByScheduledTaskInstance.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger type of the quality monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual: triggered manually. This is the default value.</description></item>
            /// <item><description>ByScheduledTaskInstance: triggered by an associated scheduling task.</description></item>
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
