// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityEvaluationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The paged query result of quality evaluation nodes.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityEvaluationTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityEvaluationTasksResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The quality evaluation tasks.</para>
            /// </summary>
            [NameInMap("DataQualityEvaluationTasks")]
            [Validation(Required=false)]
            public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks> DataQualityEvaluationTasks { get; set; }
            public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks : TeaModel {
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public long? DataSourceId { get; set; }

                /// <summary>
                /// <para>The description of the data quality evaluation task. The description can be up to 65,535 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a daily run data quality evaluation plan</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The callback settings during the epoch of data quality evaluation task instances. Currently, only one hook that blocks a scheduling node instance is supported.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks> Hooks { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks : TeaModel {
                    /// <summary>
                    /// <para>The cause that triggers the hook.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The type of the follow-up action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance: Blocks the execution of a DataWorks node instance.</description></item>
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
                /// <para>The name of the data quality evaluation task. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks. The name can be up to 255 characters in length.</para>
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
                    /// <para>The cause that triggers the notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The alert settings.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications> Notifications { get; set; }
                    public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The alert channel configurations.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The alert channel.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The alert recipient configurations.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>The extension information in JSON format. For example, DingTalk chatbots support mentioning all members.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <para>The type of the alert recipient. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>AliUid: Alibaba Cloud account UID.</description></item>
                            /// <item><description>WebhookUrl: custom webhook URL.</description></item>
                            /// <item><description>DingdingUrl: DingTalk chatbot URL.</description></item>
                            /// <item><description>FeishuUrl: Lark chatbot URL.</description></item>
                            /// <item><description>WeixinUrl: WeCom chatbot URL.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AliUid</para>
                            /// </summary>
                            [NameInMap("ReceiverType")]
                            [Validation(Required=false)]
                            public string ReceiverType { get; set; }

                            /// <summary>
                            /// <para>The specific values of the alert recipients.</para>
                            /// </summary>
                            [NameInMap("ReceiverValues")]
                            [Validation(Required=false)]
                            public List<string> ReceiverValues { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The runtime settings for data sources. Currently, only specifying the EMR YARN queue and the SQL engine for collecting EMR tables is supported. Valid SQL engine values: SPARK_SQL, KYUUBI, PRESTO_SQL, and HIVE_SQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>The monitored object of the data quality evaluation task.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget Target { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget : TeaModel {
                    /// <summary>
                    /// <para>The database type of the table dataset. Valid values:</para>
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
                    /// <para>The unique ID of the table in DataWorks Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.unit_test.tb_unit_test</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The monitored object type. Valid values:</para>
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
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger Trigger { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>This parameter takes effect when type is set to ByScheduledTaskInstance. Specifies the scheduled node IDs whose successful instance execution can trigger the task.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The type of event that triggers the quality evaluation task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ByScheduledTaskInstance: Triggered when a scheduled node instance runs successfully.</description></item>
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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
