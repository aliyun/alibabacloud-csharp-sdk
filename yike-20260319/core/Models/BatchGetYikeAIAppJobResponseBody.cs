// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class BatchGetYikeAIAppJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks. Each element in the list is the same as the result of GetYikeAIAppJob.</para>
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<BatchGetYikeAIAppJobResponseBodyJobList> JobList { get; set; }
        public class BatchGetYikeAIAppJobResponseBodyJobList : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9e09955d662a</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The input parameters for running the AI application. The value is a JSON-serialized string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
            /// </summary>
            [NameInMap("AppInputConfig")]
            [Validation(Required=false)]
            public string AppInputConfig { get; set; }

            /// <summary>
            /// <para>The time when the task started. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:34.001+08:00</para>
            /// </summary>
            [NameInMap("ExecutionFinishTime")]
            [Validation(Required=false)]
            public string ExecutionFinishTime { get; set; }

            /// <summary>
            /// <para>The time when the task ended. The time is in the yyyy-mm-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:18.809+08:00</para>
            /// </summary>
            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            /// <summary>
            /// <para>The folder ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("ProductionId")]
            [Validation(Required=false)]
            public string ProductionId { get; set; }

            /// <summary>
            /// <para>The task execution result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public BatchGetYikeAIAppJobResponseBodyJobListResult Result { get; set; }
            public class BatchGetYikeAIAppJobResponseBodyJobListResult : TeaModel {
                /// <summary>
                /// <para>The audio task result.</para>
                /// </summary>
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult> AudioResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult : TeaModel {
                    /// <summary>
                    /// <para>The media asset ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bb1dfa20a0c971f08c94e7f6d6496202</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output file URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The image task result.</para>
                /// </summary>
                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultImageResult> ImageResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultImageResult : TeaModel {
                    /// <summary>
                    /// <para>The media asset ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>318d6350a57d71f08c9ae7f7d4496302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output file URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                /// <summary>
                /// <para>The video task result.</para>
                /// </summary>
                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult> VideoResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult : TeaModel {
                    /// <summary>
                    /// <para>The media asset ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ec2de25068fd71f0a48cf7e6c4596302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <para>The output file URL.</para>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The task is created.</description></item>
            /// <item><description>Queuing: The task is queuing.</description></item>
            /// <item><description>Executing: The task is being executed.</description></item>
            /// <item><description>Finished: The task is finished.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
