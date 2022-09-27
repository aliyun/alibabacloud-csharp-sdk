// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignIpv6AddressesResponseBody : TeaModel {
        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public AssignIpv6AddressesResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class AssignIpv6AddressesResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

        }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
