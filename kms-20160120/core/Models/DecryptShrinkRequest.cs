// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DecryptShrinkRequest : TeaModel {
        /// <summary>
        /// The ciphertext that you want to decrypt.
        /// 
        /// You can generate the ciphertext by calling the following operations:
        /// 
        /// *   [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html)
        /// *   [Encrypt](https://help.aliyun.com/document_detail/28949.html)
        /// *   [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// The JSON string that consists of key-value pairs.
        /// 
        /// >  If you specify the EncryptionContext parameter when you call the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html), [Encrypt](https://help.aliyun.com/document_detail/28949.html), or [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html) operation, you must specify the same context when you call the Decrypt operation. For more information, see [EncryptionContext](https://help.aliyun.com/document_detail/42975.html).
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

    }

}
