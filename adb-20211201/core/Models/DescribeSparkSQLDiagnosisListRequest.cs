// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkSQLDiagnosisListRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all AnalyticDB for MySQL Data Lakehouse Edition (3.0) clusters in a specific region, including the cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-2zez35ww415xjwk5</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The maximum start time. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-28 23:00:00</para>
        /// </summary>
        [NameInMap("MaxStartTime")]
        [Validation(Required=false)]
        public string MaxStartTime { get; set; }

        /// <summary>
        /// <para>The minimum start time. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-28 22:00:00</para>
        /// </summary>
        [NameInMap("MinStartTime")]
        [Validation(Required=false)]
        public string MinStartTime { get; set; }

        /// <summary>
        /// <para>Sorts the query results by a specified field. The value must be a JSON string. Example: <c>[{&quot;Field&quot;:&quot;MaxExclusiveTime&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Parameters in the JSON string:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>MaxExclusiveTime</c>: the maximum execution time.</description></item>
        /// <item><description><c>PeakMemory</c>: the peak memory usage.</description></item>
        /// <item><description><c>QueryStartTime</c>: the query start time.</description></item>
        /// <item><description><c>QueryWallclockTime</c>: the query execution time.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Asc</c>: ascending order.</description></item>
        /// <item><description><c>Desc</c>: descending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, the results are sorted in ascending order by the <c>MaxExclusiveTime</c> field by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;QueryStartTime\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the regions and zones supported by AnalyticDB for MySQL, including region IDs.</para>
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
        /// <para>The unique ID of the code block in the Spark job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public long? StatementId { get; set; }

    }

}
