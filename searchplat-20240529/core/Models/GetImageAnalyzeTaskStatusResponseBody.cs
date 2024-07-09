// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetImageAnalyzeTaskStatusResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetImageAnalyzeTaskStatusResponseBodyResult Result { get; set; }
        public class GetImageAnalyzeTaskStatusResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public GetImageAnalyzeTaskStatusResponseBodyResultData Data { get; set; }
            public class GetImageAnalyzeTaskStatusResponseBodyResultData : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("content_type")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("page_num")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

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
        public GetImageAnalyzeTaskStatusResponseBodyUsage Usage { get; set; }
        public class GetImageAnalyzeTaskStatusResponseBodyUsage : TeaModel {
            [NameInMap("pv_count")]
            [Validation(Required=false)]
            public long? PvCount { get; set; }

            [NameInMap("token_count")]
            [Validation(Required=false)]
            public long? TokenCount { get; set; }

        }

    }

}
