// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskInstanceResponseBody : TeaModel {
        [NameInMap("DataQualityEvaluationTaskInstance")]
        [Validation(Required=false)]
        public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance DataQualityEvaluationTaskInstance { get; set; }
        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1716344665000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7234231689</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;triggerTime&quot;: 1733284062000 }</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>98330</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Passed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask Task { get; set; }
            public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTask : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks> Hooks { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskHooks : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
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
                /// <para>28544990</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications Notifications { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotifications : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications> Notifications { get; set; }
                    public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotifications : TeaModel {
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationChannels : TeaModel {
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{ &quot;atAll&quot;: true }</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>DingdingUrl</para>
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
                /// <para>20629</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget Target { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTarget : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>maxcompute</para>
                    /// </summary>
                    [NameInMap("DatabaseType")]
                    [Validation(Required=false)]
                    public string DatabaseType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pt=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps.api_trace.ods_d_api_log</para>
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

                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger Trigger { get; set; }
                public class GetDataQualityEvaluationTaskInstanceResponseBodyDataQualityEvaluationTaskInstanceTaskTrigger : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;triggerClient&quot;: &quot;CWF2&quot;, &quot;triggerClientId&quot;: 70001238945 }</para>
            /// </summary>
            [NameInMap("TriggerContext")]
            [Validation(Required=false)]
            public string TriggerContext { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
