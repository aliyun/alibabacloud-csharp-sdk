// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeScdnDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeScdnDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeScdnDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeScdnDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                [NameInMap("CertDomainName")]
                [Validation(Required=false)]
                public string CertDomainName { get; set; }

                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                [NameInMap("CertLife")]
                [Validation(Required=false)]
                public string CertLife { get; set; }

                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                [NameInMap("CertOrg")]
                [Validation(Required=false)]
                public string CertOrg { get; set; }

                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                [NameInMap("SSLPub")]
                [Validation(Required=false)]
                public string SSLPub { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
