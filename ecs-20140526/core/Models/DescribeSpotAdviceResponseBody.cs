// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceResponseBody : TeaModel {
        [NameInMap("AvailableSpotZones")]
        [Validation(Required=false)]
        public DescribeSpotAdviceResponseBodyAvailableSpotZones AvailableSpotZones { get; set; }
        public class DescribeSpotAdviceResponseBodyAvailableSpotZones : TeaModel {
            [NameInMap("AvailableSpotZone")]
            [Validation(Required=false)]
            public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone> AvailableSpotZone { get; set; }
            public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZone : TeaModel {
                [NameInMap("AvailableSpotResources")]
                [Validation(Required=false)]
                public DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources AvailableSpotResources { get; set; }
                public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResources : TeaModel {
                    [NameInMap("AvailableSpotResource")]
                    [Validation(Required=false)]
                    public List<DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource> AvailableSpotResource { get; set; }
                    public class DescribeSpotAdviceResponseBodyAvailableSpotZonesAvailableSpotZoneAvailableSpotResourcesAvailableSpotResource : TeaModel {
                        [NameInMap("AverageSpotDiscount")]
                        [Validation(Required=false)]
                        public int? AverageSpotDiscount { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("InterruptRateDesc")]
                        [Validation(Required=false)]
                        public string InterruptRateDesc { get; set; }

                        [NameInMap("InterruptionRate")]
                        [Validation(Required=false)]
                        public float? InterruptionRate { get; set; }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
