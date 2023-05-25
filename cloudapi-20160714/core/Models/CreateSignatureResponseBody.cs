// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateSignatureResponseBody : TeaModel {
        /// <summary>
        /// The name of the back-end signature key.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// *   This API is intended for API providers.
        /// *   The API operation only creates a key policy. You must call the binding operation to bind the key to an API.
        /// *   After the key is bound to the API, requests sent from API Gateway to the backend service contain signature strings. You can specify whether your backend service verifies these signature strings.
        /// *   The QPS limit on this operation is 50 per user.
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// Creates a backend signature key.
        /// </summary>
        [NameInMap("SignatureName")]
        [Validation(Required=false)]
        public string SignatureName { get; set; }

    }

}
