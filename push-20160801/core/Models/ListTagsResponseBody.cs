// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6EEF262B-EA7D-41DC-89B9-20F3D1E28194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagInfos")]
        [Validation(Required=false)]
        public ListTagsResponseBodyTagInfos TagInfos { get; set; }
        public class ListTagsResponseBodyTagInfos : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public List<ListTagsResponseBodyTagInfosTagInfo> TagInfo { get; set; }
            public class ListTagsResponseBodyTagInfosTagInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test_tag2</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

    }

}
