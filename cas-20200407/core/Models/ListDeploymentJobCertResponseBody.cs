// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobCertResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobCertResponseBodyData> Data { get; set; }
        public class ListDeploymentJobCertResponseBodyData : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            [NameInMap("CertInstanceId")]
            [Validation(Required=false)]
            public string CertInstanceId { get; set; }

            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            [NameInMap("CertOrderType")]
            [Validation(Required=false)]
            public string CertOrderType { get; set; }

            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            [NameInMap("IsTrustee")]
            [Validation(Required=false)]
            public bool? IsTrustee { get; set; }

            [NameInMap("Month")]
            [Validation(Required=false)]
            public int? Month { get; set; }

            [NameInMap("NotAfterTime")]
            [Validation(Required=false)]
            public long? NotAfterTime { get; set; }

            [NameInMap("NotBeforeTime")]
            [Validation(Required=false)]
            public long? NotBeforeTime { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
