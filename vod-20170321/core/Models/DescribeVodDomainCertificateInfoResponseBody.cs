// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainCertificateInfoResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeVodDomainCertificateInfoResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeVodDomainCertificateInfoResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeVodDomainCertificateInfoResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeVodDomainCertificateInfoResponseBodyCertInfosCertInfo : TeaModel {
                public string CertDomainName { get; set; }
                public string CertExpireTime { get; set; }
                public string CertLife { get; set; }
                public string CertName { get; set; }
                public string CertOrg { get; set; }
                public string CertType { get; set; }
                public string DomainName { get; set; }
                public string ServerCertificateStatus { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
