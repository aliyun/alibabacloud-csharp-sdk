// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableAccessCountRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all AnalyticDB for MySQL clusters in a specific region, including cluster IDs.</para>
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
        /// <para>The sorting rule for the query results. The value is a JSON string. Example: <c>[{&quot;Field&quot;:&quot;TableSchema&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. The JSON string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>TableSchema</c>: The name of the database.</para>
        /// </description></item>
        /// <item><description><para><c>TableName</c>: The name of the table.</para>
        /// </description></item>
        /// <item><description><para><c>AccessCount</c>: The number of times the table was accessed.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: The sorting type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: Ascending order.</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: Descending order.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the results are sorted in ascending order by the database name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;TableSchema&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The value must be a positive integer. Default value: <b>30</b>.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the available regions and zones of AnalyticDB for MySQL, including the region IDs.</para>
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
        /// <para>The date to query. Use the <em>yyyy-MM-dd</em> format. The time is in UTC.</para>
        /// <remarks>
        /// <para>You can query data from the last 30 days only.</para>
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
        /// <para>The name of the target table.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, data on the access frequency of all tables in the cluster for the specified date is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOMER</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
