// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpsResponseBody : TeaModel {
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<ListNatIpsResponseBodyNatIps> NatIps { get; set; }
        public class ListNatIpsResponseBodyNatIps : TeaModel {
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            [NameInMap("NatIpDescription")]
            [Validation(Required=false)]
            public string NatIpDescription { get; set; }

            [NameInMap("NatIpId")]
            [Validation(Required=false)]
            public string NatIpId { get; set; }

            [NameInMap("NatIpName")]
            [Validation(Required=false)]
            public string NatIpName { get; set; }

            [NameInMap("NatIpStatus")]
            [Validation(Required=false)]
            public string NatIpStatus { get; set; }

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
