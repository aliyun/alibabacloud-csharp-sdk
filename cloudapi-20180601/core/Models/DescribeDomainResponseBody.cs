// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeDomainResponseBody : TeaModel {
        [NameInMap("CertificateBody")]
        [Validation(Required=false)]
        public string CertificateBody { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        [NameInMap("DomainBindingStatus")]
        [Validation(Required=false)]
        public string DomainBindingStatus { get; set; }

        [NameInMap("DomainLegalStatus")]
        [Validation(Required=false)]
        public string DomainLegalStatus { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainNameResolution")]
        [Validation(Required=false)]
        public string DomainNameResolution { get; set; }

        [NameInMap("DomainRemark")]
        [Validation(Required=false)]
        public string DomainRemark { get; set; }

        [NameInMap("DomainWebSocketStatus")]
        [Validation(Required=false)]
        public string DomainWebSocketStatus { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

    }

}
