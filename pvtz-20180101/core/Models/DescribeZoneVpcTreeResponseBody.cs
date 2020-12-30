// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneVpcTreeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZoneVpcTreeResponseBodyZones Zones { get; set; }
        public class DescribeZoneVpcTreeResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZoneVpcTreeResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZoneVpcTreeResponseBodyZonesZone : TeaModel {
                public string UpdateTime { get; set; }
                public string ZoneType { get; set; }
                public string Remark { get; set; }
                public string CreateTime { get; set; }
                public DescribeZoneVpcTreeResponseBodyZonesZoneVpcs Vpcs { get; set; }
                public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcs : TeaModel {
                    [NameInMap("Vpc")]
                    [Validation(Required=false)]
                    public List<DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc> Vpc { get; set; }
                    public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc : TeaModel {
                        [NameInMap("VpcName")]
                        [Validation(Required=false)]
                        public string VpcName { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("RegionName")]
                        [Validation(Required=false)]
                        public string RegionName { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                }
                public int? RecordCount { get; set; }
                public string ZoneName { get; set; }
                public long? UpdateTimestamp { get; set; }
                public string ZoneId { get; set; }
                public string ZoneTag { get; set; }
                public bool? IsPtr { get; set; }
                public long? CreateTimestamp { get; set; }
            }
        };

    }

}
