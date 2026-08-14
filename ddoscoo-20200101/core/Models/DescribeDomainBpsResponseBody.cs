// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainBpsResponseBody : TeaModel {
        [NameInMap("DomainBps")]
        [Validation(Required=false)]
        public List<DescribeDomainBpsResponseBodyDomainBps> DomainBps { get; set; }
        public class DescribeDomainBpsResponseBodyDomainBps : TeaModel {
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
