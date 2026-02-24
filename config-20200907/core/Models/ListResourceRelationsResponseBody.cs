// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceRelations")]
        [Validation(Required=false)]
        public ListResourceRelationsResponseBodyResourceRelations ResourceRelations { get; set; }
        public class ListResourceRelationsResponseBodyResourceRelations : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("ResourceRelationList")]
            [Validation(Required=false)]
            public List<ListResourceRelationsResponseBodyResourceRelationsResourceRelationList> ResourceRelationList { get; set; }
            public class ListResourceRelationsResponseBodyResourceRelationsResourceRelationList : TeaModel {
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                [NameInMap("SourceResourceId")]
                [Validation(Required=false)]
                public string SourceResourceId { get; set; }

                [NameInMap("SourceResourceRegionId")]
                [Validation(Required=false)]
                public string SourceResourceRegionId { get; set; }

                [NameInMap("SourceResourceType")]
                [Validation(Required=false)]
                public string SourceResourceType { get; set; }

                [NameInMap("TargetResourceId")]
                [Validation(Required=false)]
                public string TargetResourceId { get; set; }

                [NameInMap("TargetResourceType")]
                [Validation(Required=false)]
                public string TargetResourceType { get; set; }

            }

        }

    }

}
