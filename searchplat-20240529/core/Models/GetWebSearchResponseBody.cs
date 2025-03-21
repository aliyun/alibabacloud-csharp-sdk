// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetWebSearchResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetWebSearchResponseBodyResult Result { get; set; }
        public class GetWebSearchResponseBodyResult : TeaModel {
            [NameInMap("search_result")]
            [Validation(Required=false)]
            public List<GetWebSearchResponseBodyResultSearchResult> SearchResult { get; set; }
            public class GetWebSearchResponseBodyResultSearchResult : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("link")]
                [Validation(Required=false)]
                public string Link { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                [NameInMap("snippet")]
                [Validation(Required=false)]
                public string Snippet { get; set; }

                [NameInMap("tilte")]
                [Validation(Required=false)]
                public string Tilte { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetWebSearchResponseBodyUsage Usage { get; set; }
        public class GetWebSearchResponseBodyUsage : TeaModel {
            [NameInMap("filter_model")]
            [Validation(Required=false)]
            public GetWebSearchResponseBodyUsageFilterModel FilterModel { get; set; }
            public class GetWebSearchResponseBodyUsageFilterModel : TeaModel {
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

            [NameInMap("rewrite_model")]
            [Validation(Required=false)]
            public GetWebSearchResponseBodyUsageRewriteModel RewriteModel { get; set; }
            public class GetWebSearchResponseBodyUsageRewriteModel : TeaModel {
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

            [NameInMap("search_count")]
            [Validation(Required=false)]
            public long? SearchCount { get; set; }

        }

    }

}
