// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ExportCertificateRequest : TeaModel {
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("Passphrase")]
        [Validation(Required=false)]
        public string Passphrase { get; set; }

        [NameInMap("ExportFormat")]
        [Validation(Required=false)]
        public string ExportFormat { get; set; }

    }

}
