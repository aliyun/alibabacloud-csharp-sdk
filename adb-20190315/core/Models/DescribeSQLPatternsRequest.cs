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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query details, including cluster IDs, for all AnalyticDB for MySQL clusters in a specific region.</para>
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
        /// <para>The end of the time range to query. Specify the time in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
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
        /// <para>The keyword for filtering SQL patterns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language of the response. This parameter is used to localize messages such as error details. Valid values:</para>
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
        /// <para>Specifies how to sort the query results. Set this parameter to a JSON string. Example: <c>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The JSON string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PatternCreationTime</c>: the earliest submission time of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>AverageQueryTime</c>: the average total query time of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>MaxQueryTime</c>: the maximum total query time of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>AverageExecutionTime</c>: the average execution time of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>MaxExecutionTime</c>: the maximum execution time of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>AveragePeakMemory</c>: the average peak memory usage of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>MaxPeakMemory</c>: the maximum peak memory usage of the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>AverageScanSize</c>: the average amount of data scanned by the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>MaxScanSize</c>: the maximum amount of data scanned by the SQL pattern within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>QueryCount</c>: the number of times the SQL pattern is executed within the specified time range.</para>
        /// </description></item>
        /// <item><description><para><c>FailedCount</c>: the number of failed executions for the SQL pattern within the specified time range.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;AverageQueryTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than 0.</para>
        /// <remarks>
        /// <para>The default value is <b>1</b>.</para>
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
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>30</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the available regions and availability zones for AnalyticDB for MySQL, including the region IDs.</para>
        /// </remarks>
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
        /// <para>The start of the time range to query. Specify the time in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can query data for the last 14 days only. For example, if the current time is 2021-11-22T12:00:00Z, the earliest time that you can query is 2021-11-09T12:00:00Z.</para>
        /// </description></item>
        /// <item><description><para>The interval between the start time and the end time cannot exceed 24 hours.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T00:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The username that is used to filter the SQL patterns. If you specify this parameter, only the SQL patterns of the specified user are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
