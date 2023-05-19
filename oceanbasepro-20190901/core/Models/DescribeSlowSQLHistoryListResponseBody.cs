// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSlowSQLHistoryListResponseBody : TeaModel {
        /// <summary>
        /// The end time of the time range for querying the execution history of the slow SQL statement.   
        /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Hard parsing time。
        /// </summary>
        [NameInMap("SlowSQLHistoryList")]
        [Validation(Required=false)]
        public DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList SlowSQLHistoryList { get; set; }
        public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryList : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The SQL ID, which uniquely identifies an SQL statement.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList> List { get; set; }
            public class DescribeSlowSQLHistoryListResponseBodySlowSQLHistoryListList : TeaModel {
                /// <summary>
                /// The wait event.
                /// </summary>
                [NameInMap("AffectedRows")]
                [Validation(Required=false)]
                public double? AffectedRows { get; set; }

                /// <summary>
                /// The number of row cache hits.
                /// </summary>
                [NameInMap("AppWaitTime")]
                [Validation(Required=false)]
                public double? AppWaitTime { get; set; }

                /// <summary>
                /// The average CPU time.
                /// </summary>
                [NameInMap("BlockCacheHit")]
                [Validation(Required=false)]
                public double? BlockCacheHit { get; set; }

                /// <summary>
                /// The number of rows to return on each page.  
                /// - Maximum value: 100   
                /// - Default value: 10
                /// </summary>
                [NameInMap("BlockIndexCacheHit")]
                [Validation(Required=false)]
                public double? BlockIndexCacheHit { get; set; }

                /// <summary>
                /// The number of executions.
                /// </summary>
                [NameInMap("BloomFilterCacheHit")]
                [Validation(Required=false)]
                public double? BloomFilterCacheHit { get; set; }

                /// <summary>
                /// The number of retries.
                /// </summary>
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                /// <summary>
                /// $.parameters[6].schema.example
                /// </summary>
                [NameInMap("ConcurrencyWaitTime")]
                [Validation(Required=false)]
                public double? ConcurrencyWaitTime { get; set; }

                /// <summary>
                /// $.parameters[6].schema.enumValueTitles
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// The IP address of the node.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// $.parameters[7].schema.description
                /// </summary>
                [NameInMap("DecodeTime")]
                [Validation(Required=false)]
                public double? DecodeTime { get; set; }

                /// <summary>
                /// SQLID.
                /// </summary>
                [NameInMap("DiskRead")]
                [Validation(Required=false)]
                public double? DiskRead { get; set; }

                /// <summary>
                /// The queuing time.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                [NameInMap("EndTimeUTCString")]
                [Validation(Required=false)]
                public string EndTimeUTCString { get; set; }

                /// <summary>
                /// The internal wait time.
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// The number of failures.
                /// </summary>
                [NameInMap("ExecPerSecond")]
                [Validation(Required=false)]
                public double? ExecPerSecond { get; set; }

                /// <summary>
                /// The request ID.
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public double? ExecuteTime { get; set; }

                /// <summary>
                /// The maximum CPU time.
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                /// <summary>
                /// The number of rows returned.
                /// </summary>
                [NameInMap("FailTimes")]
                [Validation(Required=false)]
                public double? FailTimes { get; set; }

                /// <summary>
                /// Example 1
                /// </summary>
                [NameInMap("GetPlanTime")]
                [Validation(Required=false)]
                public double? GetPlanTime { get; set; }

                /// <summary>
                /// $.parameters[7].schema.enumValueTitles
                /// </summary>
                [NameInMap("IOWaitTime")]
                [Validation(Required=false)]
                public double? IOWaitTime { get; set; }

                /// <summary>
                /// The quantity.
                /// </summary>
                [NameInMap("LogicalRead")]
                [Validation(Required=false)]
                public double? LogicalRead { get; set; }

                /// <summary>
                /// DescribeSlowSQLHistoryList
                /// </summary>
                [NameInMap("MaxCpuTime")]
                [Validation(Required=false)]
                public double? MaxCpuTime { get; set; }

                /// <summary>
                /// ```
                /// http(s)://[Endpoint]/?Action=DescribeSlowSQLHistoryList
                /// &TenantId=t384tolsj****
                /// &StartTime=2021-12-14T02:34:49Z
                /// &EndTime=2021-12-14T08:34:49Z
                /// &SQLId=8D6E84735C0****1823D199E2CA1****
                /// &PageNumber=1
                /// &PageSize=10
                /// &Common request parameters
                /// ```
                /// </summary>
                [NameInMap("MaxElapsedTime")]
                [Validation(Required=false)]
                public double? MaxElapsedTime { get; set; }

                /// <summary>
                /// The wait time of the client.
                /// </summary>
                [NameInMap("MemstoreReadRowCount")]
                [Validation(Required=false)]
                public double? MemstoreReadRowCount { get; set; }

                /// <summary>
                /// The number of rows read from the disk.
                /// </summary>
                [NameInMap("MissPlans")]
                [Validation(Required=false)]
                public double? MissPlans { get; set; }

                /// <summary>
                /// $.parameters[7].schema.example
                /// </summary>
                [NameInMap("NetWaitTime")]
                [Validation(Required=false)]
                public double? NetWaitTime { get; set; }

                /// <summary>
                /// The number of the page to return.    
                /// - Start value: 1   
                /// - Default value: 1
                /// </summary>
                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                /// <summary>
                /// $.parameters[6].schema.description
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public double? QueueTime { get; set; }

                /// <summary>
                /// The end time.
                /// </summary>
                [NameInMap("RPCCount")]
                [Validation(Required=false)]
                public double? RPCCount { get; set; }

                /// <summary>
                /// The time to wait for decoding.
                /// </summary>
                [NameInMap("RemotePlans")]
                [Validation(Required=false)]
                public double? RemotePlans { get; set; }

                /// <summary>
                /// The number of block index cache hits.
                /// </summary>
                [NameInMap("RetryCount")]
                [Validation(Required=false)]
                public double? RetryCount { get; set; }

                /// <summary>
                /// The number of executions per second.
                /// </summary>
                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public double? ReturnRows { get; set; }

                /// <summary>
                /// The execution history of the slow SQL statement.
                /// </summary>
                [NameInMap("RowCacheHit")]
                [Validation(Required=false)]
                public double? RowCacheHit { get; set; }

                /// <summary>
                /// You can call this operation to query the execution history of an SQL statement by SQL ID that is determined as a slow SQL statement during a specified period of time.
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public double? ScheduleTime { get; set; }

                /// <summary>
                /// The return result of the request.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// The scheduling duration.
                /// </summary>
                [NameInMap("SsstoreReadRowCount")]
                [Validation(Required=false)]
                public double? SsstoreReadRowCount { get; set; }

                /// <summary>
                /// The return result of the request.
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public double? TotalWaitTime { get; set; }

                /// <summary>
                /// The number of physical reads.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
