// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateCertificateShrinkRequest : TeaModel {
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public string SubjectAlternativeNamesShrink { get; set; }

        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        [NameInMap("ProtectionLevel")]
        [Validation(Required=false)]
        public string ProtectionLevel { get; set; }

    }

}
