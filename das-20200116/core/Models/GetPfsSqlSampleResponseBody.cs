// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSampleResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The SQL sample data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPfsSqlSampleResponseBodyData> Data { get; set; }
        public class GetPfsSqlSampleResponseBodyData : TeaModel {
            /// <summary>
            /// The number of internal on-disk temporary tables that were created when the SQL statement was executed.
            /// </summary>
            [NameInMap("CreateTmpDiskTables")]
            [Validation(Required=false)]
            public int? CreateTmpDiskTables { get; set; }

            /// <summary>
            /// The number of internal temporary tables that were created when the SQL statement was executed.
            /// </summary>
            [NameInMap("CreateTmpTables")]
            [Validation(Required=false)]
            public int? CreateTmpTables { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Db")]
            [Validation(Required=false)]
            public string Db { get; set; }

            /// <summary>
            /// The end ID of the event. By default, the value of this parameter is NULL when the event starts and is changed to the event ID when the event ends.
            /// </summary>
            [NameInMap("EndEventId")]
            [Validation(Required=false)]
            public int? EndEventId { get; set; }

            /// <summary>
            /// The number of errors returned for the SQL statement.
            /// </summary>
            [NameInMap("Errors")]
            [Validation(Required=false)]
            public int? Errors { get; set; }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public int? EventId { get; set; }

            /// <summary>
            /// The name of the event.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The execution duration. Unit: millisecond.
            /// </summary>
            [NameInMap("Latency")]
            [Validation(Required=false)]
            public double? Latency { get; set; }

            /// <summary>
            /// The lock wait duration. Unit: millisecond.
            /// </summary>
            [NameInMap("LockLatency")]
            [Validation(Required=false)]
            public double? LockLatency { get; set; }

            /// <summary>
            /// The ID of the logical database.
            /// </summary>
            [NameInMap("LogicId")]
            [Validation(Required=false)]
            public string LogicId { get; set; }

            /// <summary>
            /// Indicates whether the server failed to find an index that can be used for the SQL statement. Valid values:
            /// 
            /// *   **1**: yes.
            /// *   **0**: no.
            /// </summary>
            [NameInMap("NoGoodIndexUsed")]
            [Validation(Required=false)]
            public int? NoGoodIndexUsed { get; set; }

            /// <summary>
            /// Indicates whether table scans were performed when indexes were not used. Valid values:
            /// 
            /// *   **1**: yes.
            /// *   **0**: no.
            /// </summary>
            [NameInMap("NoIndexUsed")]
            [Validation(Required=false)]
            public int? NoIndexUsed { get; set; }

            /// <summary>
            /// The node ID.
            /// 
            /// >  This parameter is returned only for ApsaraDB RDS for MySQL Cluster Edition instances or PolarDB for MySQL clusters.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The number of rows affected by the SQL statement.
            /// </summary>
            [NameInMap("RowsAffected")]
            [Validation(Required=false)]
            public int? RowsAffected { get; set; }

            /// <summary>
            /// The number of rows scanned by the SQL statement.
            /// </summary>
            [NameInMap("RowsExamined")]
            [Validation(Required=false)]
            public int? RowsExamined { get; set; }

            /// <summary>
            /// The number of rows returned by the SQL statement.
            /// </summary>
            [NameInMap("RowsSent")]
            [Validation(Required=false)]
            public int? RowsSent { get; set; }

            /// <summary>
            /// The number of joins that are used to perform table scans without using indexes.
            /// 
            /// > : This parameter is used for the scenario in which indexes are not used in a union query. If the returned value is not 0, check the indexes of tables.
            /// </summary>
            [NameInMap("SelectFullJoin")]
            [Validation(Required=false)]
            public int? SelectFullJoin { get; set; }

            /// <summary>
            /// The number of joins that used ranges on referenced tables.
            /// </summary>
            [NameInMap("SelectFullRangeJoin")]
            [Validation(Required=false)]
            public int? SelectFullRangeJoin { get; set; }

            /// <summary>
            /// The number of joins that used ranges on the first table.
            /// </summary>
            [NameInMap("SelectRange")]
            [Validation(Required=false)]
            public int? SelectRange { get; set; }

            /// <summary>
            /// The number of joins that did not have key values. The keys and values were checked for each row of data.
            /// 
            /// > : This parameter is used for the scenario in which indexes are not used in a union query. If the returned value is not 0, check the indexes of tables.
            /// </summary>
            [NameInMap("SelectRangeCheck")]
            [Validation(Required=false)]
            public int? SelectRangeCheck { get; set; }

            /// <summary>
            /// The number of scans.
            /// </summary>
            [NameInMap("SelectScan")]
            [Validation(Required=false)]
            public int? SelectScan { get; set; }

            /// <summary>
            /// The number of merges that the sorting algorithm must perform.
            /// </summary>
            [NameInMap("SortMergePasses")]
            [Validation(Required=false)]
            public int? SortMergePasses { get; set; }

            /// <summary>
            /// The number of times the data was sorted by using ranges.
            /// </summary>
            [NameInMap("SortRange")]
            [Validation(Required=false)]
            public int? SortRange { get; set; }

            /// <summary>
            /// The number of sorted rows.
            /// </summary>
            [NameInMap("SortRows")]
            [Validation(Required=false)]
            public int? SortRows { get; set; }

            /// <summary>
            /// The number of sorts that were performed during table scans.
            /// </summary>
            [NameInMap("SortScan")]
            [Validation(Required=false)]
            public int? SortScan { get; set; }

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
            /// The thread ID.
            /// </summary>
            [NameInMap("ThreadId")]
            [Validation(Required=false)]
            public int? ThreadId { get; set; }

            /// <summary>
            /// The time when the SQL statement was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The number of warnings returned for the SQL statement.
            /// </summary>
            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public int? Warnings { get; set; }

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
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
