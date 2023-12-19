// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnGatewayAvailableZonesResponseBody : TeaModel {
        [NameInMap("AvailableZoneIdList")]
        [Validation(Required=false)]
        public List<DescribeVpnGatewayAvailableZonesResponseBodyAvailableZoneIdList> AvailableZoneIdList { get; set; }
        public class DescribeVpnGatewayAvailableZonesResponseBodyAvailableZoneIdList : TeaModel {
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
