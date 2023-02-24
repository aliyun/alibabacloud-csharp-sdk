// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ExportDataKeyResponseBody : TeaModel {
        /// <summary>
        /// The data key encrypted by using the public key and then exported.
        /// </summary>
        [NameInMap("ExportedDataKey")]
        [Validation(Required=false)]
        public string ExportedDataKey { get; set; }

        /// <summary>
        /// The ID of the CMK that is used to decrypt the specified ciphertext of the data key.
        /// 
        /// This parameter is the globally unique ID of the CMK.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The ID of the CMK version that is used to decrypt the specified ciphertext of the data key.
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
