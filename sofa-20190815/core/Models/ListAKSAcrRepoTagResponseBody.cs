// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSAcrRepoTagResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public ListAKSAcrRepoTagResponseBodyTagList TagList { get; set; }
        public class ListAKSAcrRepoTagResponseBodyTagList : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAKSAcrRepoTagResponseBodyTagListTags> Tags { get; set; }
            public class ListAKSAcrRepoTagResponseBodyTagListTags : TeaModel {
                public string Digest { get; set; }
                public long? ImageCreate { get; set; }
                public string ImageId { get; set; }
                public long? ImageSize { get; set; }
                public long? ImageUpdate { get; set; }
                public string Status { get; set; }
                public string Tag { get; set; }
            }
        };

    }

}
