// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestStatResultByInstanceIdResponseBody : TeaModel {
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
        public GetFullRequestStatResultByInstanceIdResponseBodyData Data { get; set; }
        public class GetFullRequestStatResultByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the asynchronous request failed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// Indicates whether the asynchronous request was complete. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// The returned full request data.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetFullRequestStatResultByInstanceIdResponseBodyDataResult Result { get; set; }
            public class GetFullRequestStatResultByInstanceIdResponseBodyDataResult : TeaModel {
                /// <summary>
                /// The full request data.
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<GetFullRequestStatResultByInstanceIdResponseBodyDataResultList> List { get; set; }
                public class GetFullRequestStatResultByInstanceIdResponseBodyDataResultList : TeaModel {
                    /// <summary>
                    /// The average number of scanned rows.
                    /// 
                    /// > This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.
                    /// </summary>
                    [NameInMap("AvgExaminedRows")]
                    [Validation(Required=false)]
                    public double? AvgExaminedRows { get; set; }

                    /// <summary>
                    /// The average number of rows that are fetched by compute nodes from data nodes on the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("AvgFetchRows")]
                    [Validation(Required=false)]
                    public long? AvgFetchRows { get; set; }

                    /// <summary>
                    /// The average lock wait latency. Unit: seconds.
                    /// </summary>
                    [NameInMap("AvgLockWaitTime")]
                    [Validation(Required=false)]
                    public double? AvgLockWaitTime { get; set; }

                    /// <summary>
                    /// The average number of logical reads.
                    /// </summary>
                    [NameInMap("AvgLogicalRead")]
                    [Validation(Required=false)]
                    public double? AvgLogicalRead { get; set; }

                    /// <summary>
                    /// The average number of physical asynchronous reads.
                    /// </summary>
                    [NameInMap("AvgPhysicalAsyncRead")]
                    [Validation(Required=false)]
                    public long? AvgPhysicalAsyncRead { get; set; }

                    /// <summary>
                    /// The average number of physical synchronous reads.
                    /// </summary>
                    [NameInMap("AvgPhysicalSyncRead")]
                    [Validation(Required=false)]
                    public long? AvgPhysicalSyncRead { get; set; }

                    /// <summary>
                    /// The average number of returned rows.
                    /// </summary>
                    [NameInMap("AvgReturnedRows")]
                    [Validation(Required=false)]
                    public double? AvgReturnedRows { get; set; }

                    /// <summary>
                    /// The average execution duration.
                    /// </summary>
                    [NameInMap("AvgRt")]
                    [Validation(Required=false)]
                    public double? AvgRt { get; set; }

                    /// <summary>
                    /// The average number of SQL statements.
                    /// </summary>
                    [NameInMap("AvgSqlCount")]
                    [Validation(Required=false)]
                    public long? AvgSqlCount { get; set; }

                    /// <summary>
                    /// The average number of updated rows.
                    /// 
                    ///  > This parameter is returned only for ApsaraDB RDS for MySQL and PolarDB-X 2.0 databases.
                    /// </summary>
                    [NameInMap("AvgUpdatedRows")]
                    [Validation(Required=false)]
                    public long? AvgUpdatedRows { get; set; }

                    /// <summary>
                    /// The total number of executions.
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// The percentage of the total number of executions.
                    /// </summary>
                    [NameInMap("CountRate")]
                    [Validation(Required=false)]
                    public double? CountRate { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// The number of failed executions.
                    /// </summary>
                    [NameInMap("ErrorCount")]
                    [Validation(Required=false)]
                    public long? ErrorCount { get; set; }

                    /// <summary>
                    /// The total number of scanned rows.
                    /// 
                    /// > This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.
                    /// </summary>
                    [NameInMap("ExaminedRows")]
                    [Validation(Required=false)]
                    public long? ExaminedRows { get; set; }

                    /// <summary>
                    /// The number of rows that are fetched by compute nodes from data nodes on the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("FetchRows")]
                    [Validation(Required=false)]
                    public long? FetchRows { get; set; }

                    /// <summary>
                    /// The IP address of the database instance.
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// The lock wait latency. Unit: seconds.
                    /// </summary>
                    [NameInMap("LockWaitTime")]
                    [Validation(Required=false)]
                    public double? LockWaitTime { get; set; }

                    /// <summary>
                    /// The number of logical reads.
                    /// </summary>
                    [NameInMap("LogicalRead")]
                    [Validation(Required=false)]
                    public long? LogicalRead { get; set; }

                    /// <summary>
                    /// The number of physical asynchronous reads.
                    /// </summary>
                    [NameInMap("PhysicalAsyncRead")]
                    [Validation(Required=false)]
                    public long? PhysicalAsyncRead { get; set; }

                    /// <summary>
                    /// The number of physical synchronous reads.
                    /// </summary>
                    [NameInMap("PhysicalSyncRead")]
                    [Validation(Required=false)]
                    public long? PhysicalSyncRead { get; set; }

                    /// <summary>
                    /// The port number that is used to connect to the database instance.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// The SQL template.
                    /// </summary>
                    [NameInMap("Psql")]
                    [Validation(Required=false)]
                    public string Psql { get; set; }

                    /// <summary>
                    /// The total number of rows updated or returned by the compute nodes of the PolarDB-X 2.0 instance.
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// The number of SQL statements that take longer than 1 second to execute.
                    /// </summary>
                    [NameInMap("RtGreaterThanOneSecondCount")]
                    [Validation(Required=false)]
                    public long? RtGreaterThanOneSecondCount { get; set; }

                    /// <summary>
                    /// The execution duration percentage.
                    /// </summary>
                    [NameInMap("RtRate")]
                    [Validation(Required=false)]
                    public double? RtRate { get; set; }

                    /// <summary>
                    /// The number of SQL statements.
                    /// </summary>
                    [NameInMap("SqlCount")]
                    [Validation(Required=false)]
                    public long? SqlCount { get; set; }

                    /// <summary>
                    /// The SQL ID.
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// The total number of updated rows.
                    /// </summary>
                    [NameInMap("SumUpdatedRows")]
                    [Validation(Required=false)]
                    public long? SumUpdatedRows { get; set; }

                    /// <summary>
                    /// The names of tables in the database.
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                    /// <summary>
                    /// The version number.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public long? Version { get; set; }

                    /// <summary>
                    /// The virtual private cloud (VPC) ID.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// The state of the asynchronous request. Valid values:
            /// 
            /// *   **RUNNING**
            /// *   **SUCCESS**
            /// *   **FAIL**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The time when the asynchronous request was sent. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

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
