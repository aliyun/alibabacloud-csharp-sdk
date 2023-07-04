// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyBgpGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The authentication key of the BGP group.
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// The ID of the BGP group.
        /// </summary>
        [NameInMap("BgpGroupId")]
        [Validation(Required=false)]
        public string BgpGroupId { get; set; }

        /// <summary>
        /// Specifies whether to clear the secret key. Valid values:
        /// 
        /// *   **true:** clears the secret key.
        /// *   **false:** does not clear the secret key.
        /// </summary>
        [NameInMap("ClearAuthKey")]
        [Validation(Required=false)]
        public bool? ClearAuthKey { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
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
        /// Specifies whether to use a fake ASN. Valid values:
        /// 
        /// *   **false:** does not use a fake ASN.
        /// *   **true:** uses a fake ASN.
        /// 
        /// >  A router that runs BGP typically belongs to only one autonomous system. If you want to use a different ASN to communicate with the peer but you cannot modify the BGP configuration because it may cause service interruptions, you can use a fake ASN. For example, you can use a fake ASN to communicate with the peer when you migrate or merge autonomous systems. This prevents service interruptions.
        /// </summary>
        [NameInMap("IsFakeAsn")]
        [Validation(Required=false)]
        public bool? IsFakeAsn { get; set; }

        /// <summary>
        /// The custom autonomous system number (ASN) of the BGP on the Alibaba Cloud side. Default value: 45104. Valid values:
        /// 
        /// *   **45104**
        /// *   **64512~65534**
        /// *   **4200000000~4294967294**
        /// 
        /// >  The value of **65025** is reserved by Alibaba Cloud. If you do not use the default value (45104) in scenarios where multiple connections are established, BGP loops may occur. Proceed with caution.
        /// </summary>
        [NameInMap("LocalAsn")]
        [Validation(Required=false)]
        public long? LocalAsn { get; set; }

        /// <summary>
        /// The name of the BGP group.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter and cannot start with `http://` or `https://`.
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
        /// The ID of the region to which the BGP group belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to obtain the region ID.
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

    }

}
