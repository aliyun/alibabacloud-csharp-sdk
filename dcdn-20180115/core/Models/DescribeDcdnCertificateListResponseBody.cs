// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnCertificateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeDcdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
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
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

    }

}
