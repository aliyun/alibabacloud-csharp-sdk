// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainQpsWithCacheResponseBody : TeaModel {
        [NameInMap("Blocks")]
        [Validation(Required=false)]
        public List<string> Blocks { get; set; }

        [NameInMap("CacheHits")]
        [Validation(Required=false)]
        public List<string> CacheHits { get; set; }

        [NameInMap("CcBlockQps")]
        [Validation(Required=false)]
        public List<string> CcBlockQps { get; set; }

        [NameInMap("CcJsQps")]
        [Validation(Required=false)]
        public List<string> CcJsQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("IpBlockQps")]
        [Validation(Required=false)]
        public List<string> IpBlockQps { get; set; }

        [NameInMap("PreciseBlocks")]
        [Validation(Required=false)]
        public List<string> PreciseBlocks { get; set; }

        [NameInMap("PreciseJsQps")]
        [Validation(Required=false)]
        public List<string> PreciseJsQps { get; set; }

        [NameInMap("RegionBlocks")]
        [Validation(Required=false)]
        public List<string> RegionBlocks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1577794500</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Totals")]
        [Validation(Required=false)]
        public List<string> Totals { get; set; }

    }

}
