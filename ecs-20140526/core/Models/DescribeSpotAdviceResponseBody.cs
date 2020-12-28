// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableSpotZones")]
        [Validation(Required=false)]
        public List<DescribeSpotAdviceResponseBodyAvailableSpotZones> AvailableSpotZones { get; set; }
        public class DescribeSpotAdviceResponseBodyAvailableSpotZones : TeaModel {
            [NameInMap("AvailableSpotResources")]
            [Validation(Required=false)]
            public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotResources> AvailableSpotResources { get; set; }
            public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotResources : TeaModel {
                [NameInMap("InterruptRateDesc")]
                [Validation(Required=false)]
                public string InterruptRateDesc { get; set; }

                [NameInMap("AverageSpotDiscount")]
                [Validation(Required=false)]
                public int? AverageSpotDiscount { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InterruptionRate")]
                [Validation(Required=false)]
                public float? InterruptionRate { get; set; }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
