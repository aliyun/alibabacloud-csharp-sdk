// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the endpoint that you want to query.
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// The status of the endpoint. Valid values:
        /// 
        /// *   **Creating**: being created
        /// *   **Active**: available
        /// *   **Pending**: being modified
        /// *   **Deleting**: being deleted
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
