// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTopSQLListResponseBody : TeaModel {
        /// <summary>
        /// Alibaba Cloud CLI
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The I/O wait time, in ms.
        /// </summary>
        [NameInMap("TopSQLList")]
        [Validation(Required=false)]
        public List<DescribeTopSQLListResponseBodyTopSQLList> TopSQLList { get; set; }
        public class DescribeTopSQLListResponseBodyTopSQLList : TeaModel {
            /// <summary>
            /// The internal wait time, in ms.
            /// </summary>
            [NameInMap("AffectedRows")]
            [Validation(Required=false)]
            public long? AffectedRows { get; set; }

            /// <summary>
            /// The wait time in concurrent execution, in ms.
            /// </summary>
            [NameInMap("AppWaitTime")]
            [Validation(Required=false)]
            public float? AppWaitTime { get; set; }

            /// <summary>
            /// The average CPU time, in ms.
            /// </summary>
            [NameInMap("BlockCacheHit")]
            [Validation(Required=false)]
            public long? BlockCacheHit { get; set; }

            /// <summary>
            /// $.parameters[16].schema.example
            /// </summary>
            [NameInMap("BlockIndexCacheHit")]
            [Validation(Required=false)]
            public long? BlockIndexCacheHit { get; set; }

            /// <summary>
            /// $.parameters[14].schema.enumValueTitles
            /// </summary>
            [NameInMap("BloomFilterCacheHit")]
            [Validation(Required=false)]
            public long? BloomFilterCacheHit { get; set; }

            /// <summary>
            /// $.parameters[14].schema.description
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The number of rows returned.
            /// </summary>
            [NameInMap("ConcurrencyWaitTime")]
            [Validation(Required=false)]
            public float? ConcurrencyWaitTime { get; set; }

            /// <summary>
            /// The maximum CPU time, in ms.
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public float? CpuTime { get; set; }

            /// <summary>
            /// The number of remote plans.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The number of rows to return on each page.   
            /// - Maximum value: 100   
            /// - Default value: 10
            /// </summary>
            [NameInMap("DecodeTime")]
            [Validation(Required=false)]
            public float? DecodeTime { get; set; }

            /// <summary>
            /// The IP address of the client.
            /// </summary>
            [NameInMap("DiskRead")]
            [Validation(Required=false)]
            public long? DiskRead { get; set; }

            /// <summary>
            /// The sorting rule.
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public float? ElapsedTime { get; set; }

            /// <summary>
            /// The number of rows read from the disk.
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public string Event { get; set; }

            /// <summary>
            /// The operation that you want to perform.   
            /// Set the value to **DescribeTopSQLList**.
            /// </summary>
            [NameInMap("ExecPerSecond")]
            [Validation(Required=false)]
            public float? ExecPerSecond { get; set; }

            /// <summary>
            /// The number of rows read from the memory.
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public float? ExecuteTime { get; set; }

            /// <summary>
            /// The number of executions per second.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public long? Executions { get; set; }

            /// <summary>
            /// $.parameters[12].schema.description
            /// </summary>
            [NameInMap("FailTimes")]
            [Validation(Required=false)]
            public long? FailTimes { get; set; }

            /// <summary>
            /// The queuing time, in ms.
            /// </summary>
            [NameInMap("GetPlanTime")]
            [Validation(Required=false)]
            public float? GetPlanTime { get; set; }

            /// <summary>
            /// $.parameters[15].schema.example
            /// </summary>
            [NameInMap("IOWaitTime")]
            [Validation(Required=false)]
            public float? IOWaitTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public long? Key { get; set; }

            /// <summary>
            /// You can call this operation to query SQL execution performance data collected by the diagnostic system.
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public long? LogicalRead { get; set; }

            /// <summary>
            /// SQLID.
            /// </summary>
            [NameInMap("MaxCpuTime")]
            [Validation(Required=false)]
            public float? MaxCpuTime { get; set; }

            /// <summary>
            /// The sequence number of the returned SQL statement.
            /// </summary>
            [NameInMap("MaxElapsedTime")]
            [Validation(Required=false)]
            public float? MaxElapsedTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("MemstoreReadRowCount")]
            [Validation(Required=false)]
            public long? MemstoreReadRowCount { get; set; }

            /// <summary>
            /// The total count.
            /// </summary>
            [NameInMap("MissPlans")]
            [Validation(Required=false)]
            public long? MissPlans { get; set; }

            /// <summary>
            /// The end time of the time range for querying TOP SQL statements.   
            /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
            /// </summary>
            [NameInMap("NetWaitTime")]
            [Validation(Required=false)]
            public float? NetWaitTime { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// $.parameters[12].schema.enumValueTitles
            /// </summary>
            [NameInMap("QueueTime")]
            [Validation(Required=false)]
            public float? QueueTime { get; set; }

            /// <summary>
            /// The start time of the time range for querying TOP SQL statements.   
            /// The value must be UTC time in the format of YYYY-MM-DDThh:mm:ssZ.
            /// </summary>
            [NameInMap("RPCCount")]
            [Validation(Required=false)]
            public long? RPCCount { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("RemotePlans")]
            [Validation(Required=false)]
            public long? RemotePlans { get; set; }

            /// <summary>
            /// $.parameters[13].schema.description
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public long? RetryCount { get; set; }

            /// <summary>
            /// The wait event.
            /// </summary>
            [NameInMap("ReturnRows")]
            [Validation(Required=false)]
            public long? ReturnRows { get; set; }

            /// <summary>
            /// ```
            /// http(s)://[Endpoint]/?Action=DescribeTopSQLList
            /// &TenantId=t2mr3oae0****
            /// &StartTime=2021-06-13 15:40:43
            /// &EndTime=2021-09-13 15:40:43
            /// &DbName=testdb
            /// &SearchKeyWord=update
            /// &SearchParameter=cputime
            /// &SearchRule=>
            /// &SearchValue=0.01
            /// &SQLId=8D6E84****0B8FB1823D199E2CA1****
            /// &NodeIp=i-bp19y05uq6xpacyqnlrc
            /// &PageNumber=1
            /// &PageSize=10
            /// &SortColumn=cputime
            /// &SortOrder=desc
            /// &Common request parameters
            /// ```
            /// </summary>
            [NameInMap("RowCacheHit")]
            [Validation(Required=false)]
            public long? RowCacheHit { get; set; }

            /// <summary>
            /// $.parameters[13].schema.example
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public string SQLId { get; set; }

            /// <summary>
            /// The list of top SQL statements.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public long? SQLType { get; set; }

            /// <summary>
            /// The search keyword.
            /// </summary>
            [NameInMap("ScheduleTime")]
            [Validation(Required=false)]
            public float? ScheduleTime { get; set; }

            [NameInMap("SsstoreReadRowCount")]
            [Validation(Required=false)]
            public long? SsstoreReadRowCount { get; set; }

            /// <summary>
            /// -
            /// </summary>
            [NameInMap("TotalWaitTime")]
            [Validation(Required=false)]
            public float? TotalWaitTime { get; set; }

            /// <summary>
            /// The number of Bloom filter cache hits.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// It is an online CLI tool that allows you to quickly retrieve and debug APIs. It can dynamically generate executable SDK code samples.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
