// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetCaCertResponseBody : TeaModel {
        /// <summary>
        /// The Base64-encoded content of the CA certificate.
        /// </summary>
        [NameInMap("CaCert")]
        [Validation(Required=false)]
        public string CaCert { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
