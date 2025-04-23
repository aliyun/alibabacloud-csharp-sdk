// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the AI task. This parameter takes effect only when the TaskType parameter is set to AI.</para>
        /// </summary>
        [NameInMap("AIJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyAIJobDetail AIJobDetail { get; set; }
        public class GetJobDetailResponseBodyAIJobDetail : TeaModel {
            /// <summary>
            /// <para>The end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:46Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c9dff751ba**********59d50a967f5</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The type of the AI task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIVideoCensor</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>reserved</description></item>
            /// <item><description>init</description></item>
            /// <item><description>success</description></item>
            /// <item><description>fail</description></item>
            /// <item><description>processing</description></item>
            /// <item><description>analysing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;AuditRange&quot;:[&quot;video&quot;,&quot;image-cover&quot;,&quot;text-title&quot;],&quot;AuditContent&quot;:[&quot;screen&quot;],&quot;AuditItem&quot;:[&quot;terrorism&quot;,&quot;porn&quot;],&quot;AuditAutoBlock&quot;:&quot;no&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The trigger mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto</description></item>
            /// <item><description>Manual</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>transcode</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6708D849-F109-1A6C-AC91-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the snapshot task. This parameter takes effect only when the jobType parameter is set to Snapshot.</para>
        /// </summary>
        [NameInMap("SnapshotJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodySnapshotJobDetail SnapshotJobDetail { get; set; }
        public class GetJobDetailResponseBodySnapshotJobDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:45Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63df12s0**********4hdq249t82kr91</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Configuration of normal snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;inl&quot;:0,&quot;num&quot;:32,&quot;tm&quot;:5,&quot;wd&quot;:&quot;352&quot;,&quot;ft&quot;:&quot;normal&quot;,&quot;hg&quot;:&quot;640&quot;}</para>
            /// </summary>
            [NameInMap("NormalConfig")]
            [Validation(Required=false)]
            public string NormalConfig { get; set; }

            /// <summary>
            /// <para>The sprite configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;pad&quot;:&quot;0&quot;,&quot;lines&quot;:&quot;10&quot;,&quot;mgin&quot;:&quot;0&quot;,&quot;cols&quot;:&quot;10&quot;,&quot;ikcp&quot;:&quot;false&quot;,&quot;hg&quot;:&quot;68&quot;}</para>
            /// </summary>
            [NameInMap("SpriteConfig")]
            [Validation(Required=false)]
            public string SpriteConfig { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Processing</description></item>
            /// <item><description>Fail</description></item>
            /// <item><description>Success</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The trigger mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto</description></item>
            /// <item><description>Manual</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The details of the transcoding task. This parameter takes effect only when the jobType parameter is set to Transcode.</para>
        /// </summary>
        [NameInMap("TranscodeJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyTranscodeJobDetail TranscodeJobDetail { get; set; }
        public class GetJobDetailResponseBodyTranscodeJobDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:34Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HD</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2dc1634e**********3f1d22d1a0174e</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Submitted</description></item>
            /// <item><description>Transcoding</description></item>
            /// <item><description>TranscodeSuccess</description></item>
            /// <item><description>TranscodeFail</description></item>
            /// <item><description>TranscodeCancelled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TranscodeSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbfaaec9e**********bf0b81219244c</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The ID of the user who submitted the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        [NameInMap("WorkflowTaskDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyWorkflowTaskDetail WorkflowTaskDetail { get; set; }
        public class GetJobDetailResponseBodyWorkflowTaskDetail : TeaModel {
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public string ActivityResults { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskInput")]
            [Validation(Required=false)]
            public string TaskInput { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetJobDetailResponseBodyWorkflowTaskDetailWorkflow Workflow { get; set; }
            public class GetJobDetailResponseBodyWorkflowTaskDetailWorkflow : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

    }

}
