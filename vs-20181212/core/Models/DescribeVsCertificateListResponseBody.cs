// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsCertificateListResponseBody : TeaModel {
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVsCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVsCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeVsCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeVsCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public long? CertId { get; set; }

                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                [NameInMap("Common")]
                [Validation(Required=false)]
                public string Common { get; set; }

                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

            }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
