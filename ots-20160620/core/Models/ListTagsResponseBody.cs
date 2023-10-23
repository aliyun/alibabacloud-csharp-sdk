// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class ListTagsResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
