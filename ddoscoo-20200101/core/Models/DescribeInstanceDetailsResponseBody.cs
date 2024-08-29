// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceDetailsResponseBody : TeaModel {
        /// <summary>
        /// The IP address and ISP line information about the Anti-DDoS Proxy instance.
        /// </summary>
        [NameInMap("InstanceDetails")]
        [Validation(Required=false)]
        public List<DescribeInstanceDetailsResponseBodyInstanceDetails> InstanceDetails { get; set; }
        public class DescribeInstanceDetailsResponseBodyInstanceDetails : TeaModel {
            /// <summary>
            /// The IP address information about the Anti-DDoS Proxy instance.
            /// </summary>
            [NameInMap("EipInfos")]
            [Validation(Required=false)]
            public List<DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfos> EipInfos { get; set; }
            public class DescribeInstanceDetailsResponseBodyInstanceDetailsEipInfos : TeaModel {
                /// <summary>
                /// Indicates whether a custom certificate is configured.
                /// </summary>
                [NameInMap("CertConfigured")]
                [Validation(Required=false)]
                public bool? CertConfigured { get; set; }

                /// <summary>
                /// The IP address of the instance.
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// The type of the instance.
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// The IP address-based forwarding mode of the instance. Valid values:
                /// 
                /// *   **fnat**: Requests from IPv4 addresses are forwarded to origin servers that use IPv4 addresses and requests from IPv6 addresses are forwarded to origin servers that use IPv6 addresses.
                /// *   **v6tov4**: All requests are forwarded to origin servers that use IPv4 addresses.
                /// </summary>
                [NameInMap("IpMode")]
                [Validation(Required=false)]
                public string IpMode { get; set; }

                /// <summary>
                /// The IP version of the protocol. Valid values:
                /// 
                /// *   **Ipv4**: IPv4
                /// *   **Ipv6**: IPv6
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// Indicates whether the TLS 1.3 version is supported.
                /// </summary>
                [NameInMap("Ssl13Enabled")]
                [Validation(Required=false)]
                public bool? Ssl13Enabled { get; set; }

                /// <summary>
                /// The status of the instance. Valid values:
                /// 
                /// *   **normal**: indicates that the instance is normal.
                /// *   **expired**: indicates that the instance expired.
                /// *   **defense**: indicates that traffic scrubbing is performed on the asset that is protected by the instance.
                /// *   **blackhole**: indicates that blackhole filtering is triggered for the asset that is protected by the instance.
                /// *   **punished**: indicates that the instance is in penalty.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The Transport Layer Security (TLS) version that is configured.
                /// </summary>
                [NameInMap("TlsVersion")]
                [Validation(Required=false)]
                public string TlsVersion { get; set; }

            }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The protection line of the instance.
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
