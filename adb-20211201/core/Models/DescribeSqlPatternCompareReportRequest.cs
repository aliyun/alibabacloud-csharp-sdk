// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternCompareReportRequest : TeaModel {
        /// <summary>
        /// <para>The average change rate filter range for CHANGED reports. The format is <c>left~right</c>, where values are expressed as percentages and the interval is left-exclusive and right-inclusive. Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>100~500</c>: greater than 100% and less than or equal to 500%.</description></item>
        /// <item><description><c>100~</c>: greater than 100% with no upper limit.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The left boundary is required and must be no less than 0. The right boundary must be no less than the left boundary.</description></item>
        /// <item><description>This parameter is ignored for NEW reports.</description></item>
        /// <item><description>When the time window 1 metric value is 0 and the time window 2 value is greater than 0, the Pattern is classified as zero-baseline growth and is categorized as <c>SEVERE</c> (significant change). To exclude such Patterns, set an upper limit for the change rate.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100~500</para>
        /// </summary>
        [NameInMap("ChangeRate")]
        [Validation(Required=false)]
        public string ChangeRate { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-2ze1234567890****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the parameterized SQL Pattern text. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Returns the Pattern text.</description></item>
        /// <item><description><c>false</c>: Does not return the Pattern text, which reduces the response size.</description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludePattern")]
        [Validation(Required=false)]
        public bool? IncludePattern { get; set; }

        /// <summary>
        /// <para>The analysis metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>QUERY_COUNT</c>: the number of query executions.</description></item>
        /// <item><description><c>CPU_COST</c>: the CPU consumption.</description></item>
        /// <item><description><c>SHUFFLE_SIZE</c>: the amount of shuffle data.</description></item>
        /// <item><description><c>PEAK_MEMORY</c>: the peak memory consumption.</description></item>
        /// <item><description><c>SCAN_SIZE</c>: the amount of scanned data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU_COST</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>Sorts the query results by a specified field. The value is a JSON array string, such as <c>[{&quot;Field&quot;:&quot;Time2SumValue&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</c>. The array can contain only one object. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><c>Field</c>: the sort field. This parameter is case-sensitive. Valid values:<list type="bullet">
        /// <item><description>NEW report: <c>Time2SumValue</c>, <c>Time2AvgValue</c>, <c>Time2MaxValue</c>.</description></item>
        /// <item><description>CHANGED report: <c>AvgChangeRatePercent</c>, <c>AvgTime1Value</c>, <c>AvgTime2Value</c>, <c>SumChangeRatePercent</c>, <c>SumTime1Value</c>, <c>SumTime2Value</c>, <c>MaxChangeRatePercent</c>, <c>MaxTime1Value</c>, <c>MaxTime2Value</c>.</description></item>
        /// <item><description>All report types and analysis metrics: <c>AvgRt</c>, <c>MaxRt</c>.</description></item>
        /// <item><description><c>QUERY_COUNT</c>: <c>TotalQueryTime</c>.</description></item>
        /// <item><description><c>CPU_COST</c>: <c>QueryCount</c>, <c>AvgPlanningTime</c>, <c>MaxPlanningTime</c>, <c>AvgExecutionTime</c>, <c>MaxExecutionTime</c>.</description></item>
        /// <item><description><c>SHUFFLE_SIZE</c>, <c>PEAK_MEMORY</c>: <c>QueryCount</c>.</description></item>
        /// <item><description><c>SCAN_SIZE</c>: <c>QueryCount</c>, <c>TotalScanCost</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><c>Type</c>: the sort order. This parameter is case-insensitive. Valid values:<list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>NEW reports are sorted by <c>Time2SumValue</c> in descending order by default.</description></item>
        /// <item><description>CHANGED reports are sorted by <c>AvgChangeRatePercent</c> in descending order by default.</description></item>
        /// <item><description>The value of <c>Field</c> must be applicable to the current report type and <c>MetricType</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;AvgChangeRatePercent&quot;,&quot;Type&quot;:&quot;Desc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the SQL Pattern comparison report.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

    }

}
