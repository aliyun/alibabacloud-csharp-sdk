// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListNamespaceChangeOrdersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespaceChangeOrdersResponseBodyData Data { get; set; }
        public class ListNamespaceChangeOrdersResponseBodyData : TeaModel {
            [NameInMap("ChangeOrderList")]
            [Validation(Required=false)]
            public List<ListNamespaceChangeOrdersResponseBodyDataChangeOrderList> ChangeOrderList { get; set; }
            public class ListNamespaceChangeOrdersResponseBodyDataChangeOrderList : TeaModel {
                public int? BatchCount { get; set; }
                public string BatchType { get; set; }
                public string ChangeOrderId { get; set; }
                public string CoType { get; set; }
                public string CoTypeCode { get; set; }
                public string CreateTime { get; set; }
                public string CreateUserId { get; set; }
                public string Description { get; set; }
                public string FinishTime { get; set; }
                public string GroupId { get; set; }
                public string NamespaceId { get; set; }
                public string Pipelines { get; set; }
                public string Source { get; set; }
                public int? Status { get; set; }
                public string UserId { get; set; }
            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
