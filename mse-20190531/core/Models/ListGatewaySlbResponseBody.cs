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
            /// The mode of the SLB instance.
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
            /// The ID.
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
            /// The ID of the SLB instance.
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// The IP address of the SLB instance.
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

            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }

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

            [NameInMap("VServiceList")]
            [Validation(Required=false)]
            public List<ListGatewaySlbResponseBodyDataVServiceList> VServiceList { get; set; }
            public class ListGatewaySlbResponseBodyDataVServiceList : TeaModel {
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("VServerGroupId")]
                [Validation(Required=false)]
                public string VServerGroupId { get; set; }

                [NameInMap("VServerGroupName")]
                [Validation(Required=false)]
                public string VServerGroupName { get; set; }

            }

            [NameInMap("VsMetaInfo")]
            [Validation(Required=false)]
            public string VsMetaInfo { get; set; }

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
