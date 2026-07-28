// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisTrafficMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The start timestamp, in milliseconds. If not specified, the most recent 1 hour is queried by default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239092000</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The network traffic direction based on Alibaba Cloud resources.</para>
        /// <para>In: traffic flowing into the target resource.
        /// Out: traffic flowing out of the target resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end timestamp, in milliseconds. If not specified, the most recent 1 hour is queried by default. If only BeginTime is specified, the 1 hour after BeginTime is queried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373700099</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies additional filter conditions for the traffic to perform focused network traffic analysis.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetNisTrafficMetricsRequestFilter> Filter { get; set; }
        public class GetNisTrafficMetricsRequestFilter : TeaModel {
            /// <summary>
            /// <para>Based on the TupleDimension field and TrafficScenario field, the supported filter condition label keys are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><c>TrafficScenario = VpcFlowLogAll</c> / <c>VpcFlowLogInternet</c> (VPC flow log scenario):</para>
            /// <list type="bullet">
            /// <item><description><para>When <c>TupleDimension</c> is a 1-tuple, the following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>FlowAction</c>: the action type to execute on traffic after it matches the corresponding rule or policy (required, the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>CloudIp</c>: cloud IP address (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>When <c>TupleDimension</c> is a 2-tuple, the following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>FlowAction</c>: the action type to execute on traffic after it matches the corresponding rule or policy (required, the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>SourceIp</c>: source IP address (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>DestinationIp</c>: destination IP address (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>TrafficPath</c>: traffic path (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>When <c>TupleDimension</c> is a 5-tuple, the following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>FlowAction</c>: the action type to execute on traffic after it matches the corresponding rule or policy (required, the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>VpcId</c>: VPC ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>VSwitchId</c>: vSwitch ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>NetworkInterfaceId</c>: elastic network interfaces (ENIs) ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>EcsId</c>: ECS instance ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>SourceIp</c>: source IP address</description></item>
            /// <item><description><c>DestinationIp</c>: destination IP address</description></item>
            /// <item><description><c>TrafficPath</c>: traffic path (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>SourcePort</c>: source port (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>DestinationPort</c>: destination port (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>Protocol</c>: network protocol (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In the VPC Internet scenario (<c>TrafficScenario = VpcFlowLogInternet</c>), the following additional keys are supported for filtering by Internet location:</para>
            /// <list type="bullet">
            /// <item><description><c>ClientCountry</c>: filters network traffic analysis scope by country (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>ClientCity</c>: filters network traffic analysis scope by city (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>ClientAsn</c>: filters network traffic analysis scope by ASN (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>ClientIsp</c>: filters network traffic analysis scope by client ISP (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In VPC scenarios, the following traffic metrics filters are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>MinBytes</c>: specifies the minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxBytes</c>: specifies the maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinRoundTripTime</c>: specifies the minimum RTT for sorting, in ms (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxRoundTripTime</c>: specifies the maximum RTT for sorting, in ms (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPackages</c>: specifies the minimum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPackages</c>: specifies the maximum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <hr>
            /// <list type="bullet">
            /// <item><description><para><c>TrafficScenario = TRFlowlog</c> (TR flow log scenario):</para>
            /// <list type="bullet">
            /// <item><description><para>When querying 2-tuples or adaptively using 2-tuples, the following keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>TransitRouterAttachmentId</c>: network instance connection ID (required, the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>TransitRouterPairAttachmentId</c>: peer TR connection ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>TransitRouterId</c>: transit router instance ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>SourceIp</c>: source IP address (the corresponding value does not support multiple selections when Operator is like, and supports multiple selections when Operator is not like)</description></item>
            /// <item><description><c>DestinationIp</c>: destination IP address (the corresponding value does not support multiple selections when Operator is like, and supports multiple selections when Operator is not like)</description></item>
            /// <item><description><c>Dscp</c>: Differentiated Services Code Point (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>When querying 5-tuples or adaptively using 5-tuples, the following additional keys are supported in addition to the 2-tuple keys:</para>
            /// <list type="bullet">
            /// <item><description><c>Protocol</c>: network protocol (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>SourcePort</c>: source port (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>DestinationPort</c>: destination port (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In <c>non-TR cross-region scenarios</c>, the following additional keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>TransitRouterSourceResourceId</c>: source network instance ID (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>TransitRouterDestinationResourceId</c>: destination network instance ID (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In <c>VPC connection traffic scenarios</c>, the following additional keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>TransitRouterSourceNetworkInterface</c>: source TR network interface controller (NIC) (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>TransitRouterDestinationNetworkInterface</c>: destination TR network interface controller (NIC) (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In TR scenarios, the following traffic metrics filters are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>MinBytes</c>: specifies the minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxBytes</c>: specifies the maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPackages</c>: specifies the minimum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPackages</c>: specifies the maximum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPacketsLostNoRoute</c>: minimum number of packets dropped due to no route (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPacketsLostBlackhole</c>: minimum number of packets dropped due to blackhole route (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPacketsLostTTLExpired</c>: minimum number of packets dropped due to TTL timeout (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPacketsLostNoRoute</c>: maximum number of packets dropped due to no route (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPacketsLostBlackhole</c>: maximum number of packets dropped due to blackhole route (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPacketsLostTTLExpired</c>: maximum number of packets dropped due to TTL timeout (the corresponding value does not support multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <hr>
            /// <list type="bullet">
            /// <item><description><para><c>TrafficScenario = CbwpMetric</c> (Internet Shared Bandwidth metric analysis scenario):</para>
            /// <list type="bullet">
            /// <item><description><para>The following filter condition keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>PublicIpAddress</c>: the public IP address of the associated EIP (the corresponding value does not support multiple selections when Operator is like, and supports multiple selections when Operator is not like)</description></item>
            /// <item><description><c>BindingResourceType</c>: the type of the instance resource to which the EIP is bound (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>BindingResourceId</c>: the ID of the instance resource to which the EIP is bound (the corresponding value supports multiple selections)</description></item>
            /// <item><description><c>CbwpId</c>: the Internet Shared Bandwidth instance ID (required, the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>InstanceId</c>: the EIP ID bound to the Internet Shared Bandwidth instance (the corresponding value supports multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>In CBWP scenarios, the following traffic metrics filters are supported:</para>
            /// <list type="bullet">
            /// <item><description><c>MinBytes</c>: specifies the minimum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxBytes</c>: specifies the maximum traffic volume for sorting, in bytes (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MinPackages</c>: specifies the minimum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// <item><description><c>MaxPackages</c>: specifies the maximum number of packets for sorting (the corresponding value does not support multiple selections)</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NetworkInterfaceId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter operator.</para>
            /// <list type="bullet">
            /// <item><description>TR and Internet Shared Bandwidth scenarios:<list type="bullet">
            /// <item><description>Defaults to in if not specified.</description></item>
            /// <item><description>like performs prefix matching and only one Value can be specified.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>VPC scenarios currently ignore this parameter and uniformly process it as IN.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The filter value corresponding to the specified key type.</para>
            /// <para>Based on the <c>TupleDimension</c> field and <c>TrafficScenario</c> field, the supported values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><c>TrafficScenario = VpcFlowLogAll</c> / <c>VpcFlowLogInternet</c> (VPC flow log scenario)</para>
            /// <list type="bullet">
            /// <item><description>When the key is <c>FlowAction</c>, the valid values are:<list type="bullet">
            /// <item><description><c>ACCEPT</c> (pass <c>Accept</c> by default): traffic allowed by security groups and network ACLs</description></item>
            /// <item><description><c>REJECT</c>: traffic denied by security groups and network ACLs</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><c>TrafficScenario = TRFlowlog</c> (TR flow log scenario)</para>
            /// <list type="bullet">
            /// <item><description>When the key is <c>TransitRouterAttachmentId</c>, this is a required field, and the corresponding value is also required (specify the specific VPC connection / VPN connection / VBR connection / ECR connection / inter-region connection or network instance connection ID).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><c>TrafficScenario = CbwpMetric</c> (shared bandwidth metric analysis scenario)</para>
            /// <list type="bullet">
            /// <item><description>When the key is <c>CbwpId</c>, this is a required field, and the corresponding value is also required (specify the specific Internet Shared Bandwidth instance ID).</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>In VPC scenarios, this parameter specifies the paging size. In TR and Internet Shared Bandwidth scenarios, this parameter specifies the SQL query limit. If not specified, the backend defaults to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The metric name.
        /// Common parameters supported in network traffic analysis scenarios:
        ///   bps: bits per second.
        ///   pps: packets per second.
        /// Parameters specific to the Internet scenario:
        ///   rtt: round-trip time when establishing a TCP protocol connection.
        ///   RetransmitRate: retransmission rate.
        /// Parameters specific to the area-level bandwidth scenario:
        ///   RatelimitDropPps: rate of packet loss due to rate limiting.
        ///   BandwidthUtilization: bandwidth utilization.
        /// Parameters specific to the NAT scenario:
        ///   ActiveSessionCount: number of concurrent sessions.
        ///   NewSessionPerSecond: number of new sessions per second.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The token for the next query. You do not need to specify this parameter for the first query or when no more results exist. If a next page exists, set this parameter to the NextToken value returned by the previous API invoke. This parameter is valid only in VPC scenarios. TR and Internet Shared Bandwidth scenarios do not use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f7zUd3gArYj/xjPttJo5L5dK0R+gSbfHElLqi8C2IPWMQxtV8XckOg5lk7F2bhC+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:
        /// TimestampAscending: sorts by time in ascending order.
        /// TimestampDescending: sorts by time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimestampAscending</para>
        /// </summary>
        [NameInMap("ScanBy")]
        [Validation(Required=false)]
        public string ScanBy { get; set; }

        /// <summary>
        /// <para>The aggregation step for time series data, in minutes. The final query granularity is the larger value between StepMinutes and the underlying storage granularity. The number of data points calculated by (EndTime-BeginTime)/StepMinutes cannot exceed 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StepMinutes")]
        [Validation(Required=false)]
        public int? StepMinutes { get; set; }

        /// <summary>
        /// <para>The storage bucket precision property.</para>
        /// <para>The storage bucket precision specifies the storage aggregation epoch to query. Two precision levels are supported: high precision (such as 1 minute) or long epoch (such as 1 day). The specific precision is determined by the network traffic analysis sampling interval configured for high-precision traffic statistics or long-epoch traffic statistics when creating or editing the network traffic analysis analyzer.</para>
        /// <list type="bullet">
        /// <item><description><para>The storage precisions active for the corresponding tuples of the network traffic analysis analyzer are:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: in minutes (1 minute)</description></item>
        /// <item><description><c>10</c>: in minutes (10 minutes)</description></item>
        /// <item><description><c>60</c>: in minutes (60 minutes, i.e., 1 hour)</description></item>
        /// <item><description><c>1440</c>: in minutes (1440 minutes, i.e., 1 day)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The storage bucket precision can be used for two typical purposes:</para>
        /// <list type="bullet">
        /// <item><description>High-precision traffic statistics: such as 1-minute, 10-minute, or 60-minute aggregation</description></item>
        /// <item><description>Long-epoch traffic statistics: such as 1440-minute (1-day) aggregation</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Specify a value for this field during the query to select the storage aggregation epoch. For example:</para>
        /// <list type="bullet">
        /// <item><description>Pass <c>10</c>: queries short-epoch data with a 10-minute aggregation granularity</description></item>
        /// <item><description>Pass <c>1440</c>: queries long-epoch data with a 1-day aggregation granularity</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StorageInterval")]
        [Validation(Required=false)]
        public int? StorageInterval { get; set; }

        /// <summary>
        /// <para>The ID of the network traffic analysis analyzer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nta-e093cb80c7c047afbd1d</para>
        /// </summary>
        [NameInMap("TrafficAnalyzerId")]
        [Validation(Required=false)]
        public string TrafficAnalyzerId { get; set; }

        /// <summary>
        /// <para>The supported analysis scenarios: </para>
        /// <list type="bullet">
        /// <item><description>All VPC flow log analysis</description></item>
        /// <item><description>Internet VPC flow log analysis</description></item>
        /// <item><description>All TR flow log analysis</description></item>
        /// <item><description>Internet Shared Bandwidth metric analysis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VpcFlowLogAll</para>
        /// </summary>
        [NameInMap("TrafficScenario")]
        [Validation(Required=false)]
        public string TrafficScenario { get; set; }

        /// <summary>
        /// <para>The traffic storage aggregation dimension.</para>
        /// <para>Based on the TrafficScenario:</para>
        /// <list type="bullet">
        /// <item><description><para>VpcFlowLogAll/VpcFlowLog: required. Specifies the storage aggregation view to query, which corresponds to the storage aggregation property configured in the network traffic analysis analyzer.</para>
        /// </description></item>
        /// <item><description><para>TRFlowLog/CbwpMetric: optional. Automatically adapts based on the storage aggregation property of the network traffic analysis analyzer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tuple2</para>
        /// </summary>
        [NameInMap("TupleDimension")]
        [Validation(Required=false)]
        public string TupleDimension { get; set; }

    }

}
