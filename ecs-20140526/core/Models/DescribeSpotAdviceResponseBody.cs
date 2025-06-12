// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about spot instances in the zones of the specified region.</para>
        /// <remarks>
        /// <para> The return values are sorted based on the historical percentages of average spot instance prices relative to pay-as-you-go instance prices for instance types.</para>
        /// </remarks>
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
                /// <para>Details about spot instances in the previous 30 days, including the release rate of spot instances and percentages of average spot instance prices relative to pay-as-you-go instance prices.</para>
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
                        /// <para>The percentage of the average spot instance price relative to the pay-as-you-go instance price in the previous 30 days. Unit: %. Valid values: 1 to 100.</para>
                        /// <para>You can calculate the average spot instance price based on the return value. For example, if the pay-as-you-go instance price is 1 and the return value of this parameter is 20, the average spot instance price in the previous 30 days is 0.2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("AverageSpotDiscount")]
                        [Validation(Required=false)]
                        public int? AverageSpotDiscount { get; set; }

                        /// <summary>
                        /// <para>The instance type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.c5.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The release rate range of spot instances in the previous 30 days, which corresponds to the <c>InterruptionRate</c> value. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0-3%</description></item>
                        /// <item><description>3-5%</description></item>
                        /// <item><description>5-10%</description></item>
                        /// <item><description>10-100%</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0-3%</para>
                        /// </summary>
                        [NameInMap("InterruptRateDesc")]
                        [Validation(Required=false)]
                        public string InterruptRateDesc { get; set; }

                        /// <summary>
                        /// <para>The average release rate of spot instances in the previous 30 days. Unit: %.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("InterruptionRate")]
                        [Validation(Required=false)]
                        public float? InterruptionRate { get; set; }

                    }

                }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
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
