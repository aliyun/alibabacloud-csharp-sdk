// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceResponseBody : TeaModel {
        /// <summary>
        /// Details about preemptible instances in the zones of the specified region.
        /// 
        /// > The return values are sorted based on the historical percentages of average prices of preemptible instances of the specified instance type relative to pay-as-you-go instance prices.
        /// </summary>
        [NameInMap("AvailableSpotZones")]
        [Validation(Required=false)]
        public DescribeSpotAdviceResponseBodyAvailableSpotZones AvailableSpotZones { get; set; }
        public class DescribeSpotAdviceResponseBodyAvailableSpotZones : TeaModel {
            [NameInMap("AvailableSpotZone")]
            [Validation(Required=false)]
            public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone> AvailableSpotZone { get; set; }
            public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone : TeaModel {
                /// <summary>
                /// Details about preemptible instances in the last 30 days, including the release rate of preemptible instances and percentages of average prices of preemptible instances relative to pay-as-you-go instance prices.
                /// </summary>
                [NameInMap("AvailableSpotResources")]
                [Validation(Required=false)]
                public DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources AvailableSpotResources { get; set; }
                public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources : TeaModel {
                    [NameInMap("AvailableSpotResource")]
                    [Validation(Required=false)]
                    public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource> AvailableSpotResource { get; set; }
                    public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource : TeaModel {
                        /// <summary>
                        /// The percentage of the average preemptible instance price relative to the pay-as-you-go instance price in the last 30 days. Unit: %. Valid values: 1 to 100.
                        /// 
                        /// You can calculate the average preemptible instance price based on the return value. For example, if the pay-as-you-go instance price is 1 and the return value of this parameter is 20, the average preemptible instance price in the last 30 days is 0.2.
                        /// </summary>
                        [NameInMap("AverageSpotDiscount")]
                        [Validation(Required=false)]
                        public int? AverageSpotDiscount { get; set; }

                        /// <summary>
                        /// The instance type.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The release rate range of preemptible instances in the last 30 days, which corresponds to the value of the `InterruptionRate` parameter. Valid values:
                        /// 
                        /// *   0-3%
                        /// *   3-5%
                        /// *   5-10%
                        /// *   10-100%
                        /// </summary>
                        [NameInMap("InterruptRateDesc")]
                        [Validation(Required=false)]
                        public string InterruptRateDesc { get; set; }

                        /// <summary>
                        /// The average release rate of preemptible instances in the last 30 days. Unit: %.
                        /// </summary>
                        [NameInMap("InterruptionRate")]
                        [Validation(Required=false)]
                        public float? InterruptionRate { get; set; }

                    }

                }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
