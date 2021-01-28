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
                public string CertStartTime { get; set; }
                public string CertExpireTime { get; set; }
                public string CertCaIsLegacy { get; set; }
                public string CertSubjectCommonName { get; set; }
                public string CertType { get; set; }
                public string DomainNames { get; set; }
                public string CertExpired { get; set; }
                public string Issuer { get; set; }
                public string DomainList { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
