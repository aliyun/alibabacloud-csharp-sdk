// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayDnsForwardsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayDnsForwardsResponseBodyData> Data { get; set; }
        public class ViewSmartAccessGatewayDnsForwardsResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MasterIp")]
            [Validation(Required=false)]
            public string MasterIp { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("OutboundPortIndex")]
            [Validation(Required=false)]
            public int? OutboundPortIndex { get; set; }

            [NameInMap("OutboundPortName")]
            [Validation(Required=false)]
            public string OutboundPortName { get; set; }

            [NameInMap("OutboundPortType")]
            [Validation(Required=false)]
            public string OutboundPortType { get; set; }

            [NameInMap("SlaveIp")]
            [Validation(Required=false)]
            public string SlaveIp { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
