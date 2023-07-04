// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntryRequest : TeaModel {
        /// <summary>
        /// The destination CIDR block of the route entry. IPv4 and IPv6 CIDR blocks are supported.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The ID of the next hop.
        /// 
        /// *   To delete a route other than an equal-cost multi-path (ECMP) route, set the **NextHopId** parameter and ignore the **NextHopList** parameter.
        /// *   To delete an ECMP route, set the **NextHopList** parameter and ignore the **NextHopId** parameter.
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<DeleteRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class DeleteRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// The ID of the next hop that is configured for ECMP routing. You can specify information about at most 16 next hops.
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// The type of the next hop that is configured for ECMP routing. Set the value to **RouterInterface**. You can specify information about at most 16 next hops.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the route table.
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
        /// The ID of the route that you want to delete.
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// The ID of the route table to which the route belongs.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
