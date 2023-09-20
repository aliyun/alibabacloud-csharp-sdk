// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// The domain names that are added to WAF in CNAME record mode.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeDomainsResponseBodyDomains> Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// The back-to-origin settings.
            /// </summary>
            [NameInMap("Backeds")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsBackeds Backeds { get; set; }
            public class DescribeDomainsResponseBodyDomainsBackeds : TeaModel {
                /// <summary>
                /// The HTTP addresses of the origin server.
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttp> Http { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttp : TeaModel {
                    /// <summary>
                    /// The HTTP address of the origin server.
                    /// </summary>
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

                /// <summary>
                /// The HTTPS addresses of the origin server.
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<DescribeDomainsResponseBodyDomainsBackedsHttps> Https { get; set; }
                public class DescribeDomainsResponseBodyDomainsBackedsHttps : TeaModel {
                    /// <summary>
                    /// The HTTPS address of the origin server.
                    /// </summary>
                    [NameInMap("Backend")]
                    [Validation(Required=false)]
                    public string Backend { get; set; }

                }

            }

            /// <summary>
            /// The CNAME assigned by WAF to the domain name.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The domain name that is added to WAF in CNAME record mode.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The configurations of the listeners.
            /// </summary>
            [NameInMap("ListenPorts")]
            [Validation(Required=false)]
            public DescribeDomainsResponseBodyDomainsListenPorts ListenPorts { get; set; }
            public class DescribeDomainsResponseBodyDomainsListenPorts : TeaModel {
                /// <summary>
                /// The HTTP listener ports.
                /// </summary>
                [NameInMap("Http")]
                [Validation(Required=false)]
                public List<long?> Http { get; set; }

                /// <summary>
                /// The HTTPS listener ports.
                /// </summary>
                [NameInMap("Https")]
                [Validation(Required=false)]
                public List<long?> Https { get; set; }

            }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// The status of the domain name. Valid values:
            /// 
            /// *   **1:** The domain name is in a normal state.
            /// *   **2:** The domain name is being created.
            /// *   **3:** The domain name is being modified.
            /// *   **4:** The domain name is being released.
            /// *   **5:** WAF no longer forwards traffic that is sent to the domain name.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
