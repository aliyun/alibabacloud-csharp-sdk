// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of monitoring rules that are associated with the monitor. If you configure the ID of a monitoring rule by using the DataQualityRule.Id parameter, the system associates the rule with a created monitor. If you do not configure the ID of a monitoring rule, the system creates a new monitoring rule by using other fields and associates the rule with a created monitor.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public List<CreateDataQualityEvaluationTaskRequestDataQualityRules> DataQualityRules { get; set; }
        public class CreateDataQualityEvaluationTaskRequestDataQualityRules : TeaModel {
            /// <summary>
            /// <para>The check settings for sample data.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig CheckingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig : TeaModel {
                /// <summary>
                /// <para>The method that is used to query the referenced samples. To obtain specific types of thresholds, you must query reference values. In this example, an expression is used to specify the query method of referenced samples.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bizdate&quot;: [&quot;-1&quot;]}</para>
                /// </summary>
                [NameInMap("ReferencedSamplesFilter")]
                [Validation(Required=false)]
                public string ReferencedSamplesFilter { get; set; }

                /// <summary>
                /// <para>The threshold settings.</para>
                /// </summary>
                [NameInMap("Thresholds")]
                [Validation(Required=false)]
                public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>The threshold settings for critical alerts.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>\=</description></item>
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
                    /// <para>The expected threshold setting.</para>
                    /// </summary>
                    [NameInMap("Expected")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>\=</description></item>
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
                    /// <para>The threshold settings for normal alerts.</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                    public class CreateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
                        /// <summary>
                        /// <para>The comparison operator. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>\&gt;</description></item>
                        /// <item><description>\&gt;=</description></item>
                        /// <item><description>&lt;</description></item>
                        /// <item><description>&lt;=</description></item>
                        /// <item><description>!=</description></item>
                        /// <item><description>\=</description></item>
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
                /// <item><description>Fluctuation</description></item>
                /// <item><description>FluctuationDiscreate</description></item>
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
            /// <para>The description of the monitoring rule.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The operations that you can perform after the rule-based check.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers : TeaModel {
                /// <summary>
                /// <para>The SQL statement that is used to filter failed tasks. If you define the rule by using custom SQL statements, you must specify an SQL statement to filter failed tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM ods_api_log WHERE status = \&quot;Error\&quot;;</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>The type of the operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SaveErrorData</description></item>
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
            /// <para>The name of the monitoring rule.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameters required for sampling.</para>
            /// </summary>
            [NameInMap("SamplingConfig")]
            [Validation(Required=false)]
            public CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig SamplingConfig { get; set; }
            public class CreateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The metrics used for sampling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Count: the number of rows in the table.</description></item>
                /// <item><description>Min: the minimum value of the field.</description></item>
                /// <item><description>Max: the maximum value of the field.</description></item>
                /// <item><description>Avg: the average value of the field.</description></item>
                /// <item><description>DistinctCount: the number of unique values of the field after deduplication.</description></item>
                /// <item><description>DistinctPercent: the proportion of the number of unique values of the field after deduplication to the number of rows in the table.</description></item>
                /// <item><description>DuplicatedCount: the number of duplicated values of the field.</description></item>
                /// <item><description>DuplicatedPercent: the proportion of the number of duplicated values of the field to the number of rows in the table.</description></item>
                /// <item><description>TableSize: the table size.</description></item>
                /// <item><description>NullValueCount: the number of rows in which the field value is null.</description></item>
                /// <item><description>NullValuePercent: the proportion of the number of rows in which the field value is null to the number of rows in the table.</description></item>
                /// <item><description>GroupCount: the field value and the number of rows for each field value.</description></item>
                /// <item><description>CountNotIn: the number of rows in which the field values are different from the referenced values that you specified in the rule.</description></item>
                /// <item><description>CountDistinctNotIn: the number of unique values that are different from the referenced values that you specified in the rule after deduplication.</description></item>
                /// <item><description>UserDefinedSql: specifies that data is sampled by executing custom SQL statements.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NullValueCount</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <para>The parameters required for sampling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Columns&quot;: [ &quot;id&quot;, &quot;name&quot; ] , &quot;SQL&quot;: &quot;select count(1) from table;&quot;}</para>
                /// </summary>
                [NameInMap("MetricParameters")]
                [Validation(Required=false)]
                public string MetricParameters { get; set; }

                /// <summary>
                /// <para>The statements that are used to filter unnecessary data during sampling. The statements can be up to 16,777,215 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status != \&quot;Succeeded\&quot;</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>The statements that are used to configure the parameters required for sampling before you execute the sampling statements. The statements can be up to 1,000 characters in length. Only the MaxCompute database is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.sql.type.system.odps2=True,odps.sql.hive.compatible=True</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <para>The strength of the monitoring rule. Valid values:</para>
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
            /// <para>The ID of the template used by the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM:field:null_value:fixed:0</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the monitor.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<CreateDataQualityEvaluationTaskRequestHooks> Hooks { get; set; }
        public class CreateDataQualityEvaluationTaskRequestHooks : TeaModel {
            /// <summary>
            /// <para>The hook trigger condition. When this condition is met, the hook action is triggered. Only two conditional expressions are supported:</para>
            /// <ol>
            /// <item><description>Specify only one group of rule strength type and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical.</description></item>
            /// <item><description>Specify multiple groups of rule strength types and rule check status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical, severity is Normal and status is Critical, or severity is Normal and status is Error. The enumeration of severity in a conditional expression is the same as the enumeration of severity in DataQualityRule. The enumeration of status in a conditional expression is the same as the enumeration of status in DataQualityResult.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The hook type. Only one hook type is supported.</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: Blocks the running of scheduling tasks. A monitor is triggered by scheduling tasks. After a monitor finishes running, the monitor determines whether to block the running of scheduling tasks based on the hook condition.</description></item>
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
        /// <para>The name of the monitor.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations of alert notifications.</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestNotifications Notifications { get; set; }
        public class CreateDataQualityEvaluationTaskRequestNotifications : TeaModel {
            /// <summary>
            /// <para>The notification trigger condition. When this condition is met, the alert notification is triggered. Only two conditional expressions are supported:</para>
            /// <para>Specify only one group of rule strength type and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical. Specify multiple groups of rule strength types and rule check status, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical, severity is Normal and status is Critical, or severity is Normal and status is Error. The enumeration of severity in a conditional expression is the same as the enumeration of severity in DataQualityRule. The enumeration of status in a conditional expression is the same as the enumeration of status in DataQualityResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The configurations of the alert notification.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<CreateDataQualityEvaluationTaskRequestNotificationsNotifications> Notifications { get; set; }
            public class CreateDataQualityEvaluationTaskRequestNotificationsNotifications : TeaModel {
                /// <summary>
                /// <para>The alert notification method.</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels : TeaModel {
                    /// <summary>
                    /// <para>The alert notification method.</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                }

                /// <summary>
                /// <para>The configurations of alert recipients.</para>
                /// </summary>
                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class CreateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>The additional parameters that are required when alerts are sent. The parameters are JSON-formatted strings. The following keys are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>atAll: specifies that all members in a group are mentioned when alerts are sent by using DingTalk. This parameter is valid only if you set ReceiverType to DingdingUrl.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{  &quot;atAll&quot;: true }</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>The type of the alert recipient.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>WebhookUrl</description></item>
                    /// <item><description>FeishuUrl</description></item>
                    /// <item><description>DingdingUrl</description></item>
                    /// <item><description>WeixinUrl</description></item>
                    /// <item><description>AliUid</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DingdingUrl</para>
                    /// </summary>
                    [NameInMap("ReceiverType")]
                    [Validation(Required=false)]
                    public string ReceiverType { get; set; }

                    /// <summary>
                    /// <para>The alert recipient.</para>
                    /// </summary>
                    [NameInMap("ReceiverValues")]
                    [Validation(Required=false)]
                    public List<string> ReceiverValues { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You can use this parameter to specify the DataWorks workspace on which you want to perform the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extended configurations in JSON-formatted strings. You can use this parameter only for monitors that are used to monitor the quality of E-MapReduce (EMR) data.</para>
        /// <list type="bullet">
        /// <item><description><para>queue: The Yarn queue used when a monitor checks the quality of EMR data. By default, the queue configured for the current workspace is used.</para>
        /// </description></item>
        /// <item><description><para>sqlEngine: The SQL engine used when a monitor checks the quality of EMR data.</para>
        /// <list type="bullet">
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
        /// <para>The monitored object of the monitor.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTarget Target { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTarget : TeaModel {
            /// <summary>
            /// <para>The type of the database to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <para>The partition configuration of the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>The ID of the table in Data Map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.api_test.ods_openapi_log_d</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

        }

        /// <summary>
        /// <para>The trigger configuration of the monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskRequestTrigger Trigger { get; set; }
        public class CreateDataQualityEvaluationTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The IDs of scheduling tasks. This parameter is valid only if you set Type to ByScheduledTaskInstance.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger type of the monitor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual (default): The monitor is manually triggered.</description></item>
            /// <item><description>ByScheduledTaskInstance: The monitor is triggered by the associated scheduling tasks.</description></item>
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
