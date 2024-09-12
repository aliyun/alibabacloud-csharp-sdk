// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetQueryAnalysisResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetQueryAnalysisResponseBodyResult Result { get; set; }
        public class GetQueryAnalysisResponseBodyResult : TeaModel {
            [NameInMap("intent")]
            [Validation(Required=false)]
            public string Intent { get; set; }

            [NameInMap("queries")]
            [Validation(Required=false)]
            public List<string> Queries { get; set; }

            [NameInMap("query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            [NameInMap("sql")]
            [Validation(Required=false)]
            public Dictionary<string, object> Sql { get; set; }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetQueryAnalysisResponseBodyUsage Usage { get; set; }
        public class GetQueryAnalysisResponseBodyUsage : TeaModel {
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
