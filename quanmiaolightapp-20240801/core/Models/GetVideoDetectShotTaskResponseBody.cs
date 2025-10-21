// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetVideoDetectShotTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVideoDetectShotTaskResponseBodyData Data { get; set; }
        public class GetVideoDetectShotTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Failed to proxy flink ui request, message: An error occurred: Invalid UUID string: jobsn.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("header")]
            [Validation(Required=false)]
            public GetVideoDetectShotTaskResponseBodyDataHeader Header { get; set; }
            public class GetVideoDetectShotTaskResponseBodyDataHeader : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Deduct task already success,Please do not resubmit.token \&quot;369e8f2c-d283-424a-96c4-c83efe08c89e\&quot;</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TIMEOUT_CLOSE_ORDER</para>
                /// </summary>
                [NameInMap("event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("eventInfo")]
                [Validation(Required=false)]
                public string EventInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d5c38cf6-a4bf-4a57-a697-9f449926f0c9</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6e223291-729b-4e84-9271-c13ada1a776b</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>215045f817272303448235204efdef</para>
                /// </summary>
                [NameInMap("traceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            [NameInMap("payload")]
            [Validation(Required=false)]
            public GetVideoDetectShotTaskResponseBodyDataPayload Payload { get; set; }
            public class GetVideoDetectShotTaskResponseBodyDataPayload : TeaModel {
                [NameInMap("output")]
                [Validation(Required=false)]
                public GetVideoDetectShotTaskResponseBodyDataPayloadOutput Output { get; set; }
                public class GetVideoDetectShotTaskResponseBodyDataPayloadOutput : TeaModel {
                    [NameInMap("videoSplitResult")]
                    [Validation(Required=false)]
                    public GetVideoDetectShotTaskResponseBodyDataPayloadOutputVideoSplitResult VideoSplitResult { get; set; }
                    public class GetVideoDetectShotTaskResponseBodyDataPayloadOutputVideoSplitResult : TeaModel {
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
                        public List<GetVideoDetectShotTaskResponseBodyDataPayloadOutputVideoSplitResultVideoRecognitionResult> VideoRecognitionResult { get; set; }
                        public class GetVideoDetectShotTaskResponseBodyDataPayloadOutputVideoSplitResultVideoRecognitionResult : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxx</para>
                            /// </summary>
                            [NameInMap("asr")]
                            [Validation(Required=false)]
                            public string Asr { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1748483740000</para>
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
                            /// <para>1758108425000</para>
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
                public GetVideoDetectShotTaskResponseBodyDataPayloadUsage Usage { get; set; }
                public class GetVideoDetectShotTaskResponseBodyDataPayloadUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>49</para>
                    /// </summary>
                    [NameInMap("totalTokens")]
                    [Validation(Required=false)]
                    public long? TotalTokens { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3feb69ed02d9b1a17d0f1a942675d300</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskRunInfo")]
            [Validation(Required=false)]
            public GetVideoDetectShotTaskResponseBodyDataTaskRunInfo TaskRunInfo { get; set; }
            public class GetVideoDetectShotTaskResponseBodyDataTaskRunInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("concurrentChargeEnable")]
                [Validation(Required=false)]
                public bool? ConcurrentChargeEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("responseTime")]
                [Validation(Required=false)]
                public long? ResponseTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
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
        public bool? Success { get; set; }

    }

}
