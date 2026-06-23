// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityEvaluationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>质量校验任务分页查询结果</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataQualityEvaluationTasksResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataQualityEvaluationTasksResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>质量校验任务</para>
            /// </summary>
            [NameInMap("DataQualityEvaluationTasks")]
            [Validation(Required=false)]
            public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks> DataQualityEvaluationTasks { get; set; }
            public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasks : TeaModel {
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public long? DataSourceId { get; set; }

                /// <summary>
                /// <para>数据质量校验任务描述，最长65535个字符</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a daily run data quality evaluation plan</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>数据质量校验任务实例生命周期中的回调设置，目前只支持一个阻塞调度任务的Hook</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks> Hooks { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksHooks : TeaModel {
                    /// <summary>
                    /// <para>Hook触发条件</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot; AND ${status} == &quot;Critical&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>后续处理动作类型</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance：阻塞DataWorks任务实例执行</description></item>
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
                /// <para>数据质量校验任务ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>数据质量校验任务名称，数字、英文字母、汉字、半角全角标点符号组合，最长255个字符。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data quality verification task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>告警配置</para>
                /// </summary>
                [NameInMap("Notifications")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications Notifications { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotifications : TeaModel {
                    /// <summary>
                    /// <para>Notification触发条件</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>${severity} == &quot;High&quot;</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>具体的告警设置</para>
                    /// </summary>
                    [NameInMap("Notifications")]
                    [Validation(Required=false)]
                    public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications> Notifications { get; set; }
                    public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotifications : TeaModel {
                        /// <summary>
                        /// <para>告警方式配置</para>
                        /// </summary>
                        [NameInMap("NotificationChannels")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels> NotificationChannels { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationChannels : TeaModel {
                            /// <summary>
                            /// <para>告警方式</para>
                            /// </summary>
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public List<string> Channels { get; set; }

                        }

                        /// <summary>
                        /// <para>告警接收人配置</para>
                        /// </summary>
                        [NameInMap("NotificationReceivers")]
                        [Validation(Required=false)]
                        public List<ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers> NotificationReceivers { get; set; }
                        public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksNotificationsNotificationsNotificationReceivers : TeaModel {
                            /// <summary>
                            /// <para>扩展信息，格式为 json，例如钉钉机器人支持 at 所有人</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                            /// </summary>
                            [NameInMap("Extension")]
                            [Validation(Required=false)]
                            public string Extension { get; set; }

                            /// <summary>
                            /// <para>告警接收人类型</para>
                            /// <list type="bullet">
                            /// <item><description>AliUid - 阿里云账号Uid</description></item>
                            /// <item><description>WebhookUrl - 自定义 webhook URL</description></item>
                            /// <item><description>DingdingUrl - 钉钉机器人Url</description></item>
                            /// <item><description>FeishuUrl - 飞书机器人Url</description></item>
                            /// <item><description>WeixinUrl - 企微机器人Url</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>AliUid</para>
                            /// </summary>
                            [NameInMap("ReceiverType")]
                            [Validation(Required=false)]
                            public string ReceiverType { get; set; }

                            /// <summary>
                            /// <para>告警接收人具体值</para>
                            /// </summary>
                            [NameInMap("ReceiverValues")]
                            [Validation(Required=false)]
                            public List<string> ReceiverValues { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>DataWorks工作空间ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>使用数据源时的一些设置，目前只支持指定EMR的yarn队列、采集EMR表时SQL引擎指定为SPARK_SQL|KYUUBI|PRESTO_SQL|HIVE_SQL</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
                /// </summary>
                [NameInMap("RuntimeConf")]
                [Validation(Required=false)]
                public string RuntimeConf { get; set; }

                /// <summary>
                /// <para>数据质量校验任务的监控对象</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget Target { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTarget : TeaModel {
                    /// <summary>
                    /// <para>表类型的数据集，表所属的数据库类型</para>
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
                    /// <para>分区表的分区设置</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ds=$[yyyymmdd-1]</para>
                    /// </summary>
                    [NameInMap("PartitionSpec")]
                    [Validation(Required=false)]
                    public string PartitionSpec { get; set; }

                    /// <summary>
                    /// <para>表在数据地图中的唯一ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps.unit_test.tb_unit_test</para>
                    /// </summary>
                    [NameInMap("TableGuid")]
                    [Validation(Required=false)]
                    public string TableGuid { get; set; }

                    /// <summary>
                    /// <para>监控对象类型</para>
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
                /// <para>数据质量校验任务的触发配置</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger Trigger { get; set; }
                public class ListDataQualityEvaluationTasksResponseBodyPagingInfoDataQualityEvaluationTasksTrigger : TeaModel {
                    /// <summary>
                    /// <para>type=ByScheduledTaskInstance时生效
                    /// ,具体指明哪些调度节点的实例执行成功后可以触发</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>何种事件可以触发质量校验任务执行</para>
                    /// <list type="bullet">
                    /// <item><description>ByScheduledTaskInstance：调度实例运行成功</description></item>
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
            /// <para>页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>页大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>总条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>131</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>API请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
