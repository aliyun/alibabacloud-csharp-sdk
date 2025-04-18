// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkRankingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetNisNetworkRankingResponseBodyData> Data { get; set; }
        public class GetNisNetworkRankingResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public double? ActiveSessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>129103</para>
            /// </summary>
            [NameInMap("Asn")]
            [Validation(Required=false)]
            public string Asn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tr-sample*</para>
            /// </summary>
            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cbwp-sample*</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2.XX.XX</para>
            /// </summary>
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            [NameInMap("DestinationIsp")]
            [Validation(Required=false)]
            public string DestinationIsp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DestinationRegionNo")]
            [Validation(Required=false)]
            public string DestinationRegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("DestinationZone")]
            [Validation(Required=false)]
            public string DestinationZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120.238.XX.XX</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public double? InBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public double? InPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eip-sample*</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("NewSessionPerSecond")]
            [Validation(Required=false)]
            public double? NewSessionPerSecond { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public double? OutBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public double? OutPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("RTT")]
            [Validation(Required=false)]
            public double? RTT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("RetransmitRate")]
            [Validation(Required=false)]
            public double? RetransmitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42.120.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("SourceIsp")]
            [Validation(Required=false)]
            public string SourceIsp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("SourceZone")]
            [Validation(Required=false)]
            public string SourceZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vbr-sample*</para>
            /// </summary>
            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
