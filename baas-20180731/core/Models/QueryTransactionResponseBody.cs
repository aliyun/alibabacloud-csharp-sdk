// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class QueryTransactionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryTransactionResponseBodyResult Result { get; set; }
        public class QueryTransactionResponseBodyResult : TeaModel {
            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public long? BlockHeight { get; set; }

            [NameInMap("BlockVersion")]
            [Validation(Required=false)]
            public int? BlockVersion { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentHash")]
            [Validation(Required=false)]
            public string ContentHash { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            [NameInMap("KeyWrap")]
            [Validation(Required=false)]
            public string KeyWrap { get; set; }

            [NameInMap("Nonce")]
            [Validation(Required=false)]
            public string Nonce { get; set; }

            [NameInMap("ReferenceCount")]
            [Validation(Required=false)]
            public int? ReferenceCount { get; set; }

            [NameInMap("ReferenceList")]
            [Validation(Required=false)]
            public QueryTransactionResponseBodyResultReferenceList ReferenceList { get; set; }
            public class QueryTransactionResponseBodyResultReferenceList : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public string Data { get; set; }

                [NameInMap("Length")]
                [Validation(Required=false)]
                public int? Length { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
