// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateDomainRequest : TeaModel {
        [NameInMap("caCertIndentifier")]
        [Validation(Required=false)]
        public string CaCertIndentifier { get; set; }

        [NameInMap("certIndentifier")]
        [Validation(Required=false)]
        public string CertIndentifier { get; set; }

        [NameInMap("forceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        [NameInMap("http2Option")]
        [Validation(Required=false)]
        public string Http2Option { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("tlsMax")]
        [Validation(Required=false)]
        public string TlsMax { get; set; }

        [NameInMap("tlsMin")]
        [Validation(Required=false)]
        public string TlsMin { get; set; }

    }

}
