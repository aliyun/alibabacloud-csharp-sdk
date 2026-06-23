// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Data quality monitoring details.</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTask")]
        [Validation(Required=false)]
        public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTask DataQualityEvaluationTask { get; set; }
        public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTask : TeaModel {
            /// <summary>
            /// <para>Data source ID used by the quality monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45238</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>Description of the quality monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the quality monitoring task.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Callback settings.</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskHooks> Hooks { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskHooks : TeaModel {
                /// <summary>
                /// <para>Hook trigger condition. When this condition is met, the hook action is triggered. Currently, only two types of conditional expressions are supported:</para>
                /// <list type="bullet">
                /// <item><description>Specify a single group of rule severity type and rule validation status, e.g., <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>, which means the condition is met if any executed rule with severity High has a validation result of Critical.</description></item>
                /// <item><description>Specify multiple groups of rule severity types and rule validation statuses, e.g., <c>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>, which means the condition is met if any executed rule has severity High with validation result Critical, or severity Normal with validation result Critical, or severity Normal with validation result Error. The severity enum in the conditional expression is consistent with the severity enum in DataQualityRule, and the status enum is consistent with the status in DataQualityResult.</description></item>
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
                /// <item><description>BlockTaskInstance: Blocks the scheduled task from continuing to run. When data quality monitoring is triggered by a scheduled task, after the data quality monitoring completes, Hook.Condition is used to determine whether to block the scheduled task from continuing to run.</description></item>
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
            /// <para>Data quality monitoring ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2178</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name of the quality monitoring task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI create a data quality monitoring test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Notification subscription configuration.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotifications Notifications { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotifications : TeaModel {
                /// <summary>
                /// <para>Notification trigger condition. When this condition is met, the message notification is triggered. Currently, only two types of conditional expressions are supported:</para>
                /// <list type="bullet">
                /// <item><description>Specify a single group of rule severity type and rule validation status, e.g., <c>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</c>, which means the condition is met if any executed rule with severity High has a validation result of Critical.</description></item>
                /// <item><description>Specify multiple groups of rule severity types and rule validation statuses, e.g., <c>(${severity} == &quot;High&quot;AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</c>, which means the condition is met if any executed rule has severity High with validation result Critical, or severity Normal with validation result Critical, or severity Normal with validation result Error. The severity enum in the conditional expression is consistent with the severity enum in DataQualityRule, and the status enum is consistent with the status in DataQualityResult.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>Notification settings.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications> Notifications { get; set; }
                public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications : TeaModel {
                    /// <summary>
                    /// <para>Notification method.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>Notification method.</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                    }

                    /// <summary>
                    /// <para>Alert receiver settings.</para>
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                    public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>Extended information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{  &quot;atAll&quot;: true }</para>
                        /// </summary>
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        /// <summary>
                        /// <para>Additional parameter settings when sending alerts. JSON format. Supported keys are as follows:</para>
                        /// <list type="bullet">
                        /// <item><description>atAll: Whether to @everyone in the group when sending DingTalk alerts. Takes effect when ReceiverType is DingdingUrl.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DingdingUrl</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>Alert receiver.</para>
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>Workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2626</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Extended configuration. A JSON-formatted string. Only takes effect for EMR-type data quality monitoring.</para>
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
            /// <para>Data quality monitoring object.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTarget Target { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTarget : TeaModel {
                /// <summary>
                /// <para>Database type to which the table belongs:</para>
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
                /// <para>Partition range setting for data quality monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pt=$[yyyymmdd-1]</para>
                /// </summary>
                [NameInMap("PartitionSpec")]
                [Validation(Required=false)]
                public string PartitionSpec { get; set; }

                /// <summary>
                /// <para>Unique ID of the table in Data Map.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.meta_open_api_test_sz.test_partition_tbl</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>Monitoring object type.</para>
                /// <list type="bullet">
                /// <item><description>Table: Table.</description></item>
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
            /// <para>Trigger configuration of the data quality validation task.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTrigger Trigger { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTrigger : TeaModel {
                /// <summary>
                /// <para>List of scheduled task IDs. Valid when Type is ByScheduledTaskInstance.</para>
                /// </summary>
                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<long?> TaskIds { get; set; }

                /// <summary>
                /// <para>Quality monitoring trigger type:</para>
                /// <list type="bullet">
                /// <item><description>ByManual: Manual trigger</description></item>
                /// <item><description>ByScheduledTaskInstance: Scheduled task trigger</description></item>
                /// <item><description>ByQualityNode: Quality node trigger</description></item>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
