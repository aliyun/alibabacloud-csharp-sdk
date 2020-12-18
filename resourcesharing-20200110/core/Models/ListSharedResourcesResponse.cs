// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListSharedResourcesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("SharedResources")]
        [Validation(Required=true)]
        public List<ListSharedResourcesResponseSharedResources> SharedResources { get; set; }
        public class ListSharedResourcesResponseSharedResources : TeaModel {
            [NameInMap("ResourceShareId")]
            [Validation(Required=true)]
            public string ResourceShareId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=true)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=true)]
            public string ResourceType { get; set; }

            [NameInMap("ResourceStatus")]
            [Validation(Required=true)]
            public string ResourceStatus { get; set; }

            [NameInMap("ResourceStatusMessage")]
            [Validation(Required=true)]
            public string ResourceStatusMessage { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

        }

    }

}
