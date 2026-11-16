// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class BatchGetVideoCharacterReplaceJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of job query results.</para>
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<BatchGetVideoCharacterReplaceJobsResponseBodyJobList> JobList { get; set; }
        public class BatchGetVideoCharacterReplaceJobsResponseBodyJobList : TeaModel {
            /// <summary>
            /// <para>The ID of the video character replacement application. Make sure to use a configured application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The application input parameters specified when the job was submitted. The value is a JSON serialized string. This corresponds to the AppParams parameter in the submit operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;LoadImage.1.TargetImage&quot;:&quot;1a7852b032c371f0b64fe6f6c74b****&quot;}</para>
            /// </summary>
            [NameInMap("AppInputConfig")]
            [Validation(Required=false)]
            public string AppInputConfig { get; set; }

            /// <summary>
            /// <para>The time when the job finished execution. The time is in the ISO 8601 format with a time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:54:18.809+08:00</para>
            /// </summary>
            [NameInMap("ExecutionFinishTime")]
            [Validation(Required=false)]
            public string ExecutionFinishTime { get; set; }

            /// <summary>
            /// <para>The time when the job started execution. The time is in the ISO 8601 format with a time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:34.001+08:00</para>
            /// </summary>
            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            /// <summary>
            /// <para>The folder ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>folder-u3ilwhoc36ux9a****</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The job ID, which is returned by the SubmitVideoCharacterReplaceJob operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ag_83baeea38b534ee1937b8a4acd08****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_061716****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The output results of the job, categorized by image, video, and audio.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public BatchGetVideoCharacterReplaceJobsResponseBodyJobListResult Result { get; set; }
            public class BatchGetVideoCharacterReplaceJobsResponseBodyJobListResult : TeaModel {
                /// <summary>
                /// <para>The list of output audio files.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultAudioResult> AudioResult { get; set; }
                public class BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The download URL of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp3</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The list of output images.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultImageResult> ImageResult { get; set; }
                public class BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultImageResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The download URL of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.png</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The list of output videos.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public List<BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultVideoResult> VideoResult { get; set; }
                public class BatchGetVideoCharacterReplaceJobsResponseBodyJobListResultVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1a7852b032c371f0b64fe6f6c74b****</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The download URL of the output media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4">https://outin-***.oss-cn-shanghai.aliyuncs.com/stream/48555e8b-181dd5a8c07/48555e8b-181dd5a8c07.mp4</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

            }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The job is created.</description></item>
            /// <item><description>Queuing: The job is queuing.</description></item>
            /// <item><description>Executing: The job is being executed.</description></item>
            /// <item><description>Finished: The job is finished.</description></item>
            /// <item><description>Failed: The job failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
