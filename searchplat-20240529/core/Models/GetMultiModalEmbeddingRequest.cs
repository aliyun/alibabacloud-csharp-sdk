// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMultiModalEmbeddingRequest : TeaModel {
        [NameInMap("input")]
        [Validation(Required=false)]
        public List<GetMultiModalEmbeddingRequestInput> Input { get; set; }
        public class GetMultiModalEmbeddingRequestInput : TeaModel {
            [NameInMap("image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

    }

}
