// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeVsDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeVsDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeVsDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeVsDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                public string Status { get; set; }
                public string CertLife { get; set; }
                public string CertExpireTime { get; set; }
                public string SSLPub { get; set; }
                public string CertType { get; set; }
                public string ServerCertificateStatus { get; set; }
                public string CertDomainName { get; set; }
                public string CertName { get; set; }
                public string CertOrg { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
