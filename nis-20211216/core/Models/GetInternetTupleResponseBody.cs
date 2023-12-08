// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetInternetTupleResponseBody : TeaModel {
        /// <summary>
        /// The ranking result of instances by Internet traffic.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInternetTupleResponseBodyData> Data { get; set; }
        public class GetInternetTupleResponseBodyData : TeaModel {
            /// <summary>
            /// The access point of Alibaba Cloud.
            /// 
            /// > This parameter is valid only when the value of **InstanceId** is the instance ID of an Anycast elastic IP address (EIP).
            /// </summary>
            [NameInMap("AccessRegion")]
            [Validation(Required=false)]
            public string AccessRegion { get; set; }

            /// <summary>
            /// The beginning of the time range that you queried. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// The traffic volume. Unit: bytes.
            /// </summary>
            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            /// <summary>
            /// The local city.
            /// </summary>
            [NameInMap("CloudCity")]
            [Validation(Required=false)]
            public string CloudCity { get; set; }

            /// <summary>
            /// The local country or region.
            /// </summary>
            [NameInMap("CloudCountry")]
            [Validation(Required=false)]
            public string CloudCountry { get; set; }

            /// <summary>
            /// The local IP address.
            /// </summary>
            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            /// <summary>
            /// The local ISP.
            /// </summary>
            [NameInMap("CloudIsp")]
            [Validation(Required=false)]
            public string CloudIsp { get; set; }

            /// <summary>
            /// The local port.
            /// </summary>
            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            /// <summary>
            /// The product code of the instance to which the local IP address belongs.
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// The local province.
            /// </summary>
            [NameInMap("CloudProvince")]
            [Validation(Required=false)]
            public string CloudProvince { get; set; }

            /// <summary>
            /// The direction of the Internet traffic. Valid values:
            /// 
            /// - **in**: inbound
            /// - **out**: outbound
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// The inbound traffic volume. Unit: bytes.
            /// </summary>
            [NameInMap("InByteCount")]
            [Validation(Required=false)]
            public double? InByteCount { get; set; }

            /// <summary>
            /// The number of inbound disordered packets.
            /// </summary>
            [NameInMap("InOutOrderCount")]
            [Validation(Required=false)]
            public double? InOutOrderCount { get; set; }

            /// <summary>
            /// The number of inbound packets.
            /// </summary>
            [NameInMap("InPacketCount")]
            [Validation(Required=false)]
            public double? InPacketCount { get; set; }

            /// <summary>
            /// The number of inbound repeated packets.
            /// </summary>
            [NameInMap("InRetranCount")]
            [Validation(Required=false)]
            public double? InRetranCount { get; set; }

            /// <summary>
            /// The instance ID to which the local IP address belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The remote city. In most cases, this parameter is empty if the value of **OtherCountry** is not China.
            /// </summary>
            [NameInMap("OtherCity")]
            [Validation(Required=false)]
            public string OtherCity { get; set; }

            /// <summary>
            /// The remote country or region.
            /// </summary>
            [NameInMap("OtherCountry")]
            [Validation(Required=false)]
            public string OtherCountry { get; set; }

            /// <summary>
            /// The remote IP address.
            /// </summary>
            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            /// <summary>
            /// The remote ISP.
            /// </summary>
            [NameInMap("OtherIsp")]
            [Validation(Required=false)]
            public string OtherIsp { get; set; }

            /// <summary>
            /// The remote port.
            /// </summary>
            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            /// <summary>
            /// The product code of the instance to which the remote IP address belongs. If the IP address is not in the cloud, this parameter is empty.
            /// </summary>
            [NameInMap("OtherProduct")]
            [Validation(Required=false)]
            public string OtherProduct { get; set; }

            /// <summary>
            /// The remote province. In most cases, this parameter is empty if the value of **OtherCountry** is not China.
            /// </summary>
            [NameInMap("OtherProvince")]
            [Validation(Required=false)]
            public string OtherProvince { get; set; }

            /// <summary>
            /// The outbound traffic volume. Unit: bytes.
            /// </summary>
            [NameInMap("OutByteCount")]
            [Validation(Required=false)]
            public double? OutByteCount { get; set; }

            /// <summary>
            /// The number of disordered packets.
            /// </summary>
            [NameInMap("OutOrderCount")]
            [Validation(Required=false)]
            public double? OutOrderCount { get; set; }

            /// <summary>
            /// The number of outbound disordered packets.
            /// </summary>
            [NameInMap("OutOutOrderCount")]
            [Validation(Required=false)]
            public double? OutOutOrderCount { get; set; }

            /// <summary>
            /// The number of outbound packets.
            /// </summary>
            [NameInMap("OutPacketCount")]
            [Validation(Required=false)]
            public double? OutPacketCount { get; set; }

            /// <summary>
            /// The number of outbound repeated packets.
            /// </summary>
            [NameInMap("OutRetranCount")]
            [Validation(Required=false)]
            public double? OutRetranCount { get; set; }

            /// <summary>
            /// The number of packets.
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            /// <summary>
            /// The protocol number.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RetransmitRate")]
            [Validation(Required=false)]
            public double? RetransmitRate { get; set; }

            /// <summary>
            /// The round-trip time (RTT). Unit: milliseconds.
            /// </summary>
            [NameInMap("Rtt")]
            [Validation(Required=false)]
            public double? Rtt { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
