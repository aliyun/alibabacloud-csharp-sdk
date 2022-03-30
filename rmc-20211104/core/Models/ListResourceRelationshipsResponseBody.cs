// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RMC20211104.Models
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
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("RelationshipType")]
            [Validation(Required=false)]
            public string RelationshipType { get; set; }

            [NameInMap("SourceRegionId")]
            [Validation(Required=false)]
            public string SourceRegionId { get; set; }

            [NameInMap("SourceResourceId")]
            [Validation(Required=false)]
            public string SourceResourceId { get; set; }

            [NameInMap("SourceResourceType")]
            [Validation(Required=false)]
            public string SourceResourceType { get; set; }

            [NameInMap("TargetRegionId")]
            [Validation(Required=false)]
            public string TargetRegionId { get; set; }

            [NameInMap("TargetResourceId")]
            [Validation(Required=false)]
            public string TargetResourceId { get; set; }

            [NameInMap("TargetResourceType")]
            [Validation(Required=false)]
            public string TargetResourceType { get; set; }

        }

    }

}
