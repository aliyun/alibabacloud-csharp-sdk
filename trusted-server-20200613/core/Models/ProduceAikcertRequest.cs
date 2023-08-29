// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class ProduceAikcertRequest : TeaModel {
        [NameInMap("AikName")]
        [Validation(Required=false)]
        public string AikName { get; set; }

        [NameInMap("CertRequest")]
        [Validation(Required=false)]
        public string CertRequest { get; set; }

        [NameInMap("EkCert")]
        [Validation(Required=false)]
        public string EkCert { get; set; }

        [NameInMap("EkPubKey")]
        [Validation(Required=false)]
        public string EkPubKey { get; set; }

        [NameInMap("IncludeCertChain")]
        [Validation(Required=false)]
        public bool? IncludeCertChain { get; set; }

    }

}
