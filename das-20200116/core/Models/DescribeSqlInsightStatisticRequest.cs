// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlInsightStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The sort direction. Default value: <b>false</b> (descending). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: ascending.</description></item>
        /// <item><description><b>false</b>: descending.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The database name used for filtering.</para>
        /// <remarks>
        /// <para>In certain aggregation storage pipelines, you can specify multiple database names separated by commas. In other pipelines, only a single database name is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Specifies whether to populate time series trend data for each statistical entry, which corresponds to the <b>Trend</b> field in the response. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Populates trend data.</description></item>
        /// <item><description><b>false</b>: Does not populate trend data.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Enabling this option triggers additional queries for each time slice per entry, which significantly increases query overhead. If the trend filling capability is not enabled for the instance, this parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DoFillTrend")]
        [Validation(Required=false)]
        public bool? DoFillTrend { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify a UNIX timestamp in milliseconds. The system rounds up to the nearest minute.</para>
        /// <remarks>
        /// <para>The span between this value and <b>StartTime</b> must not exceed 7 days. If <b>EndTime</b> is earlier than the time when SQL Explorer was enabled for the instance, an error indicating that the query time is earlier than the available time is returned.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Because data aggregation involves latency, the actual effective value is trimmed to a few minutes before the current time. Data from the most recent minutes may not be available.</para>
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
        /// <para>The list of structured filter conditions, specified as Key/Value pairs. The POP format is <b>Filters.N.Key</b> and <b>Filters.N.Value</b>, with a maximum of 100 pairs. <b>Key</b> is case-insensitive. Entries with an empty <b>Value</b> are ignored. Valid values of <b>Key</b> for this operation:</para>
        /// <list type="bullet">
        /// <item><description><b>keyWord</b>: the keyword. The value is split by whitespace into multiple words and takes effect together with the <b>Keyword</b> parameter.</description></item>
        /// <item><description><b>hostAddress</b>: the access source address. Separate multiple values with commas. This takes effect together with <b>TemplateId</b> when <b>Type</b> is set to <b>OriginHost</b>.</description></item>
        /// <item><description><b>accountName</b>: the database username. Separate multiple values with commas.</description></item>
        /// <item><description><b>dbName</b>: the database name. Separate multiple values with commas. This takes effect together with the <b>DbName</b> parameter.</description></item>
        /// <item><description><b>sqlType</b>: the SQL type. Separate multiple values with commas. This takes effect together with the <b>SqlType</b> parameter.</description></item>
        /// <item><description><b>sqlId</b>: the SQL template ID. Separate multiple values with commas. This takes effect together with <b>TemplateId</b> when <b>Type</b> is set to <b>SQL</b>.</description></item>
        /// <item><description><b>insRole</b>: the primary/secondary role. Valid values: <b>master</b> and <b>slave</b>. These values are case-sensitive.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Any <b>Key</b> value other than the preceding values is ignored.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter takes effect only in certain aggregation storage pipelines. In other pipelines, this parameter is entirely ignored.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSqlInsightStatisticRequestFilters> Filters { get; set; }
        public class DescribeSqlInsightStatisticRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. The value is case-insensitive. For valid values, see the description of the <b>Filters</b> parameter.</para>
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
        /// <para>This operation supports RDS for MySQL, PolarDB for MySQL, PolarDB-X, RDS for PostgreSQL, PolarDB for PostgreSQL, RDS for SQL Server, and Lindorm instances that have SQL Explorer enabled. MongoDB and Redis instances are not supported. Calling this operation for unsupported instances returns an error indicating that the operation is not supported.</para>
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
        /// <para>The idempotency ID for the SQL Explorer data query. This parameter is not required for regular queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9a4f5c4494dbd6713185d87a97aa53e8</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy retrieve on SQL template content. Separate multiple keywords with spaces. The system first performs keyword match to find the corresponding SQL templates (up to 1,000 templates), and then performs aggregation statistics based on these templates. If no templates match, an empty list is returned.</para>
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
        /// <para>The node ID of the instance. This parameter narrows the statistical scope to the specified node. Only a single node ID is supported. You cannot specify multiple node IDs separated by commas.</para>
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
        /// <para>The field used for sorting. If this parameter is not specified or an unsupported value is specified, the results are sorted by <b>rt</b> (total response time). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Response time: <b>rt</b>, <b>avgRt</b>, <b>maxRt</b>, <b>minRt</b>, <b>rtRate</b>.</description></item>
        /// <item><description>Executions: <b>count</b>, <b>countRate</b>, <b>timestamp</b>.</description></item>
        /// <item><description>Scan rows: <b>rowsExamined</b>, <b>avgRowsExamined</b>.</description></item>
        /// <item><description>Returned rows: <b>rowsReturned</b>, <b>totalRowsReturned</b>, <b>avgRowsReturned</b>, <b>maxRowsReturned</b>, <b>minRowsReturned</b>, <b>maxRowReturned</b>, <b>minRowReturned</b>.</description></item>
        /// <item><description>Logical reads: <b>logicalRead</b>, <b>totalLogicalRead</b>, <b>avgLogicalRead</b>, <b>maxLogicalRead</b>, <b>minLogicalRead</b>.</description></item>
        /// <item><description>Physical reads: <b>physicalRead</b>, <b>totalPhysicalRead</b>, <b>avgPhysicalRead</b>, <b>maxPhysicalRead</b>, <b>minPhysicalRead</b>.</description></item>
        /// <item><description>Logical writes (valid only for SQL Server instances): <b>writes</b>, <b>totalWrites</b>, <b>avgWrites</b>, <b>maxWrites</b>, <b>minWrites</b>.</description></item>
        /// <item><description>CPU time (valid only for SQL Server instances): <b>totalCpuTime</b>, <b>avgCpuTime</b>, <b>maxCpuTime</b>, <b>minCpuTime</b>.</description></item>
        /// <item><description>PolarDB-X compute node metrics (valid only when <b>Role</b> is set to <b>polarx_cn</b>): <b>scnt</b>, <b>avgScnt</b>, <b>rows</b>, <b>avgRows</b>, <b>frows</b>, <b>avgFrows</b>.</description></item>
        /// <item><description>Affected rows (valid only for Lindorm instances): <b>totalAffectRows</b>, <b>avgAffectRows</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para><b>timestamp</b> sorts by the data timestamp, which is a millisecond-level UNIX timestamp.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Only the first letter is case-insensitive. The remaining characters must exactly match the preceding values. For example, <b>AvgRt</b> is valid but <b>avgrt</b> is not.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rt</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of statistical entries per page. Default value: 10. Maximum value: 2000.</para>
        /// <remarks>
        /// <para>A value greater than 2000 returns an InvalidParams error instead of being trimmed.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When aggregating by access source or database user (<b>Type</b> is set to <b>FullRequestOrigin</b> or <b>FullRequestUser</b>), a value greater than 100 may be reset to 10 in certain aggregation storage pipelines.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role of the instance node. The value is case-insensitive. If this parameter is not specified, the role is automatically resolved from <b>InstanceId</b>. Valid values:</para>
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
        /// <para>The SQL type used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>select</b></description></item>
        /// <item><description><b>insert</b></description></item>
        /// <item><description><b>update</b></description></item>
        /// <item><description><b>delete</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Values are lowercase. In certain aggregation storage pipelines, you can specify multiple values separated by commas. In other pipelines, only a single value is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify a UNIX timestamp in milliseconds. The system rounds down to the nearest minute.</para>
        /// <remarks>
        /// <para>The value must be within the last 30 days. If the value is earlier than the time when SQL Explorer was enabled for the instance, it is automatically adjusted to the time when SQL Explorer was enabled.</para>
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
        /// <para>The identifier of the statistical object. The meaning varies depending on the value of <b>Type</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When <b>Type</b> is set to <b>SQL</b>: the SQL template ID, which corresponds to <b>SqlId</b> in the response.</description></item>
        /// <item><description>When <b>Type</b> is set to <b>OriginHost</b>: the access source address.</description></item>
        /// <item><description>When <b>Type</b> is set to <b>User</b>: the database username.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter does not take effect when <b>Type</b> is not specified, or is set to <b>FullRequestOrigin</b> or <b>FullRequestUser</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>When <b>Type</b> is set to <b>SQL</b>, you can specify multiple template IDs separated by commas. In this case, the <b>Keyword</b> parameter does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9f8e7d6c5b4a3210</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The aggregation or filter dimension for statistics. The value is case-insensitive. If this parameter is not specified, statistics are aggregated by SQL template by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullRequestOrigin</b>: Aggregates by access source address.</description></item>
        /// <item><description><b>FullRequestUser</b>: Aggregates by database user.</description></item>
        /// <item><description><b>SQL</b>: Filters by SQL template. You must also specify <b>TemplateId</b> as the SQL template ID.</description></item>
        /// <item><description><b>OriginHost</b>: Filters by access source. You must also specify <b>TemplateId</b> as the source address.</description></item>
        /// <item><description><b>User</b>: Filters by database user. You must also specify <b>TemplateId</b> as the username.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specifying a value other than the preceding values returns an InvalidParams error.</para>
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
