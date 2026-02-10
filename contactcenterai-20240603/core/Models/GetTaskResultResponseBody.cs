// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class GetTaskResultResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTaskResultResponseBodyData Data { get; set; }
        public class GetTaskResultResponseBodyData : TeaModel {
            [NameInMap("asrResult")]
            [Validation(Required=false)]
            public List<GetTaskResultResponseBodyDataAsrResult> AsrResult { get; set; }
            public class GetTaskResultResponseBodyDataAsrResult : TeaModel {
                [NameInMap("begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                [NameInMap("emotionValue")]
                [Validation(Required=false)]
                public int? EmotionValue { get; set; }

                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("speechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                [NameInMap("words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            [NameInMap("extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("ragErrorMessage")]
            [Validation(Required=false)]
            public string RagErrorMessage { get; set; }

            [NameInMap("ragResult")]
            [Validation(Required=false)]
            public string RagResult { get; set; }

            [NameInMap("ragStatus")]
            [Validation(Required=false)]
            public string RagStatus { get; set; }

            [NameInMap("taskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20240905-********-93E9-5D45-B4EF-045743A34071</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public GetTaskResultResponseBodyDataUsage Usage { get; set; }
            public class GetTaskResultResponseBodyDataUsage : TeaModel {
                [NameInMap("rag")]
                [Validation(Required=false)]
                public GetTaskResultResponseBodyDataUsageRag Rag { get; set; }
                public class GetTaskResultResponseBodyDataUsageRag : TeaModel {
                    [NameInMap("adaptive")]
                    [Validation(Required=false)]
                    public GetTaskResultResponseBodyDataUsageRagAdaptive Adaptive { get; set; }
                    public class GetTaskResultResponseBodyDataUsageRagAdaptive : TeaModel {
                        [NameInMap("inputTokens")]
                        [Validation(Required=false)]
                        public int? InputTokens { get; set; }

                        [NameInMap("invokeCount")]
                        [Validation(Required=false)]
                        public int? InvokeCount { get; set; }

                        [NameInMap("outputTokens")]
                        [Validation(Required=false)]
                        public int? OutputTokens { get; set; }

                    }

                    [NameInMap("dialogSummary")]
                    [Validation(Required=false)]
                    public GetTaskResultResponseBodyDataUsageRagDialogSummary DialogSummary { get; set; }
                    public class GetTaskResultResponseBodyDataUsageRagDialogSummary : TeaModel {
                        [NameInMap("inputTokens")]
                        [Validation(Required=false)]
                        public int? InputTokens { get; set; }

                        [NameInMap("invokeCount")]
                        [Validation(Required=false)]
                        public int? InvokeCount { get; set; }

                        [NameInMap("outputTokens")]
                        [Validation(Required=false)]
                        public int? OutputTokens { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>968A8634-FA2C-5381-9B3E-C552DED7E8BF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
