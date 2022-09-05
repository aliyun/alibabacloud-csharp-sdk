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
                [NameInMap("CertExpireTime")]
                [Validation(Required=false)]
                public string CertExpireTime { get; set; }

                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                [NameInMap("CertType")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DomainList")]
                [Validation(Required=false)]
                public string DomainList { get; set; }

                [NameInMap("HttpsCrt")]
                [Validation(Required=false)]
                public string HttpsCrt { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
