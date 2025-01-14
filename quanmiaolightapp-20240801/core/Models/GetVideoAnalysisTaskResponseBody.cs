// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class GetVideoAnalysisTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVideoAnalysisTaskResponseBodyData Data { get; set; }
        public class GetVideoAnalysisTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Access was denied, message: No such namespace namespaces/mjp-test-default.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("header")]
            [Validation(Required=false)]
            public GetVideoAnalysisTaskResponseBodyDataHeader Header { get; set; }
            public class GetVideoAnalysisTaskResponseBodyDataHeader : TeaModel {
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
            public GetVideoAnalysisTaskResponseBodyDataPayload Payload { get; set; }
            public class GetVideoAnalysisTaskResponseBodyDataPayload : TeaModel {
                [NameInMap("output")]
                [Validation(Required=false)]
                public GetVideoAnalysisTaskResponseBodyDataPayloadOutput Output { get; set; }
                public class GetVideoAnalysisTaskResponseBodyDataPayloadOutput : TeaModel {
                    [NameInMap("videoAnalysisResult")]
                    [Validation(Required=false)]
                    public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResult VideoAnalysisResult { get; set; }
                    public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("generateFinished")]
                        [Validation(Required=false)]
                        public bool? GenerateFinished { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResultUsage Usage { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResultUsage : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("inputTokens")]
                            [Validation(Required=false)]
                            public long? InputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("outputTokens")]
                            [Validation(Required=false)]
                            public long? OutputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("totalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                        [NameInMap("videoShotAnalysisResults")]
                        [Validation(Required=false)]
                        public List<GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResultVideoShotAnalysisResults> VideoShotAnalysisResults { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoAnalysisResultVideoShotAnalysisResults : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1710432000000</para>
                            /// </summary>
                            [NameInMap("endTime")]
                            [Validation(Required=false)]
                            public long? EndTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2024-10-05 06:22:00</para>
                            /// </summary>
                            [NameInMap("startTime")]
                            [Validation(Required=false)]
                            public long? StartTime { get; set; }

                            [NameInMap("text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                    }

                    [NameInMap("videoCaptionResult")]
                    [Validation(Required=false)]
                    public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoCaptionResult VideoCaptionResult { get; set; }
                    public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoCaptionResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("generateFinished")]
                        [Validation(Required=false)]
                        public bool? GenerateFinished { get; set; }

                        [NameInMap("videoCaptions")]
                        [Validation(Required=false)]
                        public List<GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoCaptionResultVideoCaptions> VideoCaptions { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoCaptionResultVideoCaptions : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1736129678000</para>
                            /// </summary>
                            [NameInMap("endTime")]
                            [Validation(Required=false)]
                            public long? EndTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>00:01</para>
                            /// </summary>
                            [NameInMap("endTimeFormat")]
                            [Validation(Required=false)]
                            public string EndTimeFormat { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>00:01</para>
                            /// </summary>
                            [NameInMap("startTime")]
                            [Validation(Required=false)]
                            public long? StartTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2025-01-07 11:52:06</para>
                            /// </summary>
                            [NameInMap("startTimeFormat")]
                            [Validation(Required=false)]
                            public string StartTimeFormat { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>xxxx</para>
                            /// </summary>
                            [NameInMap("text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                    }

                    [NameInMap("videoGenerateResult")]
                    [Validation(Required=false)]
                    public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoGenerateResult VideoGenerateResult { get; set; }
                    public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoGenerateResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("generateFinished")]
                        [Validation(Required=false)]
                        public bool? GenerateFinished { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoGenerateResultUsage Usage { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoGenerateResultUsage : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("inputTokens")]
                            [Validation(Required=false)]
                            public long? InputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("outputTokens")]
                            [Validation(Required=false)]
                            public long? OutputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("totalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                    }

                    [NameInMap("videoMindMappingGenerateResult")]
                    [Validation(Required=false)]
                    public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResult VideoMindMappingGenerateResult { get; set; }
                    public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("generateFinished")]
                        [Validation(Required=false)]
                        public bool? GenerateFinished { get; set; }

                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultUsage Usage { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultUsage : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("inputTokens")]
                            [Validation(Required=false)]
                            public long? InputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("outputTokens")]
                            [Validation(Required=false)]
                            public long? OutputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("totalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                        [NameInMap("videoMindMappings")]
                        [Validation(Required=false)]
                        public List<GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappings> VideoMindMappings { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappings : TeaModel {
                            [NameInMap("childNodes")]
                            [Validation(Required=false)]
                            public List<GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodes> ChildNodes { get; set; }
                            public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodes : TeaModel {
                                [NameInMap("childNodes")]
                                [Validation(Required=false)]
                                public List<GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodesChildNodes> ChildNodes { get; set; }
                                public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodesChildNodes : TeaModel {
                                    [NameInMap("name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                            }

                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                    }

                    [NameInMap("videoTitleGenerateResult")]
                    [Validation(Required=false)]
                    public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoTitleGenerateResult VideoTitleGenerateResult { get; set; }
                    public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoTitleGenerateResult : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("generateFinished")]
                        [Validation(Required=false)]
                        public bool? GenerateFinished { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoTitleGenerateResultUsage Usage { get; set; }
                        public class GetVideoAnalysisTaskResponseBodyDataPayloadOutputVideoTitleGenerateResultUsage : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("inputTokens")]
                            [Validation(Required=false)]
                            public long? InputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("outputTokens")]
                            [Validation(Required=false)]
                            public long? OutputTokens { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("totalTokens")]
                            [Validation(Required=false)]
                            public long? TotalTokens { get; set; }

                        }

                    }

                }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public GetVideoAnalysisTaskResponseBodyDataPayloadUsage Usage { get; set; }
                public class GetVideoAnalysisTaskResponseBodyDataPayloadUsage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
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
            public GetVideoAnalysisTaskResponseBodyDataTaskRunInfo TaskRunInfo { get; set; }
            public class GetVideoAnalysisTaskResponseBodyDataTaskRunInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("concurrentChargeEnable")]
                [Validation(Required=false)]
                public bool? ConcurrentChargeEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D0E915E-655D-59A8-894F-93873F73AAE5</para>
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
