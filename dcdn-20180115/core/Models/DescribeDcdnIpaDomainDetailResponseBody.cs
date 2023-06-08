// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The details about the accelerated domain name.
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeDcdnIpaDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// Indicates the name of the certificate if the HTTPS protocol is enabled.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The CNAME assigned to the domain name.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The accelerated domain names.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The status of the accelerated domain name. Valid values:
            /// 
            /// *   **online**: enabled
            /// *   **offline**: disabled
            /// *   **configuring**: configuring
            /// *   **configure_failed**: configuration failed
            /// *   **checking**: reviewing
            /// *   **check_failed:** review failed
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// The time when the domain name was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// Indicates whether the Security Socket Layer (SSL) certificate is enabled. Valid values:
            /// 
            /// *   **on**
            /// *   **off**.
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// The public key of the certificate if HTTPS is enabled.
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// The acceleration region. Valid values:
            /// 
            /// *   domestic: Chinese mainland
            /// *   overseas: outside the Chinese mainland
            /// *   global: global
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The information about the origin server.
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    /// <summary>
                    /// The address of the origin server.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The status.
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// The custom port. Valid values: **0** to **65535**.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The priority.
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// The type of the origin server. Valid values:
                    /// 
                    /// *   **ipaddr**: an origin IP address
                    /// *   **domain**: a domain name.
                    /// *   **oss**: Object Storage Service (OSS) buckets are not supported.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The weight of the origin server if multiple origin servers have been specified.
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
