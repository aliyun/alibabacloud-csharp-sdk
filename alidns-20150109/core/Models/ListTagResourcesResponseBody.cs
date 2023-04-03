// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. If the NextToken parameter is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The unique ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the resource and tags, such as the resource ID, the resource type, tag keys, and tag values.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource. The returned parameter value is fixed to DOMAIN.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The key of the tag.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
