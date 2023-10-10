// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("next_token")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the queried labels and resources.
        /// </summary>
        [NameInMap("tag_resources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// The resource and label.
            /// </summary>
            [NameInMap("tag_resource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("resource_id")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource. For more information, see [Labels](~~110425~~).
                /// </summary>
                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The key of the label.
                /// </summary>
                [NameInMap("tag_key")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the label.
                /// </summary>
                [NameInMap("tag_value")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
