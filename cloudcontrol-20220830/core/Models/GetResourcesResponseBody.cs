// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourcesResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public GetResourcesResponseBodyResource Resource { get; set; }
        public class GetResourcesResponseBodyResource : TeaModel {
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<GetResourcesResponseBodyResources> Resources { get; set; }
        public class GetResourcesResponseBodyResources : TeaModel {
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
