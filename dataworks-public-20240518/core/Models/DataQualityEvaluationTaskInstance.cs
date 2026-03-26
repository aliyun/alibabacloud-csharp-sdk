// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityEvaluationTaskInstance : TeaModel {
        /// <summary>
        /// <para>The time at which the instance was generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The time at which the instance finished running.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Passed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The snapshot of the configurations for the data quality monitoring task when the task starts.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskInstanceTask Task { get; set; }
        public class DataQualityEvaluationTaskInstanceTask : TeaModel {
            /// <summary>
            /// <para>The ID of the data source that is used for task running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>The callback configurations of the task during the instance lifecycle. Blocking an auto triggered node is a type of callback event. Only this type is supported.</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
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
                /// <item><description>BlockTaskInstance: An auto triggered node is blocked.</description></item>
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
            /// <para>The subscription configurations for alert notifications.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskInstanceTaskNotifications> Notifications { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                /// <summary>
                /// <para>The trigger condition of the alert notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>${blockType} == &quot;Strong&quot;</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The configurations for the alert notification.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                public class DataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                    /// <summary>
                    /// <para>The alert notification methods.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>The alert notification methods.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Mail</para>
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
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
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
                        /// <para>The alert recipient configuration.</para>
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
            /// <para>2626</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The configuration of the data source. The value of the queue field is default, and that of the sqlEngine field can be SPARK_SQL, KYUUBI, PRESTO_SQL, or HIVE_SQL to collect EMR data. The value default indicates the YARN queue for E-MapReduce (EMR) tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
            /// </summary>
            [NameInMap("RuntimeConf")]
            [Validation(Required=false)]
            public string RuntimeConf { get; set; }

            /// <summary>
            /// <para>The monitored object of the data quality monitoring task.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public DataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
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
            /// <para>The DataWorks tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>195820716552192</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// <para>The trigger configuration of the data quality monitoring task.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public DataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
                /// <summary>
                /// <para>The IDs of the auto triggered nodes of which the instances are successfully run. This parameter takes effect only if the Type parameter is set to ByScheduledTaskInstance.</para>
                /// </summary>
                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<long?> TaskIds { get; set; }

                /// <summary>
                /// <para>The trigger condition of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ByScheduledTaskInstance: The task is triggered when the instance of an auto triggered node is successfully run.</description></item>
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
