// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisTrafficRankingResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of traffic ranking analysis results.</para>
        /// </summary>
        [NameInMap("FlowRankingList")]
        [Validation(Required=false)]
        public List<DescribeNisTrafficRankingResponseBodyFlowRankingList> FlowRankingList { get; set; }
        public class DescribeNisTrafficRankingResponseBodyFlowRankingList : TeaModel {
            /// <summary>
            /// <para>The instance resource to which the EIP is bound.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when Internet Shared Bandwidth metric analysis is queried.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-ufwerthgvc*****</para>
            /// </summary>
            [NameInMap("BindingResourceId")]
            [Validation(Required=false)]
            public string BindingResourceId { get; set; }

            /// <summary>
            /// <para>The type of the instance resource to which the EIP is attached.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when Internet Shared Bandwidth metric analysis is queried.</description></item>
            /// <item><description>Valid values:<list type="bullet">
            /// <item><description>EIP_ECS: Elastic Compute Service (ECS) instance type.</description></item>
            /// <item><description>EIP_ENI: Server Load Balancer (SLB) instance type.</description></item>
            /// <item><description>EIP_NAT: NAT gateway instance type.</description></item>
            /// <item><description>EIP_SLB: elastic network interface (ENI) instance type.</description></item>
            /// <item><description>HAVIP_ECS: high availability (HA) virtual IP address type.</description></item>
            /// <item><description>TARGET_IP: IP address type.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EIP_NAT</para>
            /// </summary>
            [NameInMap("BindingResourceType")]
            [Validation(Required=false)]
            public string BindingResourceType { get; set; }

            /// <summary>
            /// <para>The bandwidth.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned for VPC, TR, or Internet Shared Bandwidth analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Bytes")]
            [Validation(Required=false)]
            public double? Bytes { get; set; }

            /// <summary>
            /// <para>The bandwidth increase.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TrafficScenario is set to TRFlowlog and the Order by field is BytesIncrease or BytesIncreaseRatio.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("BytesIncrease")]
            [Validation(Required=false)]
            public double? BytesIncrease { get; set; }

            /// <summary>
            /// <para>The bandwidth increase ratio.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TrafficScenario is set to TRFlowlog and the Order by field is BytesIncrease or BytesIncreaseRatio.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("BytesIncreaseRatio")]
            [Validation(Required=false)]
            public double? BytesIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The traffic proportion.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR or VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("BytesRate")]
            [Validation(Required=false)]
            public double? BytesRate { get; set; }

            /// <summary>
            /// <para>The CEN instance ID.</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The autonomous system number.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed for the VPC Internet scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>45102</para>
            /// </summary>
            [NameInMap("ClientAsn")]
            [Validation(Required=false)]
            public string ClientAsn { get; set; }

            /// <summary>
            /// <para>The city where the client is located.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed for the VPC Internet scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Kowloon.</para>
            /// </summary>
            [NameInMap("ClientCity")]
            [Validation(Required=false)]
            public string ClientCity { get; set; }

            /// <summary>
            /// <para>The country where the client is located.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed for the VPC Internet scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>China.</para>
            /// </summary>
            [NameInMap("ClientCountry")]
            [Validation(Required=false)]
            public string ClientCountry { get; set; }

            /// <summary>
            /// <para>The network service provider.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed for the VPC Internet scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud.</para>
            /// </summary>
            [NameInMap("ClientIsp")]
            [Validation(Required=false)]
            public string ClientIsp { get; set; }

            /// <summary>
            /// <para>The province where the client is located.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed for the VPC Internet scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Hong Kong Special Administrative Region.</para>
            /// </summary>
            [NameInMap("ClientProvince")]
            [Validation(Required=false)]
            public string ClientProvince { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 2-tuple analysis is performed for TR or VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.***.0</para>
            /// </summary>
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 5-tuple analysis is performed for TR or VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            /// <summary>
            /// <para>The destination region ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionNo")]
            [Validation(Required=false)]
            public string DestinationRegionNo { get; set; }

            /// <summary>
            /// <para>The traffic direction based on the Alibaba Cloud network resource instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound traffic.</description></item>
            /// <item><description><b>out</b>: outbound traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Dscp")]
            [Validation(Required=false)]
            public string Dscp { get; set; }

            /// <summary>
            /// <para>The ECS instance ID of the management node.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf6i1zi6yhq7h***</para>
            /// </summary>
            [NameInMap("EcsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            /// <summary>
            /// <para>The EIP ID associated with the Internet Shared Bandwidth instance.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when Internet Shared Bandwidth metric analysis is queried.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eip-fb6wzjl9hm****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The elastic network interface (ENI) ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eni-8vbf2jxul***</para>
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>The number of packets.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned for VPC, TR, or CBWP flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Packets")]
            [Validation(Required=false)]
            public double? Packets { get; set; }

            [NameInMap("PacketsIncrease")]
            [Validation(Required=false)]
            public double? PacketsIncrease { get; set; }

            [NameInMap("PacketsIncreaseRatio")]
            [Validation(Required=false)]
            public double? PacketsIncreaseRatio { get; set; }

            /// <summary>
            /// <para>The number of packets dropped due to blackhole routing.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("PacketsLostBlackhole")]
            [Validation(Required=false)]
            public double? PacketsLostBlackhole { get; set; }

            /// <summary>
            /// <para>The number of packets dropped due to no route.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PacketsLostNoRoute")]
            [Validation(Required=false)]
            public double? PacketsLostNoRoute { get; set; }

            /// <summary>
            /// <para>The number of packets dropped due to TTL expiration.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("PacketsLostTTLExpired")]
            [Validation(Required=false)]
            public double? PacketsLostTTLExpired { get; set; }

            /// <summary>
            /// <para>The network protocol.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 5-tuple analysis is performed for TR or VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated EIP.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when Internet Shared Bandwidth metric analysis is queried.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>118.31.***.86</para>
            /// </summary>
            [NameInMap("PublicIpAddress")]
            [Validation(Required=false)]
            public string PublicIpAddress { get; set; }

            /// <summary>
            /// <para>The region where the flow log resides.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The TCP RTT.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RoundTripTime")]
            [Validation(Required=false)]
            public double? RoundTripTime { get; set; }

            [NameInMap("RoundTripTimeIncrease")]
            [Validation(Required=false)]
            public double? RoundTripTimeIncrease { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 2-tuple analysis is performed for TR or VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>47.92.245.***</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The source port.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 5-tuple analysis is performed for TR or VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <para>The source region ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SourceRegionNo")]
            [Validation(Required=false)]
            public string SourceRegionNo { get; set; }

            /// <summary>
            /// <para>The traffic path.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when 2-tuple or 5-tuple analysis is performed for VPC flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("TrafficPath")]
            [Validation(Required=false)]
            public string TrafficPath { get; set; }

            /// <summary>
            /// <para>The network instance connection ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-bfde1cd4cj***</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The account ID of the destination cloud resource instance connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1906814138****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationAccountId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationAccountId { get; set; }

            /// <summary>
            /// <para>The zone of the destination resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationAvailableZone")]
            [Validation(Required=false)]
            public string TransitRouterDestinationAvailableZone { get; set; }

            /// <summary>
            /// <para>The ENI ID of the destination resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eni-fdbf2jxulm***</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationNetworkInterface")]
            [Validation(Required=false)]
            public string TransitRouterDestinationNetworkInterface { get; set; }

            /// <summary>
            /// <para>The ID of the destination cloud resource instance connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-bfve1cd4cjp****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationResourceId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationResourceId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the destination resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zeekevlhxpqxu****</para>
            /// </summary>
            [NameInMap("TransitRouterDestinationVSwitchId")]
            [Validation(Required=false)]
            public string TransitRouterDestinationVSwitchId { get; set; }

            /// <summary>
            /// <para>The transit router instance ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tr-2zefvwy2fz3444***</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The transit router peering connection instance ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-okvj1cd4cjp***</para>
            /// </summary>
            [NameInMap("TransitRouterPairAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterPairAttachmentId { get; set; }

            /// <summary>
            /// <para>The account ID of the source cloud resource instance connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1906814138***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceAccountId")]
            [Validation(Required=false)]
            public string TransitRouterSourceAccountId { get; set; }

            /// <summary>
            /// <para>The zone of the source resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("TransitRouterSourceAvailableZone")]
            [Validation(Required=false)]
            public string TransitRouterSourceAvailableZone { get; set; }

            /// <summary>
            /// <para>The ENI ID of the source resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eni-8vbf2jxulma***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceNetworkInterface")]
            [Validation(Required=false)]
            public string TransitRouterSourceNetworkInterface { get; set; }

            /// <summary>
            /// <para>The ID of the source cloud resource instance connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when TR flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-hvve1cd4cjpj***</para>
            /// </summary>
            [NameInMap("TransitRouterSourceResourceId")]
            [Validation(Required=false)]
            public string TransitRouterSourceResourceId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the source resource connected to the transit router.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only for the VPC connection traffic scenario under TR flow log analysis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-ikfdkevlhxpqxuz****</para>
            /// </summary>
            [NameInMap("TransitRouterSourceVSwitchId")]
            [Validation(Required=false)]
            public string TransitRouterSourceVSwitchId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zeekevlh****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// <list type="bullet">
            /// <item><description>This field is returned only when VPC flow log analysis is performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m5ec6i0h5xss***</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LoeJLhK0fsDqYoXkXieZUqB2vWnccJtVnsyKu9KxFFOMQxtV8XckOg5lk7F2bhC+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the traffic ranking analysis result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-7619ecb1db9148bab9f4</para>
        /// </summary>
        [NameInMap("NisTrafficRankingId")]
        [Validation(Required=false)]
        public string NisTrafficRankingId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DAC4BE1-BEEA-5D84-BE06-E1B796F3B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task running status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
