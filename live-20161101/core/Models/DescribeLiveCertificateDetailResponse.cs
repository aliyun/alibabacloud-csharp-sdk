// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCertificateDetailResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Cert")]
        [Validation(Required=true)]
        public string Cert { get; set; }

        [NameInMap("Key")]
        [Validation(Required=true)]
        public string Key { get; set; }

        [NameInMap("CertId")]
        [Validation(Required=true)]
        public long CertId { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=true)]
        public string CertName { get; set; }

    }

}
