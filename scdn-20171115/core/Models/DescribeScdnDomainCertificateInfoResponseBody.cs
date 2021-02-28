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
                public string Status { get; set; }
                public string CertLife { get; set; }
                public string CertExpireTime { get; set; }
                public string SSLPub { get; set; }
                public string SSLProtocol { get; set; }
                public string CertType { get; set; }
                public string CertDomainName { get; set; }
                public string CertName { get; set; }
                public string CertOrg { get; set; }
                public string DomainName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
