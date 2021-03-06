// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenPrivateZoneRoutesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrivateZoneInfos")]
        [Validation(Required=false)]
        public List<DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos> PrivateZoneInfos { get; set; }
        public class DescribeCenPrivateZoneRoutesResponseBodyPrivateZoneInfos : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("HostVpcId")]
            [Validation(Required=false)]
            public string HostVpcId { get; set; }

            [NameInMap("AccessRegionId")]
            [Validation(Required=false)]
            public string AccessRegionId { get; set; }

            [NameInMap("HostRegionId")]
            [Validation(Required=false)]
            public string HostRegionId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("PrivateZoneDnsServers")]
        [Validation(Required=false)]
        public string PrivateZoneDnsServers { get; set; }

    }

}
