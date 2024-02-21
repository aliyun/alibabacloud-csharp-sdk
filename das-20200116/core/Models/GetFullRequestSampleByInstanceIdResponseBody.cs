// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestSampleByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetFullRequestSampleByInstanceIdResponseBodyData> Data { get; set; }
        public class GetFullRequestSampleByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The number of rows fetched by PolarDB-X 2.0 compute nodes.
            /// </summary>
            [NameInMap("Frows")]
            [Validation(Required=false)]
            public long? Frows { get; set; }

            /// <summary>
            /// The lock wait duration. Unit: seconds.
            /// </summary>
            [NameInMap("LockWaitTime")]
            [Validation(Required=false)]
            public double? LockWaitTime { get; set; }

            /// <summary>
            /// The number of logical reads.
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public double? LogicalRead { get; set; }

            /// <summary>
            /// The source IP address.
            /// </summary>
            [NameInMap("OriginHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            /// <summary>
            /// The number of physical asynchronous reads.
            /// </summary>
            [NameInMap("PhysicalAsyncRead")]
            [Validation(Required=false)]
            public double? PhysicalAsyncRead { get; set; }

            /// <summary>
            /// The number of physical synchronous reads.
            /// </summary>
            [NameInMap("PhysicalSyncRead")]
            [Validation(Required=false)]
            public double? PhysicalSyncRead { get; set; }

            /// <summary>
            /// The number of rows updated or returned on PolarDB-X 2.0 compute nodes.
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public long? Rows { get; set; }

            /// <summary>
            /// The total number of scanned rows.
            /// 
            /// > This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.
            /// </summary>
            [NameInMap("RowsExamined")]
            [Validation(Required=false)]
            public long? RowsExamined { get; set; }

            /// <summary>
            /// The number of rows returned by the SQL statement.
            /// </summary>
            [NameInMap("RowsReturned")]
            [Validation(Required=false)]
            public long? RowsReturned { get; set; }

            /// <summary>
            /// The amount of time consumed to execute the SQL statement. Unit: seconds.
            /// </summary>
            [NameInMap("Rt")]
            [Validation(Required=false)]
            public double? Rt { get; set; }

            /// <summary>
            /// The number of scanned rows.
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// The number of requests sent from PolarDB-X 2.0 compute nodes to data nodes.
            /// </summary>
            [NameInMap("Scnt")]
            [Validation(Required=false)]
            public long? Scnt { get; set; }

            /// <summary>
            /// The sample SQL statement.
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// The SQL statement ID.
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// The type of the SQL statement. Valid values: **SELECT**, **INSERT**, **UPDATE**, **DELETE**, **LOGIN**, **LOGOUT**, **MERGE**, **ALTER**, **CREATEINDEX**, **DROPINDEX**, **CREATE**, **DROP**, **SET**, **DESC**, **REPLACE**, **CALL**, **BEGIN**, **DESCRIBE**, **ROLLBACK**, **FLUSH**, **USE**, **SHOW**, **START**, **COMMIT**, and **RENAME**.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// The time when the SQL statement was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The number of updated rows.
            /// </summary>
            [NameInMap("UpdateRows")]
            [Validation(Required=false)]
            public long? UpdateRows { get; set; }

            /// <summary>
            /// The name of the user who executes the SQL statement.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message that contains information such as an error code is returned.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
