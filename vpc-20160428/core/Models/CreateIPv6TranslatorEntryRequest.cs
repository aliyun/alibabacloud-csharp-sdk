// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIPv6TranslatorEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the associated ACL.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// Specifies whether to enable access control lists (ACLs). Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// Specifies whether to enable ACLs. Valid values:
        /// 
        /// *   **white**: a whitelist. IPv6 addresses in the ACL are allowed to access backend services.
        /// *   **black**: a blacklist. IPv6 addresses in the ACL are not allowed to access backend services.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The port that is used by the IPv6 address allocated to the IPv6 Translation Service instance.
        /// </summary>
        [NameInMap("AllocateIpv6Port")]
        [Validation(Required=false)]
        public int? AllocateIpv6Port { get; set; }

        /// <summary>
        /// The public IPv4 address that needs to provide IPv6 services.
        /// </summary>
        [NameInMap("BackendIpv4Addr")]
        [Validation(Required=false)]
        public string BackendIpv4Addr { get; set; }

        /// <summary>
        /// The port of the public IPv4 address that needs to provide IPv6 services.
        /// </summary>
        [NameInMap("BackendIpv4Port")]
        [Validation(Required=false)]
        public int? BackendIpv4Port { get; set; }

        /// <summary>
        /// The maximum bandwidth specified in the IPv6 mapping entry. Valid values:
        /// 
        /// *   \-1 (default): does not limit the maximum bandwidth specified in the IPv6 mapping entry.
        /// *   1 to 200: the bandwidth value specified in the IPv6 mapping entry. Unit: Mbit/s.
        /// 
        /// > The sum of the maximum bandwidth values specified in all IPv6 entries cannot exceed the maximum bandwidth supported by the instance.
        /// </summary>
        [NameInMap("EntryBandwidth")]
        [Validation(Required=false)]
        public int? EntryBandwidth { get; set; }

        /// <summary>
        /// The description of the IPv6 mapping entry.
        /// </summary>
        [NameInMap("EntryDescription")]
        [Validation(Required=false)]
        public string EntryDescription { get; set; }

        /// <summary>
        /// The name of the IPv6 mapping entry. It must be 2 to 100 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter. It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("EntryName")]
        [Validation(Required=false)]
        public string EntryName { get; set; }

        /// <summary>
        /// The ID of the IPv6 Translation Service instance.
        /// </summary>
        [NameInMap("Ipv6TranslatorId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region of the IPv6 Translation Service instance. You can call the **DescribeRegions** operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// </summary>
        [NameInMap("TransProtocol")]
        [Validation(Required=false)]
        public string TransProtocol { get; set; }

    }

}
