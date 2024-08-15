// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListTagValuesRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return for a single request.
        /// 
        /// Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// The value Account indicates the members of the resource directory.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag key. This parameter specifies a filter condition for the query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// The tag value for a fuzzy query.
        /// </summary>
        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public string ValueFilter { get; set; }

    }

}
