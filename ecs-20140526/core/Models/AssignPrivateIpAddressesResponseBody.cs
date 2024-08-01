// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignPrivateIpAddressesResponseBody : TeaModel {
        /// <summary>
        /// Details about the ENI and the secondary private IP addresses that are assigned to the ENI.
        /// </summary>
        [NameInMap("AssignedPrivateIpAddressesSet")]
        [Validation(Required=false)]
        public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet AssignedPrivateIpAddressesSet { get; set; }
        public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet : TeaModel {
            /// <summary>
            /// Details about the assigned IPv4 prefixes.
            /// </summary>
            [NameInMap("Ipv4PrefixSet")]
            [Validation(Required=false)]
            public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSetIpv4PrefixSet Ipv4PrefixSet { get; set; }
            public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSetIpv4PrefixSet : TeaModel {
                [NameInMap("Ipv4Prefixes")]
                [Validation(Required=false)]
                public List<string> Ipv4Prefixes { get; set; }

            }

            /// <summary>
            /// The ENI ID.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The secondary private IP addresses that are assigned to the ENI.
            /// </summary>
            [NameInMap("PrivateIpSet")]
            [Validation(Required=false)]
            public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSetPrivateIpSet PrivateIpSet { get; set; }
            public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSetPrivateIpSet : TeaModel {
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public List<string> PrivateIpAddress { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
