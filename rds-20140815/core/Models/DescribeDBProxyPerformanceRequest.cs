// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3a****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The type of the database proxy instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>common: general-purpose database proxy</description></item>
        /// <item><description>exclusive: dedicated database proxy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exclusive</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        /// <summary>
        /// <para>The aggregation dimension. Valid values. The service and server values cannot be specified at the same time.</para>
        /// <list type="bullet">
        /// <item><description><para>service: aggregates monitoring metrics by proxy endpoint.</para>
        /// </description></item>
        /// <item><description><para>node: aggregates monitoring metrics by proxy node.</para>
        /// </description></item>
        /// <item><description><para>server: aggregates monitoring metrics by database node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>service,node
        /// server,node
        /// service</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-21T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics.</para>
        /// <para>RDS MySQL supports only <b>Maxscale_CpuUsage</b>: CPU utilization.</para>
        /// <para>RDS PostgreSQL supports the following performance metrics:</para>
        /// <list type="bullet">
        /// <item><description><b>Maxscale_TotalConns</b>: connection rate</description></item>
        /// <item><description><b>Maxscale_CurrentConns</b>: current connections</description></item>
        /// <item><description><b>Maxscale_DownFlows</b>: outbound traffic</description></item>
        /// <item><description><b>Maxscale_UpFlows</b>: inbound traffic</description></item>
        /// <item><description><b>Maxscale_QPS</b>: request rate (QPS)</description></item>
        /// <item><description><b>Maxscale_MemUsage</b>: memory utilization</description></item>
        /// <item><description><b>Maxscale_CpuUsage</b>: CPU utilization</description></item>
        /// </list>
        /// <para>To query multiple performance metrics, separate them with commas (,). You can query up to six performance metrics at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Maxscale_CpuUsage</para>
        /// </summary>
        [NameInMap("MetricsName")]
        [Validation(Required=false)]
        public string MetricsName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-19T01:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
