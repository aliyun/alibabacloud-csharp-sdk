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
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>质量监控任务描述</para>
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
                /// <para>Hook触发条件</para>
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
                /// <item><description></description></item>
                /// </list>
                /// <para>Valid values:</para>
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
            /// <para>代表资源一级ID的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>2178</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>质量监控任务名称</para>
            /// <para>This parameter is required.</para>
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
                /// <para>通知触发条件</para>
                /// 
                /// <b>Example:</b>
                /// <para>(${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Critical&quot;) OR (${severity} == &quot;Normal&quot; AND ${status} == &quot;Error&quot;)</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The configurations of the alert notification.</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications> Notifications { get; set; }
                public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotifications : TeaModel {
                    /// <summary>
                    /// <para>The alert notification method.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                    public class GetDataQualityEvaluationTaskResponseBodyDataQualityEvaluationTaskNotificationsNotificationsNotificationChannels : TeaModel {
                        /// <summary>
                        /// <para>The alert notification method.</para>
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
                        /// <para>扩展信息，格式为 json，例如钉钉机器人支持 at 所有人</para>
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
                        /// <para>告警接收人</para>
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>项目空间Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>2626</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>使用数据源时的一些设置，目前只支持指定EMR的yarn队列、采集EMR表时把SQL引擎指定为SPARK-SQL</para>
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
                /// <para>The type of the database to which the table belongs.</para>
                /// <para>Valid values:</para>
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
                /// <b>Example:</b>
                /// <para>pt=$[yyyymmdd-1]</para>
                /// </summary>
                [NameInMap("PartitionSpec")]
                [Validation(Required=false)]
                public string PartitionSpec { get; set; }

                /// <summary>
                /// <para>表在数据地图中的唯一ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.meta_open_api_test_sz.test_partition_tbl</para>
                /// </summary>
                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                /// <summary>
                /// <para>监控对象类型</para>
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
                /// <para>具体指明哪些调度节点的实例执行成功后可以触发</para>
                /// </summary>
                [NameInMap("TaskIds")]
                [Validation(Required=false)]
                public List<long?> TaskIds { get; set; }

                /// <summary>
                /// <para>The trigger type of the monitor.</para>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// <item><description></description></item>
                /// </list>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ByManual (default): The monitor is manually triggered.</description></item>
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
