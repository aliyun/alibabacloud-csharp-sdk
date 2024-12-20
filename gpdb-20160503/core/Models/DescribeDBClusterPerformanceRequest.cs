// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBClusterPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query details about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is seven days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-03T15:10Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metric that you want to query. Separate multiple values with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance parameters</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpg_conn_count</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>master</b>: coordinator node.</description></item>
        /// <item><description><b>segment</b>: compute node.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the performance metrics of all nodes are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The nodes for which you want to query performance metrics. Separate multiple values with commas (,). Example: <c>master-10******1,master-10******2</c>. You can call the <a href="https://help.aliyun.com/document_detail/390136.html">DescribeDBClusterNode</a> operation to query the names of nodes.</para>
        /// <para>You can also filter the nodes based on their metric values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>top10</b>: the 10 nodes that have the highest metric values.</description></item>
        /// <item><description><b>top20</b>: the 20 nodes that have the highest metric values.</description></item>
        /// <item><description><b>bottom10</b>: the 10 nodes that have the lowest metric values.</description></item>
        /// <item><description><b>bottom20</b>: the 20 nodes that have the lowest metric values.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>top10</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string Nodes { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testgroup</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>You can query monitoring information only within the last 30 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-03T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
