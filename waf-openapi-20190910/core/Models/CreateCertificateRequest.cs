/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class CreateCertificateRequest : TeaModel {
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
