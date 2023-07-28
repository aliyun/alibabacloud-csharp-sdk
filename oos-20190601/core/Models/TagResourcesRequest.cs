// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to TagResources.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceIds { get; set; }

        /// <summary>
        /// The IDs of resources. The number of resource IDs ranges from 1 to 50.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
