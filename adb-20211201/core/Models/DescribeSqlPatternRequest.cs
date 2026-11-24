// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSqlPatternRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all clusters in a specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1ej1nq9n6****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Sorts the query results by a specified field. The format is a JSON character string, such as <c>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Pattern</c>: SQL pattern.</description></item>
        /// <item><description><c>AccessIP</c>: client IP address.</description></item>
        /// <item><description><c>User</c>: username.</description></item>
        /// <item><description><c>QueryCount</c>: total number of queries.</description></item>
        /// <item><description><c>AvgPeakMemory</c>: average peak memory usage. Unit: KB.</description></item>
        /// <item><description><c>MaxPeakMemory</c>: Peak Volume memory. Unit: KB.</description></item>
        /// <item><description><c>AvgCpuTime</c>: average computing duration. Unit: milliseconds.</description></item>
        /// <item><description><c>MaxCpuTime</c>: maximum computing duration. Unit: milliseconds.</description></item>
        /// <item><description><c>AvgStageCount</c>: average number of stages.</description></item>
        /// <item><description><c>MaxStageCount</c>: maximum number of stages.</description></item>
        /// <item><description><c>AvgTaskCount</c>: average number of tasks.</description></item>
        /// <item><description><c>MaxTaskCount</c>: maximum number of tasks.</description></item>
        /// <item><description><c>AvgScanSize</c>: average scanned data size. Unit: KB.</description></item>
        /// <item><description><c>MaxScanSize</c>: maximum scanned data size. Unit: KB.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending sorting.</description></item>
        /// <item><description><c>Desc</c>: descending sorting.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the Settings are not specified, the results are sorted in ascending order by the <c>Pattern</c> field by default.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To sort by the <c>AccessIP</c> field, you must set the <c>Type</c> parameter to <c>accessip</c>. To sort by the <c>User</c> field, you must leave the <c>Type</c> parameter empty or set it to <c>user</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers greater than 0 and less than or equal to the maximum value of the Integer type.
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
        /// <item><description><b>10</b> (default)</description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
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
        /// <para>The keyword that the SQL pattern must contain.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the details of all SQL patterns for the cluster on the date specified by the <c>StartTime</c> parameter are returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlPattern")]
        [Validation(Required=false)]
        public string SqlPattern { get; set; }

        /// <summary>
        /// <para>The start date for the query. The time is in UTC and formatted as yyyy-MM-dd.</para>
        /// <remarks>
        /// <para>Only data from the last 30 days can be queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-30</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The dimension by which to aggregate SQL patterns. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>user</c>: aggregates by user.</description></item>
        /// <item><description><c>accessip</c>: aggregates by access IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, SQL patterns are aggregated by the <c>user</c> dimension by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
