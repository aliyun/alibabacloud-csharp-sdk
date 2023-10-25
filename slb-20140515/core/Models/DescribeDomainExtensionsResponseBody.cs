// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeDomainExtensionsResponseBody : TeaModel {
        /// <summary>
        /// The list of additional certificates.
        /// </summary>
        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public DescribeDomainExtensionsResponseBodyDomainExtensions DomainExtensions { get; set; }
        public class DescribeDomainExtensionsResponseBodyDomainExtensions : TeaModel {
            [NameInMap("DomainExtension")]
            [Validation(Required=false)]
            public List<DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension> DomainExtension { get; set; }
            public class DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The ID of the additional certificate.
                /// </summary>
                [NameInMap("DomainExtensionId")]
                [Validation(Required=false)]
                public string DomainExtensionId { get; set; }

                /// <summary>
                /// The ID of the server certificate that is used by the domain name.
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

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
