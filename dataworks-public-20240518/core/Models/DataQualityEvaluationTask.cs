// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityEvaluationTask : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a daily run data quality evaluation plan.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<DataQualityEvaluationTaskHooks> Hooks { get; set; }
        public class DataQualityEvaluationTaskHooks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BlockTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>质量校验任务</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public List<DataQualityEvaluationTaskNotifications> Notifications { get; set; }
        public class DataQualityEvaluationTaskNotifications : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>${blockType} == &quot;Strong&quot;</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskNotificationsNotifications> Notifications { get; set; }
            public class DataQualityEvaluationTaskNotificationsNotifications : TeaModel {
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                public class DataQualityEvaluationTaskNotificationsNotificationsNotificationChannels : TeaModel {
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                }

                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                public class DataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AliUid</para>
                    /// </summary>
                    [NameInMap("ReceiverType")]
                    [Validation(Required=false)]
                    public string ReceiverType { get; set; }

                    [NameInMap("ReceiverValues")]
                    [Validation(Required=false)]
                    public List<string> ReceiverValues { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
        /// </summary>
        [NameInMap("RuntimeConf")]
        [Validation(Required=false)]
        public string RuntimeConf { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskTarget Target { get; set; }
        public class DataQualityEvaluationTaskTarget : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>maxcompute</para>
            /// </summary>
            [NameInMap("DatabaseType")]
            [Validation(Required=false)]
            public string DatabaseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("PartitionSpec")]
            [Validation(Required=false)]
            public string PartitionSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>odps.unit_test.tb_unit_test</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskTrigger Trigger { get; set; }
        public class DataQualityEvaluationTaskTrigger : TeaModel {
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ByScheduledTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
