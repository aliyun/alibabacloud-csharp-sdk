// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCsrDetailResponseBody : TeaModel {
        /// <summary>
        /// The content of the CSR.
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// The private key. Specify a Base64-encoded string.
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
