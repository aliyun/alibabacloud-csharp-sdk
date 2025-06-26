// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetVideoSnapshotTaskStatusResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetVideoSnapshotTaskStatusResponseBodyResult Result { get; set; }
        public class GetVideoSnapshotTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetVideoSnapshotTaskStatusResponseBodyResultData> Data { get; set; }
            public class GetVideoSnapshotTaskStatusResponseBodyResultData : TeaModel {
                [NameInMap("frame_index")]
                [Validation(Required=false)]
                public long? FrameIndex { get; set; }

                [NameInMap("frame_time")]
                [Validation(Required=false)]
                public float? FrameTime { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

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
        public GetVideoSnapshotTaskStatusResponseBodyUsage Usage { get; set; }
        public class GetVideoSnapshotTaskStatusResponseBodyUsage : TeaModel {
            [NameInMap("image_count")]
            [Validation(Required=false)]
            public long? ImageCount { get; set; }

        }

    }

}
