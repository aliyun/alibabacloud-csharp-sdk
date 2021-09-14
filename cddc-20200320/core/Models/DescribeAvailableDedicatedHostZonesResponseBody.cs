// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeAvailableDedicatedHostZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeAvailableDedicatedHostZonesResponseBodyZones Zones { get; set; }
        public class DescribeAvailableDedicatedHostZonesResponseBodyZones : TeaModel {
            [NameInMap("DedicatedHostZones")]
            [Validation(Required=false)]
            public List<DescribeAvailableDedicatedHostZonesResponseBodyZonesDedicatedHostZones> DedicatedHostZones { get; set; }
            public class DescribeAvailableDedicatedHostZonesResponseBodyZonesDedicatedHostZones : TeaModel {
                public string ZoneId { get; set; }
                public string Description { get; set; }
            }
        };

    }

}
