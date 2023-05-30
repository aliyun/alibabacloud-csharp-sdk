// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricSignResponseBody : TeaModel {
        /// <summary>
        /// The version ID of the CMK. The ID must be globally unique.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The digest that is generated for the original message by using a hash algorithm. The hash algorithm is specified by the Algorithm parameter.
        /// 
        /// > * The value is encoded in Base64.
        /// > * For more information about how to calculate message digests, see the **Preprocess signature: compute a message digest** section of the [Generate and verify a signature by using an asymmetric CMK](~~148146~~) topic.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// The calculated signature.
        /// 
        /// >  The value is encoded in Base64.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// >  If you set the KeyId parameter in the request to an alias, the ID of the CMK to which the alias is bound is returned.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
