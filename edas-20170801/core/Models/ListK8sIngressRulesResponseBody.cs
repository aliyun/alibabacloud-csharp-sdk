// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListK8sIngressRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListK8sIngressRulesResponseBodyData> Data { get; set; }
        public class ListK8sIngressRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b2b4ab4-efbc-4a81-9c45-a5942881****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-dev-cluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The Ingresses.</para>
            /// </summary>
            [NameInMap("IngressConfs")]
            [Validation(Required=false)]
            public List<ListK8sIngressRulesResponseBodyDataIngressConfs> IngressConfs { get; set; }
            public class ListK8sIngressRulesResponseBodyDataIngressConfs : TeaModel {
                /// <summary>
                /// <para>The ID of the ALB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alb-5sde0tq62r********</para>
                /// </summary>
                [NameInMap("AlbId")]
                [Validation(Required=false)]
                public string AlbId { get; set; }

                /// <summary>
                /// <para>The annotations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-annotation&quot;:&quot;test-annotation-value&quot;}</para>
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public string Annotations { get; set; }

                /// <summary>
                /// <para>The time when the Ingress was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-27 20:16:52</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The monitoring URL of the Ingress.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://grafana.console.aliyun.com/d/10xxxx/ingress">http://grafana.console.aliyun.com/d/10xxxx/ingress</a></para>
                /// </summary>
                [NameInMap("DashboardUrl")]
                [Validation(Required=false)]
                public string DashboardUrl { get; set; }

                /// <summary>
                /// <para>The IP address of the Ingress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.11x.xx.xx</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The Ingress type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NginxIngress</b>: NGINX Ingress controller</description></item>
                /// <item><description><b>AlbIngress</b>: ALB Ingress controller</description></item>
                /// </list>
                /// <para>Default value: NginxIngress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NginxIngress</para>
                /// </summary>
                [NameInMap("IngressType")]
                [Validation(Required=false)]
                public string IngressType { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test-label&quot;: &quot;test-labels&quot;}</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <para>The ID of the MSE gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("MseGatewayId")]
                [Validation(Required=false)]
                public string MseGatewayId { get; set; }

                /// <summary>
                /// <para>The name of the MSE gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-test-name</para>
                /// </summary>
                [NameInMap("MseGatewayName")]
                [Validation(Required=false)]
                public string MseGatewayName { get; set; }

                /// <summary>
                /// <para>The Ingress name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-ingress</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Kubernetes namespace to which the Ingress belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The URL used for basic monitoring of the open source version.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://g.console.aliyun.com/d/xxxxxx/nginx-ingress-dashboard-official">https://g.console.aliyun.com/d/xxxxxx/nginx-ingress-dashboard-official</a></para>
                /// </summary>
                [NameInMap("OfficalBasicUrl")]
                [Validation(Required=false)]
                public string OfficalBasicUrl { get; set; }

                /// <summary>
                /// <para>The URL used for request performance monitoring of the open source version.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://g.console.aliyun.com/d/xxxxxx/request-handling-performance-official">https://g.console.aliyun.com/d/xxxxxx/request-handling-performance-official</a></para>
                /// </summary>
                [NameInMap("OfficalRequestUrl")]
                [Validation(Required=false)]
                public string OfficalRequestUrl { get; set; }

                /// <summary>
                /// <para>The routing rules.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<ListK8sIngressRulesResponseBodyDataIngressConfsRules> Rules { get; set; }
                public class ListK8sIngressRulesResponseBodyDataIngressConfsRules : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether TLS is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableTls")]
                    [Validation(Required=false)]
                    public bool? EnableTls { get; set; }

                    /// <summary>
                    /// <para>The domain name to be accessed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The paths to be accessed.</para>
                    /// </summary>
                    [NameInMap("Paths")]
                    [Validation(Required=false)]
                    public List<ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths> Paths { get; set; }
                    public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPaths : TeaModel {
                        /// <summary>
                        /// <para>The ID of the EDAS application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>43d30ba5-c568-460c-8080-d447ed1a****</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The name of the EDAS application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my-app</para>
                        /// </summary>
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        /// <summary>
                        /// <para>The configurations of the backend Service.</para>
                        /// </summary>
                        [NameInMap("Backend")]
                        [Validation(Required=false)]
                        public ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend Backend { get; set; }
                        public class ListK8sIngressRulesResponseBodyDataIngressConfsRulesPathsBackend : TeaModel {
                            /// <summary>
                            /// <para>The name of the backend Service.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>http-service</para>
                            /// </summary>
                            [NameInMap("ServiceName")]
                            [Validation(Required=false)]
                            public string ServiceName { get; set; }

                            /// <summary>
                            /// <para>The port of the backend Service.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>8080</para>
                            /// </summary>
                            [NameInMap("ServicePort")]
                            [Validation(Required=false)]
                            public string ServicePort { get; set; }

                        }

                        /// <summary>
                        /// <para>The collection rate that is set based on the trace query feature. You can add a trace ID to a gateway to use the trace query feature of EDAS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("CollectRate")]
                        [Validation(Required=false)]
                        public int? CollectRate { get; set; }

                        /// <summary>
                        /// <para>The path to be accessed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/foo/bar</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <para>The path type that determines how a path is matched.</para>
                        /// <list type="bullet">
                        /// <item><description>ImplementationSpecific (default)</description></item>
                        /// <item><description>Exact</description></item>
                        /// <item><description>Prefix</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ImplementationSpecific</para>
                        /// </summary>
                        [NameInMap("PathType")]
                        [Validation(Required=false)]
                        public string PathType { get; set; }

                        /// <summary>
                        /// <para>The state of the Ingress. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Normal</b>: The Ingress works as expected.</description></item>
                        /// <item><description><b>ServiceNotFound</b>: The backend Service does not exist.</description></item>
                        /// <item><description><b>InvalidServicePort</b>: The Service port is invalid.</description></item>
                        /// <item><description><b>NotManagedService</b>: The Service is not managed by EDAS.</description></item>
                        /// <item><description><b>Unknown</b>: An unknown error occurred.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Normal</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the Secret that stores the Transport Layer Security (TLS) certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-secret</para>
                    /// </summary>
                    [NameInMap("SecretName")]
                    [Validation(Required=false)]
                    public string SecretName { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether SSL redirection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SslRedirect")]
                [Validation(Required=false)]
                public bool? SslRedirect { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1C9DE7-88FF-4B56-A47B-3DBBCEB******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
