// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3axxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
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
        /// <item><description>common: the general-purpose database proxy</description></item>
        /// <item><description>exclusive: the dedicated database proxy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DedicatedProxy</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-21T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The performance metrics that you want to query.</para>
        /// <para>If the instance runs MySQL, you can query only the <b>Maxscale_CpuUsage</b> performance metric, which indicates the CPU utilization of the instance.</para>
        /// <para>If the instance runs PostgreSQL, you can query the following performance metrics:</para>
        /// <list type="bullet">
        /// <item><description><b>Maxscale_TotalConns</b>: the number of connections per second</description></item>
        /// <item><description><b>Maxscale_CurrentConns</b>: the number of connections that are established</description></item>
        /// <item><description><b>Maxscale_DownFlows</b>: outbound traffic</description></item>
        /// <item><description><b>Maxscale_UpFlows</b>: inbound traffic</description></item>
        /// <item><description><b>Maxscale_QPS</b>: QPS</description></item>
        /// <item><description><b>Maxscale_MemUsage</b>: memory usage</description></item>
        /// <item><description><b>Maxscale_CpuUsage</b>: CPU utilization</description></item>
        /// </list>
        /// <para>If you want to query more than one performance metric, separate the performance metrics with commas (,). You can specify up to six performance metrics in a single request.</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
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
