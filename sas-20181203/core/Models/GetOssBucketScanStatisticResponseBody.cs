// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssBucketScanStatisticResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssBucketScanStatisticResponseBodyData Data { get; set; }
        public class GetOssBucketScanStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// The expiration time of the purchased quota.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The number of high-risk objects.
            /// </summary>
            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            /// <summary>
            /// The number of low-risk objects.
            /// </summary>
            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            /// <summary>
            /// The number of medium-risk objects.
            /// </summary>
            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            /// <summary>
            /// The number of buckets that are not checked.
            /// </summary>
            [NameInMap("NoScanBucket")]
            [Validation(Required=false)]
            public int? NoScanBucket { get; set; }

            /// <summary>
            /// The remaining quota.
            /// </summary>
            [NameInMap("RemainAuth")]
            [Validation(Required=false)]
            public int? RemainAuth { get; set; }

            /// <summary>
            /// The number of buckets in which at-risk objects exist.
            /// </summary>
            [NameInMap("RiskBucket")]
            [Validation(Required=false)]
            public int? RiskBucket { get; set; }

            /// <summary>
            /// The number of objects that are checked.
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// The total number of buckets.
            /// </summary>
            [NameInMap("TotalBucket")]
            [Validation(Required=false)]
            public int? TotalBucket { get; set; }

            /// <summary>
            /// The total number of objects in the bucket.
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
