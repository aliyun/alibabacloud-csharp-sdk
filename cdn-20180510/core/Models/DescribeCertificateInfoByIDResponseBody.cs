// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCertificateInfoByIDResponseBody : TeaModel {
        [NameInMap("CertInfos")]
        [Validation(Required=false)]
        public DescribeCertificateInfoByIDResponseBodyCertInfos CertInfos { get; set; }
        public class DescribeCertificateInfoByIDResponseBodyCertInfos : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeCertificateInfoByIDResponseBodyCertInfosCertInfo> CertInfo { get; set; }
            public class DescribeCertificateInfoByIDResponseBodyCertInfosCertInfo : TeaModel {
                public string CertExpireTime { get; set; }
                public string CreateTime { get; set; }
                public string CertType { get; set; }
                public string CertName { get; set; }
                public string CertId { get; set; }
                public string DomainList { get; set; }
                public string HttpsCrt { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
