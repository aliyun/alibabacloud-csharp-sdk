// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcRtBandWidthUsageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcRtBandWidthUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcRtBandWidthUsageResponseBodyData : TeaModel {
            [NameInMap("AnchorPeakRate")]
            [Validation(Required=false)]
            public float? AnchorPeakRate { get; set; }

            [NameInMap("AnchorPeakTs")]
            [Validation(Required=false)]
            public long? AnchorPeakTs { get; set; }

            [NameInMap("AudiencePeakRate")]
            [Validation(Required=false)]
            public float? AudiencePeakRate { get; set; }

            [NameInMap("AudiencePeakTs")]
            [Validation(Required=false)]
            public long? AudiencePeakTs { get; set; }

            [NameInMap("PeakRate")]
            [Validation(Required=false)]
            public float? PeakRate { get; set; }

            [NameInMap("PeakTs")]
            [Validation(Required=false)]
            public long? PeakTs { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
