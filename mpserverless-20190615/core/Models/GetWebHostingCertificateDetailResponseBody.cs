// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class GetWebHostingCertificateDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWebHostingCertificateDetailResponseBodyData Data { get; set; }
        public class GetWebHostingCertificateDetailResponseBodyData : TeaModel {
            [NameInMap("CertDomainName")]
            [Validation(Required=false)]
            public string CertDomainName { get; set; }
            [NameInMap("CertExpiredTime")]
            [Validation(Required=false)]
            public long? CertExpiredTime { get; set; }
            [NameInMap("CertLife")]
            [Validation(Required=false)]
            public string CertLife { get; set; }
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }
            [NameInMap("ServerCertificateStatus")]
            [Validation(Required=false)]
            public string ServerCertificateStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
