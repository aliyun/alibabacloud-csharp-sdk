// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryMonitorValuesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query for historical monitoring data. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>You can query monitoring data of the last month. The maximum query range cannot exceed 7 days.</para>
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
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. The value is fixed to <c>01m</c>.</para>
        /// <para>The system automatically determines the <b>query interval</b> based on the start time and end time. For example, if the query time range is less than or equal to 10 minutes, the data aggregation frequency is 5s, and the query results are returned at a frequency of 5s.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The query results are aligned with the data aggregation frequency of the instance. If the StartTime you specify does not fall on a data aggregation point, the first time point returned by the system is the nearest data aggregation point. For example, if the StartTime you specify is 2022-01-20T12:01:48Z, the first time point returned by the system is 2022-01-20T12:01:45Z.</description></item>
        /// <item><description>If the number of data shards of the instance is greater than or equal to 32, the minimum data aggregation frequency is 1 minute.</description></item>
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
        /// <para>The monitoring metrics. To specify multiple monitoring metrics, separate them with commas (,). Take CpuUsage as an example:</para>
        /// <list type="bullet">
        /// <item><description><para>Cluster or read/write splitting architecture:</para>
        /// <list type="bullet">
        /// <item><description>To query the overall CPU usage of all data nodes (DB), specify <b>CpuUsage$db</b>.</description></item>
        /// <item><description>To query the CPU usage of a single data node, specify <b>CpuUsage</b> and set the NodeId parameter to the DB node.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Standard architecture (primary/secondary): Specify <b>CpuUsage</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about monitoring metrics and their descriptions, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/redis/developer-reference/api-r-kvstore-2015-01-01-describehistorymonitorvalues-redis#monitorKeys-note">MonitorKeys parameter description</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/redis/developer-reference/api-r-kvstore-2015-01-01-describehistorymonitorvalues-redis#monitorKeys-note">MonitorKeys parameter description</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is empty by default. If this parameter is not specified, the UsedMemory and quotaMemory metrics are returned.</description></item>
        /// <item><description>To ensure query efficiency, specify no more than 5 monitoring metrics in a single request when querying metrics for a single node. Specify no more than 1 monitoring metric in a single request when querying aggregated monitoring metrics.</description></item>
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
        /// <para>The node ID of the instance. Specify this parameter to query the monitoring information of a specific node.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only when the instance uses a read/write splitting or cluster architecture.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/473786.html">DescribeLogicInstanceTopology</a> operation to query node IDs.</description></item>
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
        /// <para>To query the metrics of a read-only node in a cloud-native read/write splitting instance, specify the <b>NodeId</b> parameter and set this parameter to <b>READONLY</b>.</para>
        /// <remarks>
        /// <para> In other cases, you do not need to specify this parameter (or set it to <b>MASTER</b>).</para>
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
        /// <para>The start time of the query for historical monitoring data. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
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
