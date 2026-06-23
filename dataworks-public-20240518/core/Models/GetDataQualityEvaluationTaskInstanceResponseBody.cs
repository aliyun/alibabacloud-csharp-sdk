// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data quality monitoring instance.</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskInstance")]
        [Validation(Required=false)]
        public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance DataQualityEvaluationTaskInstance { get; set; }
        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the instance execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The data quality monitoring instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7234231689</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The execution parameters for the data quality check, in JSON format. The following keys are available:</para>
            /// <list type="bullet">
            /// <item><description>triggerTime: the millisecond-level timestamp of the trigger time. This is the base time for the $[yyyymmdd] expression in the data range of the data quality monitoring task. This key is required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;triggerTime&quot;: 1733284062000 }</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98330</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResults> Results { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResults : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsDetails> Details { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsDetails : TeaModel {
                    [NameInMap("CheckedValue")]
                    [Validation(Required=false)]
                    public string CheckedValue { get; set; }

                    [NameInMap("ReferencedValue")]
                    [Validation(Required=false)]
                    public string ReferencedValue { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Rule")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRule Rule { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRule : TeaModel {
                    [NameInMap("CheckingConfig")]
                    [Validation(Required=false)]
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfig CheckingConfig { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfig : TeaModel {
                        [NameInMap("ReferencedSamplesFilter")]
                        [Validation(Required=false)]
                        public string ReferencedSamplesFilter { get; set; }

                        [NameInMap("Thresholds")]
                        [Validation(Required=false)]
                        public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholds Thresholds { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholds : TeaModel {
                            [NameInMap("Critical")]
                            [Validation(Required=false)]
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsCritical Critical { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsCritical : TeaModel {
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            [NameInMap("Expected")]
                            [Validation(Required=false)]
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsExpected Expected { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsExpected : TeaModel {
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            [NameInMap("Warned")]
                            [Validation(Required=false)]
                            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsWarned Warned { get; set; }
                            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleCheckingConfigThresholdsWarned : TeaModel {
                                [NameInMap("Expression")]
                                [Validation(Required=false)]
                                public string Expression { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("ErrorHandlers")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleErrorHandlers> ErrorHandlers { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleErrorHandlers : TeaModel {
                        [NameInMap("ErrorDataFilter")]
                        [Validation(Required=false)]
                        public string ErrorDataFilter { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    [NameInMap("SamplingConfig")]
                    [Validation(Required=false)]
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleSamplingConfig SamplingConfig { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleSamplingConfig : TeaModel {
                        [NameInMap("Metric")]
                        [Validation(Required=false)]
                        public string Metric { get; set; }

                        [NameInMap("MetricParameters")]
                        [Validation(Required=false)]
                        public string MetricParameters { get; set; }

                        [NameInMap("SamplingFilter")]
                        [Validation(Required=false)]
                        public string SamplingFilter { get; set; }

                        [NameInMap("SettingConfig")]
                        [Validation(Required=false)]
                        public string SettingConfig { get; set; }

                    }

                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleTarget Target { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceResultsRuleTarget : TeaModel {
                        [NameInMap("DatabaseType")]
                        [Validation(Required=false)]
                        public string DatabaseType { get; set; }

                        [NameInMap("TableGuid")]
                        [Validation(Required=false)]
                        public string TableGuid { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("TemplateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskInstanceId")]
                [Validation(Required=false)]
                public long? TaskInstanceId { get; set; }

            }

            /// <summary>
            /// <para>The instance status of the data quality monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The check is in progress.</description></item>
            /// <item><description>Error: A rule check encountered an error.</description></item>
            /// <item><description>Passed: All rule checks passed.</description></item>
            /// <item><description>Warned: A rule triggered a normal alert threshold.</description></item>
            /// <item><description>Critical: A rule triggered a critical alert threshold.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Passed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The data quality monitoring task.</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask Task { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask : TeaModel {
                /// <summary>
                /// <para>The description of the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAPI quality monitoring test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The callback settings.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
                    /// <summary>
                    /// <para>The cause that triggers the hook action. When this condition is met, the hook action is triggered. Only two types of conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify a single combination of rule severity and rule check status. For example, <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c> means that the condition is met if any rule with a severity of High has a check result of Critical.</description></item>
                    /// <item><description>Specify multiple combinations of rule severity and rule check status. For example, <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c> means that the condition is met if any rule with a severity of High has a check result of Critical, or any rule with a severity of Normal has a check result of Critical, or any rule with a severity of Normal has a check result of Error. The severity enumeration values in the conditional expression are consistent with the severity enumeration values in DataQualityRule, and the status enumeration values are consistent with the status values in DataQualityResult.</description></item>
                    /// </list>
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
                    /// <item><description>BlockTaskInstance: Blocks the scheduling node from continuing to run. If the data quality monitoring task is triggered by a scheduling node, after the data quality monitoring task is completed, the system determines whether to block the scheduling node from continuing to run based on Hook.Condition.</description></item>
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
                /// <para>The ID of the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28544990</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data quality OpenAPI monitoring test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The notification settings.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications Notifications { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                    /// <summary>
                    /// <para>The cause that triggers a notification. When this condition is met, a message notification is sent. Only two types of conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify a single combination of rule severity and rule check status. For example, <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c> means that the condition is met if any rule with a severity of High has a check result of Critical. </description></item>
                    /// <item><description>Specify multiple combinations of rule severity and rule check status. For example, <c>(${severity} == &quot;High&quot;AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c> means that the condition is met if any rule with a severity of High has a check result of Critical, or any rule with a severity of Normal has a check result of Critical, or any rule with a severity of Normal has a check result of Error. The severity enumeration values in the conditional expression are consistent with the severity enumeration values in DataQualityRule, and the status enumeration values are consistent with the status values in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The alert methods.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The notification channels.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The notification channels.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The notification recipients.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>The additional parameter settings for sending alerts, in JSON format. The following keys are supported:</para>
                            /// <list type="bullet">
                            /// <item><description>atAll: Specifies whether to @everyone in the group when sending a DingTalk alert. This parameter takes effect only when ReceiverType is set to DingdingUrl.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{ &quot;atAll&quot;: true }</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <para>The type of the alert recipient.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>20629</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The extension configuration, a JSON-formatted character string. This parameter takes effect only for EMR-type data quality monitoring tasks.</para>
                /// <list type="bullet">
                /// <item><description>queue: The YARN queue used to execute EMR data validation. The default value is the queue configured for the current project.</description></item>
                /// <item><description>sqlEngine: The SQL engine used to execute EMR data validation. Valid values:<list type="bullet">
                /// <item><description>HIVE_SQL</description></item>
                /// <item><description>SPARK_SQL.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>The monitored object of the data quality check task. Refer to the DataQualityTarget example.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
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
                    /// <para>The partition range to monitor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pt=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the table in DataWorks Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.api_trace.ods_d_api_log</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The monitored object type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Table: table.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Table</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The trigger configuration of the data quality check task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
                    /// <summary>
                    /// <para>The list of scheduling node IDs. This parameter is valid only when Type is set to ByScheduledTaskInstance.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The trigger type of the quality monitoring task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ByManual: Manual trigger. This is the default value.</description></item>
                    /// <item><description>ByScheduledTaskInstance: Triggered by an associated scheduling node.</description></item>
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

            /// <summary>
            /// <para>The context information when the instance is triggered, in JSON format. The following keys may be included:</para>
            /// <list type="bullet">
            /// <item><description>TriggerClient: the trigger source of the data quality monitoring instance, such as CWF2 (scheduling system). More values may be added in the future.</description></item>
            /// <item><description>TriggerClientId: the ID of a specific business resource in the source system. For example, when TriggerClient is CWF2, this field records the scheduling task ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;triggerClient&quot;: &quot;CWF2&quot;, &quot;triggerClientId&quot;: 70001238945 }</para>
            /// </summary>
            [NameInMap("TriggerContext")]
            [Validation(Required=false)]
            public string TriggerContext { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed67****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
