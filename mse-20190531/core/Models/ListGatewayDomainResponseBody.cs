// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayDomainResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewayDomainResponseBodyData> Data { get; set; }
        public class ListGatewayDomainResponseBodyData : TeaModel {
            /// <summary>
            /// The expiration time of the certificate.
            /// </summary>
            [NameInMap("CertBeforeDate")]
            [Validation(Required=false)]
            public string CertBeforeDate { get; set; }

            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public ListGatewayDomainResponseBodyDataComment Comment { get; set; }
            public class ListGatewayDomainResponseBodyDataComment : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// The time when the domain name was associated.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the domain name was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// Specifies whether to enable `Http2`.
            /// - `open`: enables `Http2`.
            /// - `close`: disables `Http2`.
            /// - `globalConfig`: uses global configurations.
            /// </summary>
            [NameInMap("Http2")]
            [Validation(Required=false)]
            public string Http2 { get; set; }

            /// <summary>
            /// ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// Indicates whether HTTPS is forcibly used.
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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

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

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
