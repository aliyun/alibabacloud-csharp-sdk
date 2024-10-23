// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSqlPatternRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.</para>
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
        /// <para>The order by which to sort query results. Specify the parameter value in the JSON string format. Example: <c>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Pattern</c>: the SQL pattern.</description></item>
        /// <item><description><c>AccessIP</c>: the IP address of the client.</description></item>
        /// <item><description><c>User</c>: the username.</description></item>
        /// <item><description><c>QueryCount</c>: the number of queries performed in association with the SQL pattern within the time range to query.</description></item>
        /// <item><description><c>AvgPeakMemory</c>: the average peak memory usage of the SQL pattern within the time range to query. Unit: KB.</description></item>
        /// <item><description><c>MaxPeakMemory</c>: the maximum peak memory usage of the SQL pattern within the time range to query. Unit: KB.</description></item>
        /// <item><description><c>AvgCpuTime</c>: the average execution duration of the SQL pattern within the time range to query. Unit: milliseconds.</description></item>
        /// <item><description><c>MaxCpuTime</c>: the maximum execution duration of the SQL pattern within the time range to query. Unit: milliseconds.</description></item>
        /// <item><description><c>AvgStageCount</c>: the average number of stages.</description></item>
        /// <item><description><c>MaxStageCount</c>: the maximum number of stages.</description></item>
        /// <item><description><c>AvgTaskCount</c>: the average number of tasks.</description></item>
        /// <item><description><c>MaxTaskCount</c>: the maximum number of tasks.</description></item>
        /// <item><description><c>AvgScanSize</c>: the average amount of data scanned based on the SQL pattern within the time range to query. Unit: KB.</description></item>
        /// <item><description><c>MaxScanSize</c>: the maximum amount of data scanned based on the SQL pattern within the time range to query. Unit: KB.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, query results are sorted in ascending order of <c>Pattern</c>.</para>
        /// </description></item>
        /// <item><description><para>If you want to sort query results by <c>AccessIP</c>, you must set the <c>Type</c> parameter to <c>accessip</c>. If you want to sort query results by <c>User</c>, you must leave the <c>Type</c> parameter empty or set it to <c>user</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be a positive integer. Default value: <b>30</b>.</para>
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
        /// <para>The keyword that is used for the query.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, all SQL patterns of the AnalyticDB for MySQL cluster within the time period specified by <c>StartTime</c> are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlPattern")]
        [Validation(Required=false)]
        public string SqlPattern { get; set; }

        /// <summary>
        /// <para>The start date to query. Specify the time in the <em>yyyy-MM-dd</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>Only data within the last 30 days can be queried.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-30</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The dimension by which to aggregate the SQL patterns. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>user</c>: aggregates the SQL patterns by user.</description></item>
        /// <item><description><c>accessip</c>: aggregates the SQL patterns by client IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the SQL patterns are aggregated by <c>user</c>.</para>
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
