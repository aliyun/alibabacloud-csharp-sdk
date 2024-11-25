// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeSyncEcsHostTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The synchronized regions where the ECS instances are deployed.</para>
        /// </summary>
        [NameInMap("EcsRegions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyEcsRegions EcsRegions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyEcsRegions : TeaModel {
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public List<DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion> EcsRegion { get; set; }
            public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegion : TeaModel {
                /// <summary>
                /// <para>The synchronized region IDs.</para>
                /// </summary>
                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds RegionIds { get; set; }
                public class DescribeSyncEcsHostTaskResponseBodyEcsRegionsEcsRegionRegionIds : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public List<string> RegionId { get; set; }

                }

                /// <summary>
                /// <para>The user ID to which the region belongs. This parameter is used in cross-account synchronization scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The synchronized region IDs of the ECS instances.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeSyncEcsHostTaskResponseBodyRegions Regions { get; set; }
        public class DescribeSyncEcsHostTaskResponseBodyRegions : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<string> RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether hostname automatic synchronization is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ON: Hostname automatic synchronization is enabled. After this feature is enabled, the system automatically reads the hostnames of the Elastic Compute Service (ECS) instances in the specified regions and updates Domain Name System (DNS) records at an interval of 1 minute.</description></item>
        /// <item><description>OFF: Hostname automatic synchronization is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the task was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True</description></item>
        /// <item><description>False</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The zone ID. This ID uniquely identifies the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pvtz-test-id-2989149d628c56****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
