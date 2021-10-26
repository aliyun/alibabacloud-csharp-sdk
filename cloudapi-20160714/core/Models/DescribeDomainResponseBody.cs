// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeDomainResponseBody : TeaModel {
        [NameInMap("CertificatePrivateKey")]
        [Validation(Required=false)]
        public string CertificatePrivateKey { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainBindingStatus")]
        [Validation(Required=false)]
        public string DomainBindingStatus { get; set; }

        [NameInMap("DomainRemark")]
        [Validation(Required=false)]
        public string DomainRemark { get; set; }

        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        [NameInMap("DomainWebSocketStatus")]
        [Validation(Required=false)]
        public string DomainWebSocketStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        [NameInMap("DomainLegalStatus")]
        [Validation(Required=false)]
        public string DomainLegalStatus { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("CertificateBody")]
        [Validation(Required=false)]
        public string CertificateBody { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        [NameInMap("DomainCNAMEStatus")]
        [Validation(Required=false)]
        public string DomainCNAMEStatus { get; set; }

    }

}
