// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainQpsWithCacheResponseBody : TeaModel {
        [NameInMap("IpBlockQps")]
        [Validation(Required=false)]
        public List<string> IpBlockQps { get; set; }

        [NameInMap("CcJsQps")]
        [Validation(Required=false)]
        public List<string> CcJsQps { get; set; }

        [NameInMap("Blocks")]
        [Validation(Required=false)]
        public List<string> Blocks { get; set; }

        [NameInMap("PreciseBlocks")]
        [Validation(Required=false)]
        public List<string> PreciseBlocks { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PreciseJsQps")]
        [Validation(Required=false)]
        public List<string> PreciseJsQps { get; set; }

        [NameInMap("Totals")]
        [Validation(Required=false)]
        public List<string> Totals { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("CcBlockQps")]
        [Validation(Required=false)]
        public List<string> CcBlockQps { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("RegionBlocks")]
        [Validation(Required=false)]
        public List<string> RegionBlocks { get; set; }

        [NameInMap("CacheHits")]
        [Validation(Required=false)]
        public List<string> CacheHits { get; set; }

    }

}
