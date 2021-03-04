// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ImportCertificateRequest : TeaModel {
        [NameInMap("PKCS12Blob")]
        [Validation(Required=false)]
        public string PKCS12Blob { get; set; }

        [NameInMap("Passphrase")]
        [Validation(Required=false)]
        public string Passphrase { get; set; }

    }

}
