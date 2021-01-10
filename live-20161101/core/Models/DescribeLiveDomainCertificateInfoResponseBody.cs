// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeLiveDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeLiveDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                public string DomainName { get; set; }
                public string CertName { get; set; }
                public string CertDomainName { get; set; }
                public string CertExpireTime { get; set; }
                public string CertLife { get; set; }
                public string CertOrg { get; set; }
                public string CertType { get; set; }
                public string SSLProtocol { get; set; }
                public string Status { get; set; }
                public string SSLPub { get; set; }
            }
        };

    }

}
