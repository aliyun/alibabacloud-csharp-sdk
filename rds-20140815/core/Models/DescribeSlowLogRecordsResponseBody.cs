// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about each slow log.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord> SQLSlowRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSQLSlowRecord : TeaModel {
                /// <summary>
                /// <para>The name of the application that is connected to the instance.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The hostname of the client.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("ClientHostName")]
                [Validation(Required=false)]
                public string ClientHostName { get; set; }

                /// <summary>
                /// <para>The duration during which the SQL statement is processed by the CPU. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.002</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The time when the execution of the SQL statement started. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-18T01:40:44Z</para>
                /// </summary>
                [NameInMap("ExecutionStartTime")]
                [Validation(Required=false)]
                public string ExecutionStartTime { get; set; }

                /// <summary>
                /// <para>The name and IP address of the client that is connected to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx[xxx] @  [1xx.xxx.xxx.xx]</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The number of rows that are affected by the last SQL statement.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LastRowsAffectedCount")]
                [Validation(Required=false)]
                public long? LastRowsAffectedCount { get; set; }

                /// <summary>
                /// <para>The lock duration of the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockTimes")]
                [Validation(Required=false)]
                public long? LockTimes { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>383</para>
                /// </summary>
                [NameInMap("LogicalIORead")]
                [Validation(Required=false)]
                public long? LogicalIORead { get; set; }

                /// <summary>
                /// <para>The number of parsed rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParseRowCounts")]
                [Validation(Required=false)]
                public long? ParseRowCounts { get; set; }

                /// <summary>
                /// <para>The number of physical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("PhysicalIORead")]
                [Validation(Required=false)]
                public long? PhysicalIORead { get; set; }

                /// <summary>
                /// <para>The execution duration of the query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001</para>
                /// </summary>
                [NameInMap("QueryTimeMS")]
                [Validation(Required=false)]
                public long? QueryTimeMS { get; set; }

                /// <summary>
                /// <para>The execution duration of the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QueryTimes")]
                [Validation(Required=false)]
                public long? QueryTimes { get; set; }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnRowCounts")]
                [Validation(Required=false)]
                public long? ReturnRowCounts { get; set; }

                /// <summary>
                /// <para>The number of affected rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("RowsAffectedCount")]
                [Validation(Required=false)]
                public long? RowsAffectedCount { get; set; }

                /// <summary>
                /// <para>The unique ID of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U2FsdGVk****</para>
                /// </summary>
                [NameInMap("SQLHash")]
                [Validation(Required=false)]
                public string SQLHash { get; set; }

                /// <summary>
                /// <para>The details of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select sleep(2)</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The name of the user.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The number of I/O writes.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("WriteIOCount")]
                [Validation(Required=false)]
                public long? WriteIOCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of SQL log reports on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DBB1BB0-E5D8-4D41-B1C9-142364DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
