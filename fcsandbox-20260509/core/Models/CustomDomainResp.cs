// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CustomDomainResp : TeaModel {
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
