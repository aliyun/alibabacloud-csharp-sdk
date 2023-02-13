// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyResponseBody : TeaModel {
        /// <summary>
        /// The content of the encrypted private key.
        /// </summary>
        [NameInMap("EncryptedData")]
        [Validation(Required=false)]
        public string EncryptedData { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
