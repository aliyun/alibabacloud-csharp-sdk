// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The information about the accelerated domain name.
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeDcdnDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeDcdnDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// The CNAME that is assigned to the accelerated domain name. You must add the CNAME record to the system of your Domain Name System (DNS) provider to map the accelerated domain name to the CNAME.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The information about the Internet content provider (ICP) filing of the domain name.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The accelerated domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The status of the accelerated domain name. Valid values:
            /// 
            /// *   **online**
            /// *   **offline**
            /// *   **configuring**
            /// *   **configure_failed**
            /// *   **checking**
            /// *   **check_failed**
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// The time when the domain name was added.
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
            /// *   **on**: **enabled**
            /// *   **off**: **disabled**
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

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// The acceleration region. Default value: domestic. Valid values:
            /// 
            /// *   **domestic**: Chinese mainland
            /// *   **overseas**: global (excluding the Chinese mainland)
            /// *   **global**: global
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The information about the origin server.
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeDcdnDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeDcdnDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeDcdnDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeDcdnDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
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
                    /// The port over which requests are redirected to the origin server. Ports 443 and 80 are supported.
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
                    /// *   **domain**: an origin domain name
                    /// *   **oss**: the domain name of an Object Storage Service (OSS) bucket
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
