// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetSqlStatementResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSqlStatementResponseBodyData Data { get; set; }
        public class GetSqlStatementResponseBodyData : TeaModel {
            [NameInMap("executionTime")]
            [Validation(Required=false)]
            public List<long?> ExecutionTime { get; set; }

            [NameInMap("sqlErrorCode")]
            [Validation(Required=false)]
            public string SqlErrorCode { get; set; }

            [NameInMap("sqlErrorMessage")]
            [Validation(Required=false)]
            public string SqlErrorMessage { get; set; }

            [NameInMap("sqlOutputs")]
            [Validation(Required=false)]
            public List<GetSqlStatementResponseBodyDataSqlOutputs> SqlOutputs { get; set; }
            public class GetSqlStatementResponseBodyDataSqlOutputs : TeaModel {
                [NameInMap("rows")]
                [Validation(Required=false)]
                public string Rows { get; set; }

                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("statementId")]
            [Validation(Required=false)]
            public string StatementId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
