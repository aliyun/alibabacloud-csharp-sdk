// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMultiModalRerankerResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMultiModalRerankerResponseBodyResult Result { get; set; }
        public class GetMultiModalRerankerResponseBodyResult : TeaModel {
            [NameInMap("scores")]
            [Validation(Required=false)]
            public List<GetMultiModalRerankerResponseBodyResultScores> Scores { get; set; }
            public class GetMultiModalRerankerResponseBodyResultScores : TeaModel {
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetMultiModalRerankerResponseBodyUsage Usage { get; set; }
        public class GetMultiModalRerankerResponseBodyUsage : TeaModel {
            [NameInMap("image_token")]
            [Validation(Required=false)]
            public long? ImageToken { get; set; }

            [NameInMap("text_token")]
            [Validation(Required=false)]
            public long? TextToken { get; set; }

        }

    }

}
