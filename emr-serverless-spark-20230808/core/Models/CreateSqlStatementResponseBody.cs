// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSqlStatementResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateSqlStatementResponseBodyData Data { get; set; }
        public class CreateSqlStatementResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the SQL query.
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
