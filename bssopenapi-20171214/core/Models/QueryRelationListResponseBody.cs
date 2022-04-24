// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRelationListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRelationListResponseBodyData Data { get; set; }
        public class QueryRelationListResponseBodyData : TeaModel {
            [NameInMap("FinancialRelationInfoList")]
            [Validation(Required=false)]
            public List<QueryRelationListResponseBodyDataFinancialRelationInfoList> FinancialRelationInfoList { get; set; }
            public class QueryRelationListResponseBodyDataFinancialRelationInfoList : TeaModel {
                public long? AccountId { get; set; }
                public string AccountName { get; set; }
                public string AccountNickName { get; set; }
                public string AccountType { get; set; }
                public string EndTime { get; set; }
                public long? RelationId { get; set; }
                public string RelationType { get; set; }
                public string SetupTime { get; set; }
                public string StartTime { get; set; }
                public string State { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
