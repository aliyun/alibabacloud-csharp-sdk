// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// The zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
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
                /// The type of the user account.
                /// 
                /// *   **CUSTOMER**: Alibaba Cloud account
                /// *   **SUB**: RAM user
                /// *   **STS**: assumed role that obtains the Security Token Service (STS) token of a RAM role
                /// *   **OTHER**: other types
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// The logical location type of the built-in authoritative module in which the zone is added. Valid values:
                /// 
                /// *   **NORMAL_ZONE**: regular module
                /// *   **FAST_ZONE**: acceleration module
                /// </summary>
                [NameInMap("DnsGroup")]
                [Validation(Required=false)]
                public string DnsGroup { get; set; }

                /// <summary>
                /// Indicates whether the zone is being removed to another logical location. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("DnsGroupChanging")]
                [Validation(Required=false)]
                public bool? DnsGroupChanging { get; set; }

                /// <summary>
                /// Indicates whether the zone is a reverse lookup zone. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                /// <summary>
                /// Indicates whether the recursive resolution proxy feature is enabled for the zone. Valid values:
                /// 
                /// *   **ZONE**: The recursive resolution proxy feature is disabled for the zone.
                /// *   **RECORD**: The recursive resolution proxy feature is enabled for the zone.
                /// </summary>
                [NameInMap("ProxyPattern")]
                [Validation(Required=false)]
                public string ProxyPattern { get; set; }

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
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The tags added to the resources.
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneResourceTags ResourceTags { get; set; }
                public class DescribeZonesResponseBodyZonesZoneResourceTags : TeaModel {
                    [NameInMap("ResourceTag")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag> ResourceTag { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag : TeaModel {
                        /// <summary>
                        /// The key of tag N added to the zone.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N added to the zone.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The time when the zone was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// The time when the DNS record was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// The zone ID.
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
                /// The type of the cloud service. Valid values:
                /// 
                /// *   If ZoneType is set to AUTH_ZONE, no value is returned for this parameter.
                /// *   If ZoneType is set to CLOUD_PRODUCT_ZONE, the type of the cloud service is returned.
                /// </summary>
                [NameInMap("ZoneTag")]
                [Validation(Required=false)]
                public string ZoneTag { get; set; }

                /// <summary>
                /// The type of zones. Valid values:
                /// 
                /// *   **AUTH_ZONE**: authoritative zone
                /// *   **CLOUD_PRODUCT_ZONE**: authoritative zone for cloud services
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
