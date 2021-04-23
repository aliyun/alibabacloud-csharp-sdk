// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeDRMCertListResponseBody : TeaModel {
        [NameInMap("DRMCertInfoListList")]
        [Validation(Required=false)]
        public DescribeDRMCertListResponseBodyDRMCertInfoListList DRMCertInfoListList { get; set; }
        public class DescribeDRMCertListResponseBodyDRMCertInfoListList : TeaModel {
            [NameInMap("CertInfo")]
            [Validation(Required=false)]
            public List<DescribeDRMCertListResponseBodyDRMCertInfoListListCertInfo> CertInfo { get; set; }
            public class DescribeDRMCertListResponseBodyDRMCertInfoListListCertInfo : TeaModel {
                public string Description { get; set; }
                public string PrivateKey { get; set; }
                public string ServCert { get; set; }
                public string CertName { get; set; }
                public string Passphrase { get; set; }
                public string CertId { get; set; }
                public string Ask { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
