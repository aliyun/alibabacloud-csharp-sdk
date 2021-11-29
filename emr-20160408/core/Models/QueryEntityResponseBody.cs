// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class QueryEntityResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public QueryEntityResponseBodyItems Items { get; set; }
        public class QueryEntityResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryEntityResponseBodyItemsItem> Item { get; set; }
            public class QueryEntityResponseBodyItemsItem : TeaModel {
                public string EntityId { get; set; }
                public string EntityType { get; set; }
                public long? TagId { get; set; }
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
