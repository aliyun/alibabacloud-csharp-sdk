// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListResourcesByTagResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the `next query` is required.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the `next query` is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the `token` used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesByTagResponseBodyResources> Resources { get; set; }
        public class ListResourcesByTagResponseBodyResources : TeaModel {
            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The information of the tags.
            /// 
            /// This parameter is returned only if the `IncludeAllTags` parameter is set to `True`.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourcesByTagResponseBodyResourcesTags> Tags { get; set; }
            public class ListResourcesByTagResponseBodyResourcesTags : TeaModel {
                /// <summary>
                /// The type of the tag. Valid values:
                /// 
                /// *   custom
                /// *   system
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
