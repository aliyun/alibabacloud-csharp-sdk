// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetInternetTupleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ranking result of Internet traffic data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInternetTupleResponseBodyData> Data { get; set; }
        public class GetInternetTupleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The access point of Alibaba Cloud.</para>
            /// <remarks>
            /// <para> This parameter is valid only if you set <b>InstanceId</b> to the instance ID of an Anycast elastic IP address (EIP).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong-pop</para>
            /// </summary>
            [NameInMap("AccessRegion")]
            [Validation(Required=false)]
            public string AccessRegion { get; set; }

            /// <summary>
            /// <para>The beginning of the time range that you queried. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684373600099</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The traffic volume. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            /// <summary>
            /// <para>The local city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Nanjing</para>
            /// </summary>
            [NameInMap("CloudCity")]
            [Validation(Required=false)]
            public string CloudCity { get; set; }

            /// <summary>
            /// <para>The local country or region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("CloudCountry")]
            [Validation(Required=false)]
            public string CloudCountry { get; set; }

            /// <summary>
            /// <para>The local IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.74.XX.XX</para>
            /// </summary>
            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            /// <summary>
            /// <para>The local ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Mobile</para>
            /// </summary>
            [NameInMap("CloudIsp")]
            [Validation(Required=false)]
            public string CloudIsp { get; set; }

            /// <summary>
            /// <para>The local port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            /// <summary>
            /// <para>The service code of the instance to which the local IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EIP</para>
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// <para>The local province.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jiangsu</para>
            /// </summary>
            [NameInMap("CloudProvince")]
            [Validation(Required=false)]
            public string CloudProvince { get; set; }

            /// <summary>
            /// <para>The direction of Internet traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound</description></item>
            /// <item><description><b>out</b>: outbound</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The inbound traffic volume. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("InByteCount")]
            [Validation(Required=false)]
            public double? InByteCount { get; set; }

            /// <summary>
            /// <para>The number of inbound disordered packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InOutOrderCount")]
            [Validation(Required=false)]
            public double? InOutOrderCount { get; set; }

            /// <summary>
            /// <para>The number of inbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("InPacketCount")]
            [Validation(Required=false)]
            public double? InPacketCount { get; set; }

            /// <summary>
            /// <para>The number of inbound repeated packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InRetranCount")]
            [Validation(Required=false)]
            public double? InRetranCount { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the local IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-sample*</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The remote city. In most cases, this parameter is empty if you set <b>OtherCountry</b> to a country except China.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Austin</para>
            /// </summary>
            [NameInMap("OtherCity")]
            [Validation(Required=false)]
            public string OtherCity { get; set; }

            /// <summary>
            /// <para>The remote country or region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>United States</para>
            /// </summary>
            [NameInMap("OtherCountry")]
            [Validation(Required=false)]
            public string OtherCountry { get; set; }

            /// <summary>
            /// <para>The remote IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122.112.XX.XX</para>
            /// </summary>
            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            /// <summary>
            /// <para>The remote ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amazon.com</para>
            /// </summary>
            [NameInMap("OtherIsp")]
            [Validation(Required=false)]
            public string OtherIsp { get; set; }

            /// <summary>
            /// <para>The remote port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40002</para>
            /// </summary>
            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            /// <summary>
            /// <para>The service code of the instance to which the remote IP address belongs. If the IP address is not on the cloud, this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("OtherProduct")]
            [Validation(Required=false)]
            public string OtherProduct { get; set; }

            /// <summary>
            /// <para>The remote province. In most cases, this parameter is empty if you set <b>OtherCountry</b> to a country except China.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Texas</para>
            /// </summary>
            [NameInMap("OtherProvince")]
            [Validation(Required=false)]
            public string OtherProvince { get; set; }

            /// <summary>
            /// <para>The outbound traffic volume. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("OutByteCount")]
            [Validation(Required=false)]
            public double? OutByteCount { get; set; }

            /// <summary>
            /// <para>The number of disordered packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutOrderCount")]
            [Validation(Required=false)]
            public double? OutOrderCount { get; set; }

            /// <summary>
            /// <para>The number of outbound disordered packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutOutOrderCount")]
            [Validation(Required=false)]
            public double? OutOutOrderCount { get; set; }

            /// <summary>
            /// <para>The number of outbound packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("OutPacketCount")]
            [Validation(Required=false)]
            public double? OutPacketCount { get; set; }

            /// <summary>
            /// <para>The number of outbound repeated packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OutRetranCount")]
            [Validation(Required=false)]
            public double? OutRetranCount { get; set; }

            /// <summary>
            /// <para>The number of packets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            /// <summary>
            /// <para>The protocol number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

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
            /// <para>The round-trip time (RTT). Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Rtt")]
            [Validation(Required=false)]
            public double? Rtt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5E98683-355B-5867-8D3D-A24755F6895B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
