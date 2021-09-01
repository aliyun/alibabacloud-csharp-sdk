// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryStatementsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryStatementsResponseBodyModel Model { get; set; }
        public class QueryStatementsResponseBodyModel : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("StatementList")]
            [Validation(Required=false)]
            public List<QueryStatementsResponseBodyModelStatementList> StatementList { get; set; }
            public class QueryStatementsResponseBodyModelStatementList : TeaModel {
                public string PayeeAccountName { get; set; }
                public string PayeeId { get; set; }
                public string PayeeAccountNo { get; set; }
                public string CreateDate { get; set; }
                public string ExtInfo { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string SettleNo { get; set; }
                public string Attributes { get; set; }
                public string SettleStatus { get; set; }
                public string PayeeName { get; set; }
                public string SettleAmount { get; set; }
                public string PayeeAccountId { get; set; }
                public string ModifiedDate { get; set; }
                public string StatusMessage { get; set; }
                public string TenantId { get; set; }
            }
        };

    }

}
