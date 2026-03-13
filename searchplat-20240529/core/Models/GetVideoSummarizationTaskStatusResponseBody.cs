// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetVideoSummarizationTaskStatusResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetVideoSummarizationTaskStatusResponseBodyResult Result { get; set; }
        public class GetVideoSummarizationTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public GetVideoSummarizationTaskStatusResponseBodyResultData Data { get; set; }
            public class GetVideoSummarizationTaskStatusResponseBodyResultData : TeaModel {
                [NameInMap("chunks")]
                [Validation(Required=false)]
                public List<GetVideoSummarizationTaskStatusResponseBodyResultDataChunks> Chunks { get; set; }
                public class GetVideoSummarizationTaskStatusResponseBodyResultDataChunks : TeaModel {
                    [NameInMap("enhanced_transcript")]
                    [Validation(Required=false)]
                    public string EnhancedTranscript { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("metadata")]
                    [Validation(Required=false)]
                    public GetVideoSummarizationTaskStatusResponseBodyResultDataChunksMetadata Metadata { get; set; }
                    public class GetVideoSummarizationTaskStatusResponseBodyResultDataChunksMetadata : TeaModel {
                        [NameInMap("summary")]
                        [Validation(Required=false)]
                        public string Summary { get; set; }

                        [NameInMap("tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

                [NameInMap("video_metadata")]
                [Validation(Required=false)]
                public GetVideoSummarizationTaskStatusResponseBodyResultDataVideoMetadata VideoMetadata { get; set; }
                public class GetVideoSummarizationTaskStatusResponseBodyResultDataVideoMetadata : TeaModel {
                    [NameInMap("summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<string> Tags { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetVideoSummarizationTaskStatusResponseBodyUsage Usage { get; set; }
        public class GetVideoSummarizationTaskStatusResponseBodyUsage : TeaModel {
            [NameInMap("audio_token")]
            [Validation(Required=false)]
            public long? AudioToken { get; set; }

            [NameInMap("image_token")]
            [Validation(Required=false)]
            public long? ImageToken { get; set; }

            [NameInMap("input_token")]
            [Validation(Required=false)]
            public long? InputToken { get; set; }

            [NameInMap("output_token")]
            [Validation(Required=false)]
            public long? OutputToken { get; set; }

        }

    }

}
