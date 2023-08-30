// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("KVStoreZone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesKVStoreZone> KVStoreZone { get; set; }
            public class DescribeZonesResponseBodyZonesKVStoreZone : TeaModel {
                /// <summary>
                /// Indicates whether ApsaraDB for Redis instances can be created in the current zone. Valid values:
                /// 
                /// *   **true**: ApsaraDB for Redis instances cannot be created in the current zone.
                /// *   **false**: ApsaraDB for Redis instances can be created in the current zone.
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// Indicates whether the zone is managed by ApsaraDB RDS. The return value of this parameter is **true** in ApsaraDB for Redis.
                /// </summary>
                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Indicates whether the network type of the instance can be changed from the classic network to Virtual Private Cloud (VPC). Valid values:
                /// 
                /// *   **true**: The network type of the instance can be changed from the classic network to VPC.
                /// *   **false**: The network type of the instance cannot be changed from the classic network to VPC.
                /// </summary>
                [NameInMap("SwitchNetwork")]
                [Validation(Required=false)]
                public bool? SwitchNetwork { get; set; }

                /// <summary>
                /// The ID of the zone within the specified region.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The name of the zone within the specified region.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
