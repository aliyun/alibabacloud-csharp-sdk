// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityEvaluationTask : TeaModel {
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
        /// <para>The description of the task. The description can be up to 65,535 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a daily run data quality evaluation plan.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The callback configurations of the task during the instance lifecycle. Blocking an auto triggered node is a type of callback event. Only this type is supported.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<DataQualityEvaluationTaskHooks> Hooks { get; set; }
        public class DataQualityEvaluationTaskHooks : TeaModel {
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
        public List<DataQualityEvaluationTaskNotifications> Notifications { get; set; }
        public class DataQualityEvaluationTaskNotifications : TeaModel {
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
            /// <para>The configurations for alert notifications.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskNotificationsNotifications> Notifications { get; set; }
            public class DataQualityEvaluationTaskNotificationsNotifications : TeaModel {
                /// <summary>
                /// <para>The alert notification methods.</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class DataQualityEvaluationTaskNotificationsNotificationsNotificationChannels : TeaModel {
                    /// <summary>
                    /// <para>The alert notification method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mail</para>
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
                public List<DataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class DataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers : TeaModel {
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
                    /// <para>The type of the alert recipient.</para>
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
        /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
        /// </summary>
        [NameInMap("RuntimeConf")]
        [Validation(Required=false)]
        public string RuntimeConf { get; set; }

        /// <summary>
        /// <para>The monitored object of the task.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskTarget Target { get; set; }
        public class DataQualityEvaluationTaskTarget : TeaModel {
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>The trigger configuration of the task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskTrigger Trigger { get; set; }
        public class DataQualityEvaluationTaskTrigger : TeaModel {
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

}
