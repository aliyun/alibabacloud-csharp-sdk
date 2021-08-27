// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Bandwidths")]
        [Validation(Required=false)]
        public DescribeBandwidthLimitationResponseBodyBandwidths Bandwidths { get; set; }
        public class DescribeBandwidthLimitationResponseBodyBandwidths : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public List<DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth> Bandwidth { get; set; }
            public class DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth : TeaModel {
                public string InternetChargeType { get; set; }
                public int? Max { get; set; }
                public int? Min { get; set; }
                public string Unit { get; set; }
            }
        };

    }

}
