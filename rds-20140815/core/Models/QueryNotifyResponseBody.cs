// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class QueryNotifyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNotifyResponseBodyData Data { get; set; }
        public class QueryNotifyResponseBodyData : TeaModel {
            [NameInMap("NotifyItemList")]
            [Validation(Required=false)]
            public List<QueryNotifyResponseBodyDataNotifyItemList> NotifyItemList { get; set; }
            public class QueryNotifyResponseBodyDataNotifyItemList : TeaModel {
                public long? AliUid { get; set; }
                public bool? ConfirmFlag { get; set; }
                public long? Confirmor { get; set; }
                public string GmtCreated { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string IdempotentCount { get; set; }
                public string IdempotentId { get; set; }
                public string Level { get; set; }
                public string NotifyElement { get; set; }
                public string TemplateName { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalRecordCount")]
            [Validation(Required=false)]
            public int? TotalRecordCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
