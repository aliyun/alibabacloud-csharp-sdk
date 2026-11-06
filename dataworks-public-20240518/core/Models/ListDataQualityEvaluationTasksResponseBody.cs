// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityEvaluationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The paged query results of the data quality check tasks.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityEvaluationTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityEvaluationTasksResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The data quality check tasks.</para>
            /// </summary>
            [NameInMap("DataQualityEvaluationTasks")]
            [Validation(Required=false)]
            public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks> DataQualityEvaluationTasks { get; set; }
            public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks : TeaModel {
                /// <summary>
                /// <para>The ID of the data source used by the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45238</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public long? DataSourceId { get; set; }

                /// <summary>
                /// <para>The description of the data quality check task. The description can be up to 65,535 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a daily run data quality evaluation plan</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The callback settings in the lifecycle of the data quality check task instance. Currently, only one hook that blocks the scheduled task is supported.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks> Hooks { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks : TeaModel {
                    /// <summary>
                    /// <para>The trigger condition of the hook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The type of the subsequent action.</para>
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
                /// <para>The ID of the data quality check task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data quality check task. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks, and can be up to 255 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data quality verification task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The alert configuration.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications Notifications { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications : TeaModel {
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
                    /// <para>The specific alert settings.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications> Notifications { get; set; }
                    public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The notification channel configuration.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The notification channel.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The alert recipient configuration.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>The extended information in JSON format. For example, DingTalk chatbots support mentioning all members.</para>
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
                            /// <item><description>AliUid: Alibaba Cloud account UID</description></item>
                            /// <item><description>WebhookUrl: Custom webhook URL</description></item>
                            /// <item><description>DingdingUrl: DingTalk chatbot webhook URL</description></item>
                            /// <item><description>FeishuUrl: Lark chatbot webhook URL</description></item>
                            /// <item><description>WeixinUrl: WeCom chatbot webhook URL</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AliUid</para>
                            /// </summary>
                            [NameInMap("ReceiverType")]
                            [Validation(Required=false)]
                            public string ReceiverType { get; set; }

                            /// <summary>
                            /// <para>The specific value of the alert recipient.</para>
                            /// </summary>
                            [NameInMap("ReceiverValues")]
                            [Validation(Required=false)]
                            public List<string> ReceiverValues { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the DataWorks workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The settings used when accessing the data source. Currently, you can only specify the YARN queue for EMR and set the SQL engine to SPARK_SQL, KYUUBI, PRESTO_SQL, or HIVE_SQL when collecting EMR tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>The monitored object of the data quality check task.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget Target { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget : TeaModel {
                    /// <summary>
                    /// <para>The database type of the table for table-type datasets. Valid values:</para>
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
                    /// <para>The type of the monitored object.</para>
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
                /// <para>The trigger configuration of the data quality check task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger Trigger { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the scheduled nodes. This parameter takes effect only when Type is set to ByScheduledTaskInstance. It specifies the scheduled nodes whose successful instance execution triggers the task.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The event that triggers the execution of the data quality check task.</para>
                    /// <list type="bullet">
                    /// <item><description>ByScheduledTaskInstance: The scheduled instance runs successfully.</description></item>
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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
