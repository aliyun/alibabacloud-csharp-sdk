// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetKnowledgeBaseSmartIndexConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>已发布产物引用</para>
        /// </summary>
        [NameInMap("artifacts")]
        [Validation(Required=false)]
        public GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifacts Artifacts { get; set; }
        public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>知识洞察</para>
            /// </summary>
            [NameInMap("knowledgeInsights")]
            [Validation(Required=false)]
            public GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsKnowledgeInsights KnowledgeInsights { get; set; }
            public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsKnowledgeInsights : TeaModel {
                /// <summary>
                /// <para>产物资源业务 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001187</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

            /// <summary>
            /// <para>主题卡片目录</para>
            /// </summary>
            [NameInMap("topicCards")]
            [Validation(Required=false)]
            public GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicCards TopicCards { get; set; }
            public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicCards : TeaModel {
                /// <summary>
                /// <para>产物目录业务 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-topic-cards-example</para>
                /// </summary>
                [NameInMap("directoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

            }

            /// <summary>
            /// <para>主题关系图</para>
            /// </summary>
            [NameInMap("topicGraph")]
            [Validation(Required=false)]
            public GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicGraph TopicGraph { get; set; }
            public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicGraph : TeaModel {
                /// <summary>
                /// <para>产物资源业务 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001085</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

            /// <summary>
            /// <para>主题概览</para>
            /// </summary>
            [NameInMap("topicOverview")]
            [Validation(Required=false)]
            public GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicOverview TopicOverview { get; set; }
            public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicOverview : TeaModel {
                /// <summary>
                /// <para>产物资源业务 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001186</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

        }

        /// <summary>
        /// <para>当前或最近任务账单标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>billing-example</para>
        /// </summary>
        [NameInMap("billingId")]
        [Validation(Required=false)]
        public string BillingId { get; set; }

        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>企业知识库根目录业务 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-example</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>是否开启 LLM Wiki 智能索引</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>最近一次配置或扫描错误</para>
        /// 
        /// <b>Example:</b>
        /// <para>自动扫描失败</para>
        /// </summary>
        [NameInMap("lastError")]
        [Validation(Required=false)]
        public string LastError { get; set; }

        /// <summary>
        /// <para>最近成功任务标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("lastSuccessTaskId")]
        [Validation(Required=false)]
        public string LastSuccessTaskId { get; set; }

        /// <summary>
        /// <para>配置生命周期：DISABLED、ENABLED 或 DISABLING</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为 success</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>配置版本；更新时作为 expectedRevision 提交</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>自动执行计划</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public GetKnowledgeBaseSmartIndexConfigurationResponseBodySchedule Schedule { get; set; }
        public class GetKnowledgeBaseSmartIndexConfigurationResponseBodySchedule : TeaModel {
            /// <summary>
            /// <para>Cron 表达式；空表示手动执行</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 2 * * *</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>下次计划执行时间，ISO 8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-19T02:00:00+08:00</para>
            /// </summary>
            [NameInMap("nextRunAt")]
            [Validation(Required=false)]
            public string NextRunAt { get; set; }

            /// <summary>
            /// <para>计划使用的 IANA 时区</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

        }

        /// <summary>
        /// <para>智能索引产物目录业务 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-artifacts-example</para>
        /// </summary>
        [NameInMap("targetDirId")]
        [Validation(Required=false)]
        public string TargetDirId { get; set; }

        /// <summary>
        /// <para>当前或最近任务状态</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public GetKnowledgeBaseSmartIndexConfigurationResponseBodyTask Task { get; set; }
        public class GetKnowledgeBaseSmartIndexConfigurationResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>任务账单标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>billing-example</para>
            /// </summary>
            [NameInMap("billingId")]
            [Validation(Required=false)]
            public string BillingId { get; set; }

            /// <summary>
            /// <para>任务计费状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("billingStatus")]
            [Validation(Required=false)]
            public string BillingStatus { get; set; }

            /// <summary>
            /// <para>任务执行状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>QUEUED</para>
            /// </summary>
            [NameInMap("executionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            /// <summary>
            /// <para>任务创建时间，ISO 8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-18T09:00:00+00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>任务更新时间，ISO 8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-18T09:01:00+00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>最近一次任务错误</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务执行失败</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public string LastError { get; set; }

            /// <summary>
            /// <para>任务操作类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>任务执行进度</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>任务结果上报状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("reportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>是否复用已有任务</para>
            /// </summary>
            [NameInMap("reused")]
            [Validation(Required=false)]
            public bool? Reused { get; set; }

            /// <summary>
            /// <para>任务业务标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("taskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>任务触发类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>用量统计是否完成</para>
            /// </summary>
            [NameInMap("usageComplete")]
            [Validation(Required=false)]
            public bool? UsageComplete { get; set; }

        }

    }

}
