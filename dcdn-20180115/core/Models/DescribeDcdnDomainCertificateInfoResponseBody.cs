// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDcdnDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDcdnDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                public string CertDomainName { get; set; }
                public string CertExpireTime { get; set; }
                public string CertLife { get; set; }
                public string CertName { get; set; }
                public string CertOrg { get; set; }
                public string CertType { get; set; }
                public string DomainName { get; set; }
                public string SSLProtocol { get; set; }
                public string SSLPub { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
