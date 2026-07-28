// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkMetricsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Explicitly passes sub-account IDs.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The start time, in <b>ms</b>, in <b>UNIX</b> timestamp format. If not specified, the most recent 1 hour is queried by default. The earliest start time is 7 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239092000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The collection of metric query parameters for specific business scenarios. For metric description of each scenario, see <a href="https://help.aliyun.com/document_detail/2833348.html">GetNisNetworkMetrics</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string DimensionsShrink { get; set; }

        /// <summary>
        /// <para>The end time, in <b>ms</b>, in <b>UNIX</b> timestamp format. If not specified, the most recent 1 hour is queried by default. If only BeginTime is specified, the 1 hour after BeginTime is queried. The maximum time span between the end time and start time is 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373700099</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The metric name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>bps: bits per second.</description></item>
        /// <item><description>pps: packets per second.</description></item>
        /// <item><description>rtt: round-trip time when establishing a TCP connection.</description></item>
        /// <item><description>RetransmitRate: retransmission rate.</description></item>
        /// <item><description>RatelimitDropPps: rate of packets dropped due to throttling.</description></item>
        /// <item><description>ActiveSessionCount: concurrent sessions.</description></item>
        /// <item><description>NewSessionPerSecond: new sessions per second.</description></item>
        /// <item><description>BandwidthUtilization: bandwidth utilization.</description></item>
        /// <item><description>passRate: inspection pass rate.<remarks>
        /// <para>If no RTT data is available within the selected time range, the connection is a persistent connection and no initial connection was established during that period.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>Analyzes traffic by the Alibaba Cloud network resource type used for traffic forwarding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AccessInternetIpV4: all Alibaba Cloud public IPv4 addresses.</description></item>
        /// <item><description>AccessInternetIpV4Limited: all region-throttled Alibaba Cloud public IPv4 addresses.</description></item>
        /// <item><description>ElasticIP: Elastic IP Address (EIP) (IPv4).</description></item>
        /// <item><description>PublicIpEcs: static public IP address bound to an ECS instance (IPv4).</description></item>
        /// <item><description>PublicIpClb: static public IP address bound to a CLB instance (IPv4).</description></item>
        /// <item><description>NAT: public traffic through SNAT.</description></item>
        /// <item><description>TR: traffic through Cloud Enterprise Network (CEN) transit routers.</description></item>
        /// <item><description>TRAttachment: traffic through CEN connection instances, including intra-region and inter-region connections. Intra-region connections have inbound and outbound directions. Inter-region connections have only the outbound direction.</description></item>
        /// <item><description>VBR: traffic through virtual border routers.</description></item>
        /// <item><description>GA: traffic through Global Accelerator.</description></item>
        /// <item><description>InternetProbing: Internet quality probing data.</description></item>
        /// <item><description>IntranetProbing: internal network quality probing data.</description></item>
        /// <item><description>NisInspectionHistoryReportScore: inspection history scores.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessInternetIPV4</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: TimestampAscending. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TimestampAscending: sorts by time in ascending order.</description></item>
        /// <item><description>TimestampDescending: sorts by time in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TimestampAscending</para>
        /// </summary>
        [NameInMap("ScanBy")]
        [Validation(Required=false)]
        public string ScanBy { get; set; }

        [NameInMap("StepMinutes")]
        [Validation(Required=false)]
        public int? StepMinutes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use cross-account access mode. This is a reserved parameter and is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCrossAccount")]
        [Validation(Required=false)]
        public bool? UseCrossAccount { get; set; }

    }

}
