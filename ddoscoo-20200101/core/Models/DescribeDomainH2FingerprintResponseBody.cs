// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainH2FingerprintResponseBody : TeaModel {
        [NameInMap("DomainH2Fp")]
        [Validation(Required=false)]
        public List<DescribeDomainH2FingerprintResponseBodyDomainH2Fp> DomainH2Fp { get; set; }
        public class DescribeDomainH2FingerprintResponseBodyDomainH2Fp : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("H2Fingerprint")]
            [Validation(Required=false)]
            public string H2Fingerprint { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
