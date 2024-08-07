// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListResourceRelationsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return for a single request. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region in which the resource resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the resource that is associated with the object.
        /// </summary>
        [NameInMap("TargetResourceId")]
        [Validation(Required=false)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// The type of the resource that is associated with the object.
        /// </summary>
        [NameInMap("TargetResourceType")]
        [Validation(Required=false)]
        public string TargetResourceType { get; set; }

    }

}
