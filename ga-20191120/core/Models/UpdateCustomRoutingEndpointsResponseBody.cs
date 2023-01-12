// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateCustomRoutingEndpointsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the endpoints.
        /// </summary>
        [NameInMap("EndpointIds")]
        [Validation(Required=false)]
        public List<string> EndpointIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
