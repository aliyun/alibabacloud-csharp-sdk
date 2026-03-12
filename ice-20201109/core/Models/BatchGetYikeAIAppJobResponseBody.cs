// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetYikeAIAppJobResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<BatchGetYikeAIAppJobResponseBodyJobList> JobList { get; set; }
        public class BatchGetYikeAIAppJobResponseBodyJobList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>9e09955d662a</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;LoadImage.1.TargetImage\&quot;:\&quot;MediaId1\&quot;}</para>
            /// </summary>
            [NameInMap("AppInputConfig")]
            [Validation(Required=false)]
            public string AppInputConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:34.001+08:00</para>
            /// </summary>
            [NameInMap("ExecutionFinishTime")]
            [Validation(Required=false)]
            public string ExecutionFinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-02-06T18:53:18.809+08:00</para>
            /// </summary>
            [NameInMap("ExecutionStartTime")]
            [Validation(Required=false)]
            public string ExecutionStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pd_0617169475</para>
            /// </summary>
            [NameInMap("ProductionId")]
            [Validation(Required=false)]
            public string ProductionId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public BatchGetYikeAIAppJobResponseBodyJobListResult Result { get; set; }
            public class BatchGetYikeAIAppJobResponseBodyJobListResult : TeaModel {
                [NameInMap("AudioResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult> AudioResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultAudioResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>bb1dfa20a0c971f08c94e7f6d6496202</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp3</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                [NameInMap("ImageResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultImageResult> ImageResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultImageResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>318d6350a57d71f08c9ae7f7d4496302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

                [NameInMap("VideoResult")]
                [Validation(Required=false)]
                public List<BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult> VideoResult { get; set; }
                public class BatchGetYikeAIAppJobResponseBodyJobListResultVideoResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ec2de25068fd71f0a48cf7e6c4596302</para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp4">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.mp4</a></para>
                    /// </summary>
                    [NameInMap("OutputUrl")]
                    [Validation(Required=false)]
                    public string OutputUrl { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
