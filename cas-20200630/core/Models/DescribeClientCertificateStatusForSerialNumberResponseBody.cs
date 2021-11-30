// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusForSerialNumberResponseBody : TeaModel {
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public List<DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus> CertificateStatus { get; set; }
        public class DescribeClientCertificateStatusForSerialNumberResponseBodyCertificateStatus : TeaModel {
            [NameInMap("RevokeTime")]
            [Validation(Required=false)]
            public long? RevokeTime { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
