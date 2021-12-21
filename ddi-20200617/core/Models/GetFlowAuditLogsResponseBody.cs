// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class GetFlowAuditLogsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public GetFlowAuditLogsResponseBodyItems Items { get; set; }
        public class GetFlowAuditLogsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<GetFlowAuditLogsResponseBodyItemsItem> Item { get; set; }
            public class GetFlowAuditLogsResponseBodyItemsItem : TeaModel {
                public string Content { get; set; }
                public string EntityGroupId { get; set; }
                public string EntityId { get; set; }
                public string EntityType { get; set; }
                public string Operation { get; set; }
                public string OperatorId { get; set; }
                public string Status { get; set; }
                public long? Ts { get; set; }
                public string UserId { get; set; }
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
