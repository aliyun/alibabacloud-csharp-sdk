// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunVideoDetectShotResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunVideoDetectShotResponseBodyHeader Header { get; set; }
        public class RunVideoDetectShotResponseBodyHeader : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParam</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pop sign mismatch, please check log.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-finished</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>14d15c78c4c34d428212f4d923d4ede1</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3b5287b317477940746851672dca0c</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunVideoDetectShotResponseBodyPayload Payload { get; set; }
        public class RunVideoDetectShotResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunVideoDetectShotResponseBodyPayloadOutput Output { get; set; }
            public class RunVideoDetectShotResponseBodyPayloadOutput : TeaModel {
                [NameInMap("videoSplitResult")]
                [Validation(Required=false)]
                public RunVideoDetectShotResponseBodyPayloadOutputVideoSplitResult VideoSplitResult { get; set; }
                public class RunVideoDetectShotResponseBodyPayloadOutputVideoSplitResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("reasonText")]
                    [Validation(Required=false)]
                    public string ReasonText { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("videoParts")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, string>> VideoParts { get; set; }

                    [NameInMap("videoRecognitionResult")]
                    [Validation(Required=false)]
                    public List<RunVideoDetectShotResponseBodyPayloadOutputVideoSplitResultVideoRecognitionResult> VideoRecognitionResult { get; set; }
                    public class RunVideoDetectShotResponseBodyPayloadOutputVideoSplitResultVideoRecognitionResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("asr")]
                        [Validation(Required=false)]
                        public string Asr { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1755742611000</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("ocr")]
                        [Validation(Required=false)]
                        public string Ocr { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1756433675000</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("vl")]
                        [Validation(Required=false)]
                        public string Vl { get; set; }

                    }

                }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunVideoDetectShotResponseBodyPayloadUsage Usage { get; set; }
            public class RunVideoDetectShotResponseBodyPayloadUsage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4546</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>820</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5366</para>
                /// </summary>
                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>58868FD6-53D7-5ACD-80F7-854C8EA256EF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
