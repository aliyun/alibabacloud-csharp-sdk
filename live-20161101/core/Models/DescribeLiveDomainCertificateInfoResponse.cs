// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainCertificateInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CertInfos")]
        [Validation(Required=true)]
        public DescribeLiveDomainCertificateInfoResponseCertInfos CertInfos { get; set; }
        public class DescribeLiveDomainCertificateInfoResponseCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainCertificateInfoResponseCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeLiveDomainCertificateInfoResponseCertInfosCertInfo : TeaModel {
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
