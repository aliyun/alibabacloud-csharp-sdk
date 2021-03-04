// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListCertificatesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("CertificateSummaryList")]
        [Validation(Required=false)]
        public ListCertificatesResponseBodyCertificateSummaryList CertificateSummaryList { get; set; }
        public class ListCertificatesResponseBodyCertificateSummaryList : TeaModel {
            [NameInMap("CertificateSummary")]
            [Validation(Required=false)]
            public List<ListCertificatesResponseBodyCertificateSummaryListCertificateSummary> CertificateSummary { get; set; }
            public class ListCertificatesResponseBodyCertificateSummaryListCertificateSummary : TeaModel {
                public string Status { get; set; }
                public string KeySpec { get; set; }
                public string Subject { get; set; }
                public string ProtectionLevel { get; set; }
                public string Issuer { get; set; }
                public string NotBefore { get; set; }
                public string NotAfter { get; set; }
                public string CertificateId { get; set; }
            }
        };

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
