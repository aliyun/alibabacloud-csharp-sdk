// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductTagsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("InvalidProductTags")]
        [Validation(Required=false)]
        public CreateProductTagsResponseBodyInvalidProductTags InvalidProductTags { get; set; }
        public class CreateProductTagsResponseBodyInvalidProductTags : TeaModel {
            [NameInMap("ProductTag")]
            [Validation(Required=false)]
            public List<CreateProductTagsResponseBodyInvalidProductTagsProductTag> ProductTag { get; set; }
            public class CreateProductTagsResponseBodyInvalidProductTagsProductTag : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
