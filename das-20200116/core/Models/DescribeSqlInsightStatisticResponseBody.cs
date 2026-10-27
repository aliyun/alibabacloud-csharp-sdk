// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlInsightStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The envelope for the asynchronous query result. The first call returns <b>ResultId</b> and <b>State</b>. You must poll the API with the exact same request parameters until <b>State</b> is <b>SUCCESS</b>, and then retrieve the statistical details from <b>List</b>.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlInsightStatisticResponseBodyData Data { get; set; }
        public class DescribeSqlInsightStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The SQL Explorer statistical query result.</para>
            /// <remarks>
            /// <para>Returned only when <b>State</b> is <b>SUCCESS</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSqlInsightStatisticResponseBodyDataData Data { get; set; }
            public class DescribeSqlInsightStatisticResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The extended information.</para>
                /// <remarks>
                /// <para>This operation does not return this field.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Extra")]
                [Validation(Required=false)]
                public object Extra { get; set; }

                /// <summary>
                /// <para>The list of SQL Explorer statistical results. Each element is a statistical entry under an aggregation dimension.</para>
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<DescribeSqlInsightStatisticResponseBodyDataDataList> List { get; set; }
                public class DescribeSqlInsightStatisticResponseBodyDataDataList : TeaModel {
                    /// <summary>
                    /// <para>The number of affected rows for a single SQL statement. For <b>SELECT</b> statements, this indicates the number of scanned rows. For <b>DML</b> statements, this indicates the number of affected rows.</para>
                    /// <remarks>
                    /// <para>Returned only for Lindorm instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("AffectRows")]
                    [Validation(Required=false)]
                    public long? AffectRows { get; set; }

                    /// <summary>
                    /// <para>The value of the aggregation dimension for the current statistics. This value varies based on the <b>Type</b> request parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>When aggregated by SQL template: the SQL template ID, which is the same as <b>SqlId</b>.</description></item>
                    /// <item><description>When <b>Type</b> is <b>FullRequestOrigin</b>: the source access address.</description></item>
                    /// <item><description>When <b>Type</b> is <b>FullRequestUser</b>: the database username.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>651b56fe9418d48edb8fdf0980ec****</para>
                    /// </summary>
                    [NameInMap("AggKey")]
                    [Validation(Required=false)]
                    public string AggKey { get; set; }

                    /// <summary>
                    /// <para>The average number of affected rows.</para>
                    /// <remarks>
                    /// <para>Returned only for Lindorm instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.2</para>
                    /// </summary>
                    [NameInMap("AvgAffectRows")]
                    [Validation(Required=false)]
                    public double? AvgAffectRows { get; set; }

                    /// <summary>
                    /// <para>The average CPU time consumed by SQL execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12.5</para>
                    /// </summary>
                    [NameInMap("AvgCpuTime")]
                    [Validation(Required=false)]
                    public double? AvgCpuTime { get; set; }

                    /// <summary>
                    /// <para>The average number of rows fetched by PolarDB-X compute nodes from data nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgFrows")]
                    [Validation(Required=false)]
                    public double? AvgFrows { get; set; }

                    /// <summary>
                    /// <para>The average lock wait time per execution, in milliseconds.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.00009589874265269765</para>
                    /// </summary>
                    [NameInMap("AvgLockWaitTime")]
                    [Validation(Required=false)]
                    public double? AvgLockWaitTime { get; set; }

                    /// <summary>
                    /// <para>The average number of logical reads per execution.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>654.4470327860251</para>
                    /// </summary>
                    [NameInMap("AvgLogicalRead")]
                    [Validation(Required=false)]
                    public double? AvgLogicalRead { get; set; }

                    /// <summary>
                    /// <para>The average number of physical asynchronous reads per execution.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalAsyncRead")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalAsyncRead { get; set; }

                    /// <summary>
                    /// <para>The average number of physical reads.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>654.4</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalRead")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The average number of physical synchronous reads per execution.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalSyncRead")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalSyncRead { get; set; }

                    /// <summary>
                    /// <para>The average number of updated and returned rows for PolarDB-X compute nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgRows")]
                    [Validation(Required=false)]
                    public double? AvgRows { get; set; }

                    /// <summary>
                    /// <para>The average number of scanned rows per execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsExamined")]
                    [Validation(Required=false)]
                    public double? AvgRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The average number of returned rows per execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("AvgRowsReturned")]
                    [Validation(Required=false)]
                    public double? AvgRowsReturned { get; set; }

                    /// <summary>
                    /// <para>The average number of updated rows per execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30.2</para>
                    /// </summary>
                    [NameInMap("AvgRowsUpdated")]
                    [Validation(Required=false)]
                    public double? AvgRowsUpdated { get; set; }

                    /// <summary>
                    /// <para>The average execution time per execution, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.499</para>
                    /// </summary>
                    [NameInMap("AvgRt")]
                    [Validation(Required=false)]
                    public double? AvgRt { get; set; }

                    /// <summary>
                    /// <para>The average number of scanned rows.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. To obtain the average number of scanned rows, use <b>AvgRowsExamined</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgScanRows")]
                    [Validation(Required=false)]
                    public double? AvgScanRows { get; set; }

                    /// <summary>
                    /// <para>The average number of requests sent from PolarDB-X compute nodes to data nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgScnt")]
                    [Validation(Required=false)]
                    public double? AvgScnt { get; set; }

                    /// <summary>
                    /// <para>The average number of logical writes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgWrites")]
                    [Validation(Required=false)]
                    public double? AvgWrites { get; set; }

                    /// <summary>
                    /// <para>The total number of executions for the SQL template within the statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>127</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The ratio of the number of times the SQL template in this entry is executed to the total number of times SQL statements execute on the instance. Valid values: 0 to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0586</para>
                    /// </summary>
                    [NameInMap("CountRate")]
                    [Validation(Required=false)]
                    public double? CountRate { get; set; }

                    /// <summary>
                    /// <para>The total CPU time consumed by SQL execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CpuTime")]
                    [Validation(Required=false)]
                    public long? CpuTime { get; set; }

                    /// <summary>
                    /// <para>The name of the database where the SQL statement is executed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dbtest01</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <para>The error code returned by the SQL execution.</para>
                    /// <remarks>
                    /// <para>Error codes belong to the details of a single SQL statement. This operation returns aggregated statistics at the template level and does not return this field. To check error occurrences, use <b>ErrorCount</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1146</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The number of execution errors for the SQL template within the statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ErrorCount")]
                    [Validation(Required=false)]
                    public long? ErrorCount { get; set; }

                    /// <summary>
                    /// <para>The time when the SQL template first appeared. The time is a UNIX timestamp in milliseconds.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1659308149000</para>
                    /// </summary>
                    [NameInMap("FirstTime")]
                    [Validation(Required=false)]
                    public long? FirstTime { get; set; }

                    /// <summary>
                    /// <para>The total number of rows fetched by PolarDB-X compute nodes from data nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Frows")]
                    [Validation(Required=false)]
                    public long? Frows { get; set; }

                    /// <summary>
                    /// <para>The hash value of the SQL template, returned together with the SQL template.</para>
                    /// <remarks>
                    /// <para>This value is generated by the kernel of PolarDB-X compute nodes. For instances that are not PolarDB-X compute nodes, the value is empty.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
                    /// </summary>
                    [NameInMap("Hash")]
                    [Validation(Required=false)]
                    public string Hash { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the instance to which the statistical data belongs.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the converged storage link of the instance. For some links, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-2ze1jdv45i7l6****.mysql.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <para>The total lock wait time, in milliseconds.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1089.4177720290281</para>
                    /// </summary>
                    [NameInMap("LockWaitTime")]
                    [Validation(Required=false)]
                    public double? LockWaitTime { get; set; }

                    /// <summary>
                    /// <para>The total number of logical reads.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165848</para>
                    /// </summary>
                    [NameInMap("LogicalRead")]
                    [Validation(Required=false)]
                    public double? LogicalRead { get; set; }

                    /// <summary>
                    /// <para>The maximum CPU time consumed in a single execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("MaxCpuTime")]
                    [Validation(Required=false)]
                    public long? MaxCpuTime { get; set; }

                    /// <summary>
                    /// <para>The maximum number of logical reads in a single execution.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3186</para>
                    /// </summary>
                    [NameInMap("MaxLogicalRead")]
                    [Validation(Required=false)]
                    public long? MaxLogicalRead { get; set; }

                    /// <summary>
                    /// <para>The maximum number of physical reads in a single execution.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3186</para>
                    /// </summary>
                    [NameInMap("MaxPhysicalRead")]
                    [Validation(Required=false)]
                    public long? MaxPhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The maximum number of scanned rows in a single execution.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. To obtain the number of scanned rows, use <b>RowsExamined</b> and <b>AvgRowsExamined</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>318613</para>
                    /// </summary>
                    [NameInMap("MaxRowsExamined")]
                    [Validation(Required=false)]
                    public long? MaxRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The maximum number of returned rows in a single execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("MaxRowsReturned")]
                    [Validation(Required=false)]
                    public long? MaxRowsReturned { get; set; }

                    /// <summary>
                    /// <para>The maximum execution time in a single execution, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12.499</para>
                    /// </summary>
                    [NameInMap("MaxRt")]
                    [Validation(Required=false)]
                    public double? MaxRt { get; set; }

                    /// <summary>
                    /// <para>The maximum number of logical writes in a single execution.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWrites")]
                    [Validation(Required=false)]
                    public long? MaxWrites { get; set; }

                    /// <summary>
                    /// <para>The minimum CPU time consumed in a single execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("MinCpuTime")]
                    [Validation(Required=false)]
                    public long? MinCpuTime { get; set; }

                    /// <summary>
                    /// <para>The minimum number of logical reads in a single execution.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MinLogicalRead")]
                    [Validation(Required=false)]
                    public long? MinLogicalRead { get; set; }

                    /// <summary>
                    /// <para>The minimum number of physical reads in a single execution.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MinPhysicalRead")]
                    [Validation(Required=false)]
                    public long? MinPhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The minimum number of returned rows in a single execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinRowsReturned")]
                    [Validation(Required=false)]
                    public long? MinRowsReturned { get; set; }

                    /// <summary>
                    /// <para>The minimum execution time in a single execution, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.409789</para>
                    /// </summary>
                    [NameInMap("MinRt")]
                    [Validation(Required=false)]
                    public double? MinRt { get; set; }

                    /// <summary>
                    /// <para>The minimum number of logical writes in a single execution.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("MinWrites")]
                    [Validation(Required=false)]
                    public long? MinWrites { get; set; }

                    /// <summary>
                    /// <para>The display alias configured for the source access address.</para>
                    /// <remarks>
                    /// <para>Returned only when aggregated by access source (when <b>Type</b> is <b>FullRequestOrigin</b>). In other scenarios, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>order-1</para>
                    /// </summary>
                    [NameInMap("OriginAlias")]
                    [Validation(Required=false)]
                    public string OriginAlias { get; set; }

                    /// <summary>
                    /// <para>The source address of the client that initiated the SQL statement.</para>
                    /// <remarks>
                    /// <para>When <b>Type</b> is <b>FullRequestOrigin</b>, this field is the aggregation dimension for the statistics.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.26.XX.XXX</para>
                    /// </summary>
                    [NameInMap("OriginHost")]
                    [Validation(Required=false)]
                    public string OriginHost { get; set; }

                    /// <summary>
                    /// <para>The parameter content of the SQL sample.</para>
                    /// <remarks>
                    /// <para>This operation returns aggregated statistics at the template level and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[1, &quot;das&quot;]</para>
                    /// </summary>
                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public string Params { get; set; }

                    /// <summary>
                    /// <para>The total number of physical asynchronous reads.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PhysicalAsyncRead")]
                    [Validation(Required=false)]
                    public double? PhysicalAsyncRead { get; set; }

                    /// <summary>
                    /// <para>The total number of physical reads.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165848</para>
                    /// </summary>
                    [NameInMap("PhysicalRead")]
                    [Validation(Required=false)]
                    public long? PhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The total number of physical synchronous reads.</para>
                    /// <remarks>
                    /// <para>Data is available only when <b>Version</b> is <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PhysicalSyncRead")]
                    [Validation(Required=false)]
                    public double? PhysicalSyncRead { get; set; }

                    /// <summary>
                    /// <para>The connection port of the instance to which the statistical data belongs.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the converged storage link of the instance. For some links, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The parameterized SQL template text, which is the statement with constants in the SQL replaced by placeholders.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select * from t_order where id = ?</para>
                    /// </summary>
                    [NameInMap("Psql")]
                    [Validation(Required=false)]
                    public string Psql { get; set; }

                    /// <summary>
                    /// <para>The total number of updated and returned rows for PolarDB-X compute nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// <para>The total number of scanned rows for the SQL template within the statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048576</para>
                    /// </summary>
                    [NameInMap("RowsExamined")]
                    [Validation(Required=false)]
                    public long? RowsExamined { get; set; }

                    /// <summary>
                    /// <para>The total number of returned rows for the SQL template within the statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("RowsReturned")]
                    [Validation(Required=false)]
                    public long? RowsReturned { get; set; }

                    /// <summary>
                    /// <para>The total execution time of the SQL template within the statistical period, in milliseconds.</para>
                    /// <remarks>
                    /// <para>For PolarDB-X compute nodes (where <b>Role</b> is <b>polarx_cn</b>) with a kernel version earlier than 5.4.13, this value is converted from microseconds to milliseconds.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.409789</para>
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    /// <summary>
                    /// <para>The number of times the execution duration exceeded 1 second.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the aggregated storage link of the instance. For some links, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("RtGreaterThanOneSecondCount")]
                    [Validation(Required=false)]
                    public long? RtGreaterThanOneSecondCount { get; set; }

                    /// <summary>
                    /// <para>The ratio of the total execution time of this statistic to the total execution time of all SQL statements for the instance. Valid values: 0 to 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1384</para>
                    /// </summary>
                    [NameInMap("RtRate")]
                    [Validation(Required=false)]
                    public double? RtRate { get; set; }

                    /// <summary>
                    /// <para>The type identifier of the sample data.</para>
                    /// <remarks>
                    /// <para>This operation returns aggregated statistics and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sql</para>
                    /// </summary>
                    [NameInMap("SampleType")]
                    [Validation(Required=false)]
                    public string SampleType { get; set; }

                    /// <summary>
                    /// <para>The number of scanned rows for a single SQL statement.</para>
                    /// <remarks>
                    /// <para>This operation returns aggregated statistics at the template dimension and does not return this field. Use the aggregated metrics <b>RowsExamined</b> and <b>AvgRowsExamined</b> instead.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>29</para>
                    /// </summary>
                    [NameInMap("ScanRows")]
                    [Validation(Required=false)]
                    public long? ScanRows { get; set; }

                    /// <summary>
                    /// <para>The total number of requests sent from PolarDB-X compute nodes to data nodes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for PolarDB-X compute nodes. For other engines, the value is null or 0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scnt")]
                    [Validation(Required=false)]
                    public long? Scnt { get; set; }

                    /// <summary>
                    /// <para>The original SQL text.</para>
                    /// <remarks>
                    /// <para>The statistical results return the SQL template (<b>Psql</b>) and do not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select * from t_order where id = 1</para>
                    /// </summary>
                    [NameInMap("Sql")]
                    [Validation(Required=false)]
                    public string Sql { get; set; }

                    /// <summary>
                    /// <para>The SQL template ID, which uniquely identifies a category of parameterized SQL statements. Multiple executions under the same template are aggregated into a single statistic. You can use this ID to associate the same category of SQL statements across multi-dimensional queries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>651b56fe9418d48edb8fdf0980ec****</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <para>The SQL text after unified processing of parameter values, used in sample data scenarios.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select * from t_order where id = ?</para>
                    /// </summary>
                    [NameInMap("SqlNew")]
                    [Validation(Required=false)]
                    public string SqlNew { get; set; }

                    /// <summary>
                    /// <para>The SQL text feature value, used in SQL analysis scenarios.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select_from_t_order</para>
                    /// </summary>
                    [NameInMap("SqlTextFeature")]
                    [Validation(Required=false)]
                    public string SqlTextFeature { get; set; }

                    /// <summary>
                    /// <para>The SQL type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>select</b></description></item>
                    /// <item><description><b>insert</b></description></item>
                    /// <item><description><b>update</b></description></item>
                    /// <item><description><b>delete</b></description></item>
                    /// <item><description><b>other</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select</para>
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// <para>The total number of updated rows for the SQL template within the statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3810</para>
                    /// </summary>
                    [NameInMap("SumRowsUpdated")]
                    [Validation(Required=false)]
                    public double? SumRowsUpdated { get; set; }

                    /// <summary>
                    /// <para>The list of table names involved in the SQL statement.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                    /// <summary>
                    /// <para>The database thread ID that executed the SQL statement.</para>
                    /// <remarks>
                    /// <para>The thread ID belongs to the details of a single SQL statement. This operation returns aggregated statistics at the template dimension and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>57472578</para>
                    /// </summary>
                    [NameInMap("ThreadId")]
                    [Validation(Required=false)]
                    public string ThreadId { get; set; }

                    /// <summary>
                    /// <para>The execution time proportion.</para>
                    /// <remarks>
                    /// <para>This operation returns the execution time proportion through <b>RtRate</b> and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1384</para>
                    /// </summary>
                    [NameInMap("TimeRate")]
                    [Validation(Required=false)]
                    public double? TimeRate { get; set; }

                    /// <summary>
                    /// <para>The data timestamp, which is a UNIX timestamp in milliseconds.</para>
                    /// <remarks>
                    /// <para>The statistical results are aggregated at the SQL template dimension and do not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1718600000000</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The total number of affected rows.</para>
                    /// <remarks>
                    /// <para>This field is returned only for Lindorm instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3810</para>
                    /// </summary>
                    [NameInMap("TotalAffectRows")]
                    [Validation(Required=false)]
                    public long? TotalAffectRows { get; set; }

                    /// <summary>
                    /// <para>The total execution time of the SQL statement.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. Use <b>Rt</b> for the total execution time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>310</para>
                    /// </summary>
                    [NameInMap("TotalRt")]
                    [Validation(Required=false)]
                    public long? TotalRt { get; set; }

                    /// <summary>
                    /// <para>The total number of scanned rows.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. Use <b>RowsExamined</b> for the total number of scanned rows.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048576</para>
                    /// </summary>
                    [NameInMap("TotalScanRows")]
                    [Validation(Required=false)]
                    public long? TotalScanRows { get; set; }

                    /// <summary>
                    /// <para>The trend sequence of execution counts for the SQL template, divided by time slices within the query time window.</para>
                    /// <remarks>
                    /// <para>This field is returned only when the request parameter <b>DoFillTrend</b> is set to <b>true</b> and the trend padding feature is enabled for the instance. The time slice interval is automatically determined by the query span. Time slices with no data may be padded with zeros.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Trend")]
                    [Validation(Required=false)]
                    public List<DescribeSqlInsightStatisticResponseBodyDataDataListTrend> Trend { get; set; }
                    public class DescribeSqlInsightStatisticResponseBodyDataDataListTrend : TeaModel {
                        /// <summary>
                        /// <para>The timestamp of the trend point, which is a UNIX timestamp in milliseconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1718000000000</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// <para>The number of SQL executions within the time slice.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public object Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of updated rows for a single SQL statement.</para>
                    /// <remarks>
                    /// <para>This operation returns aggregated statistics at the template dimension and does not return this field. Use the aggregated metrics <b>SumRowsUpdated</b> and <b>AvgRowsUpdated</b> instead.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("UpdateRows")]
                    [Validation(Required=false)]
                    public long? UpdateRows { get; set; }

                    /// <summary>
                    /// <para>The database username that executed the SQL statement.</para>
                    /// <remarks>
                    /// <para>When <b>Type</b> is <b>FullRequestUser</b>, this field is the aggregation dimension for this statistic.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testUser</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                    /// <summary>
                    /// <para>The version of the SQL Explorer data collection link. If the instance collects logical read or lock wait data, the value is <b>1</b>. Otherwise, the value is <b>0</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: V0 basic collection link.</description></item>
                    /// <item><description><b>1</b>: V1 collection link, which collects four additional metrics based on V0: <b>LockWaitTime</b>, <b>LogicalRead</b>, <b>PhysicalSyncRead</b>, and <b>PhysicalAsyncRead</b>.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>When <b>0</b> is returned, the preceding extended metrics have no data.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public int? Version { get; set; }

                    /// <summary>
                    /// <para>The VPC ID of the instance to which the statistical data belongs.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the aggregated storage link of the instance. For some links, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zentqj1sk4qmolci****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The total number of logical writes.</para>
                    /// <remarks>
                    /// <para>This is an exclusive metric for SQL Server instances. For other engines, the value is null.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Writes")]
                    [Validation(Required=false)]
                    public long? Writes { get; set; }

                }

                /// <summary>
                /// <para>The current page number, which corresponds to the request parameter <b>PageNo</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNo")]
                [Validation(Required=false)]
                public long? PageNo { get; set; }

                /// <summary>
                /// <para>The number of entries returned per page, which corresponds to the request parameter <b>PageSize</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of statistical entries that meet the query conditions, which can be used for pagination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>The error code for the failed asynchronous query.</para>
            /// <remarks>
            /// <para>This field is returned only when the query fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>-10200020</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous query has finished. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: <b>State</b> is <b>SUCCESS</b> or <b>FAIL</b>.</description></item>
            /// <item><description><b>false</b>: <b>State</b> is <b>RUNNING</b>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The error description for the failed asynchronous query.</para>
            /// <remarks>
            /// <para>This field is returned only when the query fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>startTime must be in 30 days and the interval must be within 7 day</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The hash identifier of the request parameters.</para>
            /// <remarks>
            /// <para>This operation does not return this field. Use <b>ResultId</b> to identify the asynchronous query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>507044db6c4eadfa2dab9b084e80****</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <para>The asynchronous query result ID, which is in the format of an async_ prefix followed by a hash value. It is calculated based on all business parameters of the current request.</para>
            /// <remarks>
            /// <para>Repeated calls with the same parameters hit the same query result. Therefore, you must carry the exact same request parameters as the first call when polling. Any parameter change generates a different <b>ResultId</b> and triggers a new query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The current state of the asynchronous query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: The query is running. Continue polling.</description></item>
            /// <item><description><b>SUCCESS</b>: The query is successful. The <b>Data</b> field has a value.</description></item>
            /// <item><description><b>FAIL</b>: The query failed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When the query fails, the operation directly returns an error code and an error message, instead of a normal response body with <b>State</b> set to <b>FAIL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous query was submitted, which is a UNIX timestamp in milliseconds.</para>
            /// <remarks>
            /// <para>When the query fails, this value is the time when the failure occurred.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1718600000000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The response message. An error description is returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
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
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed. Check the cause based on <b>Code</b> and <b>Message</b>.</description></item>
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
