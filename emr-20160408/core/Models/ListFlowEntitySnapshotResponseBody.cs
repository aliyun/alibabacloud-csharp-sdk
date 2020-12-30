// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowEntitySnapshotResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ListFlowEntitySnapshotResponseBodyItems Items { get; set; }
        public class ListFlowEntitySnapshotResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<ListFlowEntitySnapshotResponseBodyItemsItem> Item { get; set; }
            public class ListFlowEntitySnapshotResponseBodyItemsItem : TeaModel {
                public bool? Active { get; set; }
                public string Data { get; set; }
                public string EntityId { get; set; }
                public string EntityType { get; set; }
                public string UserId { get; set; }
                public long? GmtCreate { get; set; }
                public string Message { get; set; }
                public string EntityGroupId { get; set; }
                public string CommitterId { get; set; }
                public string Revision { get; set; }
            }
        };

    }

}
