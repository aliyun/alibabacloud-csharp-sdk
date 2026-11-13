// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityEvaluationTaskInstance : TeaModel {
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
        /// <para>The task instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The current running status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Passed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The snapshot of the data quality check task at the start of the check.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskInstanceTask Task { get; set; }
        public class DataQualityEvaluationTaskInstanceTask : TeaModel {
            /// <summary>
            /// <para>The ID of the data source used to execute the data quality check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>The callback settings for the lifecycle of the data quality check task instance. Currently, only one hook that blocks the scheduled task is supported.</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
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
                /// <para>The type of the subsequent action. Valid values:</para>
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
            /// <para>Quality check task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The alert subscription configuration of the data quality check task.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskInstanceTaskNotifications> Notifications { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                /// <summary>
                /// <para>The alert trigger condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${blockType} == &quot;Strong&quot;</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The specific message notification settings.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                public class DataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                    /// <summary>
                    /// <para>The notification channel.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>The notification channel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;Mail&quot;]</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                    }

                    /// <summary>
                    /// <para>The notification recipient configuration.</para>
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>The extension information in JSON format. For example, DingTalk chatbots support mentioning all users.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                        /// </summary>
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        /// <summary>
                        /// <para>The notification recipient type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AliUid</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>The notification recipient values.</para>
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
            /// <para>2626</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The settings used when the data source is accessed. Currently, you can only specify the YARN queue for EMR and set the SQL engine to SPARK_SQL, KYUUBI, PRESTO_SQL, or HIVE_SQL when collecting EMR tables.</para>
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
            public DataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
                /// <summary>
                /// <para>The database type to which the table belongs, applicable when the dataset is of the table type. Valid values:</para>
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
                /// <para>The monitored object type.</para>
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
            /// <para>The ID of the DataWorks tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>195820716552192</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The trigger configuration of the data quality check task.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public DataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
                /// <summary>
                /// <para>The IDs of the scheduled nodes whose successful instance execution triggers the check. This parameter takes effect only when Type is set to ByScheduledTaskInstance.</para>
                /// </summary>
                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<long?> TaskIds { get; set; }

                /// <summary>
                /// <para>The type of event that triggers the execution of the quality check task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ByScheduledTaskInstance: A scheduled instance completes successfully.</description></item>
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

}
