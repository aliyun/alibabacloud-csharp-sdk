// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainQPSListResponseBody : TeaModel {
        [NameInMap("DomainQPSList")]
        [Validation(Required=false)]
        public List<DescribeDomainQPSListResponseBodyDomainQPSList> DomainQPSList { get; set; }
        public class DescribeDomainQPSListResponseBodyDomainQPSList : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("MaxAttackQps")]
            [Validation(Required=false)]
            public long? MaxAttackQps { get; set; }

            [NameInMap("AttackQps")]
            [Validation(Required=false)]
            public long? AttackQps { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            [NameInMap("TotalQps")]
            [Validation(Required=false)]
            public long? TotalQps { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("CacheHits")]
            [Validation(Required=false)]
            public long? CacheHits { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
