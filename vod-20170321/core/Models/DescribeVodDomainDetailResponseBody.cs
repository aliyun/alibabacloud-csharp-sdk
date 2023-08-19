// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The basic information about the domain name for CDN.
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeVodDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeVodDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// The name of the certificate. The value of this parameter is returned if HTTPS is enabled.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The CNAME that is assigned to the domain name for CDN. You must add a CNAME record in the system of your Domain Name System (DNS) service provider to map the domain name for CDN to the CNAME.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The description of the domain name for CDN.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The domain name for CDN.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The status of the domain name for CDN. Value values:
            /// *   **online**: indicates that the domain name is enabled.
            /// *   **offline**: indicates that the domain name is disabled.
            /// *   **configuring**: indicates that the domain name is being configured.
            /// *   **configure_failed**: indicates that the domain name failed to be configured.
            /// *   **checking**: indicates that the domain name is under review.
            /// *   **check_failed**: indicates that the domain name failed the review.
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// The time when the domain name for CDN was added. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// The last time when the domain name for CDN was modified. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// Indicates whether the Secure Sockets Layer (SSL) certificate is enabled. Valid values:
            /// *   **on**: indicates that the SSL certificate is enabled.
            /// *   **off**: indicates that the SSL certificate is disabled.
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// The public key of the certificate. The value of this parameter is returned if HTTPS is enabled.
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// This parameter is applicable to users of level 3 or higher in mainland China and users outside mainland China. Valid values:
            /// *   **domestic**: mainland China. This is the default value.
            /// *   **overseas**: outside mainland China.
            /// *   **global**: regions in and outside mainland China.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The information about the origin server.
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeVodDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeVodDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    /// <summary>
                    /// The address of the origin server.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The status of the origin server. Valid values:
                    /// *   **online**: indicates that the origin server is enabled.
                    /// *   **offline**: indicates that the origin server is disabled.
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// The port number. Valid values: 443 and 80.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The priority of the origin server.
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// The type of the origin server. Valid values:
                    /// *   **ipaddr**: a server that you can access by using an IP address.
                    /// *   **domain**: a server that you can access by using a domain name.
                    /// *   **oss**: the URL of an Object Storage Service (OSS) bucket.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The weight of the origin server.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
