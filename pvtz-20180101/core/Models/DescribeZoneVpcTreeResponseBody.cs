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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("Vpcs")]
                [Validation(Required=false)]
                public DescribeZoneVpcTreeResponseBodyZonesZoneVpcs Vpcs { get; set; }
                public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcs : TeaModel {
                    [NameInMap("Vpc")]
                    [Validation(Required=false)]
                    public List<DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc> Vpc { get; set; }
                    public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc : TeaModel {
                        /// <summary>
                        /// region Id
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("RegionName")]
                        [Validation(Required=false)]
                        public string RegionName { get; set; }

                        /// <summary>
                        /// vpc id
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        [NameInMap("VpcName")]
                        [Validation(Required=false)]
                        public string VpcName { get; set; }

                        [NameInMap("VpcType")]
                        [Validation(Required=false)]
                        public string VpcType { get; set; }

                    }

                }

                /// <summary>
                /// Zone id
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

                [NameInMap("ZoneTag")]
                [Validation(Required=false)]
                public string ZoneTag { get; set; }

                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
