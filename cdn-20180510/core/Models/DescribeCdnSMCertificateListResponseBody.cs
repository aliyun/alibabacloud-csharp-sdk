// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSMCertificateListResponseBody : TeaModel {
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnSMCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnSMCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnSMCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnSMCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnSMCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnSMCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("CertIdentifier")]
                    [Validation(Required=false)]
                    public string CertIdentifier { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                }

            }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
