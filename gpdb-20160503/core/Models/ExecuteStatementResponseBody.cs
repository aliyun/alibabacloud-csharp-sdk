// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        /// <summary>
        /// The time when the SQL statements were created.
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The returned results of the synchronous call.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            /// <summary>
            /// The metadata of the columns.
            /// </summary>
            [NameInMap("ColumnMetadata")]
            [Validation(Required=false)]
            public ExecuteStatementResponseBodyDataColumnMetadata ColumnMetadata { get; set; }
            public class ExecuteStatementResponseBodyDataColumnMetadata : TeaModel {
                [NameInMap("ColumnMetadata")]
                [Validation(Required=false)]
                public List<ColumnMetadata> ColumnMetadata { get; set; }

            }

            /// <summary>
            /// The rows of data.
            /// </summary>
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

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalNumRows")]
            [Validation(Required=false)]
            public long? TotalNumRows { get; set; }

        }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The ID of the job for asynchronously executing the SQL statements.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ARN of the access credential for the created Data API account.
        /// </summary>
        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        /// <summary>
        /// The status of the operation. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
