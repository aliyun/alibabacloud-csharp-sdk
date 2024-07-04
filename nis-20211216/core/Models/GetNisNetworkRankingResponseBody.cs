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
            [NameInMap("ActiveSessionCount")]
            [Validation(Required=false)]
            public double? ActiveSessionCount { get; set; }

            [NameInMap("Asn")]
            [Validation(Required=false)]
            public string Asn { get; set; }

            [NameInMap("AttachmentId")]
            [Validation(Required=false)]
            public string AttachmentId { get; set; }

            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            [NameInMap("DestinationIsp")]
            [Validation(Required=false)]
            public string DestinationIsp { get; set; }

            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            [NameInMap("DestinationRegionNo")]
            [Validation(Required=false)]
            public string DestinationRegionNo { get; set; }

            [NameInMap("DestinationZone")]
            [Validation(Required=false)]
            public string DestinationZone { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("InBps")]
            [Validation(Required=false)]
            public double? InBps { get; set; }

            [NameInMap("InPps")]
            [Validation(Required=false)]
            public double? InPps { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("NewSessionPerSecond")]
            [Validation(Required=false)]
            public double? NewSessionPerSecond { get; set; }

            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public double? OutBps { get; set; }

            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public double? OutPps { get; set; }

            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("RTT")]
            [Validation(Required=false)]
            public double? RTT { get; set; }

            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            [NameInMap("RetransmitRate")]
            [Validation(Required=false)]
            public double? RetransmitRate { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("SourceIsp")]
            [Validation(Required=false)]
            public string SourceIsp { get; set; }

            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            [NameInMap("SourceZone")]
            [Validation(Required=false)]
            public string SourceZone { get; set; }

            [NameInMap("VbrId")]
            [Validation(Required=false)]
            public string VbrId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
