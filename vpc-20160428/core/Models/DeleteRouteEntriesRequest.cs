// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntriesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the route table.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
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
        /// The information about the routes that you want to delete.
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<DeleteRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class DeleteRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// The destination CIDR block of the route that you want to delete. IPv4 and IPv6 CIDR blocks are supported. You can specify up to 50 destination CIDR blocks.
            /// 
            /// >  If **RouteEntryId** is not specified, **DstCidrBlock** and **NextHop** are required.
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// The ID of the next hop that you want to delete. You can specify up to 50 next hop IDs.
            /// 
            /// >  If **RouteEntryId** is not specified, **DstCidrBlock** and **NextHop** are required.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The ID of the route that you want to delete. You can specify up to 50 route IDs.
            /// 
            /// >  If **RouteEntryId** is not specified, **DstCidrBlock** and **NextHop** are required.
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// The ID of the route table to which the routes to be deleted belongs. You can specify up to 50 route table IDs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
