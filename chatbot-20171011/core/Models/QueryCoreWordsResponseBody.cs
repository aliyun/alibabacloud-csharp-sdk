// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class QueryCoreWordsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("CoreWords")]
        [Validation(Required=false)]
        public List<QueryCoreWordsResponseBodyCoreWords> CoreWords { get; set; }
        public class QueryCoreWordsResponseBodyCoreWords : TeaModel {
            [NameInMap("CoreWordCode")]
            [Validation(Required=false)]
            public string CoreWordCode { get; set; }

            [NameInMap("CoreWordName")]
            [Validation(Required=false)]
            public string CoreWordName { get; set; }

            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public List<string> Synonyms { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
