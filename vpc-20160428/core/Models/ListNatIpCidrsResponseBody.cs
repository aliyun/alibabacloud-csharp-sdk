// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpCidrsResponseBody : TeaModel {
        [NameInMap("NatIpCidrs")]
        [Validation(Required=false)]
        public List<ListNatIpCidrsResponseBodyNatIpCidrs> NatIpCidrs { get; set; }
        public class ListNatIpCidrsResponseBodyNatIpCidrs : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            [NameInMap("NatIpCidrDescription")]
            [Validation(Required=false)]
            public string NatIpCidrDescription { get; set; }

            [NameInMap("NatIpCidrId")]
            [Validation(Required=false)]
            public string NatIpCidrId { get; set; }

            [NameInMap("NatIpCidrName")]
            [Validation(Required=false)]
            public string NatIpCidrName { get; set; }

            [NameInMap("NatIpCidrStatus")]
            [Validation(Required=false)]
            public string NatIpCidrStatus { get; set; }

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
