// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextGenerationResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTextGenerationResponseBodyResult Result { get; set; }
        public class GetTextGenerationResponseBodyResult : TeaModel {
            [NameInMap("search_results")]
            [Validation(Required=false)]
            public List<GetTextGenerationResponseBodyResultSearchResults> SearchResults { get; set; }
            public class GetTextGenerationResponseBodyResultSearchResults : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetTextGenerationResponseBodyUsage Usage { get; set; }
        public class GetTextGenerationResponseBodyUsage : TeaModel {
            [NameInMap("input_tokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            [NameInMap("output_tokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            [NameInMap("total_tokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

        }

    }

}
