// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOssBucketScanStatisticResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssBucketScanStatisticResponseBodyData Data { get; set; }
        public class GetOssBucketScanStatisticResponseBodyData : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            [NameInMap("NoScanBucket")]
            [Validation(Required=false)]
            public int? NoScanBucket { get; set; }

            [NameInMap("RemainAuth")]
            [Validation(Required=false)]
            public int? RemainAuth { get; set; }

            [NameInMap("RiskBucket")]
            [Validation(Required=false)]
            public int? RiskBucket { get; set; }

            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            [NameInMap("TotalBucket")]
            [Validation(Required=false)]
            public int? TotalBucket { get; set; }

            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
