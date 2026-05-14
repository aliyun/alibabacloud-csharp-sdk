// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetJinaAiReaderResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetJinaAiReaderResponseBodyResult Result { get; set; }
        public class GetJinaAiReaderResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, string> Meta { get; set; }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetJinaAiReaderResponseBodyUsage Usage { get; set; }
        public class GetJinaAiReaderResponseBodyUsage : TeaModel {
            [NameInMap("token_count")]
            [Validation(Required=false)]
            public int? TokenCount { get; set; }

        }

    }

}
