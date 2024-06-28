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
        /// The BGP group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BgpGroupId")]
        [Validation(Required=false)]
        public string BgpGroupId { get; set; }

        /// <summary>
        /// Specifies whether to clear the secret key. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("ClearAuthKey")]
        [Validation(Required=false)]
        public bool? ClearAuthKey { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The BGP group description.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to use a fake AS number. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// 
        /// > A router that runs BGP typically belongs to only one AS. If you need to replace an AS with a new one, but you cannot immediately modify BGP configurations due to business requirements, you can specify a fake AS number to establish a connection with the local end. This ensures service continuity in scenarios such as AS migration or AS merging.
        /// </summary>
        [NameInMap("IsFakeAsn")]
        [Validation(Required=false)]
        public bool? IsFakeAsn { get; set; }

        /// <summary>
        /// The custom autonomous system number (ASN) of the BGP on the Alibaba Cloud side. Valid values:
        /// 
        /// *   **45104**
        /// *   **64512~65534**
        /// *   **4200000000~4294967294**
        /// 
        /// >  **65025** is reserved by Alibaba Cloud. Alibaba Cloud uses **45104** as the **local ASN** by default. Custom **local ASNs** may cause loops in multi-line scenarios. Proceed with caution.
        /// </summary>
        [NameInMap("LocalAsn")]
        [Validation(Required=false)]
        public long? LocalAsn { get; set; }

        /// <summary>
        /// The BGP group name.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
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
        /// The region ID of the BGP group.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
