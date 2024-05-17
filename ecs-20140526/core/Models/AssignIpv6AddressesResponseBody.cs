// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignIpv6AddressesResponseBody : TeaModel {
        /// <summary>
        /// The IPv6 prefixes of the ENI.
        /// </summary>
        [NameInMap("Ipv6PrefixSets")]
        [Validation(Required=false)]
        public AssignIpv6AddressesResponseBodyIpv6PrefixSets Ipv6PrefixSets { get; set; }
        public class AssignIpv6AddressesResponseBodyIpv6PrefixSets : TeaModel {
            [NameInMap("Ipv6Prefix")]
            [Validation(Required=false)]
            public List<string> Ipv6Prefix { get; set; }

        }

        /// <summary>
        /// The IPv6 addresses assigned to the ENI.
        /// </summary>
        [NameInMap("Ipv6Sets")]
        [Validation(Required=false)]
        public AssignIpv6AddressesResponseBodyIpv6Sets Ipv6Sets { get; set; }
        public class AssignIpv6AddressesResponseBodyIpv6Sets : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<string> Ipv6Address { get; set; }

        }

        /// <summary>
        /// The ENI ID.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
