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
        /// <para>You can call the DescribeDBClusters operation to query the IDs of all clusters in a specified region.
        /// <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a></para>
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
        /// <para>Specifies the sorting of query results by a specified field. The format is a JSON character string, such as <c>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Parameters:</para>
        /// <list type="bullet">
        /// <item><description><para>Field: the sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pattern: SQL pattern.</description></item>
        /// <item><description>AccessIP: client IP address.</description></item>
        /// <item><description>User: username.</description></item>
        /// <item><description>QueryCount: total number of queries.</description></item>
        /// <item><description>AvgPeakMemory: average peak memory. Unit: KB.</description></item>
        /// <item><description>MaxPeakMemory: Peak Volume memory. Unit: KB.</description></item>
        /// <item><description>AvgCpuTime: average computing duration. Unit: milliseconds.</description></item>
        /// <item><description>MaxCpuTime: maximum computing duration. Unit: milliseconds.</description></item>
        /// <item><description>AvgStageCount: average number of stages.</description></item>
        /// <item><description>MaxStageCount: maximum number of stages.</description></item>
        /// <item><description>AvgTaskCount: average number of tasks.</description></item>
        /// <item><description>MaxTaskCount: maximum number of tasks.</description></item>
        /// <item><description>AvgScanSize: average scan size. Unit: KB.</description></item>
        /// <item><description>MaxScanSize: maximum scan size. Unit: KB.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Type: the sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending sorting.</description></item>
        /// <item><description>Desc: descending sorting.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no Settings are specified for this parameter, the results are sorted in ascending order by the Pattern field by default.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>To perform sorting by the AccessIP field, you must set the Type parameter to accessip. To perform sorting by the User field, you must leave the Type parameter empty or set it to user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;Pattern&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers greater than 0 and no greater than the maximum value of the Integer type.
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
        /// <para>If this parameter is not specified, the details of all SQL patterns for the cluster on the date specified by the StartTime parameter are returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlPattern")]
        [Validation(Required=false)]
        public string SqlPattern { get; set; }

        /// <summary>
        /// <para>The start date of the query. The time is in UTC and formatted as yyyy-MM-dd.</para>
        /// <remarks>
        /// <para>You can only query data within the last 30 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-30</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Aggregates SQL patterns by a specified dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user: aggregates by user.</description></item>
        /// <item><description>accessip: aggregates by access IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, SQL patterns are aggregated by user by default.</para>
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
