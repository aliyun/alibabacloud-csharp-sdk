// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnCertificateDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CertId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

    }

}
