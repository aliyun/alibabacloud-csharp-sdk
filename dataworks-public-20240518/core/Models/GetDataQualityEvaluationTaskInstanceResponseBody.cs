// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the monitor instance.</para>
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
            /// <para>The end time of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the data quality monitoring instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7234231689</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Data quality verification execution parameters in JSON format. The available keys are as follows:</para>
            /// <list type="bullet">
            /// <item><description>triggerTime: the millisecond timestamp of the trigger time. The baseline time of the $[yyyymmdd] expression in the data range of data quality monitoring. Required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;triggerTime&quot;: 1733284062000 }</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98330</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The status of the data quality monitoring instance.</para>
            /// <list type="bullet">
            /// <item><description>Running: Verifying</description></item>
            /// <item><description>Error: A rule verification Error occurred.</description></item>
            /// <item><description>Passed: all rules are verified</description></item>
            /// <item><description>Warned: normal alarm threshold triggered by rules</description></item>
            /// <item><description>Critical: Threshold for serious alerts triggered by rules</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Passed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The monitor.</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask Task { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask : TeaModel {
                /// <summary>
                /// <para>The description of the monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAPI quality monitoring test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hook.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
                    /// <summary>
                    /// <para>The hook trigger condition. When this condition is met, the hook action is triggered. Only two conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify only one group of rule strength type and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical.</description></item>
                    /// <item><description>Specify multiple groups of rule strength types and rule check status, such as <c>(${severity} == &quot;High&quot;AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical, severity is Normal and status is Critical, or severity is Normal and status is Error. The enumeration of severity in a conditional expression is the same as the enumeration of severity in DataQualityRule. The enumeration of status in a conditional expression is the same as the enumeration of status in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>Hook type. Currently, only one type is supported:</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance: the blocking scheduling task continues to run. Data quality monitoring is triggered by the scheduling task. After the data quality monitoring is completed, the Hook.Condition is used to determine whether the blocking scheduling task continues to run.</description></item>
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
                /// <para>The ID of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28544990</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data quality OpenAPI monitoring test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The configurations of alert notifications.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications Notifications { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                    /// <summary>
                    /// <para>The notification trigger condition. When this condition is met, the alert notification is triggered. Only two conditional expressions are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify only one group of rule strength type and rule check status, such as <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical.</description></item>
                    /// <item><description>Specify multiple groups of rule strength types and rule check status, such as <c>(${severity} == &quot;High&quot;AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>. In this expression, the hook trigger condition is met if severity is High and status is Critical, severity is Normal and status is Critical, or severity is Normal and status is Error. The enumeration of severity in a conditional expression is the same as the enumeration of severity in DataQualityRule. The enumeration of status in a conditional expression is the same as the enumeration of status in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The alert notification methods.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The notification method.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The notification method.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The value of the receiver.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>Additional parameter settings for sending alerts in json format. The supported keys are as follows:</para>
                            /// <list type="bullet">
                            /// <item><description>atAll: when sending DingTalk alerts, do you need to @ everyone in the group. It takes effect when ReceiverType is DingdingUrl.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{ &quot;atAll&quot;: true }</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <para>The type of alert recipient.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>DingdingUrl</para>
                            /// </summary>
                            [NameInMap("ReceiverType")]
                            [Validation(Required=false)]
                            public string ReceiverType { get; set; }

                            /// <summary>
                            /// <para>The recipient of the alert.</para>
                            /// </summary>
                            [NameInMap("ReceiverValues")]
                            [Validation(Required=false)]
                            public List<string> ReceiverValues { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20629</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Extended configuration, JSON-formatted string, takes effect only for EMR-type data quality monitoring.</para>
                /// <list type="bullet">
                /// <item><description>queue: the yarn queue used when performing EMR data quality verification. The default queue is the queue configured for this project.</description></item>
                /// <item><description>sqlEngine: SQL engine used when performing EMR data verification<list type="bullet">
                /// <item><description>HIVE_ SQL</description></item>
                /// <item><description>SPARK_ SQL</description></item>
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
                /// <para>The monitored object of the monitor.</para>
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
                    /// <para>The partition range monitored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pt=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the table in the data map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.api_trace.ods_d_api_log</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The type of the monitoring object.</para>
                    /// <list type="bullet">
                    /// <item><description>Table: Table</description></item>
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
                /// <para>The trigger configuration of the monitor.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
                    /// <summary>
                    /// <para>The Id list of the scheduled task, which is valid when the Type is ByScheduledTaskInstance.</para>
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

            /// <summary>
            /// <para>The context information when the instance is triggered, in JSON format. The possible keys are as follows:</para>
            /// <list type="bullet">
            /// <item><description>TriggerClient: the trigger source of the data quality monitoring instance, such as CWF2 (scheduling system), may be added later.</description></item>
            /// <item><description>TriggerClientId: associated with a specific business resource in the source system. For example, if TriggerClient is CWF2, the ID of the scheduling task is recorded here.</description></item>
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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
