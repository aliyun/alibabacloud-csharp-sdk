// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDomainResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDomainResponseBodyData Data { get; set; }
        public class GetDomainResponseBodyData : TeaModel {
            [NameInMap("algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("caCertIndentifier")]
            [Validation(Required=false)]
            public string CaCertIndentifier { get; set; }

            [NameInMap("certIndentifier")]
            [Validation(Required=false)]
            public string CertIndentifier { get; set; }

            [NameInMap("certName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("forceHttps")]
            [Validation(Required=false)]
            public bool? ForceHttps { get; set; }

            [NameInMap("http2Option")]
            [Validation(Required=false)]
            public string Http2Option { get; set; }

            [NameInMap("issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("notAfterTimstamp")]
            [Validation(Required=false)]
            public long? NotAfterTimstamp { get; set; }

            [NameInMap("notBeforeTimestamp")]
            [Validation(Required=false)]
            public long? NotBeforeTimestamp { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            [NameInMap("tlsMax")]
            [Validation(Required=false)]
            public string TlsMax { get; set; }

            [NameInMap("tlsMin")]
            [Validation(Required=false)]
            public string TlsMin { get; set; }

            [NameInMap("updatetimestamp")]
            [Validation(Required=false)]
            public long? Updatetimestamp { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
