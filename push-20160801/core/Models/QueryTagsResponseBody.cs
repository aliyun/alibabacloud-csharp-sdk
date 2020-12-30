// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryTagsResponseBody : TeaModel {
        [NameInMap("TagInfos")]
        [Validation(Required=false)]
        public QueryTagsResponseBodyTagInfos TagInfos { get; set; }
        public class QueryTagsResponseBodyTagInfos : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public List<QueryTagsResponseBodyTagInfosTagInfo> TagInfo { get; set; }
            public class QueryTagsResponseBodyTagInfosTagInfo : TeaModel {
                public string TagName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
