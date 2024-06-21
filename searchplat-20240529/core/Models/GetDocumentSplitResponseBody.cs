// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetDocumentSplitResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDocumentSplitResponseBodyResult Result { get; set; }
        public class GetDocumentSplitResponseBodyResult : TeaModel {
            [NameInMap("chunks")]
            [Validation(Required=false)]
            public List<GetDocumentSplitResponseBodyResultChunks> Chunks { get; set; }
            public class GetDocumentSplitResponseBodyResultChunks : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public Dictionary<string, string> Meta { get; set; }

            }

            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Nodes { get; set; }

            [NameInMap("rich_texts")]
            [Validation(Required=false)]
            public List<GetDocumentSplitResponseBodyResultRichTexts> RichTexts { get; set; }
            public class GetDocumentSplitResponseBodyResultRichTexts : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public Dictionary<string, string> Meta { get; set; }

            }

            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<GetDocumentSplitResponseBodyResultSentences> Sentences { get; set; }
            public class GetDocumentSplitResponseBodyResultSentences : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("meta")]
                [Validation(Required=false)]
                public Dictionary<string, string> Meta { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetDocumentSplitResponseBodyUsage Usage { get; set; }
        public class GetDocumentSplitResponseBodyUsage : TeaModel {
            [NameInMap("token_count")]
            [Validation(Required=false)]
            public long? TokenCount { get; set; }

        }

    }

}
