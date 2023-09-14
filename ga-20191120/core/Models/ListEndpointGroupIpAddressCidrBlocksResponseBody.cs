// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupIpAddressCidrBlocksResponseBody : TeaModel {
        /// <summary>
        /// The region ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// The CIDR blocks.
        /// </summary>
        [NameInMap("IpAddressCidrBlocks")]
        [Validation(Required=false)]
        public List<string> IpAddressCidrBlocks { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the endpoint group belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The status of the endpoint group.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
