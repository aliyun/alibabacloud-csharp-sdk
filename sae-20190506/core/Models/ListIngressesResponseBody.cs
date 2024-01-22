// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListIngressesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The port specified for the SLB listener.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIngressesResponseBodyData Data { get; set; }
        public class ListIngressesResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the SLB instance based on the IP address. Valid values:
            /// 
            /// *   **internet**: the Internet-facing SLB instance.
            /// *   **intranet**: the internal-facing SLB instance.
            /// </summary>
            [NameInMap("IngressList")]
            [Validation(Required=false)]
            public List<ListIngressesResponseBodyDataIngressList> IngressList { get; set; }
            public class ListIngressesResponseBodyDataIngressList : TeaModel {
                /// <summary>
                /// The error code. 
                /// 
                /// - The **ErrorCode** parameter is not returned when the request succeeds.
                /// - The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("CertIds")]
                [Validation(Required=false)]
                public string CertIds { get; set; }

                /// <summary>
                /// The ID of the routing rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the list of routing rules was obtained. Valid values:
                /// 
                /// *   **true**: indicates that the list was obtained.
                /// *   **false**: indicates that the list could not be obtained.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The type of the SLB instance based on the processing capabilities. Valid values:
                /// 
                /// *   **clb**: the Classic Load Balancer (CLB) instance.
                /// *   **alb**: the Application Load Balancer (ALB) instance.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public string ListenerPort { get; set; }

                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                [NameInMap("LoadBalanceType")]
                [Validation(Required=false)]
                public string LoadBalanceType { get; set; }

                [NameInMap("MseGatewayId")]
                [Validation(Required=false)]
                public string MseGatewayId { get; set; }

                [NameInMap("MseGatewayPort")]
                [Validation(Required=false)]
                public string MseGatewayPort { get; set; }

                [NameInMap("MseGatewayProtocol")]
                [Validation(Required=false)]
                public string MseGatewayProtocol { get; set; }

                /// <summary>
                /// The HTTP status code. Valid values:
                /// 
                /// *   **2xx**: indicates that the request was successful.
                /// *   **3xx**: indicates that the request was redirected.
                /// *   **4xx**: indicates that the request was invalid.
                /// *   **5xx**: indicates that a server error occurred.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the routing rule.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The ID of the certificate.
                /// </summary>
                [NameInMap("SlbId")]
                [Validation(Required=false)]
                public string SlbId { get; set; }

                /// <summary>
                /// The protocol used to forward requests. Valid values:
                /// 
                /// *   **HTTP**: used when the application needs to identify the transmitted data.
                /// *   **HTTPS**: used when the application requires encrypted data transmission.
                /// </summary>
                [NameInMap("SlbType")]
                [Validation(Required=false)]
                public string SlbType { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The name of the routing rule.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
