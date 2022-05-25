// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointZonesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public List<ListVpcEndpointZonesResponseBodyZones> Zones { get; set; }
        public class ListVpcEndpointZonesResponseBodyZones : TeaModel {
            [NameInMap("EniId")]
            [Validation(Required=false)]
            public string EniId { get; set; }

            [NameInMap("EniIp")]
            [Validation(Required=false)]
            public string EniIp { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneDomain")]
            [Validation(Required=false)]
            public string ZoneDomain { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneStatus")]
            [Validation(Required=false)]
            public string ZoneStatus { get; set; }

        }

    }

}
