// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestOriginStatByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFullRequestOriginStatByInstanceIdResponseBodyData Data { get; set; }
        public class GetFullRequestOriginStatByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the full request data.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetFullRequestOriginStatByInstanceIdResponseBodyDataList> List { get; set; }
            public class GetFullRequestOriginStatByInstanceIdResponseBodyDataList : TeaModel {
                /// <summary>
                /// The average number of scanned rows.
                /// 
                /// > This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.
                /// </summary>
                [NameInMap("AvgExaminedRows")]
                [Validation(Required=false)]
                public double? AvgExaminedRows { get; set; }

                /// <summary>
                /// The average number of rows that are fetched from data nodes by compute nodes on the PolarDB-X 2.0 instance.
                /// </summary>
                [NameInMap("AvgFetchRows")]
                [Validation(Required=false)]
                public long? AvgFetchRows { get; set; }

                /// <summary>
                /// The average lock wait duration. Unit: seconds.
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
                public double? AvgPhysicalSyncRead { get; set; }

                /// <summary>
                /// The average number of returned rows.
                /// </summary>
                [NameInMap("AvgReturnedRows")]
                [Validation(Required=false)]
                public double? AvgReturnedRows { get; set; }

                /// <summary>
                /// The average number of rows.
                /// </summary>
                [NameInMap("AvgRows")]
                [Validation(Required=false)]
                public long? AvgRows { get; set; }

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
                /// > This parameter is returned only for ApsaraDB RDS for MySQL and PolarDB-X 2.0 databases.
                /// </summary>
                [NameInMap("AvgUpdatedRows")]
                [Validation(Required=false)]
                public double? AvgUpdatedRows { get; set; }

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
                /// The number of rows that are fetched from data nodes by compute nodes on the PolarDB-X 2.0 instance.
                /// </summary>
                [NameInMap("FetchRows")]
                [Validation(Required=false)]
                public long? FetchRows { get; set; }

                /// <summary>
                /// The network address of the database instance.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The IP address of the client that executes the SQL statement.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

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
                public long? LogicalRead { get; set; }

                /// <summary>
                /// The IP address of the client that executes the SQL statement.
                /// </summary>
                [NameInMap("OriginHost")]
                [Validation(Required=false)]
                public string OriginHost { get; set; }

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
                /// The total number of updated rows.
                /// </summary>
                [NameInMap("SumUpdatedRows")]
                [Validation(Required=false)]
                public long? SumUpdatedRows { get; set; }

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
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
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
