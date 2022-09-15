// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewaySlbResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewaySlbResponseBodyData> Data { get; set; }
        public class ListGatewaySlbResponseBodyData : TeaModel {
            [NameInMap("EditEnable")]
            [Validation(Required=false)]
            public bool? EditEnable { get; set; }

            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("GatewaySlbMode")]
            [Validation(Required=false)]
            public string GatewaySlbMode { get; set; }

            [NameInMap("GatewaySlbStatus")]
            [Validation(Required=false)]
            public string GatewaySlbStatus { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            [NameInMap("HttpsPort")]
            [Validation(Required=false)]
            public int? HttpsPort { get; set; }

            [NameInMap("HttpsVServerGroupId")]
            [Validation(Required=false)]
            public string HttpsVServerGroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ServiceWeight")]
            [Validation(Required=false)]
            public int? ServiceWeight { get; set; }

            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public string SlbPort { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

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
