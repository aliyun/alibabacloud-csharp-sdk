// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListIpv4GatewaysResponseBody : TeaModel {
        [NameInMap("Ipv4GatewayModels")]
        [Validation(Required=false)]
        public List<ListIpv4GatewaysResponseBodyIpv4GatewayModels> Ipv4GatewayModels { get; set; }
        public class ListIpv4GatewaysResponseBodyIpv4GatewayModels : TeaModel {
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Ipv4GatewayDescription")]
            [Validation(Required=false)]
            public string Ipv4GatewayDescription { get; set; }

            [NameInMap("Ipv4GatewayId")]
            [Validation(Required=false)]
            public string Ipv4GatewayId { get; set; }

            [NameInMap("Ipv4GatewayName")]
            [Validation(Required=false)]
            public string Ipv4GatewayName { get; set; }

            [NameInMap("Ipv4GatewayRouteTableId")]
            [Validation(Required=false)]
            public string Ipv4GatewayRouteTableId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
