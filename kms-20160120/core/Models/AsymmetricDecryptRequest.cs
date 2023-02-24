/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricDecryptRequest : TeaModel {
        /// <summary>
        /// The decryption algorithm.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The ciphertext that you want to decrypt.
        /// 
        /// > 
        /// *   The value is encoded in Base64.
        /// *   You can call the [AsymmetricEncrypt](~~148131~~) operation to generate the ciphertext.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// The ID of the customer master key (CMK). The ID must be globally unique.
        /// 
        /// >  You can also set this parameter to an alias that is bound to the CMK. For more information, see [Alias overview](~~68522~~).
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The version ID of the CMK. The ID must be globally unique.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
