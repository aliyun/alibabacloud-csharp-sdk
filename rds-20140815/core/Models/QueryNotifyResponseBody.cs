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
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                [NameInMap("ConfirmFlag")]
                [Validation(Required=false)]
                public bool? ConfirmFlag { get; set; }

                [NameInMap("Confirmor")]
                [Validation(Required=false)]
                public long? Confirmor { get; set; }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IdempotentCount")]
                [Validation(Required=false)]
                public string IdempotentCount { get; set; }

                [NameInMap("IdempotentId")]
                [Validation(Required=false)]
                public string IdempotentId { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("NotifyElement")]
                [Validation(Required=false)]
                public string NotifyElement { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
