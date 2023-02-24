// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateAndExportDataKeyResponseBody : TeaModel {
        /// <summary>
        /// The ciphertext of the data key encrypted by using the primary CMK version.
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// The data key encrypted by using the public key and then exported.
        /// </summary>
        [NameInMap("ExportedDataKey")]
        [Validation(Required=false)]
        public string ExportedDataKey { get; set; }

        /// <summary>
        /// The globally unique ID of the CMK.
        /// 
        /// >  If you set the KeyId parameter to an alias, the ID of the CMK to which the alias is bound is returned.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The ID of the CMK version that is used to encrypt the plaintext. It is the primary version of the CMK.
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
