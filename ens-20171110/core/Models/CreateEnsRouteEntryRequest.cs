// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEnsRouteEntryRequest : TeaModel {
        /// <summary>
        /// The description of the custom route entry.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The destination CIDR block of the custom route entry. Make sure that the destination CIDR block meets the following requirements:
        /// 
        /// *   The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.
        /// *   The destination CIDR block of the custom route entry is different from the destination CIDR blocks of other route entries in the same route table.
        /// *   0.0.0.0/0 indicates the default CIDR block.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// The ID of the next hop of the custom route entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// The type of next hop of the custom route entry. Valid values:
        /// 
        /// *   Instance (default): an ENS instance.
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        /// <summary>
        /// The name of the custom route entry that you want to add. The name must be 1 to 128 characters in length. It cannot start with http:// or https://.
        /// </summary>
        [NameInMap("RouteEntryName")]
        [Validation(Required=false)]
        public string RouteEntryName { get; set; }

        /// <summary>
        /// The ID of the route table to which you want to add a custom route entry.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
