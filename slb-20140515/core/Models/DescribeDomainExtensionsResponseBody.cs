// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeDomainExtensionsResponseBody : TeaModel {
        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public DescribeDomainExtensionsResponseBodyDomainExtensions DomainExtensions { get; set; }
        public class DescribeDomainExtensionsResponseBodyDomainExtensions : TeaModel {
            [NameInMap("DomainExtension")]
            [Validation(Required=false)]
            public List<DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension> DomainExtension { get; set; }
            public class DescribeDomainExtensionsResponseBodyDomainExtensionsDomainExtension : TeaModel {
                public string Domain { get; set; }
                public string DomainExtensionId { get; set; }
                public string ServerCertificateId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
