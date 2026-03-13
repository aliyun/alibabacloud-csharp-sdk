// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetVideoSegmentationTaskStatusResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetVideoSegmentationTaskStatusResponseBodyResult Result { get; set; }
        public class GetVideoSegmentationTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetVideoSegmentationTaskStatusResponseBodyResultData> Data { get; set; }
            public class GetVideoSegmentationTaskStatusResponseBodyResultData : TeaModel {
                [NameInMap("chunk_index")]
                [Validation(Required=false)]
                public int? ChunkIndex { get; set; }

                [NameInMap("end_time")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("snapshots")]
                [Validation(Required=false)]
                public List<GetVideoSegmentationTaskStatusResponseBodyResultDataSnapshots> Snapshots { get; set; }
                public class GetVideoSegmentationTaskStatusResponseBodyResultDataSnapshots : TeaModel {
                    [NameInMap("frame_index")]
                    [Validation(Required=false)]
                    public int? FrameIndex { get; set; }

                    [NameInMap("frame_time")]
                    [Validation(Required=false)]
                    public float? FrameTime { get; set; }

                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

                [NameInMap("start_time")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

                [NameInMap("transcript")]
                [Validation(Required=false)]
                public string Transcript { get; set; }

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
        public GetVideoSegmentationTaskStatusResponseBodyUsage Usage { get; set; }
        public class GetVideoSegmentationTaskStatusResponseBodyUsage : TeaModel {
            [NameInMap("audio_token")]
            [Validation(Required=false)]
            public long? AudioToken { get; set; }

            [NameInMap("image_token")]
            [Validation(Required=false)]
            public long? ImageToken { get; set; }

        }

    }

}
