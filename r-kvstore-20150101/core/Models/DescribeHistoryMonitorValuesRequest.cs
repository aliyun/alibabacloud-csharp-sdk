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
        /// <list type="bullet">
        /// <item><description>You can query the monitoring data of the last month. The maximum time range that you can specify for a query is seven days.</description></item>
        /// <item><description>If the number of data nodes in the instance is greater than 32, the time range to query for the Data Node Aggregation and Proxy Node Aggregation metrics cannot exceed 1 hour.</description></item>
        /// </list>
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
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The interval at which to collect monitoring data. Unit: minutes. Set the value to <c>01m</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01m</para>
        /// </summary>
        [NameInMap("IntervalForHistory")]
        [Validation(Required=false)]
        public string IntervalForHistory { get; set; }

        /// <summary>
        /// <para>The monitoring metrics. Separate the metrics with commas (,). Take CpuUsage as an example:</para>
        /// <list type="bullet">
        /// <item><description><para>Cluster or read/write splitting instances</para>
        /// <list type="bullet">
        /// <item><description>To query the overall CPU utilization of all data nodes, specify <b>CpuUsage$db</b>.</description></item>
        /// <item><description>To query the CPU utilization of a single data node, specify <b>CpuUsage</b> and NodeId.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Standard master-replica instances: Specify only <b>CpuUsage</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about monitoring metrics and their descriptions, see <a href="https://www.alibabacloud.com/help/zh/redis/developer-reference/api-r-kvstore-2015-01-01-describehistorymonitorvalues-redis#monitorKeys-note">Additional description of MonitorKeys</a>.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is empty by default, which indicates that the UsedMemory and quotaMemory metrics are returned.</para>
        /// </description></item>
        /// <item><description><para>To ensure query efficiency, we recommend that you specify no more than five metrics for a single node at a time, and specify only a single metric when you query aggregate metrics.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>memoryUsage</para>
        /// </summary>
        [NameInMap("MonitorKeys")]
        [Validation(Required=false)]
        public string MonitorKeys { get; set; }

        /// <summary>
        /// <para>The ID of the node in the instance. You can set this parameter to query the data of a specified node.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is available only for read/write splitting or cluster instances of ApsaraDB for Redis.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/94665.html">DescribeLogicInstanceTopology</a> operation to query node IDs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0#1679****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>If you want to query the metrics of the read replicas in a cloud-native read/write splitting instance, you must set this parameter to <b>READONLY</b> and specify <b>NodeId</b>.</para>
        /// <remarks>
        /// <para>In other cases, you do not need to specify this parameter or you can set this parameter to <b>MASTER</b>.</para>
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

    }

}
