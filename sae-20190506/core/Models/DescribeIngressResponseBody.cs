// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeIngressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The port specified for the SLB listener.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeIngressResponseBodyData Data { get; set; }
        public class DescribeIngressResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the application specified in the default rule.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            [NameInMap("CertIds")]
            [Validation(Required=false)]
            public string CertIds { get; set; }

            /// <summary>
            /// The forwarding rules.
            /// </summary>
            [NameInMap("DefaultRule")]
            [Validation(Required=false)]
            public DescribeIngressResponseBodyDataDefaultRule DefaultRule { get; set; }
            public class DescribeIngressResponseBodyDataDefaultRule : TeaModel {
                /// <summary>
                /// The domain name of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The container port of the application specified in the forwarding rule.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// The name of the application specified in the forwarding rule.
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

            }

            /// <summary>
            /// The name of the routing rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The HTTP status code. Valid values:
            /// 
            /// *   **2xx**: indicates that the request was successful.
            /// *   **3xx**: indicates that the request was redirected.
            /// *   **4xx**: indicates that the request was invalid.
            /// *   **5xx**: indicates that a server error occurred.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// The default rule.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// Indicates whether the configurations of the routing rule were queried successfully. Valid values:
            /// 
            /// *   **true**: indicates that the query was successful.
            /// *   **false**: indicates that the query failed.
            /// </summary>
            [NameInMap("LoadBalanceType")]
            [Validation(Required=false)]
            public string LoadBalanceType { get; set; }

            /// <summary>
            /// The ID of the application specified in the default rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the certificate.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// The ID of the application specified in the forwarding rule.
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeIngressResponseBodyDataRules> Rules { get; set; }
            public class DescribeIngressResponseBodyDataRules : TeaModel {
                /// <summary>
                /// The protocol used to forward requests. Valid values:
                /// 
                /// *   **HTTP**: used when the application needs to identify the transmitted data.
                /// *   **HTTPS**: used when the application requires encrypted data transmission.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The path of the URL.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("BackendProtocol")]
                [Validation(Required=false)]
                public string BackendProtocol { get; set; }

                /// <summary>
                /// The ID of the routing rule.
                /// </summary>
                [NameInMap("ContainerPort")]
                [Validation(Required=false)]
                public int? ContainerPort { get; set; }

                /// <summary>
                /// The type of the SLB instance based on the processing capabilities. Valid values:
                /// 
                /// *   **clb**: the Classic Load Balancer (CLB) instance.
                /// *   **alb**: the Application Load Balancer (ALB) instance.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The error code.
                /// 
                /// *   The **ErrorCode** parameter is not returned when the request succeeds.
                /// *   The **ErrorCode** parameter is returned when the request fails. For more information, see **Error codes** in this topic.
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("RewritePath")]
                [Validation(Required=false)]
                public string RewritePath { get; set; }

            }

            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The type of the SLB instance based on the IP address. Valid values:
            /// 
            /// *   **internet**: the Internet-facing SLB instance.
            /// *   **intranet**: the internal-facing SLB instance.
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// The container port of the application specified in the default rule.
            /// </summary>
            [NameInMap("SlbType")]
            [Validation(Required=false)]
            public string SlbType { get; set; }

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
