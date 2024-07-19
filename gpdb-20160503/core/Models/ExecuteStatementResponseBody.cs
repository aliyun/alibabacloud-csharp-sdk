// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            [NameInMap("ColumnMetadata")]
            [Validation(Required=false)]
            public ExecuteStatementResponseBodyDataColumnMetadata ColumnMetadata { get; set; }
            public class ExecuteStatementResponseBodyDataColumnMetadata : TeaModel {
                [NameInMap("ColumnMetadata")]
                [Validation(Required=false)]
                public List<ColumnMetadata> ColumnMetadata { get; set; }

            }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public ExecuteStatementResponseBodyDataRecords Records { get; set; }
            public class ExecuteStatementResponseBodyDataRecords : TeaModel {
                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<ExecuteStatementResponseBodyDataRecordsRecords> Records { get; set; }
                public class ExecuteStatementResponseBodyDataRecordsRecords : TeaModel {
                    [NameInMap("Record")]
                    [Validation(Required=false)]
                    public List<Field> Record { get; set; }

                }

            }

            [NameInMap("TotalNumRows")]
            [Validation(Required=false)]
            public long? TotalNumRows { get; set; }

        }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
