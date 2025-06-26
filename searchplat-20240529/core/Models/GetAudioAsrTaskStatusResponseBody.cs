// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetAudioAsrTaskStatusResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAudioAsrTaskStatusResponseBodyResult Result { get; set; }
        public class GetAudioAsrTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetAudioAsrTaskStatusResponseBodyResultData> Data { get; set; }
            public class GetAudioAsrTaskStatusResponseBodyResultData : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public float? End { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public float? Start { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

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
        public GetAudioAsrTaskStatusResponseBodyUsage Usage { get; set; }
        public class GetAudioAsrTaskStatusResponseBodyUsage : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

        }

    }

}
