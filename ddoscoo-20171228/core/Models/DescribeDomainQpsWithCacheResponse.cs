// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainQpsWithCacheResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=true)]
        public int? Interval { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long StartTime { get; set; }

        [NameInMap("Totals")]
        [Validation(Required=true)]
        public List<string> Totals { get; set; }

        [NameInMap("Blocks")]
        [Validation(Required=true)]
        public List<string> Blocks { get; set; }

        [NameInMap("CacheHits")]
        [Validation(Required=true)]
        public List<string> CacheHits { get; set; }

        [NameInMap("PreciseBlocks")]
        [Validation(Required=true)]
        public List<string> PreciseBlocks { get; set; }

        [NameInMap("RegionBlocks")]
        [Validation(Required=true)]
        public List<string> RegionBlocks { get; set; }

        [NameInMap("IpBlockQps")]
        [Validation(Required=true)]
        public List<string> IpBlockQps { get; set; }

        [NameInMap("CcJsQps")]
        [Validation(Required=true)]
        public List<string> CcJsQps { get; set; }

        [NameInMap("PreciseJsQps")]
        [Validation(Required=true)]
        public List<string> PreciseJsQps { get; set; }

        [NameInMap("CcBlockQps")]
        [Validation(Required=true)]
        public List<string> CcBlockQps { get; set; }

    }

}
