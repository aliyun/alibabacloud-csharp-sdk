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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specified region, including the instance IDs.</para>
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
        /// <para>The end time of the query. Specify the time in the <c>YYYY-MM-DDTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the time interval between the start time and the end time cannot exceed 7 days.</para>
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
        /// <para>The names of the performance metrics. Separate multiple metrics with commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/86943.html">Performance metric table</a>.</para>
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
        /// <item><description><b>master</b>: Master node.</description></item>
        /// <item><description><b>segment</b>: Segment node.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the monitoring metrics of all nodes are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The names of the nodes for which you want to query monitoring metrics. Separate multiple node names with commas (,), such as <c>master-10******1,master-10******2</c>. You can call the <a href="https://help.aliyun.com/document_detail/390136.html">DescribeDBClusterNode</a> operation to obtain the node names.</para>
        /// <para>You can also filter nodes based on the values of monitoring metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>top10</b>: The top 10 nodes with the highest monitoring metric values.</description></item>
        /// <item><description><b>top20</b>: The top 20 nodes with the highest monitoring metric values.</description></item>
        /// <item><description><b>bottom10</b>: The bottom 10 nodes with the lowest monitoring metric values.</description></item>
        /// <item><description><b>bottom20</b>: The bottom 20 nodes with the lowest monitoring metric values.</description></item>
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
        /// <para>The start time of the query. Specify the time in the <c>YYYY-MM-DDTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>You can query monitoring information only for the last 30 days.</para>
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
