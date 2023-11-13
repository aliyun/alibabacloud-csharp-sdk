// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainQpsWithCacheResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the attack QPS.
        /// </summary>
        [NameInMap("Blocks")]
        [Validation(Required=false)]
        public List<string> Blocks { get; set; }

        /// <summary>
        /// An array consisting of cache hit ratios.
        /// </summary>
        [NameInMap("CacheHits")]
        [Validation(Required=false)]
        public List<string> CacheHits { get; set; }

        /// <summary>
        /// An array consisting of the QPS that is blocked by the Frequency Control policy.
        /// </summary>
        [NameInMap("CcBlockQps")]
        [Validation(Required=false)]
        public List<string> CcBlockQps { get; set; }

        /// <summary>
        /// An array consisting of the QPS for which the Frequency Control policy triggers Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA).
        /// </summary>
        [NameInMap("CcJsQps")]
        [Validation(Required=false)]
        public List<string> CcJsQps { get; set; }

        /// <summary>
        /// The intervals between every two adjacent records. Unit: seconds.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// An array consisting of the QPS that is blocked by the blacklist for domain names.
        /// </summary>
        [NameInMap("IpBlockQps")]
        [Validation(Required=false)]
        public List<string> IpBlockQps { get; set; }

        /// <summary>
        /// An array consisting of the QPS that is blocked by the Accurate Access Control policy.
        /// </summary>
        [NameInMap("PreciseBlocks")]
        [Validation(Required=false)]
        public List<string> PreciseBlocks { get; set; }

        /// <summary>
        /// An array consisting of the QPS for which the Accurate Access Control policy triggers the JavaScript challenge.
        /// </summary>
        [NameInMap("PreciseJsQps")]
        [Validation(Required=false)]
        public List<string> PreciseJsQps { get; set; }

        /// <summary>
        /// An array consisting of the QPS that is blocked by the Location Blacklist policy.
        /// </summary>
        [NameInMap("RegionBlocks")]
        [Validation(Required=false)]
        public List<string> RegionBlocks { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// An array consisting of the total QPS.
        /// </summary>
        [NameInMap("Totals")]
        [Validation(Required=false)]
        public List<string> Totals { get; set; }

    }

}
