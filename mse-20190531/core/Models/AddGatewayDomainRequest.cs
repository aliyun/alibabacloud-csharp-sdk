// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayDomainRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        [NameInMap("MustHttps")]
        [Validation(Required=false)]
        public bool? MustHttps { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("TlsMax")]
        [Validation(Required=false)]
        public string TlsMax { get; set; }

        [NameInMap("TlsMin")]
        [Validation(Required=false)]
        public string TlsMin { get; set; }

    }

}
