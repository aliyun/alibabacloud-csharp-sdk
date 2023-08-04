// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class ExecuteStatementRequest : TeaModel {
        [NameInMap("ContinueAfterTimeout")]
        [Validation(Required=false)]
        public bool? ContinueAfterTimeout { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("FormatRecordsAs")]
        [Validation(Required=false)]
        public string FormatRecordsAs { get; set; }

        [NameInMap("IncludeResultMetadata")]
        [Validation(Required=false)]
        public bool? IncludeResultMetadata { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<SqlParameter> Parameters { get; set; }

        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        [NameInMap("ResultSetOptions")]
        [Validation(Required=false)]
        public ExecuteStatementRequestResultSetOptions ResultSetOptions { get; set; }
        public class ExecuteStatementRequestResultSetOptions : TeaModel {
            [NameInMap("DecimalReturnType")]
            [Validation(Required=false)]
            public string DecimalReturnType { get; set; }

            [NameInMap("LongReturnType")]
            [Validation(Required=false)]
            public string LongReturnType { get; set; }

        }

        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
