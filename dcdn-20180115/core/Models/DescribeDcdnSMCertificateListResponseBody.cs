// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateListResponseBody : TeaModel {
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnSMCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnSMCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                public string CertIdentifier { get; set; }
                public string CertName { get; set; }
                public string Common { get; set; }
                public string Issuer { get; set; }
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
