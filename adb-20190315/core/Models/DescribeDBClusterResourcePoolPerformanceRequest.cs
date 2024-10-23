// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterResourcePoolPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end of the time range to monitor the resource group. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-10T07:01Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The metrics of the resource group. You can enter multiple metrics at the same time to query the monitoring information. Separate multiple metrics with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AnalyticDB_RP_CPU</b>: the average CPU utilization. Unit: %.</description></item>
        /// <item><description><b>AnalyticDB_RP_RT</b>: the query response time (RT). Unit: milliseconds.</description></item>
        /// <item><description><b>AnalyticDB_RP_QPS</b>: the queries per second (QPS). The value of this parameter must be a numeric value.</description></item>
        /// <item><description><b>AnalyticDB_RP_WaitTime</b>: the query waiting time. Unit: milliseconds.</description></item>
        /// <item><description><b>AnalyticDB_RP_OriginalNode</b>: the number of basic nodes in the resource group.</description></item>
        /// <item><description><b>AnalyticDB_RP_ActualNode</b>: the number of scheduled nodes that are scaled out in the resource group.</description></item>
        /// <item><description><b>AnalyticDB_RP_PlanNode</b>: the number of scheduled nodes to be scaled out in the resource group.</description></item>
        /// <item><description><b>AnalyticDB_RP_TotalNode</b>: the total number of nodes in the resource group. Total number of nodes = Number of basic nodes + Number of scheduled nodes that are scaled out.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you leave this parameter empty, the monitoring information about all metrics is returned.</para>
        /// </description></item>
        /// <item><description><para>For more information about scaling plans, see <a href="https://help.aliyun.com/document_detail/189507.html">Create a resource scaling plan</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AnalyticDB_RP_CPU</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The names of the resource groups that you want to query. You can enter multiple names of resource groups. Separate multiple names with commas (,).</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The value of this parameter is case-insensitive. For example, <c>USER_DEFAULT</c> and <c>user_default</c> specify the same resource group.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the monitoring information about the <c>USER_DEFAULT</c> resource group is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TEST_POOL</para>
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to monitor the resource group. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mmZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You can view only the monitoring information about the resource groups within the last two days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-10T07:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
