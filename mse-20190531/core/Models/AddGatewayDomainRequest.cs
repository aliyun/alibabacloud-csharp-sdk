// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayDomainRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the certificate.
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// Specifies whether to enable `HTTP/2`.
        /// 
        /// *   `open`: enables `HTTP/2`
        /// *   `close`: disables `HTTP/2`
        /// *   `globalConfig`: uses global configurations
        /// </summary>
        [NameInMap("Http2")]
        [Validation(Required=false)]
        public string Http2 { get; set; }

        /// <summary>
        /// Specifies whether to enable HTTPS.
        /// </summary>
        [NameInMap("MustHttps")]
        [Validation(Required=false)]
        public bool? MustHttps { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the protocol.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The maximum version of Transport Layer Security (TLS).
        /// </summary>
        [NameInMap("TlsMax")]
        [Validation(Required=false)]
        public string TlsMax { get; set; }

        /// <summary>
        /// The minimum version of TLS.
        /// </summary>
        [NameInMap("TlsMin")]
        [Validation(Required=false)]
        public string TlsMin { get; set; }

    }

}
