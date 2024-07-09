// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneVpcTreeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZoneVpcTreeResponseBodyZones Zones { get; set; }
        public class DescribeZoneVpcTreeResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZoneVpcTreeResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZoneVpcTreeResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// The time when the zone was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the zone was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The creator of the zone.
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// The operator type.
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                /// <summary>
                /// The logical location of the built-in authoritative module in which the zone is added. Valid values:
                /// 
                /// *   NORMAL_ZONE: regular module
                /// *   FAST_ZONE: acceleration module
                /// </summary>
                [NameInMap("DnsGroup")]
                [Validation(Required=false)]
                public string DnsGroup { get; set; }

                /// <summary>
                /// Indicates whether the zone is being removed to another logical location. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("DnsGroupChanging")]
                [Validation(Required=false)]
                public bool? DnsGroupChanging { get; set; }

                /// <summary>
                /// Indicates whether the zone is a reverse lookup zone. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                /// <summary>
                /// The number of Domain Name System (DNS) records.
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                /// <summary>
                /// The description of the zone.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The time when the zone was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The time when the zone was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// The VPCs bound to the zones.
                /// </summary>
                [NameInMap("Vpcs")]
                [Validation(Required=false)]
                public DescribeZoneVpcTreeResponseBodyZonesZoneVpcs Vpcs { get; set; }
                public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcs : TeaModel {
                    [NameInMap("Vpc")]
                    [Validation(Required=false)]
                    public List<DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc> Vpc { get; set; }
                    public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc : TeaModel {
                        /// <summary>
                        /// The region ID.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The name of the region.
                        /// </summary>
                        [NameInMap("RegionName")]
                        [Validation(Required=false)]
                        public string RegionName { get; set; }

                        /// <summary>
                        /// The VPC ID.
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// The name of the VPC.
                        /// </summary>
                        [NameInMap("VpcName")]
                        [Validation(Required=false)]
                        public string VpcName { get; set; }

                        /// <summary>
                        /// The type of the VPC. Valid values:
                        /// 
                        /// *   STANDARD: standard VPC
                        /// *   EDS: Elastic Desktop Service (EDS) workspace VPC
                        /// </summary>
                        [NameInMap("VpcType")]
                        [Validation(Required=false)]
                        public string VpcType { get; set; }

                    }

                }

                /// <summary>
                /// The global ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The name of the zone.
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

                /// <summary>
                /// The type of the cloud service.
                /// 
                /// *   If the value of the ZoneType parameter is AUTH_ZONE, no value is returned for this parameter.
                /// *   If the value of the ZoneType parameter is CLOUD_PRODUCT_ZONE, the type of the cloud service is returned.
                /// </summary>
                [NameInMap("ZoneTag")]
                [Validation(Required=false)]
                public string ZoneTag { get; set; }

                /// <summary>
                /// The type of the zone. Valid values:
                /// 
                /// *   AUTH_ZONE: authoritative zone
                /// *   CLOUD_PRODUCT_ZONE: authoritative zone for cloud services
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
