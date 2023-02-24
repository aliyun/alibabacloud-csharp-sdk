// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListResourceTagsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tags of the CMK.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ListResourceTagsResponseBodyTags Tags { get; set; }
        public class ListResourceTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListResourceTagsResponseBodyTagsTag> Tag { get; set; }
            public class ListResourceTagsResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The globally unique ID of the CMK.
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                /// <summary>
                /// The tag key.
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

}
