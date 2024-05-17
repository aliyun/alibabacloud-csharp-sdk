// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationRequest : TeaModel {
        /// <summary>
        /// The ID of the next hop.
        /// 
        /// > Set the value to **BlackHole** if you want to query the prefix list that generates blackhole routes.
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// The ID of the network instance associated with the next hop connection.
        /// </summary>
        [NameInMap("NextHopInstanceId")]
        [Validation(Required=false)]
        public string NextHopInstanceId { get; set; }

        /// <summary>
        /// The type of the next hop. Valid values:
        /// 
        /// *   **BlackHole**: The prefix list that generates blackhole routes.
        /// *   **VPC**: The prefix list whose next hop is a virtual private cloud (VPC) connection.
        /// *   **VBR**: The prefix list whose next hop is a virtual border router (VBR) connection.
        /// *   **TR**: The prefix list whose next hop is an inter-region connection on the transit router.
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the prefix list belongs.
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **100**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the prefix list.
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// The ID of the region where the transit router is deployed.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
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
        /// The status of the prefix list. Valid values:
        /// 
        /// *   **Active**
        /// *   **Updating**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the transit router.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// The ID of the route table of the transit router.
        /// </summary>
        [NameInMap("TransitRouterTableId")]
        [Validation(Required=false)]
        public string TransitRouterTableId { get; set; }

    }

}
