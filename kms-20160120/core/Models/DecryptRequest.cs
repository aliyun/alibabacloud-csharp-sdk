// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptRequest : TeaModel {
        /// <summary>
        /// The ciphertext that you want to decrypt.
        /// 
        /// You can generate the ciphertext by calling the following operations:
        /// 
        /// *   [GenerateDataKey](~~28948~~)
        /// *   [Encrypt](~~28949~~)
        /// *   [GenerateDataKeyWithoutPlaintext](~~134043~~)
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// The JSON string that consists of key-value pairs.
        /// 
        /// >  If you specify the EncryptionContext parameter when you call the [GenerateDataKey](~~28948~~), [Encrypt](~~28949~~), or [GenerateDataKeyWithoutPlaintext](~~134043~~) operation, you must specify the same context when you call the Decrypt operation. For more information, see [EncryptionContext](~~42975~~).
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

    }

}
