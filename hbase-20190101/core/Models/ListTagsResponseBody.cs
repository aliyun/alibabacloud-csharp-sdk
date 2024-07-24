// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>36D1BE9B-3C4A-425B-947A-69E3D77999C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ListTagsResponseBodyTags Tags { get; set; }
        public class ListTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListTagsResponseBodyTagsTag> Tag { get; set; }
            public class ListTagsResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
