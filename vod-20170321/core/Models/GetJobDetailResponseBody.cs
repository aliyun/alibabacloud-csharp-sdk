// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the AI task. This field has a value only when TaskType is AI.</para>
        /// </summary>
        [NameInMap("AIJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyAIJobDetail AIJobDetail { get; set; }
        public class GetJobDetailResponseBodyAIJobDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:46Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c9dff751ba**********59d50a967f5</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The AI task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AIVideoCensor</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>reserved: submitted.</description></item>
            /// <item><description>init: started.</description></item>
            /// <item><description>success: execution succeeded.</description></item>
            /// <item><description>fail: execution failed.</description></item>
            /// <item><description>processing: processing in progress.</description></item>
            /// <item><description>analysing: analysis in progress.</description></item>
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
            /// <para>The trigger method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: automatically triggered by a workflow.</description></item>
            /// <item><description>Manual: manually submitted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The task type.</para>
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
        /// <para>The details of the snapshot task. This field has a value only when jobType is Snapshot.</para>
        /// </summary>
        [NameInMap("SnapshotJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodySnapshotJobDetail SnapshotJobDetail { get; set; }
        public class GetJobDetailResponseBodySnapshotJobDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:45Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63df12s0**********4hdq249t82kr91</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The normal snapshot configuration.</para>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Processing: processing in progress.</description></item>
            /// <item><description>Fail: task failed.</description></item>
            /// <item><description>Success: task succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The trigger method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Auto: automatically triggered by a workflow.</description></item>
            /// <item><description>Manual: manually submitted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Auto</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public string Trigger { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The details of the transcoding task. This field has a value only when jobType is Transcode.</para>
        /// </summary>
        [NameInMap("TranscodeJobDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyTranscodeJobDetail TranscodeJobDetail { get; set; }
        public class GetJobDetailResponseBodyTranscodeJobDetail : TeaModel {
            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:34Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
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
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2dc1634e**********3f1d22d1a0174e</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Submitted: submitted.</description></item>
            /// <item><description>Transcoding: transcoding in progress.</description></item>
            /// <item><description>TranscodeSuccess: transcoding succeeded.</description></item>
            /// <item><description>TranscodeFail: transcoding failed.</description></item>
            /// <item><description>TranscodeCancelled: transcoding canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TranscodeSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbfaaec9e**********bf0b81219244c</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The media asset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30e5d7**********bd900764de7c0102</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The details of the workflow task. This field has a value only when TaskType is Workflow.</para>
        /// </summary>
        [NameInMap("WorkflowTaskDetail")]
        [Validation(Required=false)]
        public GetJobDetailResponseBodyWorkflowTaskDetail WorkflowTaskDetail { get; set; }
        public class GetJobDetailResponseBodyWorkflowTaskDetail : TeaModel {
            /// <summary>
            /// <para>The processing results of each workflow node, in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;VodSnapshot_123\&quot;:{\&quot;ActivityId\&quot;:\&quot;VodSnapshot\&quot;,\&quot;ActivityInstanceId\&quot;:\&quot;c8cf62d53bef4e04bf703976bae6d0b9\&quot;,\&quot;EndTime\&quot;:\&quot;2025-03-27T08:15:51Z\&quot;,\&quot;Result\&quot;:\&quot;{\\\&quot;RequestId\\\&quot;:\\\&quot;8B3649AF-5A6B-1099-BEB6-164D81067398\\\&quot;,\\\&quot;EventType\\\&quot;:\\\&quot;SnapshotComplete\\\&quot;,\\\&quot;UserId\\\&quot;:1797131669910763,\\\&quot;MessageBody\\\&quot;:{\\\&quot;Status\\\&quot;:\\\&quot;success\\\&quot;,\\\&quot;VideoId\\\&quot;:\\\&quot;00f985a50ae371f0ad1c4106e0ea0102\\\&quot;,\\\&quot;EventType\\\&quot;:\\\&quot;SnapshotComplete\\\&quot;,\\\&quot;EventTime\\\&quot;:\\\&quot;2025-03-27T08:15:50Z\\\&quot;,\\\&quot;TriggerSource\\\&quot;:\\\&quot;{\\\\\\\&quot;ActivityInstanceId\\\\\\\&quot;:\\\\\\\&quot;c8cf62d53bef4e04bf703976bae6d0b9\\\\\\\&quot;,\\\\\\\&quot;BizType\\\\\\\&quot;:\\\\\\\&quot;ice-workflow\\\\\\\&quot;}\\\&quot;}}\&quot;,\&quot;StartTime\&quot;:\&quot;2025-03-27T08:15:47Z\&quot;,\&quot;Status\&quot;:\&quot;Succeed\&quot;},\&quot;Translate_zh_en\&quot;:{\&quot;ActivityId\&quot;:\&quot;VodTranslation\&quot;,\&quot;ActivityInstanceId\&quot;:\&quot;c043a872bb044763a3d293a5c2458b50\&quot;,\&quot;EndTime\&quot;:\&quot;2025-03-27T08:20:19Z\&quot;,\&quot;Result\&quot;:\&quot;{\\\&quot;Type\\\&quot;:\\\&quot;VideoTranslationAll\\\&quot;,\\\&quot;Success\\\&quot;:false}\&quot;,\&quot;StartTime\&quot;:\&quot;2025-03-27T08:15:46Z\&quot;,\&quot;Status\&quot;:\&quot;Failed\&quot;},\&quot;Act_Start\&quot;:{\&quot;ActivityId\&quot;:\&quot;start\&quot;,\&quot;ActivityInstanceId\&quot;:\&quot;8a9402f4ff064084bf496707fb2d664a\&quot;,\&quot;Result\&quot;:\&quot;{\\\&quot;Type\\\&quot;:\\\&quot;Media\\\&quot;,\\\&quot;bizType\\\&quot;:6,\\\&quot;Media\\\&quot;:\\\&quot;00f985a50ae371f0ad1c4106e0ea0102\\\&quot;,\\\&quot;Title\\\&quot;:\\\&quot;2.mp4\\\&quot;,\\\&quot;taskInput\\\&quot;:\\\&quot;{\\\\\\\&quot;Type\\\\\\\&quot;:\\\\\\\&quot;Media\\\\\\\&quot;,\\\\\\\&quot;Media\\\\\\\&quot;:\\\\\\\&quot;00f985a50ae371f0ad1c4106e0ea0102\\\\\\\&quot;}\\\&quot;,\\\&quot;userTaskInput\\\&quot;:\\\&quot;{\\\\\\\&quot;Type\\\\\\\&quot;:\\\\\\\&quot;Media\\\\\\\&quot;,\\\\\\\&quot;Media\\\\\\\&quot;:\\\\\\\&quot;00f985a50ae371f0ad1c4106e0ea0102\\\\\\\&quot;,\\\\\\\&quot;Title\\\\\\\&quot;:\\\\\\\&quot;2.mp4\\\\\\\&quot;,\\\\\\\&quot;StorageLocation\\\\\\\&quot;:\\\\\\\&quot;yiming-pre.oss-cn-shanghai.aliyuncs.com\\\\\\\&quot;}\\\&quot;,\\\&quot;StorageLocation\\\&quot;:\\\&quot;yiming-pre.oss-cn-shanghai.aliyuncs.com\\\&quot;,\\\&quot;callerUid\\\&quot;:1797131669910763,\\\&quot;CUR_NODE_NAME\\\&quot;:\\\&quot;Act_Start\\\&quot;}\&quot;,\&quot;StartTime\&quot;:\&quot;2025-03-27T08:15:45Z\&quot;,\&quot;Status\&quot;:\&quot;Succeed\&quot;},\&quot;VodDynamicImage_123\&quot;:{\&quot;ActivityId\&quot;:\&quot;VodDynamicImage\&quot;,\&quot;ActivityInstanceId\&quot;:\&quot;26e8dab82ab84110b1150f146caf633c\&quot;,\&quot;EndTime\&quot;:\&quot;2025-03-27T08:15:55Z\&quot;,\&quot;Result\&quot;:\&quot;{\\\&quot;RequestId\\\&quot;:\\\&quot;7120B5D5-430F-14AD-8922-577F072DDD64\\\&quot;,\\\&quot;EventType\\\&quot;:\\\&quot;DynamicImageComplete\\\&quot;,\\\&quot;UserId\\\&quot;:1797131669910763,\\\&quot;MessageBody\\\&quot;:{\\\&quot;Status\\\&quot;:\\\&quot;success\\\&quot;,\\\&quot;VideoId\\\&quot;:\\\&quot;00f985a50ae371f0ad1c4106e0ea0102\\\&quot;,\\\&quot;EventType\\\&quot;:\\\&quot;DynamicImageComplete\\\&quot;,\\\&quot;EventTime\\\&quot;:\\\&quot;2025-03-27T08:15:52Z\\\&quot;,\\\&quot;TriggerSource\\\&quot;:\\\&quot;{\\\\\\\&quot;ActivityInstanceId\\\\\\\&quot;:\\\\\\\&quot;26e8dab82ab84110b1150f146caf633c\\\\\\\&quot;,\\\\\\\&quot;BizType\\\\\\\&quot;:\\\\\\\&quot;ice-workflow\\\\\\\&quot;}\\\&quot;}}\&quot;,\&quot;StartTime\&quot;:\&quot;2025-03-27T08:15:47Z\&quot;,\&quot;Status\&quot;:\&quot;Succeed\&quot;}}</para>
            /// </summary>
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public string ActivityResults { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-27T08:15:46Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-27T08:20:19Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Init: started.</description></item>
            /// <item><description>Processing: processing in progress.</description></item>
            /// <item><description>Succeed: succeeded.</description></item>
            /// <item><description>Failed: failed.</description></item>
            /// <item><description>Canceled: canceled.</description></item>
            /// <item><description>Skip: skipped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46ecc024******92c8e26237e51</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The media asset information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Type\&quot;:\&quot;Media\&quot;,\&quot;Media\&quot;:\&quot;00f985a50ae371f0ad1c4106e0ea0102\&quot;,\&quot;Title\&quot;:\&quot;2.mp4\&quot;,\&quot;StorageLocation\&quot;:\&quot;yiming-pre.oss-cn-shanghai.aliyuncs.com\&quot;}</para>
            /// </summary>
            [NameInMap("TaskInput")]
            [Validation(Required=false)]
            public string TaskInput { get; set; }

            /// <summary>
            /// <para>The custom settings. The value is a JSON string that supports message callback, upload acceleration, and other settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The workflow details.</para>
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetJobDetailResponseBodyWorkflowTaskDetailWorkflow Workflow { get; set; }
            public class GetJobDetailResponseBodyWorkflowTaskDetailWorkflow : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-1000000</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The time when the workflow was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-26T05:50:14Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the workflow was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-26T07:51:55Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The workflow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All_Activity_New_1_app-1000000</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The workflow status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Active: activated.</description></item>
                /// <item><description>Inactive: not activated.</description></item>
                /// <item><description>Deleted: deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The workflow type. Not populated by default.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vw_09d6*****b5c5b19a0c891e02</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

    }

}
