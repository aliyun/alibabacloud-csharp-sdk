// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs. Each object mirrors the details returned by the <c>GetYikeAIAppJob</c> operation.</para>
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<BatchGetYikeAIAppJobResponseBodyJobList> JobList { get; set; }
        public class BatchGetYikeAIAppJobResponseBodyJobList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e09955d662a</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The AI application\&quot;s input parameters, formatted as a JSON-serialized string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
            /// </summary>
            [NameInMap("AppInputConfig")]
            [Validation(Required=false)]
            public string AppInputConfig { get; set; }

            /// <summary>
            /// <para>The time the job execution finished. The time is in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:34.001+08:00</para>
            /// </summary>
            [NameInMap("ExecutionFinishTime")]
            [Validation(Required=false)]
            public string ExecutionFinishTime { get; set; }

            /// <summary>
            /// <para>The time the job execution started. The time is in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:18.809+08:00</para>
            /// </summary>
            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("ProductionId")]
            [Validation(Required=false)]
            public string ProductionId { get; set; }

            /// <summary>
            /// <para>The execution result of the job.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public BatchGetYikeAIAppJobResponseBodyJobListResult Result { get; set; }
            public class BatchGetYikeAIAppJobResponseBodyJobListResult : TeaModel {
                /// <summary>
                /// <para>The audio result.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult> AudioResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bb1dfa20a0c971f08c94e7f6d6496202</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The image result.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultImageResult> ImageResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultImageResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>318d6350a57d71f08c9ae7f7d4496302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The video result.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult> VideoResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The ID of the media asset.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ec2de25068fd71f0a48cf7e6c4596302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp4">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp4</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the job. Valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Created</c>: The job has been created.</para>
            /// </description></item>
            /// <item><description><para><c>Queuing</c>: The job is in the queue.</para>
            /// </description></item>
            /// <item><description><para><c>Executing</c>: The job is executing.</para>
            /// </description></item>
            /// <item><description><para><c>Finished</c>: The job completed successfully.</para>
            /// </description></item>
            /// <item><description><para><c>Failed</c>: The job failed to complete.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
