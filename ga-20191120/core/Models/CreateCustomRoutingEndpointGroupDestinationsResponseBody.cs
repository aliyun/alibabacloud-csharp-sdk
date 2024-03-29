// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateCustomRoutingEndpointGroupDestinationsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the endpoint group mappings.
        /// </summary>
        [NameInMap("DestinationIds")]
        [Validation(Required=false)]
        public List<string> DestinationIds { get; set; }

        /// <summary>
        /// The IDs of the endpoint group mappings.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
