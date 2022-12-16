// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewaySlbResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data entries returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListGatewaySlbResponseBodyData> Data { get; set; }
        public class ListGatewaySlbResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the edit operation is supported.
            /// </summary>
            [NameInMap("EditEnable")]
            [Validation(Required=false)]
            public bool? EditEnable { get; set; }

            /// <summary>
            /// The ID of the gateway.
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// The service source.
            /// </summary>
            [NameInMap("GatewaySlbMode")]
            [Validation(Required=false)]
            public string GatewaySlbMode { get; set; }

            /// <summary>
            /// The association status.
            /// </summary>
            [NameInMap("GatewaySlbStatus")]
            [Validation(Required=false)]
            public string GatewaySlbStatus { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The port number of the HTTP virtual service group.
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// The port number of the HTTPS virtual service group.
            /// </summary>
            [NameInMap("HttpsPort")]
            [Validation(Required=false)]
            public int? HttpsPort { get; set; }

            /// <summary>
            /// The ID of the HTTPS virtual service group.
            /// </summary>
            [NameInMap("HttpsVServerGroupId")]
            [Validation(Required=false)]
            public string HttpsVServerGroupId { get; set; }

            /// <summary>
            /// ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The service weight.
            /// </summary>
            [NameInMap("ServiceWeight")]
            [Validation(Required=false)]
            public int? ServiceWeight { get; set; }

            /// <summary>
            /// SLB ID
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// SLB IP
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// The port number of the SLB instance.
            /// </summary>
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public string SlbPort { get; set; }

            /// <summary>
            /// The description of the status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The type.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The ID of the HTTP virtual service group.
            /// </summary>
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
