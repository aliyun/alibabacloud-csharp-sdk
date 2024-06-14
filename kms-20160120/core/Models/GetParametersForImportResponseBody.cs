// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetParametersForImportResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to import key material.
        /// 
        /// The token is valid for 24 hours. The value of this parameter is required when you call the [ImportKeyMaterial](https://help.aliyun.com/document_detail/68622.html) operation.
        /// </summary>
        [NameInMap("ImportToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// The globally unique ID of the CMK.
        /// 
        /// The value of this parameter is required when you call the [ImportKeyMaterial](https://help.aliyun.com/document_detail/68622.html) operation.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The public key that is used to encrypt key material.
        /// 
        /// The public key is Base64-encoded.
        /// </summary>
        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the token expires.
        /// </summary>
        [NameInMap("TokenExpireTime")]
        [Validation(Required=false)]
        public string TokenExpireTime { get; set; }

    }

}
