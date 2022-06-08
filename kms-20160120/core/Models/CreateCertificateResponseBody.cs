// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateCertificateResponseBody : TeaModel {
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
