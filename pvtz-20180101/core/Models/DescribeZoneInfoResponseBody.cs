// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// The virtual private clouds (VPCs) bound to the zone.
        /// </summary>
        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public DescribeZoneInfoResponseBodyBindVpcs BindVpcs { get; set; }
        public class DescribeZoneInfoResponseBodyBindVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeZoneInfoResponseBodyBindVpcsVpc> Vpc { get; set; }
            public class DescribeZoneInfoResponseBodyBindVpcsVpc : TeaModel {
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

                /// <summary>
                /// The ID of the user to which the VPC belongs. The value null indicates that the VPC belongs to the current user.
                /// </summary>
                [NameInMap("VpcUserId")]
                [Validation(Required=false)]
                public long? VpcUserId { get; set; }

            }

        }

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
        /// The type of the operator.
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
        /// *   Indicates whether the zone is a reverse lookup zone. Valid values: true and false. The value true indicates that the zone is a reverse lookup zone.
        /// *   The value false indicates that the zone is not a reverse lookup zone.
        /// </summary>
        [NameInMap("IsPtr")]
        [Validation(Required=false)]
        public bool? IsPtr { get; set; }

        /// <summary>
        /// *   Indicates whether the recursive resolution proxy feature is enabled for the zone. Valid values: **ZONE**: The recursive resolution proxy feature is disabled for the zone.
        /// *   **RECORD**: The recursive resolution proxy feature is enabled for the zone.
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// The total number of DNS records.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Indicates whether the secondary Domain Name System (DNS) feature is enabled for the zone. Valid values:
        /// 
        /// *   **true**: The secondary DNS feature is enabled.
        /// *   **false**: The secondary DNS feature is disabled.
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

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
        /// The global ID of the zone.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The zone name.
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// *   If ZoneType is set to AUTH_ZONE, no value is returned for this parameter.
        /// *   If ZoneType is set to CLOUD_PRODUCT_ZONE, the type of the cloud service is returned.
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
