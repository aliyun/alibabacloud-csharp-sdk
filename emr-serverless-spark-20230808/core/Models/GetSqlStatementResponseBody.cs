// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetSqlStatementResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSqlStatementResponseBodyData Data { get; set; }
        public class GetSqlStatementResponseBodyData : TeaModel {
            /// <summary>
            /// The list of time that is consumed by SQL queries.
            /// </summary>
            [NameInMap("executionTime")]
            [Validation(Required=false)]
            public List<long?> ExecutionTime { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("sqlErrorCode")]
            [Validation(Required=false)]
            public string SqlErrorCode { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("sqlErrorMessage")]
            [Validation(Required=false)]
            public string SqlErrorMessage { get; set; }

            /// <summary>
            /// The query results.
            /// </summary>
            [NameInMap("sqlOutputs")]
            [Validation(Required=false)]
            public List<GetSqlStatementResponseBodyDataSqlOutputs> SqlOutputs { get; set; }
            public class GetSqlStatementResponseBodyDataSqlOutputs : TeaModel {
                /// <summary>
                /// The queried data, which is a string in the JSON format.
                /// </summary>
                [NameInMap("rows")]
                [Validation(Required=false)]
                public string Rows { get; set; }

                /// <summary>
                /// The information about the schema, which is a string in the JSON format.
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// The query status.
            /// 
            /// Valid values:
            /// 
            /// *   running
            /// *   available
            /// *   cancelled
            /// *   error
            /// *   cancelling
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The query ID.
            /// </summary>
            [NameInMap("statementId")]
            [Validation(Required=false)]
            public string StatementId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
