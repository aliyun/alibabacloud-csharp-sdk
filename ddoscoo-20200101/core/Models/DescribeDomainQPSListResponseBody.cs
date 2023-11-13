// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainQPSListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the statistics on the QPS of the website.
        /// </summary>
        [NameInMap("DomainQPSList")]
        [Validation(Required=false)]
        public List<DescribeDomainQPSListResponseBodyDomainQPSList> DomainQPSList { get; set; }
        public class DescribeDomainQPSListResponseBodyDomainQPSList : TeaModel {
            /// <summary>
            /// The attack QPS.
            /// </summary>
            [NameInMap("AttackQps")]
            [Validation(Required=false)]
            public long? AttackQps { get; set; }

            /// <summary>
            /// The number of cache hits.
            /// </summary>
            [NameInMap("CacheHits")]
            [Validation(Required=false)]
            public long? CacheHits { get; set; }

            /// <summary>
            /// The index number of the returned data.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// The peak attack QPS.
            /// </summary>
            [NameInMap("MaxAttackQps")]
            [Validation(Required=false)]
            public long? MaxAttackQps { get; set; }

            /// <summary>
            /// The peak of normal QPS.
            /// </summary>
            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            /// <summary>
            /// The peak of total QPS.
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// The time when the data was collected. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// The total QPS.
            /// </summary>
            [NameInMap("TotalQps")]
            [Validation(Required=false)]
            public long? TotalQps { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
