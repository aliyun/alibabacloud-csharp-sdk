// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkRankingResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of cloud network metric ranking data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetNisNetworkRankingResponseBodyData> Data { get; set; }
        public class GetNisNetworkRankingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of concurrent connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public double? ActiveSessionCount { get; set; }

            /// <summary>
            /// <para>The autonomous system number (ASN) of the client ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>129103</para>
            /// </summary>
            [NameInMap("Asn")]
            [Validation(Required=false)]
            public string Asn { get; set; }

            /// <summary>
            /// <para>The transit router attachment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-sample*</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <para>The bandwidth package instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-sample*</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The traffic volume in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            /// <summary>
            /// <para>The city where the client is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chengdu.</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The country where the client is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China.</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.XX.XX</para>
            /// </summary>
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            /// <summary>
            /// <para>The destination ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud.</para>
            /// </summary>
            [NameInMap("DestinationIsp")]
            [Validation(Required=false)]
            public string DestinationIsp { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            /// <summary>
            /// <para>The destination region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionNo")]
            [Validation(Required=false)]
            public string DestinationRegionNo { get; set; }

            /// <summary>
            /// <para>The destination zone for probing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("DestinationZone")]
            [Validation(Required=false)]
            public string DestinationZone { get; set; }

            [NameInMap("GlobalCountryCode")]
            [Validation(Required=false)]
            public string GlobalCountryCode { get; set; }

            [NameInMap("GlobalProvinceCode")]
            [Validation(Required=false)]
            public string GlobalProvinceCode { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.238.XX.XX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public double? InBps { get; set; }

            /// <summary>
            /// <para>The inbound packet rate. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public double? InPps { get; set; }

            /// <summary>
            /// <para>The cloud resource instance ID corresponding to each scenario. For example, in the cross-region network traffic analysis scenario, this represents the CEN ID. In the public network scenario, this represents the EIP ID, ECS instance ID, or CLB ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-sample*</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ISP of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Mobile.</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("LineType")]
            [Validation(Required=false)]
            public string LineType { get; set; }

            /// <summary>
            /// <para>The number of new connections per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("NewSessionPerSecond")]
            [Validation(Required=false)]
            public double? NewSessionPerSecond { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public double? OutBps { get; set; }

            /// <summary>
            /// <para>The outbound packet rate. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public double? OutPps { get; set; }

            /// <summary>
            /// <para>The number of traffic packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            /// <summary>
            /// <para>The network protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The province or state where the client is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sichuan.</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The latency. Unit: ms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RTT")]
            [Validation(Required=false)]
            public double? RTT { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The retransmission rate of TCP packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("RetransmitRate")]
            [Validation(Required=false)]
            public double? RetransmitRate { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.120.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The source Internet Service Provider (ISP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Mobile.</para>
            /// </summary>
            [NameInMap("SourceIsp")]
            [Validation(Required=false)]
            public string SourceIsp { get; set; }

            /// <summary>
            /// <para>The source port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The source zone for probing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("SourceZone")]
            [Validation(Required=false)]
            public string SourceZone { get; set; }

            /// <summary>
            /// <para>The instance ID of the virtual border router (VBR).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-sample*</para>
            /// </summary>
            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
