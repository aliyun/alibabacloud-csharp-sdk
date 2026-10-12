// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityEvaluationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of data quality rules associated with data quality monitoring.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public List<UpdateDataQualityEvaluationTaskRequestDataQualityRules> DataQualityRules { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestDataQualityRules : TeaModel {
            /// <summary>
            /// <para>The sample check settings.</para>
            /// </summary>
            [NameInMap("CheckingConfig")]
            [Validation(Required=false)]
            public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig CheckingConfig { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfig : TeaModel {
                /// <summary>
                /// <para>The expression used to specify the query method for reference samples. Some threshold types require querying reference samples and aggregating their values to derive the comparison threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bizdate&quot;: [&quot;-1&quot;]}</para>
                /// </summary>
                [NameInMap("ReferencedSamplesFilter")]
                [Validation(Required=false)]
                public string ReferencedSamplesFilter { get; set; }

                /// <summary>
                /// <para>The check threshold settings.</para>
                /// </summary>
                [NameInMap("Thresholds")]
                [Validation(Required=false)]
                public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds Thresholds { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholds : TeaModel {
                    /// <summary>
                    /// <para>The threshold settings for critical warnings.</para>
                    /// </summary>
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical Critical { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsCritical : TeaModel {
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
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected Expected { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsExpected : TeaModel {
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
                    /// <para>The threshold settings for normal warnings.</para>
                    /// </summary>
                    [NameInMap("Warned")]
                    [Validation(Required=false)]
                    public UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned Warned { get; set; }
                    public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesCheckingConfigThresholdsWarned : TeaModel {
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
                /// <item><description>Fluctation: fluctuation range check</description></item>
                /// <item><description>Auto: intelligent threshold check</description></item>
                /// <item><description>FluctationDiscreate: discrete value fluctuation range check</description></item>
                /// <item><description>Average: average fluctuation range check</description></item>
                /// <item><description>Fixed: fixed value check</description></item>
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
            /// <para>Specifies whether the data quality rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The error handlers for quality rule check issues.</para>
            /// </summary>
            [NameInMap("ErrorHandlers")]
            [Validation(Required=false)]
            public List<UpdateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers> ErrorHandlers { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesErrorHandlers : TeaModel {
                /// <summary>
                /// <para>The SQL statement used to filter error data. This parameter is required if the rule is a custom SQL rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM ods_d_openapi_log WHERE status = \&quot;Error\&quot;</para>
                /// </summary>
                [NameInMap("ErrorDataFilter")]
                [Validation(Required=false)]
                public string ErrorDataFilter { get; set; }

                /// <summary>
                /// <para>The handler type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SaveErrorData: retain error data</description></item>
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
            /// <para>The ID of the check rule. You can call the <a href="https://help.aliyun.com/document_detail/173995.html">ListQualityRules</a> operation to obtain the rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1022171560</para>
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
            public UpdateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig SamplingConfig { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestDataQualityRulesSamplingConfig : TeaModel {
                /// <summary>
                /// <para>The name of the sampled metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Count: the number of rows in the table</description></item>
                /// <item><description>Min: the minimum value of the field</description></item>
                /// <item><description>Max: the maximum value of the field</description></item>
                /// <item><description>Avg: the average value of the field</description></item>
                /// <item><description>DistinctCount: the number of unique values in the field</description></item>
                /// <item><description>DistinctPercent: the ratio of the number of unique values in the field to the total number of rows</description></item>
                /// <item><description>DuplicatedCount: the number of duplicate values in the field</description></item>
                /// <item><description>DuplicatedPercent: the ratio of the number of duplicate values in the field to the total number of rows</description></item>
                /// <item><description>TableSize: the size of the table</description></item>
                /// <item><description>NullValueCount: the number of rows where the field is null</description></item>
                /// <item><description>NullValuePercent: the proportion of rows where the field is null</description></item>
                /// <item><description>GroupCount: the number of rows corresponding to each value after aggregation by field value</description></item>
                /// <item><description>CountNotIn: the number of rows that do not match the enumerated values</description></item>
                /// <item><description>CountDistinctNotIn: the number of unique values that do not match the enumerated values</description></item>
                /// <item><description>UserDefinedSql: sample collection by using custom SQL statements</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CountNotIn</para>
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
                /// <para>The conditions used to filter out unneeded data during sampling. The maximum length is 16,777,215 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status != \&quot;Succeeded\&quot;</para>
                /// </summary>
                [NameInMap("SamplingFilter")]
                [Validation(Required=false)]
                public string SamplingFilter { get; set; }

                /// <summary>
                /// <para>The runtime parameter setting statements inserted before the execution of sampling statements. The maximum length is 1,000 characters. Only MaxCompute is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.sql.type.system.odps2=True,odps.sql.hive.compatible=True</para>
                /// </summary>
                [NameInMap("SettingConfig")]
                [Validation(Required=false)]
                public string SettingConfig { get; set; }

            }

            /// <summary>
            /// <para>The severity level of the rule for the business, which corresponds to the strong and weak rules on the page. Valid values:</para>
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
        /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to obtain the data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358750</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the quality monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook settings.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<UpdateDataQualityEvaluationTaskRequestHooks> Hooks { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestHooks : TeaModel {
            /// <summary>
            /// <para>The Cause of the hook. When this Cause is met, the hook action is triggered. Currently, only the following two types of conditional expressions are supported:</para>
            /// <list type="bullet">
            /// <item><description>Specify only one group of rule severity levels and rule check statuses, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This indicates that if the check result of a rule you execute with the severity of High is Critical, the condition is met.</description></item>
            /// <item><description>Specify multiple groups of rule severity levels and rule check statuses, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This indicates that if the check result of a rule you execute with the severity of High is Critical, the check result of a rule you execute with the severity of Normal is Critical, or the check result of a rule you execute with the severity of Normal is Error, the condition is met. The enum values of severity in the conditional expression are consistent with those in DataQualityRule, and the enum values of status are consistent with those in DataQualityResult.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The hook action executed after the data quality check is completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: blocks the scheduled task</description></item>
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
        /// <para>The ID of the data quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7227061794</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the quality monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification subscription configuration.</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestNotifications Notifications { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestNotifications : TeaModel {
            /// <summary>
            /// <para>The Cause of the notification. When this Cause is met, a message notification is triggered. Currently, only the following two types of conditional expressions are supported:</para>
            /// <list type="bullet">
            /// <item><description>Specify only one group of rule severity levels and rule check statuses, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. This indicates that if the check result of a rule you execute with the severity of High is Critical, the condition is met.</description></item>
            /// <item><description>Specify multiple groups of rule severity levels and rule check statuses, such as <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. This indicates that if the check result of a rule you execute with the severity of High is Critical, the check result of a rule you execute with the severity of Normal is Critical, or the check result of a rule you execute with the severity of Normal is Error, the condition is met. The enum values of severity in the conditional expression are consistent with those in DataQualityRule, and the enum values of status are consistent with those in DataQualityResult.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The notification settings.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotifications> Notifications { get; set; }
            public class UpdateDataQualityEvaluationTaskRequestNotificationsNotifications : TeaModel {
                /// <summary>
                /// <para>The notification methods.</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationChannels : TeaModel {
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
                public List<UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class UpdateDataQualityEvaluationTaskRequestNotificationsNotificationsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>The additional parameter settings when an alert is sent. This parameter is in JSON format. Supported keys:</para>
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
                    /// <para>The alert recipient type.</para>
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
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extension configuration. This parameter is a character string in JSON format and takes effect only for EMR data quality monitoring.</para>
        /// <list type="bullet">
        /// <item><description>queue: the YARN queue used when you execute EMR data validation. Default value: the queue configured for the current project.</description></item>
        /// <item><description>sqlEngine: the SQL DPI engine used when you execute EMR data validation. Valid values:<list type="bullet">
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
        /// <para>The monitored object for data quality monitoring.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestTarget Target { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestTarget : TeaModel {
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
            /// <para>dt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <para>The unique ID of the table in DataWorks Data Map.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odsp.openapi.ods_d_openapi_log</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

        }

        /// <summary>
        /// <para>The trigger configuration of the data quality check task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateDataQualityEvaluationTaskRequestTrigger Trigger { get; set; }
        public class UpdateDataQualityEvaluationTaskRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The list of scheduled task IDs. This parameter takes effect only when Type is set to ByScheduledTaskInstance.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger type of the quality monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByScheduledTaskInstance: triggered by an associated scheduled task</description></item>
            /// <item><description>ByManual: manually triggered</description></item>
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
