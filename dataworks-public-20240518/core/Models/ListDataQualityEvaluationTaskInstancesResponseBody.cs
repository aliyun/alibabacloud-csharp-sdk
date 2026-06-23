// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityEvaluationTaskInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination query result of quality evaluation task instances.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The successfully triggered TaskInstance.</para>
            /// </summary>
            [NameInMap("DataQualityEvaluationTaskInstances")]
            [Validation(Required=false)]
            public List<ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstances> DataQualityEvaluationTaskInstances { get; set; }
            public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstances : TeaModel {
                /// <summary>
                /// <para>The creation time of the task instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The end time of the task instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710239005403</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the quality check task instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The parameter settings used during the actual runtime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;bizdate&quot;: &quot;20240517&quot;,
                ///   &quot;triggerTime&quot;: &quot;1710239005403&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks project workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The current running status.</para>
                /// <list type="bullet">
                /// <item><description>Running</description></item>
                /// <item><description>Error</description></item>
                /// <item><description>Passed</description></item>
                /// <item><description>Warned</description></item>
                /// <item><description>Critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Critical</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The snapshot of the data quality evaluation task when the evaluation starts.</para>
                /// </summary>
                [NameInMap("Task")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTask Task { get; set; }
                public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTask : TeaModel {
                    /// <summary>
                    /// <para>The description of the quality monitoring task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>This is a daily run data quality evaluation plan.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The callback settings in the lifecycle of the data quality evaluation task instance. Currently, only one Hook for blocking scheduled tasks is supported.</para>
                    /// </summary>
                    [NameInMap("Hooks")]
                    [Validation(Required=false)]
                    public List<ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskHooks> Hooks { get; set; }
                    public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskHooks : TeaModel {
                        /// <summary>
                        /// <para>The trigger condition of the Hook.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                        /// </summary>
                        [NameInMap("Condition")]
                        [Validation(Required=false)]
                        public string Condition { get; set; }

                        /// <summary>
                        /// <para>The type of the subsequent processing action.</para>
                        /// <list type="bullet">
                        /// <item><description>BlockTaskInstance: Blocks the execution of the DataWorks task instance.</description></item>
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
                    /// <para>The ID of the data quality evaluation task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10001</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the quality monitoring task.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Quality verification task</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The notification subscription configuration.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotifications Notifications { get; set; }
                    public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotifications : TeaModel {
                        /// <summary>
                        /// <para>The trigger condition of the notification.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>${severity} == &quot;High&quot;</para>
                        /// </summary>
                        [NameInMap("Condition")]
                        [Validation(Required=false)]
                        public string Condition { get; set; }

                        /// <summary>
                        /// <para>The notification settings.</para>
                        /// </summary>
                        [NameInMap("Notifications")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotifications> Notifications { get; set; }
                        public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotifications : TeaModel {
                            /// <summary>
                            /// <para>The alert recipient settings.</para>
                            /// </summary>
                            [NameInMap("NofiticationReceivers")]
                            [Validation(Required=false)]
                            public List<ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotificationsNofiticationReceivers> NofiticationReceivers { get; set; }
                            public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotificationsNofiticationReceivers : TeaModel {
                                /// <summary>
                                /// <para>The extension information, in JSON format. For example, a DingTalk bot supports at-all.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                                /// </summary>
                                [NameInMap("Extension")]
                                [Validation(Required=false)]
                                public string Extension { get; set; }

                                /// <summary>
                                /// <para>The type of the alert recipient.</para>
                                /// <list type="bullet">
                                /// <item><description>AliUid - The UID of the Alibaba Cloud account</description></item>
                                /// <item><description>WebhookUrl - A custom webhook URL</description></item>
                                /// <item><description>DingdingUrl - The URL of a DingTalk bot</description></item>
                                /// <item><description>FeishuUrl - The URL of a Lark bot</description></item>
                                /// <item><description>WeixinUrl - The URL of a WeCom bot</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>AliUid</para>
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

                            /// <summary>
                            /// <para>The alert method.</para>
                            /// </summary>
                            [NameInMap("NotificationChannels")]
                            [Validation(Required=false)]
                            public List<ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                            public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskNotificationsNotificationsNotificationChannels : TeaModel {
                                /// <summary>
                                /// <para>The alert method.</para>
                                /// </summary>
                                [NameInMap("Channels")]
                                [Validation(Required=false)]
                                public List<string> Channels { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>The ID of the project workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    /// <summary>
                    /// <para>Settings used when accessing data sources. Currently, only specifying the YARN queue of EMR and specifying the SQL engine as SPARK_SQL|KYUUBI|PRESTO_SQL|HIVE_SQL when collecting EMR tables are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
                    /// </summary>
                    [NameInMap("RuntimeConf")]
                    [Validation(Required=false)]
                    public string RuntimeConf { get; set; }

                    /// <summary>
                    /// <para>The monitoring object of the data quality evaluation task.</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskTarget Target { get; set; }
                    public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskTarget : TeaModel {
                        /// <summary>
                        /// <para>For a dataset of table type, the database type to which the table belongs.</para>
                        /// <list type="bullet">
                        /// <item><description>maxcompute</description></item>
                        /// <item><description>emr</description></item>
                        /// <item><description>cdh</description></item>
                        /// <item><description>hologres</description></item>
                        /// <item><description>analyticdb_for_postgresql</description></item>
                        /// <item><description>analyticdb_for_mysql</description></item>
                        /// <item><description>starrocks</description></item>
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
                        /// <para>ds=$[yyyymmdd-1]</para>
                        /// </summary>
                        [NameInMap("PartitionSpec")]
                        [Validation(Required=false)]
                        public string PartitionSpec { get; set; }

                        /// <summary>
                        /// <para>The unique ID of the table in Data Map.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>odps.unit_test.tb_unit_test</para>
                        /// </summary>
                        [NameInMap("TableGuid")]
                        [Validation(Required=false)]
                        public string TableGuid { get; set; }

                        /// <summary>
                        /// <para>The type of the monitoring object.</para>
                        /// <list type="bullet">
                        /// <item><description>Table</description></item>
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
                    /// <para>The trigger configuration of the data quality evaluation task.</para>
                    /// </summary>
                    [NameInMap("Trigger")]
                    [Validation(Required=false)]
                    public ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskTrigger Trigger { get; set; }
                    public class ListDataQualityEvaluationTaskInstancesResponseBodyPagingInfoDataQualityEvaluationTaskInstancesTaskTrigger : TeaModel {
                        /// <summary>
                        /// <para>The IDs of scheduled task nodes.</para>
                        /// </summary>
                        [NameInMap("TaskIds")]
                        [Validation(Required=false)]
                        public List<long?> TaskIds { get; set; }

                        /// <summary>
                        /// <para>The type of event that can trigger the execution of the quality evaluation task.</para>
                        /// <list type="bullet">
                        /// <item><description>ByScheduledTaskInstance: A scheduled instance runs successfully.</description></item>
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
                /// <para>The context information when the instance is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;TriggerClientId&quot;: 10001,
                ///   &quot;TriggerClient&quot;: &quot;CWF2&quot;
                /// }</para>
                /// </summary>
                [NameInMap("TriggerContext")]
                [Validation(Required=false)]
                public string TriggerContext { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>294</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
