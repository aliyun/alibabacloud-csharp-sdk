// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateVideoSummarizationTaskRequest : TeaModel {
        [NameInMap("input")]
        [Validation(Required=false)]
        public CreateVideoSummarizationTaskRequestInput Input { get; set; }
        public class CreateVideoSummarizationTaskRequestInput : TeaModel {
            [NameInMap("chunks")]
            [Validation(Required=false)]
            public List<CreateVideoSummarizationTaskRequestInputChunks> Chunks { get; set; }
            public class CreateVideoSummarizationTaskRequestInputChunks : TeaModel {
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("snapshots")]
                [Validation(Required=false)]
                public List<CreateVideoSummarizationTaskRequestInputChunksSnapshots> Snapshots { get; set; }
                public class CreateVideoSummarizationTaskRequestInputChunksSnapshots : TeaModel {
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

            [NameInMap("file_name")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("oss")]
            [Validation(Required=false)]
            public string Oss { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("output")]
        [Validation(Required=false)]
        public CreateVideoSummarizationTaskRequestOutput Output { get; set; }
        public class CreateVideoSummarizationTaskRequestOutput : TeaModel {
            [NameInMap("oss")]
            [Validation(Required=false)]
            public string Oss { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
