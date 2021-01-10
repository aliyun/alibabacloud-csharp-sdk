// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionaryEntriesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInterventionDictionaryEntriesResponseBodyResult> Result { get; set; }
        public class ListInterventionDictionaryEntriesResponseBodyResult : TeaModel {
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

            [NameInMap("tokens")]
            [Validation(Required=false)]
            public List<ListInterventionDictionaryEntriesResponseBodyResultTokens> Tokens { get; set; }
            public class ListInterventionDictionaryEntriesResponseBodyResultTokens : TeaModel {
                [NameInMap("tagLabel")]
                [Validation(Required=false)]
                public string TagLabel { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

            }

            [NameInMap("relevance")]
            [Validation(Required=false)]
            public Dictionary<string, object> Relevance { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
