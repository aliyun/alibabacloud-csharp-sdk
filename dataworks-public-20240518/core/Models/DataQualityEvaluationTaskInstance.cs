// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DataQualityEvaluationTaskInstance : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Passed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public DataQualityEvaluationTaskInstanceTask Task { get; set; }
        public class DataQualityEvaluationTaskInstanceTask : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<DataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
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
            public List<DataQualityEvaluationTaskInstanceTaskNotifications> Notifications { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>${blockType} == &quot;Strong&quot;</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                public class DataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                    }

                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                    public class DataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
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
            public DataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
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

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public DataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
            public class DataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
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

}
