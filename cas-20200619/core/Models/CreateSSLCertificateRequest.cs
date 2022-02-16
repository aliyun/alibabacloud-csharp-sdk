/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200619.Models
{
    public class CreateSSLCertificateRequest : TeaModel {
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
