// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityEvaluationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityEvaluationTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityEvaluationTasksResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The data quality monitoring tasks.</para>
            /// </summary>
            [NameInMap("DataQualityEvaluationTasks")]
            [Validation(Required=false)]
            public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks> DataQualityEvaluationTasks { get; set; }
            public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks : TeaModel {
                /// <summary>
                /// <para>The description of the data quality monitoring task. The description can be up to 65,535 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a daily run data quality evaluation plan</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The callback configurations of the task during the instance lifecycle. Blocking an auto triggered node is a type of callback event. Only this type is supported.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks> Hooks { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks : TeaModel {
                    /// <summary>
                    /// <para>The trigger configuration of the callback event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The type of the callback event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance. The value indicates that an auto triggered node is blocked.</description></item>
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
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data quality monitoring task. The name can be up to 255 characters in length and can contain digits, letters, and punctuation marks.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The configurations for alert notifications.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications Notifications { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications : TeaModel {
                    /// <summary>
                    /// <para>The trigger condition of the alert notification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The configurations for the alert notification.</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications> Notifications { get; set; }
                    public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>The alert notification methods.</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>The alert notification methods.</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>The alert recipients.</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>The extended information in the JSON format. For example, the DingTalk chatbot can remind all members in a DingTalk group by using the at sign (@).</para>
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
                            /// <item><description>AliUid: Alibaba Cloud account ID</description></item>
                            /// <item><description>WebhookUrl: URL of a custom webhook</description></item>
                            /// <item><description>DingdingUrl: DingTalk chatbot URL</description></item>
                            /// <item><description>FeishuUrl: Lark chatbot URL</description></item>
                            /// <item><description>WeixinUrl: WeCom chatbot URL</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AliUid</para>
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
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The configuration of the data source. The value of the queue field is default, and that of the sqlEngine field can be set to SPARK_SQL, KYUUBI, PRESTO_SQL, or HIVE_SQL. The value default indicates the YARN queue for E-MapReduce (EMR) tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK-SQL&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>The monitored object of the task.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget Target { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget : TeaModel {
                    /// <summary>
                    /// <para>The type of the database to which the table belongs. Valid values:</para>
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
                    /// <para>The configuration of the partitioned table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <para>The ID of the table in Data Map.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.unit_test.tb_unit_test</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>The type of the monitored object. Valid values:</para>
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
                /// <para>The trigger configuration of the task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger Trigger { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the auto triggered nodes of which the instances are successfully run. This parameter takes effect only if the Type parameter is set to ByScheduledTaskInstance.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The trigger condition of the task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ByScheduledTaskInstance. The value indicates that the task is triggered when the instance of an auto triggered node is successfully run.</description></item>
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
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
