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
        /// <para>The envelope for asynchronous query results. The first call returns <b>ResultId</b> and <b>State</b>. Poll with the exact same request parameters until <b>State</b> is <b>SUCCESS</b>, then retrieve the statistical details from <b>List</b>.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlInsightStatisticResponseBodyData Data { get; set; }
        public class DescribeSqlInsightStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The SQL Explorer statistical query results.</para>
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
                /// <para>This field is not returned by this operation.</para>
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
                    /// <para>The value of the aggregation dimension for this statistical entry, which varies based on the <b>Type</b> request parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>When aggregated by SQL template: the SQL template ID, which is the same as <b>SqlId</b>.</description></item>
                    /// <item><description>When <b>Type</b> is set to <b>FullRequestOrigin</b>: the access source address.</description></item>
                    /// <item><description>When <b>Type</b> is set to <b>FullRequestUser</b>: the database username.</description></item>
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
                    /// <para>Returned only for Lindorm instances. The value is null for other database engines.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12.5</para>
                    /// </summary>
                    [NameInMap("AvgCpuTime")]
                    [Validation(Required=false)]
                    public double? AvgCpuTime { get; set; }

                    /// <summary>
                    /// <para>The average number of rows fetched by the PolarDB-X compute node from data nodes.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other database engines.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalSyncRead")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalSyncRead { get; set; }

                    /// <summary>
                    /// <para>The average number of updated rows and returned rows for the PolarDB-X compute node.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgRows")]
                    [Validation(Required=false)]
                    public double? AvgRows { get; set; }

                    /// <summary>
                    /// <para>The average number of rows scanned per execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsExamined")]
                    [Validation(Required=false)]
                    public double? AvgRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The average number of rows returned per execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("AvgRowsReturned")]
                    [Validation(Required=false)]
                    public double? AvgRowsReturned { get; set; }

                    /// <summary>
                    /// <para>The average number of rows updated per execution.</para>
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
                    /// <para>This field is not returned by this operation. Use <b>AvgRowsExamined</b> for the average number of scanned rows.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgScanRows")]
                    [Validation(Required=false)]
                    public double? AvgScanRows { get; set; }

                    /// <summary>
                    /// <para>The average number of requests sent by the PolarDB-X compute node to data nodes.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other database engines.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgWrites")]
                    [Validation(Required=false)]
                    public double? AvgWrites { get; set; }

                    /// <summary>
                    /// <para>The total number of executions of the SQL template within the statistical interval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>127</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The ratio of the number of executions of this statistical entry to the total number of executions of all SQL statements on the instance. The value ranges from 0 to 1.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
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
                    /// <para>The error code returned by SQL execution.</para>
                    /// <remarks>
                    /// <para>The error code is a detail of a single SQL statement. This operation returns template-level aggregated statistics and does not return this field. Use <b>ErrorCount</b> for error information.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1146</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The number of execution errors for the SQL template within the statistical interval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ErrorCount")]
                    [Validation(Required=false)]
                    public long? ErrorCount { get; set; }

                    /// <summary>
                    /// <para>The time when the SQL template first appeared.</para>
                    /// <remarks>
                    /// <para>This field is not returned by this operation.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1659308149000</para>
                    /// </summary>
                    [NameInMap("FirstTime")]
                    [Validation(Required=false)]
                    public long? FirstTime { get; set; }

                    /// <summary>
                    /// <para>The total number of rows fetched by the PolarDB-X compute node from data nodes.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other database engines.</para>
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
                    /// <para>This value is generated by the PolarDB-X compute node kernel. The value is empty for non-PolarDB-X compute node instances.</para>
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
                    /// <para>Whether this field is returned depends on the aggregated storage link of the instance. The value is null for some links.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>165848</para>
                    /// </summary>
                    [NameInMap("LogicalRead")]
                    [Validation(Required=false)]
                    public double? LogicalRead { get; set; }

                    /// <summary>
                    /// <para>The maximum CPU time in a single execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3186</para>
                    /// </summary>
                    [NameInMap("MaxPhysicalRead")]
                    [Validation(Required=false)]
                    public long? MaxPhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The maximum number of rows scanned in a single execution.</para>
                    /// <remarks>
                    /// <para>This field is not returned by this operation. Use <b>RowsExamined</b> and <b>AvgRowsExamined</b> for scanned row counts.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>318613</para>
                    /// </summary>
                    [NameInMap("MaxRowsExamined")]
                    [Validation(Required=false)]
                    public long? MaxRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The maximum number of rows returned in a single execution.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWrites")]
                    [Validation(Required=false)]
                    public long? MaxWrites { get; set; }

                    /// <summary>
                    /// <para>The minimum CPU time in a single execution, in microseconds.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MinPhysicalRead")]
                    [Validation(Required=false)]
                    public long? MinPhysicalRead { get; set; }

                    /// <summary>
                    /// <para>The minimum number of rows returned in a single execution.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("MinWrites")]
                    [Validation(Required=false)]
                    public long? MinWrites { get; set; }

                    /// <summary>
                    /// <para>The display alias configured for the access source address.</para>
                    /// <remarks>
                    /// <para>Returned only when aggregated by access source (when <b>Type</b> is set to <b>FullRequestOrigin</b>). The value is null in other scenarios.</para>
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
                    /// <para>When <b>Type</b> is set to <b>FullRequestOrigin</b>, this field serves as the aggregation dimension for the statistical entry.</para>
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
                    /// <para>This operation returns template-level aggregated statistics and does not return this field.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other database engines.</para>
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
                    /// <para>Data is available only when <b>Version</b> is set to <b>1</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PhysicalSyncRead")]
                    [Validation(Required=false)]
                    public double? PhysicalSyncRead { get; set; }

                    /// <summary>
                    /// <para>The port of the instance to which the statistical data belongs.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the aggregated storage link of the instance. The value is null for some links.</para>
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
                    /// <para>The total number of updated rows and returned rows for the PolarDB-X compute node.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// <para>The total number of rows examined by the SQL template within the statistical interval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048576</para>
                    /// </summary>
                    [NameInMap("RowsExamined")]
                    [Validation(Required=false)]
                    public long? RowsExamined { get; set; }

                    /// <summary>
                    /// <para>The total number of rows returned by the SQL template within the statistical interval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("RowsReturned")]
                    [Validation(Required=false)]
                    public long? RowsReturned { get; set; }

                    /// <summary>
                    /// <para>The total execution duration of the SQL template within the statistical interval. Unit: milliseconds.</para>
                    /// <remarks>
                    /// <para>For PolarDB-X compute nodes (where <b>Role</b> is <b>polarx_cn</b>) with kernel versions earlier than 5.4.13, this value is converted from microseconds to milliseconds.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.409789</para>
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public double? Rt { get; set; }

                    /// <summary>
                    /// <para>The number of times the execution duration exceeds 1 second.</para>
                    /// <remarks>
                    /// <para>Whether this field is returned depends on the aggregation storage link of the instance. The value is null for certain links.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("RtGreaterThanOneSecondCount")]
                    [Validation(Required=false)]
                    public long? RtGreaterThanOneSecondCount { get; set; }

                    /// <summary>
                    /// <para>The ratio of the total execution duration of this entry to the total execution duration of all SQL statements on the instance. Valid values: 0 to 1.</para>
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
                    /// <para>The number of rows scanned by a single SQL statement.</para>
                    /// <remarks>
                    /// <para>This operation returns template-level aggregated statistics and does not return this field. Use the aggregated metrics <b>RowsExamined</b> and <b>AvgRowsExamined</b> instead.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>29</para>
                    /// </summary>
                    [NameInMap("ScanRows")]
                    [Validation(Required=false)]
                    public long? ScanRows { get; set; }

                    /// <summary>
                    /// <para>The total number of requests sent from the PolarDB-X compute node to data nodes.</para>
                    /// <remarks>
                    /// <para>This metric is exclusive to PolarDB-X compute nodes. The value is null or 0 for other engines.</para>
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
                    /// <para>The SQL template ID that uniquely identifies a type of parameterized SQL statement. Multiple executions under the same template are aggregated into a single statistical entry. You can use this ID to correlate the same type of SQL across multi-dimensional queries.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>651b56fe9418d48edb8fdf0980ec****</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <para>The SQL text with parameter values uniformly processed, used in sample data scenarios.</para>
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
                    /// <para>The total number of rows updated by the SQL template within the statistical interval.</para>
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
                    /// <para>The thread ID is a detail of a single SQL statement. This operation returns template-level aggregated statistics and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>57472578</para>
                    /// </summary>
                    [NameInMap("ThreadId")]
                    [Validation(Required=false)]
                    public string ThreadId { get; set; }

                    /// <summary>
                    /// <para>The execution duration ratio.</para>
                    /// <remarks>
                    /// <para>This operation returns the execution duration ratio through <b>RtRate</b> and does not return this field.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1384</para>
                    /// </summary>
                    [NameInMap("TimeRate")]
                    [Validation(Required=false)]
                    public double? TimeRate { get; set; }

                    /// <summary>
                    /// <para>The data timestamp. This value is a UNIX timestamp. Unit: milliseconds.</para>
                    /// <remarks>
                    /// <para>The statistical results are aggregated at the SQL template level and do not return this field.</para>
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
                    /// <para>This field is returned only for Lindorm instances. The value is null for other engines.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3810</para>
                    /// </summary>
                    [NameInMap("TotalAffectRows")]
                    [Validation(Required=false)]
                    public long? TotalAffectRows { get; set; }

                    /// <summary>
                    /// <para>The total SQL execution duration.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. Use <b>Rt</b> for the total execution duration.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>310</para>
                    /// </summary>
                    [NameInMap("TotalRt")]
                    [Validation(Required=false)]
                    public long? TotalRt { get; set; }

                    /// <summary>
                    /// <para>The total number of rows scanned.</para>
                    /// <remarks>
                    /// <para>This operation does not return this field. Use <b>RowsExamined</b> for the total number of rows scanned.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048576</para>
                    /// </summary>
                    [NameInMap("TotalScanRows")]
                    [Validation(Required=false)]
                    public long? TotalScanRows { get; set; }

                    /// <summary>
                    /// <para>The execution count trend sequence of the SQL template, divided into time slices within the query time window.</para>
                    /// <remarks>
                    /// <para>This field is returned only when the request parameter <b>DoFillTrend</b> is set to <b>true</b> and the trend padding capability is enabled for the instance. The time slice interval is automatically determined by the query span. Time slices with no data may be padded with zeros.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Trend")]
                    [Validation(Required=false)]
                    public List<DescribeSqlInsightStatisticResponseBodyDataDataListTrend> Trend { get; set; }
                    public class DescribeSqlInsightStatisticResponseBodyDataDataListTrend : TeaModel {
                        /// <summary>
                        /// <para>The timestamp of the trend data point. This value is a UNIX timestamp. Unit: milliseconds.</para>
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
                    /// <para>The number of rows updated by a single SQL statement.</para>
                    /// <remarks>
                    /// <para>This operation returns template-level aggregated statistics and does not return this field. Use the aggregated metrics <b>SumRowsUpdated</b> and <b>AvgRowsUpdated</b> instead.</para>
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
                    /// <para>When <b>Type</b> is set to <b>FullRequestUser</b>, this field serves as the aggregation dimension for the statistical entry.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testUser</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                    /// <summary>
                    /// <para>The SQL Explorer data collection link version. The value <b>1</b> is returned when the instance collects logical read or lock wait data. Otherwise, the value <b>0</b> is returned. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: V0 basic collection link.</description></item>
                    /// <item><description><b>1</b>: V1 collection link, which additionally collects four metrics (<b>LockWaitTime</b>, <b>LogicalRead</b>, <b>PhysicalSyncRead</b>, and <b>PhysicalAsyncRead</b>) on top of V0.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>When the value is <b>0</b>, the extended metrics contain no data.</para>
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
                    /// <para>Whether this field is returned depends on the aggregation storage link of the instance. The value is null for certain links.</para>
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
                    /// <para>This metric is exclusive to SQL Server instances. The value is null for other engines.</para>
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
                /// <para>The current page number, corresponding to the request parameter <b>PageNo</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNo")]
                [Validation(Required=false)]
                public long? PageNo { get; set; }

                /// <summary>
                /// <para>The number of entries per page, corresponding to the request parameter <b>PageSize</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of statistical entries that match the query conditions. You can use this value for pagination calculation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>The error code of the asynchronous query failure.</para>
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
            /// <para>Indicates whether the asynchronous query has completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: <b>State</b> is <b>SUCCESS</b> or <b>FAIL</b>.</description></item>
            /// <item><description><b>false</b>: <b>State</b> is <b>RUNNING</b>.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The error description of the asynchronous query failure.</para>
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
            /// <para>The asynchronous query result ID, in the format of an async_ prefix followed by a hash value computed from all business parameters of the request.</para>
            /// <remarks>
            /// <para>Repeated calls with the same parameters return the same query result. Therefore, when polling, you must use exactly the same request parameters as the initial call. Any change in parameters generates a different <b>ResultId</b> and triggers a new query.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>async__507044db6c4eadfa2dab9b084e80****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The current status of the asynchronous query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: The query is in progress. Continue polling.</description></item>
            /// <item><description><b>SUCCESS</b>: The query succeeded. The <b>Data</b> field contains data only in this state.</description></item>
            /// <item><description><b>FAIL</b>: The query failed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When the query fails, the operation directly returns an error code and error message instead of a normal response body with <b>State</b> set to <b>FAIL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the asynchronous query was submitted. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>When the query fails, this value indicates the time when the failure occurred.</para>
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
        /// <para>The response message. An error description is returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request, which can be used for troubleshooting.</para>
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
        /// <item><description><b>false</b>: The request failed. Check the <b>Code</b> and <b>Message</b> fields to determine the cause.</description></item>
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
