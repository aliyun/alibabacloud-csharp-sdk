// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsCertificateListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVsCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVsCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeVsCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeVsCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                public long? LastTime { get; set; }
                public string Fingerprint { get; set; }
                public string CertName { get; set; }
                public string Issuer { get; set; }
                public long? CertId { get; set; }
                public string Common { get; set; }
            }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

    }

}
