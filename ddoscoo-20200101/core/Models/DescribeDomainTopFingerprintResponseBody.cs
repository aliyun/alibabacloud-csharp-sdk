// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainTopFingerprintResponseBody : TeaModel {
        [NameInMap("DomainTopFp")]
        [Validation(Required=false)]
        public List<DescribeDomainTopFingerprintResponseBodyDomainTopFp> DomainTopFp { get; set; }
        public class DescribeDomainTopFingerprintResponseBodyDomainTopFp : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Fingerprinting")]
            [Validation(Required=false)]
            public string Fingerprinting { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
