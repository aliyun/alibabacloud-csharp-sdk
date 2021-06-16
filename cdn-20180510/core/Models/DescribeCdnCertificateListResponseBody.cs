// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnCertificateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                }

            }
        };

    }

}
