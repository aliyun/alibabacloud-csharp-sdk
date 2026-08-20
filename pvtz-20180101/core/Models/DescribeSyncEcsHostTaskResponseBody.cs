// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeSyncEcsHostTaskResponseBody : TeaModel {
        [NameInMap("EcsRegions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyEcsRegions EcsRegions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyEcsRegions : TeaModel {
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public List<DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion> EcsRegion { get; set; }
            public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion : TeaModel {
                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds RegionIds { get; set; }
                public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public List<string> RegionId { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

        }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyRegions Regions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyRegions : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<string> RegionId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the automatic hostname synchronization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ON: Enabled. The system reads the hostnames of ECS instances in the selected region and updates the DNS records every minute.</para>
        /// </description></item>
        /// <item><description><para>OFF: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>True</para>
        /// </description></item>
        /// <item><description><para>False</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pvtz-test-id-2989149d628c56****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
