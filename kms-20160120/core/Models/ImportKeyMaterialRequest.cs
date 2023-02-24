// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ImportKeyMaterialRequest : TeaModel {
        /// <summary>
        /// Use** GetParametersForImport** the Returned public key and the base64-encoded key material.
        /// </summary>
        [NameInMap("EncryptedKeyMaterial")]
        [Validation(Required=false)]
        public string EncryptedKeyMaterial { get; set; }

        /// <summary>
        /// By calling** GetParametersForImport** the import token.
        /// </summary>
        [NameInMap("ImportToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// The ID of the CMK to be imported.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The time when the key material expires.
        /// 
        /// If this parameter is not specified or set this parameter to 0, the key material does not expire.
        /// 
        /// >  The value cannot be earlier than the time when the API is called (based on the server time).
        /// </summary>
        [NameInMap("KeyMaterialExpireUnix")]
        [Validation(Required=false)]
        public long? KeyMaterialExpireUnix { get; set; }

    }

}
