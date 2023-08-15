// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ListTagsResponseBody : TeaModel {
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
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
