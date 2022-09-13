// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainByCertificateResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnDomainByCertificateResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnDomainByCertificateResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainByCertificateResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnDomainByCertificateResponseBodyCertInfosCertInfo : TeaModel {
                [NameInMap("CertCaIsLegacy")]
                [Validation(Required=false)]
                public string CertCaIsLegacy { get; set; }

                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                [NameInMap("CertExpired")]
                [Validation(Required=false)]
                public string CertExpired { get; set; }

                [NameInMap("CertStartTime")]
                [Validation(Required=false)]
                public string CertStartTime { get; set; }

                [NameInMap("CertSubjectCommonName")]
                [Validation(Required=false)]
                public string CertSubjectCommonName { get; set; }

                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                [NameInMap("DomainNames")]
                [Validation(Required=false)]
                public string DomainNames { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
