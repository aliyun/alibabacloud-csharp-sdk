// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogHistogramAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed data of the asynchronous task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogHistogramAsyncResponseBodyData Data { get; set; }
        public class DescribeSlowLogHistogramAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogHistogramAsyncResponseBodyDataData Data { get; set; }
            public class DescribeSlowLogHistogramAsyncResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The average CPU time, in seconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgCPUTime")]
                [Validation(Required=false)]
                public List<double?> AvgCPUTime { get; set; }

                /// <summary>
                /// <para>The average number of scanned documents.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgDocExamined")]
                [Validation(Required=false)]
                public List<double?> AvgDocExamined { get; set; }

                /// <summary>
                /// <para>The average number of pulled rows.</para>
                /// </summary>
                [NameInMap("AvgFrows")]
                [Validation(Required=false)]
                public List<double?> AvgFrows { get; set; }

                /// <summary>
                /// <para>The average number of I/O writes.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgIOWrites")]
                [Validation(Required=false)]
                public List<double?> AvgIOWrites { get; set; }

                /// <summary>
                /// <para>The average number of scanned index rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgKeysExamined")]
                [Validation(Required=false)]
                public List<double?> AvgKeysExamined { get; set; }

                /// <summary>
                /// <para>The average number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgLastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The average lock wait duration, in seconds.</para>
                /// </summary>
                [NameInMap("AvgLockTime")]
                [Validation(Required=false)]
                public List<double?> AvgLockTime { get; set; }

                /// <summary>
                /// <para>The average number of logical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgLogicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgLogicalIOReads { get; set; }

                /// <summary>
                /// <para>The average number of physical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgPhysicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgPhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The average number of returned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
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
                /// <para>The average number of affected rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("AvgRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The average number of scanned rows.</para>
                /// </summary>
                [NameInMap("AvgRowsExamined")]
                [Validation(Required=false)]
                public List<double?> AvgRowsExamined { get; set; }

                /// <summary>
                /// <para>The average number of returned rows.</para>
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
                /// <para>The CPU time, in seconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CPUTime")]
                [Validation(Required=false)]
                public List<double?> CPUTime { get; set; }

                /// <summary>
                /// <para>The number of slow query logs in the trend chart.</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public List<long?> Count { get; set; }

                /// <summary>
                /// <para>The number of scanned documents.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DocExamined")]
                [Validation(Required=false)]
                public List<long?> DocExamined { get; set; }

                /// <summary>
                /// <para>The number of rows pulled by the compute nodes (CNs) of a PolarDB-X 2.0 instance.</para>
                /// <remarks>
                /// <para>This parameter is returned only for PolarDB-X 2.0 instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Frows")]
                [Validation(Required=false)]
                public List<long?> Frows { get; set; }

                /// <summary>
                /// <para>The number of I/O writes.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
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
                    /// <para>The number of slow query logs.</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public List<long?> Count { get; set; }

                    /// <summary>
                    /// <para>The trend metrics.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
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
                        /// <para>The ID of the instance role.</para>
                        /// <remarks>
                        /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2492</para>
                        /// </summary>
                        [NameInMap("InsId")]
                        [Validation(Required=false)]
                        public string InsId { get; set; }

                        /// <summary>
                        /// <para>The role of the instance.</para>
                        /// <remarks>
                        /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>userAdmin</para>
                        /// </summary>
                        [NameInMap("InsRole")]
                        [Validation(Required=false)]
                        public string InsRole { get; set; }

                        /// <summary>
                        /// <para>The number of slow query logs on the physical node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("TotalCount")]
                        [Validation(Required=false)]
                        public long? TotalCount { get; set; }

                    }

                    /// <summary>
                    /// <para>The role of the instance.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
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
                    /// <para>The total number of slow query logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                }

                /// <summary>
                /// <para>The number of scanned index rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public List<long?> KeysExamined { get; set; }

                /// <summary>
                /// <para>The number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("LastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> LastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The total lock wait duration, in seconds.</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public List<double?> LockTime { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("LogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> LogicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum CPU time, in seconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxCPUTime")]
                [Validation(Required=false)]
                public List<double?> MaxCPUTime { get; set; }

                /// <summary>
                /// <para>The maximum number of scanned documents.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxDocExamined")]
                [Validation(Required=false)]
                public List<long?> MaxDocExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of pulled rows.</para>
                /// </summary>
                [NameInMap("MaxFrows")]
                [Validation(Required=false)]
                public List<long?> MaxFrows { get; set; }

                /// <summary>
                /// <para>The maximum number of I/O writes.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxIOWrites")]
                [Validation(Required=false)]
                public List<long?> MaxIOWrites { get; set; }

                /// <summary>
                /// <para>The maximum number of scanned index rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxKeysExamined")]
                [Validation(Required=false)]
                public List<long?> MaxKeysExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxLastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The maximum lock wait duration, in seconds.</para>
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public List<double?> MaxLockTime { get; set; }

                /// <summary>
                /// <para>The maximum number of logical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxLogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxLogicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum number of physical reads.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxPhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxPhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The maximum number of returned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
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
                /// <para>The maximum number of affected rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MaxRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The maximum number of scanned rows.</para>
                /// </summary>
                [NameInMap("MaxRowsExamined")]
                [Validation(Required=false)]
                public List<long?> MaxRowsExamined { get; set; }

                /// <summary>
                /// <para>The maximum number of returned rows.</para>
                /// </summary>
                [NameInMap("MaxRowsSent")]
                [Validation(Required=false)]
                public List<long?> MaxRowsSent { get; set; }

                /// <summary>
                /// <para>The maximum execution duration, in seconds.</para>
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
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> PhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The number of returned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB for MongoDB instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ReturnNum")]
                [Validation(Required=false)]
                public List<long?> ReturnNum { get; set; }

                /// <summary>
                /// <para>The total number of updated or returned rows on the compute nodes of a PolarDB-X 2.0 instance.</para>
                /// <remarks>
                /// <para>This parameter is returned only for PolarDB-X 2.0 instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<long?> Rows { get; set; }

                /// <summary>
                /// <para>The number of affected rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for SQL Server instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> RowsCountAffected { get; set; }

                /// <summary>
                /// <para>The total number of scanned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned for the following database engines: ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public List<long?> RowsExamined { get; set; }

                /// <summary>
                /// <para>The number of returned rows.</para>
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public List<long?> RowsSent { get; set; }

                /// <summary>
                /// <para>The total execution duration, in seconds.</para>
                /// </summary>
                [NameInMap("Rt")]
                [Validation(Required=false)]
                public List<double?> Rt { get; set; }

                /// <summary>
                /// <para>The number of requests sent from the compute nodes (CNs) to the data nodes (DNs) of a PolarDB-X 2.0 instance.</para>
                /// <remarks>
                /// <para>This parameter is returned only for PolarDB-X 2.0 instances.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public List<long?> Scnt { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
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
                /// <para>This parameter is returned only for relational databases.</para>
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public List<long?> Ts { get; set; }

                /// <summary>
                /// <para>This parameter is reserved.</para>
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
            /// <para>Indicates whether the asynchronous task is complete.</para>
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
            /// <para>无</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <para>The ID of the asynchronous task result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__20ee808e72257f16a4fe024057ca****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The state of the asynchronous task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RUNNING</b>: The task is running.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: The task is successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>: The task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the request was made.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645668213000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
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
