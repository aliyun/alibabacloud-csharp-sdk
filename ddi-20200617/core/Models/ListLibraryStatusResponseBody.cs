// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListLibraryStatusResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListLibraryStatusResponseBodyItems Items { get; set; }
        public class ListLibraryStatusResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListLibraryStatusResponseBodyItemsItem> Item { get; set; }
            public class ListLibraryStatusResponseBodyItemsItem : TeaModel {
                public string Status { get; set; }
                public string ClusterName { get; set; }
                public string ClusterBizId { get; set; }
                public string LibraryBizId { get; set; }
                public string LibraryName { get; set; }
            }
        };

    }

}
