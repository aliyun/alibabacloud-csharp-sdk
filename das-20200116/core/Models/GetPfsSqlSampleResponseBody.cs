// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The SQL sample data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetPfsSqlSampleResponseBodyData> Data { get; set; }
        public class GetPfsSqlSampleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of internal on-disk temporary tables that were created when the SQL statement was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CreateTmpDiskTables")]
            [Validation(Required=false)]
            public int? CreateTmpDiskTables { get; set; }

            /// <summary>
            /// <para>The number of internal temporary tables that were created when the SQL statement was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CreateTmpTables")]
            [Validation(Required=false)]
            public int? CreateTmpTables { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDB</para>
            /// </summary>
            [NameInMap("Db")]
            [Validation(Required=false)]
            public string Db { get; set; }

            /// <summary>
            /// <para>The end ID of the event. By default, the value of this parameter is NULL when the event starts and is changed to the event ID when the event ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EndEventId")]
            [Validation(Required=false)]
            public int? EndEventId { get; set; }

            /// <summary>
            /// <para>The number of errors returned for the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Errors")]
            [Validation(Required=false)]
            public int? Errors { get; set; }

            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63735293</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public int? EventId { get; set; }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>statement/sql/select</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1jdv45i7l6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The execution duration. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.199</para>
            /// </summary>
            [NameInMap("Latency")]
            [Validation(Required=false)]
            public double? Latency { get; set; }

            /// <summary>
            /// <para>The lock wait duration. Unit: millisecond.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.09</para>
            /// </summary>
            [NameInMap("LockLatency")]
            [Validation(Required=false)]
            public double? LockLatency { get; set; }

            /// <summary>
            /// <para>The ID of the logical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("LogicId")]
            [Validation(Required=false)]
            public string LogicId { get; set; }

            /// <summary>
            /// <para>Indicates whether the server failed to find an index that can be used for the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes.</description></item>
            /// <item><description><b>0</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoGoodIndexUsed")]
            [Validation(Required=false)]
            public int? NoGoodIndexUsed { get; set; }

            /// <summary>
            /// <para>Indicates whether table scans were performed when indexes were not used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes.</description></item>
            /// <item><description><b>0</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoIndexUsed")]
            [Validation(Required=false)]
            public int? NoIndexUsed { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// <remarks>
            /// <para> This parameter is returned only for ApsaraDB RDS for MySQL Cluster Edition instances or PolarDB for MySQL clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>r-x****-db-0</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The number of rows affected by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RowsAffected")]
            [Validation(Required=false)]
            public int? RowsAffected { get; set; }

            /// <summary>
            /// <para>The number of rows scanned by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048576</para>
            /// </summary>
            [NameInMap("RowsExamined")]
            [Validation(Required=false)]
            public int? RowsExamined { get; set; }

            /// <summary>
            /// <para>The number of rows returned by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RowsSent")]
            [Validation(Required=false)]
            public int? RowsSent { get; set; }

            /// <summary>
            /// <para>The number of joins that are used to perform table scans without using indexes.</para>
            /// <remarks>
            /// <para>: This parameter is used for the scenario in which indexes are not used in a union query. If the returned value is not 0, check the indexes of tables.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SelectFullJoin")]
            [Validation(Required=false)]
            public int? SelectFullJoin { get; set; }

            /// <summary>
            /// <para>The number of joins that used ranges on referenced tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SelectFullRangeJoin")]
            [Validation(Required=false)]
            public int? SelectFullRangeJoin { get; set; }

            /// <summary>
            /// <para>The number of joins that used ranges on the first table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SelectRange")]
            [Validation(Required=false)]
            public int? SelectRange { get; set; }

            /// <summary>
            /// <para>The number of joins that did not have key values. The keys and values were checked for each row of data.</para>
            /// <remarks>
            /// <para>: This parameter is used for the scenario in which indexes are not used in a union query. If the returned value is not 0, check the indexes of tables.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SelectRangeCheck")]
            [Validation(Required=false)]
            public int? SelectRangeCheck { get; set; }

            /// <summary>
            /// <para>The number of scans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SelectScan")]
            [Validation(Required=false)]
            public int? SelectScan { get; set; }

            /// <summary>
            /// <para>The number of merges that the sorting algorithm must perform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SortMergePasses")]
            [Validation(Required=false)]
            public int? SortMergePasses { get; set; }

            /// <summary>
            /// <para>The number of times the data was sorted by using ranges.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SortRange")]
            [Validation(Required=false)]
            public int? SortRange { get; set; }

            /// <summary>
            /// <para>The number of sorted rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SortRows")]
            [Validation(Required=false)]
            public int? SortRows { get; set; }

            /// <summary>
            /// <para>The number of sorts that were performed during table scans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SortScan")]
            [Validation(Required=false)]
            public int? SortScan { get; set; }

            /// <summary>
            /// <para>The sample SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from xxxx where ****</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The SQL statement ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>651b56fe9418d48edb8fdf0980ec****</para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <para>The thread ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81751940</para>
            /// </summary>
            [NameInMap("ThreadId")]
            [Validation(Required=false)]
            public int? ThreadId { get; set; }

            /// <summary>
            /// <para>The time when the SQL statement was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660100753556</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196278346919****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The number of warnings returned for the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Warnings")]
            [Validation(Required=false)]
            public int? Warnings { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9CB97BC4-6479-55D0-B9D0-EA925AFE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
