// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                public string Status { get; set; }
                public string CertLife { get; set; }
                public string CertExpireTime { get; set; }
                public string CertUpdateTime { get; set; }
                public string ServerCertificateStatus { get; set; }
                public string CertDomainName { get; set; }
                public string CertOrg { get; set; }
                public string DomainName { get; set; }
                public string CertStartTime { get; set; }
                public string CertType { get; set; }
                public string CertName { get; set; }
                public string DomainCnameStatus { get; set; }
                public string ServerCertificate { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
