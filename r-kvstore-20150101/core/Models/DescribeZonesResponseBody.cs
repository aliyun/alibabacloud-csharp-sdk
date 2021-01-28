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

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("KVStoreZone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesKVStoreZone> KVStoreZone { get; set; }
            public class DescribeZonesResponseBodyZonesKVStoreZone : TeaModel {
                public bool? IsRds { get; set; }
                public string ZoneId { get; set; }
                public bool? Disabled { get; set; }
                public bool? SwitchNetwork { get; set; }
                public string ZoneName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
