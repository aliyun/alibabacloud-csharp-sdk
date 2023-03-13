// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// 
        /// > This parameter is valid only when the **TagKey.N** parameter is empty.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the resource is deployed.
        /// 
        /// You can ignore this parameter if ResourceType is set to Cen or BandwidthPackage.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource. Valid values of **N**: **1** to **50**.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The resource type. Valid value:
        /// 
        /// **Cen**: Cloud Enterprise Network (CEN) instance
        /// 
        /// **BandwidthPackage**: bandwidth plan
        /// 
        /// **TransitRouter**: transit router
        /// 
        /// **TransitRouterVpcAttachment**: virtual private cloud (VPC) connection
        /// 
        /// **TransitRouterVbrAttachment**: virtual border router (VBR) connection
        /// 
        /// **TransitRouterPeerAttachment**: inter-region connection
        /// 
        /// **TransitRouterVpnAttachment**: VPN connection
        /// 
        /// **TransitRouterRouteTable**: route table
        /// 
        /// **Flowlog**: flow log
        /// 
        /// **TransitRouterMulticastDomain**: multicast domain
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag key.
        /// 
        /// The tag key cannot exceed 64 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
        /// 
        /// If multiple tag keys are specified, the logical relation among these tag keys is **AND**. Valid values of **N**: **1** to **20**.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
