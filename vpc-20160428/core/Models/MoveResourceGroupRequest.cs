// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class MoveResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which you want to move the resource.
        /// 
        /// >  You can use resource groups to facilitate resource grouping and permission management for an Alibaba Cloud. For more information, see [What is resource management?](https://help.aliyun.com/document_detail/94475.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region to which the cloud resource belongs.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the resource for which you want to modify the resource group. Valid values:
        /// 
        /// *   **Vpc**
        /// *   **Eip**
        /// *   **BandwidthPackage**
        /// *   **PrefixList**
        /// *   **PublicIpAddressPool**
        /// *   **FlowLog**
        /// *   **HaVip**
        /// *   **TrafficMirrorFilter**
        /// *   **TrafficMirrorSession**
        /// *   **IPv4Gateway**
        /// *   **IPv6Gateway**
        /// *   **DhcpOptionsSet**
        /// *   **GatewayEndpoint**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
