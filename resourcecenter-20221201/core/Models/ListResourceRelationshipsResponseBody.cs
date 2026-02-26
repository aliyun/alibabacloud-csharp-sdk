// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListResourceRelationshipsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceRelationships")]
        [Validation(Required=false)]
        public List<ListResourceRelationshipsResponseBodyResourceRelationships> ResourceRelationships { get; set; }
        public class ListResourceRelationshipsResponseBodyResourceRelationships : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RelatedResourceId")]
            [Validation(Required=false)]
            public string RelatedResourceId { get; set; }

            [NameInMap("RelatedResourceRegionId")]
            [Validation(Required=false)]
            public string RelatedResourceRegionId { get; set; }

            [NameInMap("RelatedResourceType")]
            [Validation(Required=false)]
            public string RelatedResourceType { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
