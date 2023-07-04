// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateBgpGroupRequest : TeaModel {
        /// <summary>
        /// The authentication key of the BGP group.
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the BGP group.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The IP version. Valid values:
        /// 
        /// *   **IPv4**: This is the default value.
        /// *   **IPv6**: IPv6 is supported only if the VBR for which you want to create the BGP group has IPv6 enabled.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// Specifies whether to use a fake ASN. Valid values:
        /// 
        /// *   **false** (default): no
        /// *   **true**: yes
        /// 
        /// >  In most cases, a router that runs BGP belongs to only one AS. If you want to use a different ASN to communicate with the peer but you cannot modify the BGP configuration because it may cause service downtime, you can use a fake ASN. For example, you can use a fake ASN to communicate with the peer when you migrate or merge ASs. This prevents service interruptions.
        /// </summary>
        [NameInMap("IsFakeAsn")]
        [Validation(Required=false)]
        public bool? IsFakeAsn { get; set; }

        /// <summary>
        /// The custom ASN on the Alibaba Cloud side. Valid values:
        /// 
        /// *   **45104**
        /// *   **64512~65534**
        /// *   **4200000000~4294967294**
        /// 
        /// >  **65025** is reserved by Alibaba Cloud. By default, Alibaba Cloud uses **45104** as **LocalAsn**. If you use a custom **LocalAsn** in scenarios where multiple connections are used, BGP loops may occur. Proceed with caution.
        /// </summary>
        [NameInMap("LocalAsn")]
        [Validation(Required=false)]
        public long? LocalAsn { get; set; }

        /// <summary>
        /// The name of the BGP group.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ASN of the gateway device in the data center.
        /// </summary>
        [NameInMap("PeerAsn")]
        [Validation(Required=false)]
        public long? PeerAsn { get; set; }

        /// <summary>
        /// The region ID of the VBR.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The maximum number of routes supported by a BGP peer. Default value: **110**.
        /// </summary>
        [NameInMap("RouteQuota")]
        [Validation(Required=false)]
        public int? RouteQuota { get; set; }

        /// <summary>
        /// The ID of the VBR.
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

    }

}
