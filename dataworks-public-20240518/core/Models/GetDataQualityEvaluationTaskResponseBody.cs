// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityEvaluationTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the monitor.</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTask")]
        [Validation(Required=false)]
        public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTask DataQualityEvaluationTask { get; set; }
        public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTask : TeaModel {
            /// <summary>
            /// <para>The ID of the data source used for the monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45238</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>The description of the monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the quality monitoring task.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The hook.</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskHooks> Hooks { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskHooks : TeaModel {
                /// <summary>
                /// <para>Hook trigger condition. When this condition is met, hook action is triggered. Currently, only two conditional expressions are supported:</para>
                /// <list type="bullet">
                /// <item><description>Specify only one set of rule severity types AND rule verification status, such as <c>${severity} = = &quot;High&quot; AND ${status} = = &quot;Critical&quot;</c>, which indicates that in the executed rule, if the rule verification result of severity High is Critical, the condition is met.</description></item>
                /// <item><description>Specify multiple sets of rule severity types AND rule verification status, such as <c>(${severity} = = &quot;High&quot; AND ${status} = &quot;Critical&quot;) OR (${severity} = &quot;Normal&quot; AND ${status} = &quot;Critical&quot;) OR (${severity} = &quot;Normal&quot; AND ${status} = &quot;Error&quot;)</c>, if the rule verification result of severity High is Critical, the rule verification result of severity Normal is Critical, or the rule verification result of severity Normal is Error, the enumeration that satisfies the condition expression severity is consistent with the enumeration DataQualityRule in severity, and the enumeration of status is consistent with the status in DataQualityResult.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The hook type. Only one hook type is supported.</para>
                /// <list type="bullet">
                /// <item><description>BlockTaskInstance: Blocks the running of scheduling tasks. A monitor is triggered by scheduling tasks. After a monitor finishes running, the monitor determines whether to block the running of scheduling tasks based on the hook condition.</description></item>
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
            /// <para>The ID of the data quality monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2178</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the monitor.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI create a data quality monitoring test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The configurations of alert notifications.</para>
            /// </summary>
            [NameInMap("Notifications")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotifications Notifications { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotifications : TeaModel {
                /// <summary>
                /// <para>The notification trigger condition. When this condition is met, a message notification is triggered. Currently, only two conditional expressions are supported:</para>
                /// <list type="bullet">
                /// <item><description>Specify only one set of rule severity types AND rule verification status, such as <c>${severity} = = &quot;High&quot; AND ${status} = = &quot;Critical&quot;</c>, which indicates that in the executed rule, if the rule verification result of severity High is Critical, the condition is met.</description></item>
                /// <item><description>Specify multiple sets of rule severity types AND rule verification status, such as <c>(${severity} = = &quot;High&quot; AND ${status} = &quot;Critical&quot;) OR (${severity} = &quot;Normal&quot; AND ${status} = &quot;Critical&quot;) OR (${severity} = &quot;Normal&quot; AND ${status} = &quot;Error&quot;)</c>, if the rule verification result of severity High is Critical, the rule verification result of severity Normal is Critical, or the rule verification result of severity Normal is Error, the enumeration that satisfies the condition expression severity is consistent with the enumeration DataQualityRule in severity, and the enumeration of status is consistent with the status in DataQualityResult.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The configurations of alert notifications.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications> Notifications { get; set; }
                public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications : TeaModel {
                    /// <summary>
                    /// <para>The alert notification methods.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>The alert notification methods.</para>
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                    }

                    /// <summary>
                    /// <para>The configurations of alert recipients.</para>
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                    public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>The extended information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{  &quot;atAll&quot;: true }</para>
                        /// </summary>
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        /// <summary>
                        /// <para>The additional parameters that are required when alerts are sent. The parameters are JSON-formatted strings. The following keys are supported:</para>
                        /// <list type="bullet">
                        /// <item><description>atAll: specifies that all members in a group are mentioned when alerts are sent by using DingTalk. This parameter is valid only if you set ReceiverType to DingdingUrl.</description></item>
                        /// </list>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>WebhookUrl</description></item>
                        /// <item><description>FeishuUrl</description></item>
                        /// <item><description>DingdingUrl</description></item>
                        /// <item><description>WeixinUrl</description></item>
                        /// <item><description>AliUid</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DingdingUrl</para>
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
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2626</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Extended configuration, JSON-formatted string, takes effect only for EMR-type data quality monitoring.</para>
            /// <list type="bullet">
            /// <item><description>queue: the yarn queue used when performing EMR data quality verification. The default queue is the queue configured for this project.</description></item>
            /// <item><description>sqlEngine: SQL engine used when performing EMR data verification<list type="bullet">
            /// <item><description>HIVE_ SQL</description></item>
            /// <item><description>SPARK_ SQL</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
            /// </summary>
            [NameInMap("RuntimeConf")]
            [Validation(Required=false)]
            public string RuntimeConf { get; set; }

            /// <summary>
            /// <para>The monitored object of the monitor.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTarget Target { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTarget : TeaModel {
                /// <summary>
                /// <para>The type of the database to which the table belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>maxcompute</description></item>
                /// <item><description>hologres</description></item>
                /// <item><description>cdh</description></item>
                /// <item><description>analyticdb_for_mysql</description></item>
                /// <item><description>starrocks</description></item>
                /// <item><description>emr</description></item>
                /// <item><description>analyticdb_for_postgresql</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>maxcompute</para>
                /// </summary>
                [NameInMap("DatabaseType")]
                [Validation(Required=false)]
                public string DatabaseType { get; set; }

                /// <summary>
                /// <para>Data quality monitoring partition range settings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pt=$[yyyymmdd-1]</para>
                /// </summary>
                [NameInMap("PartitionSpec")]
                [Validation(Required=false)]
                public string PartitionSpec { get; set; }

                /// <summary>
                /// <para>The ID of the table in Data Map.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.meta_open_api_test_sz.test_partition_tbl</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>The type of the monitoring object.</para>
                /// <list type="bullet">
                /// <item><description>Table: Table.</description></item>
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
            /// <para>The trigger configuration of the monitor.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTrigger Trigger { get; set; }
            public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskTrigger : TeaModel {
                /// <summary>
                /// <para>The IDs of scheduling tasks. This parameter is valid only if you set Type to ByScheduledTaskInstance.</para>
                /// </summary>
                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<long?> TaskIds { get; set; }

                /// <summary>
                /// <para>The trigger type of the monitor. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ByManual: The monitor is manually triggered.</description></item>
                /// <item><description>ByScheduledTaskInstance: The monitor is triggered by associated scheduling tasks.</description></item>
                /// <item><description>ByQualityNode: The monitor is triggered by created data quality monitoring nodes.</description></item>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-SDFSDF-SDFDSF-SDFSDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
