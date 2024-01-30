// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sIngressRulesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The response data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListK8sIngressRulesResponseBodyData> Data { get; set; }
        public class ListK8sIngressRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The cluster name.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The Ingresses.
            /// </summary>
            [NameInMap("IngressConfs")]
            [Validation(Required=false)]
            public List<ListK8sIngressRulesResponseBodyDataIngressConfs> IngressConfs { get; set; }
            public class ListK8sIngressRulesResponseBodyDataIngressConfs : TeaModel {
                /// <summary>
                /// The ID of the ALB instance.
                /// </summary>
                [NameInMap("AlbId")]
                [Validation(Required=false)]
                public string AlbId { get; set; }

                /// <summary>
                /// The annotations.
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// The time when the Ingress was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The monitoring URL of the Ingress.
                /// </summary>
                [NameInMap("DashboardUrl")]
                [Validation(Required=false)]
                public string DashboardUrl { get; set; }

                /// <summary>
                /// The IP address of the Ingress.
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// The Ingress type. Valid values:
                /// 
                /// *   **NginxIngress**: NGINX Ingress controller
                /// *   **AlbIngress**: ALB Ingress controller
                /// 
                /// Default value: NginxIngress.
                /// </summary>
                [NameInMap("IngressType")]
                [Validation(Required=false)]
                public string IngressType { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The ID of the MSE gateway.
                /// </summary>
                [NameInMap("MseGatewayId")]
                [Validation(Required=false)]
                public string MseGatewayId { get; set; }

                /// <summary>
                /// The name of the MSE gateway.
                /// </summary>
                [NameInMap("MseGatewayName")]
                [Validation(Required=false)]
                public string MseGatewayName { get; set; }

                /// <summary>
                /// The Ingress name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The Kubernetes namespace to which the Ingress belongs.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The URL used for basic monitoring of the open source version.
                /// </summary>
                [NameInMap("OfficalBasicUrl")]
                [Validation(Required=false)]
                public string OfficalBasicUrl { get; set; }

                /// <summary>
                /// The URL used for request performance monitoring of the open source version.
                /// </summary>
                [NameInMap("OfficalRequestUrl")]
                [Validation(Required=false)]
                public string OfficalRequestUrl { get; set; }

                /// <summary>
                /// The routing rules.
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListK8sIngressRulesResponseBodyDataIngressConfsRules> Rules { get; set; }
                public class ListK8sIngressRulesResponseBodyDataIngressConfsRules : TeaModel {
                    /// <summary>
                    /// Indicates whether TLS is enabled. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("EnableTls")]
                    [Validation(Required=false)]
                    public bool? EnableTls { get; set; }

                    /// <summary>
                    /// The domain name to be accessed.
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The paths to be accessed.
                    /// </summary>
                    [NameInMap("Paths")]
                    [Validation(Required=false)]
                    public List<ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths> Paths { get; set; }
                    public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths : TeaModel {
                        /// <summary>
                        /// The ID of the EDAS application.
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// The name of the EDAS application.
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        /// <summary>
                        /// The configurations of the backend Service.
                        /// </summary>
                        [NameInMap("Backend")]
                        [Validation(Required=false)]
                        public ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend Backend { get; set; }
                        public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend : TeaModel {
                            /// <summary>
                            /// The name of the backend Service.
                            /// </summary>
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            /// <summary>
                            /// The port of the backend Service.
                            /// </summary>
                            [NameInMap("ServicePort")]
                            [Validation(Required=false)]
                            public string ServicePort { get; set; }

                        }

                        /// <summary>
                        /// The collection rate that is set based on the trace query feature. You can add a trace ID to a gateway to use the trace query feature of EDAS.
                        /// </summary>
                        [NameInMap("CollectRate")]
                        [Validation(Required=false)]
                        public int? CollectRate { get; set; }

                        /// <summary>
                        /// The path to be accessed.
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// The path type that determines how a path is matched.
                        /// 
                        /// *   ImplementationSpecific (default)
                        /// *   Exact
                        /// *   Prefix
                        /// </summary>
                        [NameInMap("PathType")]
                        [Validation(Required=false)]
                        public string PathType { get; set; }

                        /// <summary>
                        /// The state of the Ingress. Valid values:
                        /// 
                        /// *   **Normal**: The Ingress works as expected.
                        /// *   **ServiceNotFound**: The backend Service does not exist.
                        /// *   **InvalidServicePort**: The Service port is invalid.
                        /// *   **NotManagedService**: The Service is not managed by EDAS.
                        /// *   **Unknown**: An unknown error occurred.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    /// <summary>
                    /// The name of the Secret that stores the Transport Layer Security (TLS) certificate.
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

                /// <summary>
                /// Indicates whether SSL redirection is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("SslRedirect")]
                [Validation(Required=false)]
                public bool? SslRedirect { get; set; }

            }

            /// <summary>
            /// The ID of the Alibaba Cloud region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The message that is returned.
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

    }

}
