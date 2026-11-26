// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The references to published smart index artifacts. This value is empty if no artifacts are available or if the feature is disabled. Internal storage credentials are not included.</para>
        /// </summary>
        [NameInMap("artifacts")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifacts Artifacts { get; set; }
        public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The resource reference for knowledge insights. This value is empty if the artifact is not yet available.</para>
            /// </summary>
            [NameInMap("knowledgeInsights")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsKnowledgeInsights KnowledgeInsights { get; set; }
            public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsKnowledgeInsights : TeaModel {
                /// <summary>
                /// <para>The business ID of the knowledge insights resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001187</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

            /// <summary>
            /// <para>The reference to the directory where topic cards are located. This value is empty if the artifact is not yet available.</para>
            /// </summary>
            [NameInMap("topicCards")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicCards TopicCards { get; set; }
            public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicCards : TeaModel {
                /// <summary>
                /// <para>The business ID of the topic card artifact directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-topic-cards-example</para>
                /// </summary>
                [NameInMap("directoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

            }

            /// <summary>
            /// <para>The resource reference for the topic graph. This value is empty if the artifact is not yet available.</para>
            /// </summary>
            [NameInMap("topicGraph")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicGraph TopicGraph { get; set; }
            public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicGraph : TeaModel {
                /// <summary>
                /// <para>The business ID of the topic graph resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001085</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

            }

            /// <summary>
            /// <para>The resource reference for the topic overview. This value is empty if the artifact is not yet available.</para>
            /// </summary>
            [NameInMap("topicOverview")]
            [Validation(Required=false)]
            public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicOverview TopicOverview { get; set; }
            public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyArtifactsTopicOverview : TeaModel {
                /// <summary>
                /// <para>The business ID of the topic overview resource.</para>
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
        /// <para>The bill ID of the current or most recent task. This value is empty if no corresponding task exists. The existence of a bill ID does not indicate that the deduction is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>billing-example</para>
        /// </summary>
        [NameInMap("billingId")]
        [Validation(Required=false)]
        public string BillingId { get; set; }

        /// <summary>
        /// <para>The business status code. A value of 200 indicates success. If the request fails, a specific business error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business ID of the root directory for the enterprise knowledge base. Subsequent configuration operations use this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-example</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Indicates whether the LLM Wiki smart index is currently enabled. This parameter indicates the configuration switch status and does not indicate whether the build task is complete.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The description of the most recent configuration or scan error. This value is empty if no error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic scan failed</para>
        /// </summary>
        [NameInMap("lastError")]
        [Validation(Required=false)]
        public string LastError { get; set; }

        /// <summary>
        /// <para>The business ID of the most recent successful build task. This value is empty if no successful task exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("lastSuccessTaskId")]
        [Validation(Required=false)]
        public string LastSuccessTaskId { get; set; }

        /// <summary>
        /// <para>The configuration lifecycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLED: Disabled.</description></item>
        /// <item><description>ENABLED: Enabled.</description></item>
        /// <item><description>DISABLING: Artifacts are being cleaned up after disabling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        /// <summary>
        /// <para>The response message. The value is success if the request is successful. If the request fails, this parameter describes the cause of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID. You can use this ID to troubleshoot issues related to this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The current configuration version. Submit this value as expectedRevision during the next update. The value is 0 when not configured, and increments by 1 after each successful save.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>The automatic execution schedule. An empty cronExpression indicates manual execution.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodySchedule Schedule { get; set; }
        public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodySchedule : TeaModel {
            /// <summary>
            /// <para>The current five-part cron automatic execution schedule. An empty value indicates manual execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 2 * * *</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The next scheduled execution time in ISO 8601 format. This value is empty when no automatic schedule is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-19T02:00:00+08:00</para>
            /// </summary>
            [NameInMap("nextRunAt")]
            [Validation(Required=false)]
            public string NextRunAt { get; set; }

            /// <summary>
            /// <para>The IANA time zone name for the execution schedule. Default value: Asia/Shanghai when not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

        }

        /// <summary>
        /// <para>The business ID of the smart index artifact directory. This value is empty if no artifact directory exists or if the feature is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-artifacts-example</para>
        /// </summary>
        [NameInMap("targetDirId")]
        [Validation(Required=false)]
        public string TargetDirId { get; set; }

        /// <summary>
        /// <para>The status of the task generated by this save operation, or the current or most recent task status returned by the read operation. This value is empty if no corresponding task exists.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyTask Task { get; set; }
        public class UpdateKnowledgeBaseSmartIndexConfigurationResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The bill ID corresponding to the task. The existence of a bill ID does not indicate that the deduction is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>billing-example</para>
            /// </summary>
            [NameInMap("billingId")]
            [Validation(Required=false)]
            public string BillingId { get; set; }

            /// <summary>
            /// <para>The billing status of the task. For example, PENDING indicates that settlement is not complete, and ENDED indicates that the billing process has ended. This status is returned separately from the task execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("billingStatus")]
            [Validation(Required=false)]
            public string BillingStatus { get; set; }

            /// <summary>
            /// <para>The execution status of the task. For example, QUEUED indicates that the task is queued, RUNNING indicates that the task is running, SUCCEEDED indicates that the task succeeded, and FAILED indicates that the task failed. Evaluate the build result based on the task status. A successful configuration save does not indicate a successful task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QUEUED</para>
            /// </summary>
            [NameInMap("executionStatus")]
            [Validation(Required=false)]
            public string ExecutionStatus { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-18T09:00:00+00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was updated, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-18T09:01:00+00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The description of the most recent task error. This value is empty if no error occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task execution failed</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public string LastError { get; set; }

            /// <summary>
            /// <para>The operation type of the smart index task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>full: Full build.</description></item>
            /// <item><description>incremental: Incremental update.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The execution progress reported by the task. This value is empty if the task has not yet reported progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>The reporting status of the task result. For example, pending indicates that the result is waiting to be reported, and not_required indicates that reporting is not required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("reportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether an existing task was reused. The value is false if no task was reused.</para>
            /// </summary>
            [NameInMap("reused")]
            [Validation(Required=false)]
            public bool? Reused { get; set; }

            /// <summary>
            /// <para>The business ID of the smart index task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0123456789abcdef0123456789abcdef</para>
            /// </summary>
            [NameInMap("taskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>The trigger type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>manual: Manually triggered.</description></item>
            /// <item><description>scheduled: Triggered by an automatic schedule.
            /// The build task generated upon the first enabling uses manual.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>Indicates whether the task usage statistics are complete. This status is independent of the task execution status and billing status.</para>
            /// </summary>
            [NameInMap("usageComplete")]
            [Validation(Required=false)]
            public bool? UsageComplete { get; set; }

        }

    }

}
