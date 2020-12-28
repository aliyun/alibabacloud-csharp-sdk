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
        public List<DescribeBandwidthLimitationResponseBodyBandwidths> Bandwidths { get; set; }
        public class DescribeBandwidthLimitationResponseBodyBandwidths : TeaModel {
            [NameInMap("Max")]
            [Validation(Required=false)]
            public int? Max { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("Min")]
            [Validation(Required=false)]
            public int? Min { get; set; }

        }

    }

}
