// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateProductTagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InvalidProductTags")]
        [Validation(Required=false)]
        public UpdateProductTagsResponseBodyInvalidProductTags InvalidProductTags { get; set; }
        public class UpdateProductTagsResponseBodyInvalidProductTags : TeaModel {
            [NameInMap("ProductTag")]
            [Validation(Required=false)]
            public List<UpdateProductTagsResponseBodyInvalidProductTagsProductTag> ProductTag { get; set; }
            public class UpdateProductTagsResponseBodyInvalidProductTagsProductTag : TeaModel {
                public string TagKey { get; set; }
                public string TagValue { get; set; }
            }
        };

    }

}
