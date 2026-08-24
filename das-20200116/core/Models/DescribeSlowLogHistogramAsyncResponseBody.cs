// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogHistogramAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>AsyncResult<Histogram>。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogHistogramAsyncResponseBodyData Data { get; set; }
        public class DescribeSlowLogHistogramAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogHistogramAsyncResponseBodyDataData Data { get; set; }
            public class DescribeSlowLogHistogramAsyncResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The average CPU processing duration. Unit: seconds (s).</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgCPUTime")]
                [Validation(Required=false)]
                public List<double?> AvgCPUTime { get; set; }

                /// <summary>
                /// <para>The average number of document rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgDocExamined")]
                [Validation(Required=false)]
                public List<double?> AvgDocExamined { get; set; }

                /// <summary>
                /// <para>The average number of rows fetched.</para>
                /// </summary>
                [NameInMap("AvgFrows")]
                [Validation(Required=false)]
                public List<double?> AvgFrows { get; set; }

                /// <summary>
                /// <para>The average number of I/O writes.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgIOWrites")]
                [Validation(Required=false)]
                public List<double?> AvgIOWrites { get; set; }

                /// <summary>
                /// <para>The average number of index rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgKeysExamined")]
                [Validation(Required=false)]
                public List<double?> AvgKeysExamined { get; set; }

                /// <summary>
                /// <para>The average number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgLastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The average lock wait time. Unit: seconds.</para>
                /// </summary>
                [NameInMap("AvgLockTime")]
                [Validation(Required=false)]
                public List<double?> AvgLockTime { get; set; }

                /// <summary>
                /// <para>The average number of logical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgLogicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgLogicalIOReads { get; set; }

                /// <summary>
                /// <para>The average number of physical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgPhysicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgPhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The average number of rows returned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgReturnNum")]
                [Validation(Required=false)]
                public List<double?> AvgReturnNum { get; set; }

                /// <summary>
                /// <para>The average number of rows.</para>
                /// </summary>
                [NameInMap("AvgRows")]
                [Validation(Required=false)]
                public List<double?> AvgRows { get; set; }

                /// <summary>
                /// <para>The average number of rows affected.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The average number of rows scanned.</para>
                /// </summary>
                [NameInMap("AvgRowsExamined")]
                [Validation(Required=false)]
                public List<double?> AvgRowsExamined { get; set; }

                /// <summary>
                /// <para>The average number of rows returned.</para>
                /// </summary>
                [NameInMap("AvgRowsSent")]
                [Validation(Required=false)]
                public List<double?> AvgRowsSent { get; set; }

                /// <summary>
                /// <para>The average execution duration.</para>
                /// </summary>
                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public List<double?> AvgRt { get; set; }

                /// <summary>
                /// <para>The average number of requests.</para>
                /// </summary>
                [NameInMap("AvgScnt")]
                [Validation(Required=false)]
                public List<double?> AvgScnt { get; set; }

                /// <summary>
                /// <para>The CPU processing duration. Unit: seconds (s).</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CPUTime")]
                [Validation(Required=false)]
                public List<double?> CPUTime { get; set; }

                /// <summary>
                /// <para>The slow log count trend.</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public List<long?> Count { get; set; }

                /// <summary>
                /// <para>The number of document rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DocExamined")]
                [Validation(Required=false)]
                public List<long?> DocExamined { get; set; }

                /// <summary>
                /// <para>The number of rows fetched by the compute node (CN) of the PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Frows")]
                [Validation(Required=false)]
                public List<long?> Frows { get; set; }

                /// <summary>
                /// <para>The number of I/O writes.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("IOWrites")]
                [Validation(Required=false)]
                public List<long?> IOWrites { get; set; }

                /// <summary>
                /// <para>The trend metrics.</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<DescribeSlowLogHistogramAsyncResponseBodyDataDataItem> Item { get; set; }
                public class DescribeSlowLogHistogramAsyncResponseBodyDataDataItem : TeaModel {
                    /// <summary>
                    /// <para>The number of slow logs.</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public List<long?> Count { get; set; }

                    /// <summary>
                    /// <para>The trend metrics.</para>
                    /// <remarks>
                    /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("InsItems")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogHistogramAsyncResponseBodyDataDataItemInsItems> InsItems { get; set; }
                    public class DescribeSlowLogHistogramAsyncResponseBodyDataDataItemInsItems : TeaModel {
                        /// <summary>
                        /// <para>The number of executions.</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public List<long?> Count { get; set; }

                        /// <summary>
                        /// <para>The instance role ID.</para>
                        /// <remarks>
                        /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2492</para>
                        /// </summary>
                        [NameInMap("InsId")]
                        [Validation(Required=false)]
                        public string InsId { get; set; }

                        /// <summary>
                        /// <para>The instance role.</para>
                        /// <remarks>
                        /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userAdmin</para>
                        /// </summary>
                        [NameInMap("InsRole")]
                        [Validation(Required=false)]
                        public string InsRole { get; set; }

                        /// <summary>
                        /// <para>The number of slow logs on the physical node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("TotalCount")]
                        [Validation(Required=false)]
                        public long? TotalCount { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance role.</para>
                    /// <remarks>
                    /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("InsRole")]
                    [Validation(Required=false)]
                    public string InsRole { get; set; }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-bp1hi0wg57s3n0i3n8-db-0</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The total number of slow logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                }

                /// <summary>
                /// <para>The number of index rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public List<long?> KeysExamined { get; set; }

                /// <summary>
                /// <para>The number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("LastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> LastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The total lock wait time. Unit: seconds.</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public List<double?> LockTime { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("LogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> LogicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum CPU processing duration. Unit: seconds (s).</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxCPUTime")]
                [Validation(Required=false)]
                public List<double?> MaxCPUTime { get; set; }

                /// <summary>
                /// <para>The maximum number of document rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxDocExamined")]
                [Validation(Required=false)]
                public List<long?> MaxDocExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of rows fetched.</para>
                /// </summary>
                [NameInMap("MaxFrows")]
                [Validation(Required=false)]
                public List<long?> MaxFrows { get; set; }

                /// <summary>
                /// <para>The maximum number of I/O writes.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxIOWrites")]
                [Validation(Required=false)]
                public List<long?> MaxIOWrites { get; set; }

                /// <summary>
                /// <para>The maximum number of index rows scanned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxKeysExamined")]
                [Validation(Required=false)]
                public List<long?> MaxKeysExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxLastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The maximum lock wait time. Unit: seconds.</para>
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public List<double?> MaxLockTime { get; set; }

                /// <summary>
                /// <para>The maximum number of logical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxLogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxLogicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum number of physical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxPhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxPhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum number of rows returned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxReturnNum")]
                [Validation(Required=false)]
                public List<long?> MaxReturnNum { get; set; }

                /// <summary>
                /// <para>The maximum number of rows.</para>
                /// </summary>
                [NameInMap("MaxRows")]
                [Validation(Required=false)]
                public List<long?> MaxRows { get; set; }

                /// <summary>
                /// <para>The maximum number of rows affected.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The maximum number of rows scanned.</para>
                /// </summary>
                [NameInMap("MaxRowsExamined")]
                [Validation(Required=false)]
                public List<long?> MaxRowsExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of rows returned.</para>
                /// </summary>
                [NameInMap("MaxRowsSent")]
                [Validation(Required=false)]
                public List<long?> MaxRowsSent { get; set; }

                /// <summary>
                /// <para>The maximum execution duration. Unit: seconds.</para>
                /// </summary>
                [NameInMap("MaxRt")]
                [Validation(Required=false)]
                public List<double?> MaxRt { get; set; }

                /// <summary>
                /// <para>The maximum number of requests.</para>
                /// </summary>
                [NameInMap("MaxScnt")]
                [Validation(Required=false)]
                public List<long?> MaxScnt { get; set; }

                /// <summary>
                /// <para>The number of physical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> PhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// <remarks>
                /// <para>Supported only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ReturnNum")]
                [Validation(Required=false)]
                public List<long?> ReturnNum { get; set; }

                /// <summary>
                /// <para>The total number of rows updated or returned by compute nodes of the PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<long?> Rows { get; set; }

                /// <summary>
                /// <para>The number of rows affected.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> RowsCountAffected { get; set; }

                /// <summary>
                /// <para>The total number of rows scanned.</para>
                /// <remarks>
                /// <para>Databases that currently support this field: ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public List<long?> RowsExamined { get; set; }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public List<long?> RowsSent { get; set; }

                /// <summary>
                /// <para>The total execution duration. Unit: seconds.</para>
                /// </summary>
                [NameInMap("Rt")]
                [Validation(Required=false)]
                public List<double?> Rt { get; set; }

                /// <summary>
                /// <para>The number of DN requests from the compute node (CN) of the PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public List<long?> Scnt { get; set; }

                /// <summary>
                /// <para>The total number of records queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                /// <summary>
                /// <para>The total number of slow query logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <para>Used only for relational databases.</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public List<long?> Ts { get; set; }

                /// <summary>
                /// <para>Not used. Reserved field.</para>
                /// </summary>
                [NameInMap("TsEnd")]
                [Validation(Required=false)]
                public List<long?> TsEnd { get; set; }

            }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The key of the request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <para>The result ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__20ee808e72257f16a4fe024057ca****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The current state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>SUCCESS</b>: Succeeded.</description></item>
            /// <item><description><b>FAIL</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The request time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645668213000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para> This parameter returns <b>Successful</b> when the request succeeds. If the request fails, an exception message (such as an error code) is returned.</para>
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
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
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
        public string Success { get; set; }

    }

}
