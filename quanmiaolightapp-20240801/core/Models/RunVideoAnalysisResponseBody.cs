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
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            [NameInMap("eventInfo")]
            [Validation(Required=false)]
            public string EventInfo { get; set; }

            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

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
                [NameInMap("videoAnalysisResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResult VideoAnalysisResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResult : TeaModel {
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultUsage : TeaModel {
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

                    [NameInMap("videoShotAnalysisResults")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultVideoShotAnalysisResults> VideoShotAnalysisResults { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoAnalysisResultVideoShotAnalysisResults : TeaModel {
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

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
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("videoCaptions")]
                    [Validation(Required=false)]
                    public List<RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResultVideoCaptions> VideoCaptions { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoCaptionResultVideoCaptions : TeaModel {
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

                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

                [NameInMap("videoGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResult VideoGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResult : TeaModel {
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoGenerateResultUsage : TeaModel {
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

                [NameInMap("videoMindMappingGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResult VideoMindMappingGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResult : TeaModel {
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoMindMappingGenerateResultUsage : TeaModel {
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

                [NameInMap("videoTitleGenerateResult")]
                [Validation(Required=false)]
                public RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResult VideoTitleGenerateResult { get; set; }
                public class RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResult : TeaModel {
                    [NameInMap("generateFinished")]
                    [Validation(Required=false)]
                    public bool? GenerateFinished { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("usage")]
                    [Validation(Required=false)]
                    public RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResultUsage Usage { get; set; }
                    public class RunVideoAnalysisResponseBodyPayloadOutputVideoTitleGenerateResultUsage : TeaModel {
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

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
