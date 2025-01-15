// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunVideoAnalysisResponseBody : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RunVideoAnalysisResponseBodyHeader Header { get; set; }
        public class RunVideoAnalysisResponseBodyHeader : TeaModel {
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
            /// <para>task-progress-start-generating</para>
            /// </summary>
            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2150432017236011824686132ecdbc</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("payload")]
        [Validation(Required=false)]
        public RunVideoAnalysisResponseBodyPayload Payload { get; set; }
        public class RunVideoAnalysisResponseBodyPayload : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public RunVideoAnalysisResponseBodyPayloadOutput Output { get; set; }
            public class RunVideoAnalysisResponseBodyPayloadOutput : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>http://</para>
                /// </summary>
                [NameInMap("resultJsonFileUrl")]
                [Validation(Required=false)]
                public string ResultJsonFileUrl { get; set; }

                [NameInMap("videoAnalysisResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResult VideoAnalysisResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-vl-max</para>
                    /// </summary>
                    [NameInMap("modelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultUsage : TeaModel {
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
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("totalTokens")]
                        [Validation(Required=false)]
                        public long? TotalTokens { get; set; }

                    }

                    [NameInMap("videoShotAnalysisResults")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultVideoShotAnalysisResults> VideoShotAnalysisResults { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultVideoShotAnalysisResults : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1000</para>
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
                public RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResult VideoCaptionResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("videoCaptions")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResultVideoCaptions> VideoCaptions { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResultVideoCaptions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1710432000000</para>
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
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>00:01</para>
                        /// </summary>
                        [NameInMap("startTimeFormat")]
                        [Validation(Required=false)]
                        public string StartTimeFormat { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                [NameInMap("videoGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResult VideoGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-max</para>
                    /// </summary>
                    [NameInMap("modelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    [NameInMap("modelReduce")]
                    [Validation(Required=false)]
                    public bool? ModelReduce { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResultUsage : TeaModel {
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
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("totalTokens")]
                        [Validation(Required=false)]
                        public long? TotalTokens { get; set; }

                    }

                }

                [NameInMap("videoMindMappingGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResult VideoMindMappingGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("modelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    [NameInMap("modelReduce")]
                    [Validation(Required=false)]
                    public bool? ModelReduce { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultUsage : TeaModel {
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
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("totalTokens")]
                        [Validation(Required=false)]
                        public long? TotalTokens { get; set; }

                    }

                    [NameInMap("videoMindMappings")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappings> VideoMindMappings { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappings : TeaModel {
                        [NameInMap("childNodes")]
                        [Validation(Required=false)]
                        public List<RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodes> ChildNodes { get; set; }
                        public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodes : TeaModel {
                            [NameInMap("childNodes")]
                            [Validation(Required=false)]
                            public List<RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodesChildNodes> ChildNodes { get; set; }
                            public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultVideoMindMappingsChildNodesChildNodes : TeaModel {
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

                [NameInMap("videoShotSnapshotResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResult VideoShotSnapshotResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResult : TeaModel {
                    [NameInMap("videoShots")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResultVideoShots> VideoShots { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResultVideoShots : TeaModel {
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("endTimeFormat")]
                        [Validation(Required=false)]
                        public string EndTimeFormat { get; set; }

                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        [NameInMap("startTimeFormat")]
                        [Validation(Required=false)]
                        public string StartTimeFormat { get; set; }

                        [NameInMap("videoSnapshots")]
                        [Validation(Required=false)]
                        public List<RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResultVideoShotsVideoSnapshots> VideoSnapshots { get; set; }
                        public class RunVideoAnalysisResponseBodyPayloadOutputVideoShotSnapshotResultVideoShotsVideoSnapshots : TeaModel {
                            [NameInMap("url")]
                            [Validation(Required=false)]
                            public string Url { get; set; }

                        }

                    }

                }

                [NameInMap("videoTitleGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResult VideoTitleGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen-max</para>
                    /// </summary>
                    [NameInMap("modelId")]
                    [Validation(Required=false)]
                    public string ModelId { get; set; }

                    [NameInMap("modelReduce")]
                    [Validation(Required=false)]
                    public bool? ModelReduce { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResultUsage : TeaModel {
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

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public RunVideoAnalysisResponseBodyPayloadUsage Usage { get; set; }
            public class RunVideoAnalysisResponseBodyPayloadUsage : TeaModel {
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                [NameInMap("totalTokens")]
                [Validation(Required=false)]
                public long? TotalTokens { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>117F5ABE-CF02-5502-9A3F-E56BC9081A64</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
