// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMultiModalRerankerRequest : TeaModel {
        [NameInMap("docs")]
        [Validation(Required=false)]
        public List<GetMultiModalRerankerRequestDocs> Docs { get; set; }
        public class GetMultiModalRerankerRequestDocs : TeaModel {
            [NameInMap("image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public GetMultiModalRerankerRequestQuery Query { get; set; }
        public class GetMultiModalRerankerRequestQuery : TeaModel {
            [NameInMap("image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
