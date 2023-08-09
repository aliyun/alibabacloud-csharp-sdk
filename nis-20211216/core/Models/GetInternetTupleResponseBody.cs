// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetInternetTupleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInternetTupleResponseBodyData> Data { get; set; }
        public class GetInternetTupleResponseBodyData : TeaModel {
            [NameInMap("AccessRegion")]
            [Validation(Required=false)]
            public string AccessRegion { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("ByteCount")]
            [Validation(Required=false)]
            public double? ByteCount { get; set; }

            [NameInMap("CloudCity")]
            [Validation(Required=false)]
            public string CloudCity { get; set; }

            [NameInMap("CloudCountry")]
            [Validation(Required=false)]
            public string CloudCountry { get; set; }

            [NameInMap("CloudIp")]
            [Validation(Required=false)]
            public string CloudIp { get; set; }

            [NameInMap("CloudIsp")]
            [Validation(Required=false)]
            public string CloudIsp { get; set; }

            [NameInMap("CloudPort")]
            [Validation(Required=false)]
            public string CloudPort { get; set; }

            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            [NameInMap("CloudProvince")]
            [Validation(Required=false)]
            public string CloudProvince { get; set; }

            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            [NameInMap("InByteCount")]
            [Validation(Required=false)]
            public double? InByteCount { get; set; }

            [NameInMap("InOutOrderCount")]
            [Validation(Required=false)]
            public double? InOutOrderCount { get; set; }

            [NameInMap("InPacketCount")]
            [Validation(Required=false)]
            public double? InPacketCount { get; set; }

            [NameInMap("InRetranCount")]
            [Validation(Required=false)]
            public double? InRetranCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OtherCity")]
            [Validation(Required=false)]
            public string OtherCity { get; set; }

            [NameInMap("OtherCountry")]
            [Validation(Required=false)]
            public string OtherCountry { get; set; }

            [NameInMap("OtherIp")]
            [Validation(Required=false)]
            public string OtherIp { get; set; }

            [NameInMap("OtherIsp")]
            [Validation(Required=false)]
            public string OtherIsp { get; set; }

            [NameInMap("OtherPort")]
            [Validation(Required=false)]
            public string OtherPort { get; set; }

            [NameInMap("OtherProduct")]
            [Validation(Required=false)]
            public string OtherProduct { get; set; }

            [NameInMap("OtherProvince")]
            [Validation(Required=false)]
            public string OtherProvince { get; set; }

            [NameInMap("OutByteCount")]
            [Validation(Required=false)]
            public double? OutByteCount { get; set; }

            [NameInMap("OutOrderCount")]
            [Validation(Required=false)]
            public double? OutOrderCount { get; set; }

            [NameInMap("OutOutOrderCount")]
            [Validation(Required=false)]
            public double? OutOutOrderCount { get; set; }

            [NameInMap("OutPacketCount")]
            [Validation(Required=false)]
            public double? OutPacketCount { get; set; }

            [NameInMap("OutRetranCount")]
            [Validation(Required=false)]
            public double? OutRetranCount { get; set; }

            [NameInMap("PacketCount")]
            [Validation(Required=false)]
            public double? PacketCount { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RetranCount")]
            [Validation(Required=false)]
            public double? RetranCount { get; set; }

            [NameInMap("Rtt")]
            [Validation(Required=false)]
            public double? Rtt { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
