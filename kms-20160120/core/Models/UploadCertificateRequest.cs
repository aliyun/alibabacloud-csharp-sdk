// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UploadCertificateRequest : TeaModel {
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("CertificateChain")]
        [Validation(Required=false)]
        public string CertificateChain { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

    }

}
