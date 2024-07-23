// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignPrivateIpAddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the ENI and the secondary private IP addresses that are assigned to the ENI.</para>
        /// </summary>
        [NameInMap("AssignedPrivateIpAddressesSet")]
        [Validation(Required=false)]
        public AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet AssignedPrivateIpAddressesSet { get; set; }
        public class AssignPrivateIpAddressesResponseBodyAssignedPrivateIpAddressesSet : TeaModel {
            /// <summary>
            /// <para>Details about the assigned IPv4 prefixes.</para>
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
            /// <para>The ENI ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp125p95hhdhn3ot****</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The secondary private IP addresses that are assigned to the ENI.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
