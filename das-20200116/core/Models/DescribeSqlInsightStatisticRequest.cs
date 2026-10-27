// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlInsightStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Default value: <b>false</b> (descending order). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: ascending order.</description></item>
        /// <item><description><b>false</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The name of the database used to filter the results.</para>
        /// <remarks>
        /// <para>In the aggregation storage links of some instances, you can specify multiple database names separated by commas. In other links, you can specify only a single database name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Specifies whether to populate time series trend data for each statistical result, which corresponds to the <b>Trend</b> field in the response. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: populates trend data.</description></item>
        /// <item><description><b>false</b>: does not populate trend data.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is set to true, the system additionally queries data for each time slice for each result, which significantly increases the query overhead. If the trend filling capability is not enabled for the instance, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DoFillTrend")]
        [Validation(Required=false)]
        public bool? DoFillTrend { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in milliseconds. The system rounds up the value to the nearest minute.</para>
        /// <remarks>
        /// <para>The time span between <b>EndTime</b> and <b>StartTime</b> cannot exceed 7 days. If <b>EndTime</b> is earlier than the time when the SQL Explorer feature was enabled for the instance, an error indicating that the query time is earlier than the available time is returned.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Due to delays in data aggregation, the actual effective value is truncated to a few minutes before the current time. Therefore, data from the most recent few minutes may not be queried.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718600000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of structured filter conditions. The conditions are passed as key-value pairs. The POP format is <b>Filters.N.Key</b> and <b>Filters.N.Value</b>. A maximum of 100 pairs can be specified. <b>Key</b> is not case-sensitive. Entries with an empty <b>Value</b> are ignored. Valid values of <b>Key</b> that take effect in this operation:</para>
        /// <list type="bullet">
        /// <item><description><b>keyWord</b>: the keywords. The keywords are split into multiple words by whitespace characters and take effect together with the <b>Keyword</b> parameter.</description></item>
        /// <item><description><b>hostAddress</b>: the access source addresses. Separate multiple addresses with commas. This key takes effect together with <b>TemplateId</b> when <b>Type</b> is set to <b>OriginHost</b>.</description></item>
        /// <item><description><b>accountName</b>: the database usernames. Separate multiple usernames with commas.</description></item>
        /// <item><description><b>dbName</b>: the database names. Separate multiple names with commas. This key takes effect together with the <b>DbName</b> parameter.</description></item>
        /// <item><description><b>sqlType</b>: the SQL statement types. Separate multiple types with commas. This key takes effect together with the <b>SqlType</b> parameter.</description></item>
        /// <item><description><b>sqlId</b>: the SQL template IDs. Separate multiple IDs with commas. This key takes effect together with <b>TemplateId</b> when <b>Type</b> is set to <b>SQL</b>.</description></item>
        /// <item><description><b>insRole</b>: the primary/secondary role. Valid values are <b>master</b> and <b>slave</b>. This value is case-sensitive.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify a <b>Key</b> other than the preceding values, the key is ignored.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter takes effect only in the aggregation storage links of some instances. In other links, this parameter is completely ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSqlInsightStatisticRequestFilters> Filters { get; set; }
        public class DescribeSqlInsightStatisticRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the conditional filter. The key is not case-sensitive. For active values, see the metric description of the <b>Filters</b> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sqlType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition. If the value is null or an empty string, the filter condition is ignored. Separate multiple values with commas. The specific upper limit depends on the corresponding key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <remarks>
        /// <para>This operation supports ApsaraDB RDS for MySQL, PolarDB for MySQL, PolarDB-X, ApsaraDB RDS for PostgreSQL, PolarDB for PostgreSQL, ApsaraDB RDS for SQL Server, and Lindorm instances that have the SQL Explorer feature enabled. MongoDB and Redis instances are not supported. If you invoke this operation for unsupported instances, a fault indicating that the operation is not supported is returned.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1q6f9z5xxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The idempotent ID for querying SQL Explorer data. You do not need to specify this parameter for common queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9a4f5c4494dbd6713185d87a97aa53e8</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The keywords used to retrieve SQL templates by fuzzy match based on the SQL template content. Separate multiple keywords with spaces. The system first performs keyword match to retrieve up to 1,000 corresponding SQL templates, and then performs aggregation statistics based on these templates. If no matching templates are found, an empty list is returned.</para>
        /// <remarks>
        /// <para>This parameter does not take effect when <b>Type</b> is set to <b>SQL</b> and <b>TemplateId</b> is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>t_order</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The ID of the node in the instance. This parameter is used to narrow the statistics scope to the specified node. Only a single node ID is supported. Multiple node IDs separated by commas are not supported.</para>
        /// <remarks>
        /// <para>This parameter is required only for instances that consist of multiple nodes, such as PolarDB-X and Lindorm instances. You can ignore this parameter for single-node instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp1xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. If this parameter is not specified or an unsupported value is specified, the results are sorted by <b>rt</b> (total response time). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Response time: <b>rt</b>, <b>avgRt</b>, <b>maxRt</b>, <b>minRt</b>, and <b>rtRate</b>.</description></item>
        /// <item><description>Executions: <b>count</b>, <b>countRate</b>, and <b>timestamp</b>.</description></item>
        /// <item><description>Scanned rows: <b>rowsExamined</b> and <b>avgRowsExamined</b>.</description></item>
        /// <item><description>Returned rows: <b>rowsReturned</b>, <b>totalRowsReturned</b>, <b>avgRowsReturned</b>, <b>maxRowsReturned</b>, <b>minRowsReturned</b>, <b>maxRowReturned</b>, and <b>minRowReturned</b>.</description></item>
        /// <item><description>Logical reads: <b>logicalRead</b>, <b>totalLogicalRead</b>, <b>avgLogicalRead</b>, <b>maxLogicalRead</b>, and <b>minLogicalRead</b>.</description></item>
        /// <item><description>Physical reads: <b>physicalRead</b>, <b>totalPhysicalRead</b>, <b>avgPhysicalRead</b>, <b>maxPhysicalRead</b>, and <b>minPhysicalRead</b>.</description></item>
        /// <item><description>Logical writes (valid only for SQL Server instances): <b>writes</b>, <b>totalWrites</b>, <b>avgWrites</b>, <b>maxWrites</b>, and <b>minWrites</b>.</description></item>
        /// <item><description>CPU time (valid only for SQL Server instances): <b>totalCpuTime</b>, <b>avgCpuTime</b>, <b>maxCpuTime</b>, and <b>minCpuTime</b>.</description></item>
        /// <item><description>PolarDB-X compute nodes (valid only when <b>Role</b> is set to <b>polarx_cn</b>): <b>scnt</b>, <b>avgScnt</b>, <b>rows</b>, <b>avgRows</b>, <b>frows</b>, and <b>avgFrows</b>.</description></item>
        /// <item><description>Affected rows (valid only for Lindorm instances): <b>totalAffectRows</b> and <b>avgAffectRows</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para><b>timestamp</b> indicates that the results are sorted by data timestamp. The timestamp is a UNIX timestamp in milliseconds.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Only the first letter is case-insensitive. The remaining characters must exactly match the preceding values. For example, <b>AvgRt</b> is valid, but <b>avgrt</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rt</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. If this parameter is not specified, the default value 1 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of statistical entries to return on each page. If this parameter is not specified, the default value 10 is used. The maximum value is 2000.</para>
        /// <remarks>
        /// <para>If the value exceeds 2000, an InvalidParams error is returned instead of being truncated.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When statistics are aggregated by access source or database user (when <b>Type</b> is set to <b>FullRequestOrigin</b> or <b>FullRequestUser</b>), a value greater than 100 is reset to 10 in some aggregation storage links.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role of the instance node. The value is not case-sensitive. If this parameter is not specified, the role is automatically parsed based on <b>InstanceId</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx_cn</b>: PolarDB-X compute node.</description></item>
        /// <item><description><b>polarx_dn</b>: PolarDB-X storage node.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This value affects the scope of returned fields. For example, <b>Scnt</b>, <b>Rows</b>, and <b>Frows</b> are returned only when the value is <b>polarx_cn</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The SQL statement type used to filter the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>select</b></description></item>
        /// <item><description><b>insert</b></description></item>
        /// <item><description><b>update</b></description></item>
        /// <item><description><b>delete</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>The values must be in lowercase. In the aggregation storage links of some instances, you can specify multiple values separated by commas. In other links, you can specify only a single value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds. The system rounds down the value to the nearest minute.</para>
        /// <remarks>
        /// <para>The start time cannot be more than 30 days before the current time. If the specified start time is earlier than the time when the SQL Explorer feature was enabled for the instance, the start time is automatically adjusted to the enabling time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718000000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The identifier of the statistics object. The meaning varies based on the value of <b>Type</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>Type</b> is set to <b>SQL</b>: specify the SQL template ID, which is the <b>SqlId</b> in the response.</description></item>
        /// <item><description>When <b>Type</b> is set to <b>OriginHost</b>: specify the access source address.</description></item>
        /// <item><description>When <b>Type</b> is set to <b>User</b>: specify the database username.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter does not take effect when <b>Type</b> is empty, <b>FullRequestOrigin</b>, or <b>FullRequestUser</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When <b>Type</b> is set to <b>SQL</b>, you can specify multiple template IDs separated by commas. In this case, <b>Keyword</b> does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9f8e7d6c5b4a3210</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The aggregation or filter dimension for statistics. The value is not case-sensitive. If this parameter is not specified, the statistics are aggregated by SQL template by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullRequestOrigin</b>: aggregates statistics by access source address.</description></item>
        /// <item><description><b>FullRequestUser</b>: aggregates statistics by database user.</description></item>
        /// <item><description><b>SQL</b>: filters statistics by SQL template. You must also specify <b>TemplateId</b> as the SQL template ID.</description></item>
        /// <item><description><b>OriginHost</b>: filters statistics by access source. You must also specify <b>TemplateId</b> as the source address.</description></item>
        /// <item><description><b>User</b>: filters statistics by database user. You must also specify <b>TemplateId</b> as the username.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify a value other than the preceding values, an InvalidParams error is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
