// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR block of the route entry.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the next hop.</para>
        /// <remarks>
        /// <para><c>NextHopId</c> and <c>NextHopList</c> are mutually exclusive. You can specify one but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>A list of next hops for an ECMP route.</para>
        /// <remarks>
        /// <para><c>NextHopId</c> and <c>NextHopList</c> are mutually exclusive. You can specify one but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<DeleteRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class DeleteRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// <para>The ID of a next hop in the ECMP route.</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of a next hop in the ECMP route. Set the value to <c>Instance</c>.</para>
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
        /// <para>The ID of the region.</para>
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
        /// <para>The ID of the route table that contains the route entry.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
