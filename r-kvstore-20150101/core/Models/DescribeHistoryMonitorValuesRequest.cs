// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You can query monitoring data within the past month. The maximum time range to query is 7 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-06T00:30:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and its value is fixed at <c>01m</c>.</para>
        /// <para>The system automatically determines the <b>query interval</b> based on the specified start and end times. For example, if the specified time range is 10 minutes or less, data is aggregated every 5 seconds, and the query results are returned at 5-second intervals.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If the specified <c>StartTime</c> is not at a data aggregation point, the first time point returned by the system is the nearest preceding data aggregation point. For example, if you set StartTime to <c>2022-01-20T12:01:48Z</c>, the first time point returned is <c>2022-01-20T12:01:45Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If the instance has 32 or more data shards, the minimum data aggregation frequency is 1 minute.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01m</para>
        /// </summary>
        [NameInMap("IntervalForHistory")]
        [Validation(Required=false)]
        public string IntervalForHistory { get; set; }

        /// <summary>
        /// <para>The monitoring metric to query, such as <c>CpuUsage</c>. To specify multiple metrics, separate them with a comma (,).</para>
        /// <list type="bullet">
        /// <item><description><para>For instances that use the cluster or read/write splitting architecture:</para>
        /// <list type="bullet">
        /// <item><description><para>To query the overall CPU utilization of all data nodes, set this parameter to <b>CpuUsage$db</b>.</para>
        /// </description></item>
        /// <item><description><para>To query the CPU utilization of a single data node, set this parameter to <b>CpuUsage</b> and specify the node in the <c>NodeId</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For instances that use the standard architecture (primary/standby), set this parameter to <b>CpuUsage</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about monitoring metrics, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/redis/developer-reference/api-r-kvstore-2015-01-01-describehistorymonitorvalues-redis#monitorKeys-note">Additional information about the MonitorKeys parameter</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/redis/developer-reference/api-r-kvstore-2015-01-01-describehistorymonitorvalues-redis#monitorKeys-note">Additional information about the MonitorKeys parameter</a> below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the <c>UsedMemory</c> and <c>quotaMemory</c> metrics are returned by default.</para>
        /// </description></item>
        /// <item><description><para>To ensure query efficiency, we recommend that you specify a maximum of 5 monitoring metrics for a single node and a maximum of 1 aggregate monitoring metric per query.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CpuUsage</para>
        /// </summary>
        [NameInMap("MonitorKeys")]
        [Validation(Required=false)]
        public string MonitorKeys { get; set; }

        /// <summary>
        /// <para>The ID of a node in the instance. You can use this parameter to query the monitoring data of a specific node.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for instances that use the read/write splitting or cluster architecture.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/473786.html">DescribeLogicInstanceTopology</a> operation to query node IDs.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0#1679****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>If you want to query the metrics of a read-only node in a cloud-native instance that uses a read/write splitting architecture, you must specify the <b>NodeId</b> and set this parameter to <b>READONLY</b>.</para>
        /// <remarks>
        /// <para>In all other cases, you do not need to specify this parameter. You can also set it to <b>MASTER</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>READONLY</para>
        /// </summary>
        [NameInMap("NodeRole")]
        [Validation(Required=false)]
        public string NodeRole { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-06T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
