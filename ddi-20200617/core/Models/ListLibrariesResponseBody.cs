// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListLibrariesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListLibrariesResponseBodyItems Items { get; set; }
        public class ListLibrariesResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListLibrariesResponseBodyItemsItem> Item { get; set; }
            public class ListLibrariesResponseBodyItemsItem : TeaModel {
                public string BizId { get; set; }
                public long? CreateTime { get; set; }
                public string LibraryVersion { get; set; }
                public string Name { get; set; }
                public string Properties { get; set; }
                public string Scope { get; set; }
                public string SourceLocation { get; set; }
                public string SourceType { get; set; }
                public string Type { get; set; }
                public string UserId { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
