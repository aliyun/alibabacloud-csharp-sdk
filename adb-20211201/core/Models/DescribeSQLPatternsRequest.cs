// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all AnalyticDB for MySQL Data Lakehouse Edition clusters in a specified region, including the cluster IDs.</para>
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
        /// <para>The end time of the query. Specify the time in UTC in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
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
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Simplified Chinese (default language).</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sorting rule for the query results. The format is a JSON character string. Example: <c>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The JSON character string contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PatternCreationTime</c>: the earliest commit time of the pattern within the query time range.</description></item>
        /// <item><description><c>AverageQueryTime</c>: the average total time consumed by the pattern within the query time range.</description></item>
        /// <item><description><c>MaxQueryTime</c>: the maximum total time consumed by the pattern within the query time range.</description></item>
        /// <item><description><c>AverageExecutionTime</c>: the average execution duration of the pattern within the query time range.</description></item>
        /// <item><description><c>MaxExecutionTime</c>: the maximum execution duration of the pattern within the query time range.</description></item>
        /// <item><description><c>AveragePeakMemory</c>: the average peak memory usage of the pattern within the query time range.</description></item>
        /// <item><description><c>MaxPeakMemory</c>: the maximum peak memory usage of the pattern within the query time range.</description></item>
        /// <item><description><c>AverageScanSize</c>: the average amount of data read by the pattern within the query time range.</description></item>
        /// <item><description><c>MaxScanSize</c>: the maximum amount of data read by the pattern within the query time range.</description></item>
        /// <item><description><c>QueryCount</c>: the number of executions of the pattern within the query time range.</description></item>
        /// <item><description><c>FailedCount</c>: the number of failed executions of the pattern within the query time range.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sort order. The value is not case-sensitive. Valid values:</para>
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
        /// <para>The page number. Valid values: integers greater than 0 and up to the maximum integer value.
        /// Default value: 1.</para>
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
        /// <item><description><b>10</b> (default value)</description></item>
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
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The hash value of the SQL pattern, which is used to filter a specific SQL pattern.</para>
        /// </summary>
        [NameInMap("SqlPatternHash")]
        [Validation(Required=false)]
        public long? SqlPatternHash { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in UTC in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can only query data from the last 14 days.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The interval between the start time and the end time cannot exceed 24 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-06T03:06:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the database account that executes the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
