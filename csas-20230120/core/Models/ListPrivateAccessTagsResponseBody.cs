// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The internal access tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPrivateAccessTagsResponseBodyTags> Tags { get; set; }
        public class ListPrivateAccessTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// The IDs of the internal access applications.
            /// </summary>
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            /// <summary>
            /// The time when the internal access tag was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the internal access tag.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the internal access tag.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The IDs of the internal access policies.
            /// </summary>
            [NameInMap("PolicyIds")]
            [Validation(Required=false)]
            public List<string> PolicyIds { get; set; }

            /// <summary>
            /// The ID of the internal access tag.
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

            /// <summary>
            /// The type of the internal access tag. Valid values:
            /// 
            /// *   **Default**
            /// *   **Custom**
            /// </summary>
            [NameInMap("TagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

        }

        /// <summary>
        /// The total number of internal access tags.
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
