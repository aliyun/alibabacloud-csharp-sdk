// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricVerifyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// >  If you set the KeyId parameter in the request to an alias, the ID of the CMK to which the alias is bound is returned.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The version ID of the CMK that is used to encrypt the plaintext.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the signature passed the verification.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public bool? Value { get; set; }

    }

}
