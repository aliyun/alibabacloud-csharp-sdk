// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateCertificateRequest : TeaModel {
        [NameInMap("ExportablePrivateKey")]
        [Validation(Required=false)]
        public bool? ExportablePrivateKey { get; set; }

        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public Dictionary<string, object> SubjectAlternativeNames { get; set; }

    }

}
