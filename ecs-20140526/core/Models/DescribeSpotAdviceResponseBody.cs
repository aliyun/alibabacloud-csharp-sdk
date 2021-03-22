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
        public DescribeSpotAdviceResponseBodyAvailableSpotZones AvailableSpotZones { get; set; }
        public class DescribeSpotAdviceResponseBodyAvailableSpotZones : TeaModel {
            [NameInMap("AvailableSpotZone")]
            [Validation(Required=false)]
            public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone> AvailableSpotZone { get; set; }
            public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone : TeaModel {
                public DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources AvailableSpotResources { get; set; }
                public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources : TeaModel {
                    [NameInMap("AvailableSpotResource")]
                    [Validation(Required=false)]
                    public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource> AvailableSpotResource { get; set; }
                    public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource : TeaModel {
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

                }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
