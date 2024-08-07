// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceRelationsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the relationship.
        /// </summary>
        [NameInMap("ResourceRelations")]
        [Validation(Required=false)]
        public ListResourceRelationsResponseBodyResourceRelations ResourceRelations { get; set; }
        public class ListResourceRelationsResponseBodyResourceRelations : TeaModel {
            /// <summary>
            /// The maximum number of entries returned on each page.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The token that was used to initiate the next request.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// An array that contains the relationships.
            /// </summary>
            [NameInMap("ResourceRelationList")]
            [Validation(Required=false)]
            public List<ListResourceRelationsResponseBodyResourceRelationsResourceRelationList> ResourceRelationList { get; set; }
            public class ListResourceRelationsResponseBodyResourceRelationsResourceRelationList : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud account to which the resource belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The type of the relationship between the resource and the object.
                /// 
                /// Valid values:
                /// 
                /// *   IsContained: The object is included as part of the resource.
                /// *   IsAttachedTo: The object is added to the resource.
                /// *   IsAssociatedIn: The object is associated with the resource.
                /// *   Contains: The object contains the resource.
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("SourceResourceId")]
                [Validation(Required=false)]
                public string SourceResourceId { get; set; }

                /// <summary>
                /// The ID of the region in which the resource resides.
                /// </summary>
                [NameInMap("SourceResourceRegionId")]
                [Validation(Required=false)]
                public string SourceResourceRegionId { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("SourceResourceType")]
                [Validation(Required=false)]
                public string SourceResourceType { get; set; }

                /// <summary>
                /// The ID of the associated resource.
                /// </summary>
                [NameInMap("TargetResourceId")]
                [Validation(Required=false)]
                public string TargetResourceId { get; set; }

                /// <summary>
                /// The type of the associated resource.
                /// </summary>
                [NameInMap("TargetResourceType")]
                [Validation(Required=false)]
                public string TargetResourceType { get; set; }

            }

        }

    }

}
