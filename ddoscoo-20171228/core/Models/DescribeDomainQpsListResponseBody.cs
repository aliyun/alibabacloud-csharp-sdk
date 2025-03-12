// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainQpsListResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeDomainQpsListResponseBodyDataList> DataList { get; set; }
        public class DescribeDomainQpsListResponseBodyDataList : TeaModel {
            [NameInMap("AttackQps")]
            [Validation(Required=false)]
            public long? AttackQps { get; set; }

            [NameInMap("CacheHits")]
            [Validation(Required=false)]
            public long? CacheHits { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("MaxAttackQps")]
            [Validation(Required=false)]
            public long? MaxAttackQps { get; set; }

            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("TotalQps")]
            [Validation(Required=false)]
            public long? TotalQps { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
