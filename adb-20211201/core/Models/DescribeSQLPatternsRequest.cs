// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL (Data Lakehouse Edition) cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> API to find the cluster IDs of all AnalyticDB for MySQL (Data Lakehouse Edition) clusters in a specific region.</para>
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
        /// <para>The end of the time range to query. The time must be in UTC and formatted as <em>yyyy-MM-ddTHH:mm:ssZ</em>.</para>
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
        /// <para>The keyword for filtering the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The response language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Simplified Chinese (default)</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// <item><description><para><b>ja</b>: Japanese</para>
        /// </description></item>
        /// <item><description><para><b>zh-tw</b>: Traditional Chinese</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sort order for the results. Specify this parameter as a JSON string, for example, <c>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The string consists of the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PatternCreationTime</c>: The earliest submission time of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>AverageQueryTime</c>: The average query time of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>MaxQueryTime</c>: The maximum query time of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>AverageExecutionTime</c>: The average execution time of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>MaxExecutionTime</c>: The maximum execution time of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>AveragePeakMemory</c>: The average peak memory of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>MaxPeakMemory</c>: The maximum peak memory of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>AverageScanSize</c>: The average scanned data size of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>MaxScanSize</c>: The maximum scanned data size of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>QueryCount</c>: The query count of the pattern.</para>
        /// </description></item>
        /// <item><description><para><c>FailedCount</c>: The failure count of the pattern.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sort order. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending order.</para>
        /// </description></item>
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
        /// <para>The page number. Must be an integer greater than 0. Default: 1.</para>
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
        /// <item><description><para><b>10</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SqlPatternHash")]
        [Validation(Required=false)]
        public long? SqlPatternHash { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The time must be in UTC and formatted as <em>yyyy-MM-ddTHH:mm:ssZ</em>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Data is available for the last 14 days only.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The time range cannot exceed 24 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-06T03:06:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username of the database account used to execute the SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
