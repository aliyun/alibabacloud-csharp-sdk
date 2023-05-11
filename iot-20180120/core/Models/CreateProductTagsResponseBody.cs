// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductTagsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The invalid product tags returned if the call fails.
        /// </summary>
        [NameInMap("InvalidProductTags")]
        [Validation(Required=false)]
        public CreateProductTagsResponseBodyInvalidProductTags InvalidProductTags { get; set; }
        public class CreateProductTagsResponseBodyInvalidProductTags : TeaModel {
            [NameInMap("ProductTag")]
            [Validation(Required=false)]
            public List<CreateProductTagsResponseBodyInvalidProductTagsProductTag> ProductTag { get; set; }
            public class CreateProductTagsResponseBodyInvalidProductTagsProductTag : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful. The tags were attached to the product.
        /// *   **false**: The call failed. This value indicates that the tags failed to be attached to the product.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
