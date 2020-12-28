// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeDomainExtensionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainExtensions")]
        [Validation(Required=false)]
        public List<DescribeDomainExtensionsResponseBodyDomainExtensions> DomainExtensions { get; set; }
        public class DescribeDomainExtensionsResponseBodyDomainExtensions : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("ServerCertificateId")]
            [Validation(Required=false)]
            public string ServerCertificateId { get; set; }

            [NameInMap("DomainExtensionId")]
            [Validation(Required=false)]
            public string DomainExtensionId { get; set; }

        }

    }

}
