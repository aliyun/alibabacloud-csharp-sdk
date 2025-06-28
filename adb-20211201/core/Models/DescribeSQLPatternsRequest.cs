// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-8vb8de93v9b****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-07T03:06:00Z</para>
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
        /// <para>The language. Valid values:</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b> (default)</description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
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
        /// <list type="bullet">
        /// <item><description>Only data within the last 14 days can be queried.</description></item>
        /// <item><description>The maximum time range that can be specified is 24 hours.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-06T03:06:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
