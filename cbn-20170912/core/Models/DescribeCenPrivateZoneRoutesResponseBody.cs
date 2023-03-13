// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenPrivateZoneRoutesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IP address of the DNS server used by PrivateZone.
        /// </summary>
        [NameInMap("PrivateZoneDnsServers")]
        [Validation(Required=false)]
        public string PrivateZoneDnsServers { get; set; }

        /// <summary>
        /// The configuration details of PrivateZone.
        /// </summary>
        [NameInMap("PrivateZoneInfos")]
        [Validation(Required=false)]
        public DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos PrivateZoneInfos { get; set; }
        public class DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos : TeaModel {
            [NameInMap("PrivateZoneInfo")]
            [Validation(Required=false)]
            public List<DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfosPrivateZoneInfo> PrivateZoneInfo { get; set; }
            public class DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfosPrivateZoneInfo : TeaModel {
                /// <summary>
                /// The ID of the region where PrivateZone is accessed.
                /// </summary>
                [NameInMap("AccessRegionId")]
                [Validation(Required=false)]
                public string AccessRegionId { get; set; }

                /// <summary>
                /// The ID of the region where PrivateZone is deployed.
                /// </summary>
                [NameInMap("HostRegionId")]
                [Validation(Required=false)]
                public string HostRegionId { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) that is associated with PrivateZone.
                /// </summary>
                [NameInMap("HostVpcId")]
                [Validation(Required=false)]
                public string HostVpcId { get; set; }

                /// <summary>
                /// The status of PrivateZone. Valid values:
                /// 
                /// *   **Creating**: being created
                /// *   **Active**: available
                /// *   **Deleting**: being deleted
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
