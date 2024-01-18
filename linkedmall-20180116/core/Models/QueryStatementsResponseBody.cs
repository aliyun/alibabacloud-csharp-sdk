// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryStatementsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryStatementsResponseBodyModel Model { get; set; }
        public class QueryStatementsResponseBodyModel : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("StatementList")]
            [Validation(Required=false)]
            public List<QueryStatementsResponseBodyModelStatementList> StatementList { get; set; }
            public class QueryStatementsResponseBodyModelStatementList : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("KpNoGenerateTime")]
                [Validation(Required=false)]
                public string KpNoGenerateTime { get; set; }

                [NameInMap("ModifiedDate")]
                [Validation(Required=false)]
                public string ModifiedDate { get; set; }

                [NameInMap("PayeeAccountId")]
                [Validation(Required=false)]
                public string PayeeAccountId { get; set; }

                [NameInMap("PayeeAccountName")]
                [Validation(Required=false)]
                public string PayeeAccountName { get; set; }

                [NameInMap("PayeeAccountNo")]
                [Validation(Required=false)]
                public string PayeeAccountNo { get; set; }

                [NameInMap("PayeeId")]
                [Validation(Required=false)]
                public string PayeeId { get; set; }

                [NameInMap("PayeeName")]
                [Validation(Required=false)]
                public string PayeeName { get; set; }

                [NameInMap("SettleAmount")]
                [Validation(Required=false)]
                public string SettleAmount { get; set; }

                [NameInMap("SettleNo")]
                [Validation(Required=false)]
                public string SettleNo { get; set; }

                [NameInMap("SettleStatus")]
                [Validation(Required=false)]
                public string SettleStatus { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
