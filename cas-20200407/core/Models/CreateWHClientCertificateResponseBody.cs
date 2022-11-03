// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateWHClientCertificateResponseBody : TeaModel {
        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("ParentX509Certificate")]
        [Validation(Required=false)]
        public string ParentX509Certificate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RootX509Certificate")]
        [Validation(Required=false)]
        public string RootX509Certificate { get; set; }

        [NameInMap("X509Certificate")]
        [Validation(Required=false)]
        public string X509Certificate { get; set; }

    }

}
