// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class QueryTagResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public QueryTagResponseBodyItems Items { get; set; }
        public class QueryTagResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryTagResponseBodyItemsItem> Item { get; set; }
            public class QueryTagResponseBodyItemsItem : TeaModel {
                public string Category { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
            }
        };

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
