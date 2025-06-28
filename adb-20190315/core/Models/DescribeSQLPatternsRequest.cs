// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL clusters in a region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T00:15:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The keyword that is used for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of file titles and error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): simplified Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order by which to sort query results. Specify the parameter value in the JSON format. Example: <c>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PatternCreationTime</c>: the earliest commit time of the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>AverageQueryTime</c>: the average total amount of time consumed by the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>MaxQueryTime</c>: the maximum total amount of time consumed by the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>AverageExecutionTime</c>: the average execution duration of the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>MaxExecutionTime</c>: the maximum execution duration of the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>AveragePeakMemory</c>: the average peak memory usage of the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>MaxPeakMemory</c>: the maximum peak memory usage of the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>AverageScanSize</c>: the average amount of data scanned based on the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>MaxScanSize</c>: the maximum amount of data scanned based on the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>QueryCount</c>: the number of queries performed in association with the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>FailedCount</c>: the number of failed queries performed in association with the SQL pattern within the time range to query.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the value <b>1</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the value <b>30</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Only data within the last 14 days can be queried. For example, if the current time is 2021-11-22T12:00:00Z, you can query SQL patterns at a point in time as early as 2021-11-09T12:00:00Z.</para>
        /// </description></item>
        /// <item><description><para>The maximum time range that can be specified is 24 hours.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T00:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
