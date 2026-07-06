// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class UpdateCustomDomainInput : TeaModel {
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

    }

}
