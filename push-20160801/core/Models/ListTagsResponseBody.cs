// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class ListTagsResponseBody : TeaModel {
        [NameInMap("TagInfos")]
        [Validation(Required=false)]
        public ListTagsResponseBodyTagInfos TagInfos { get; set; }
        public class ListTagsResponseBodyTagInfos : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public List<ListTagsResponseBodyTagInfosTagInfo> TagInfo { get; set; }
            public class ListTagsResponseBodyTagInfosTagInfo : TeaModel {
                public string TagName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
