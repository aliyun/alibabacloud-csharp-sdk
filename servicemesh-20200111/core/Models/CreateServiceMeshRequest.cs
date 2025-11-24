// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateServiceMeshRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable access log collection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccessLogEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access log collection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;&quot;: disables access log collection.</description></item>
        /// <item><description><c>/dev/stdout</c>: enables access log collection. Access logs are written to /dev/stdout.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/dev/stdout</para>
        /// </summary>
        [NameInMap("AccessLogFile")]
        [Validation(Required=false)]
        public string AccessLogFile { get; set; }

        /// <summary>
        /// <para>Custom fields of access logs. To set this parameter, you must enable access log collection. Otherwise, you cannot set this parameter. The value must be a JSON string. The following key values must be contained: authority_for, bytes_received, bytes_sent, downstream_local_address, downstream_remote_address, duration, istio_policy_status, method, path, protocol, requested_server_name, response_code, response_flags, route_name, start_time, trace_id, upstream_cluster, upstream_host, upstream_local_address, upstream_service_time, upstream_transport_failure_reason, user_agent, and x_forwarded_for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;authority_for&quot;:&quot;%REQ(:AUTHORITY)%&quot;,&quot;bytes_received&quot;:&quot;%BYTES_RECEIVED%&quot;,&quot;bytes_sent&quot;:&quot;%BYTES_SENT%&quot;,&quot;downstream_local_address&quot;:&quot;%DOWNSTREAM_LOCAL_ADDRESS%&quot;,&quot;downstream_remote_address&quot;:&quot;%DOWNSTREAM_REMOTE_ADDRESS%&quot;,&quot;duration&quot;:&quot;%DURATION%&quot;,&quot;istio_policy_status&quot;:&quot;%DYNAMIC_METADATA(istio.mixer:status)%&quot;,&quot;method&quot;:&quot;%REQ(:METHOD)%&quot;,&quot;path&quot;:&quot;%REQ(X-ENVOY-ORIGINAL-PATH?:PATH)%&quot;,&quot;protocol&quot;:&quot;%PROTOCOL%&quot;,&quot;request_id&quot;:&quot;%REQ(X-REQUEST-ID)%&quot;,&quot;requested_server_name&quot;:&quot;%REQUESTED_SERVER_NAME%&quot;,&quot;response_code&quot;:&quot;%RESPONSE_CODE%&quot;,&quot;response_flags&quot;:&quot;%RESPONSE_FLAGS%&quot;,&quot;route_name&quot;:&quot;%ROUTE_NAME%&quot;,&quot;start_time&quot;:&quot;%START_TIME%&quot;,&quot;trace_id&quot;:&quot;%REQ(X-B3-TRACEID)%&quot;,&quot;upstream_cluster&quot;:&quot;%UPSTREAM_CLUSTER%&quot;,&quot;upstream_host&quot;:&quot;%UPSTREAM_HOST%&quot;,&quot;upstream_local_address&quot;:&quot;%UPSTREAM_LOCAL_ADDRESS%&quot;,&quot;upstream_service_time&quot;:&quot;%RESP(X-ENVOY-UPSTREAM-SERVICE-TIME)%&quot;,&quot;upstream_transport_failure_reason&quot;:&quot;%UPSTREAM_TRANSPORT_FAILURE_REASON%&quot;,&quot;user_agent&quot;:&quot;%REQ(USER-AGENT)%&quot;,&quot;x_forwarded_for&quot;:&quot;%REQ(X-FORWARDED-FOR)%&quot;}</para>
        /// </summary>
        [NameInMap("AccessLogFormat")]
        [Validation(Required=false)]
        public string AccessLogFormat { get; set; }

        /// <summary>
        /// <para>The SLS project from which access logs are collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-log-cf245a429b6ff4b6e97f20797758*****</para>
        /// </summary>
        [NameInMap("AccessLogProject")]
        [Validation(Required=false)]
        public string AccessLogProject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable gRPC Access Log Service (ALS) of Envoy. gRPC is short for Google Remote Procedure Call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccessLogServiceEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogServiceEnabled { get; set; }

        /// <summary>
        /// <para>The endpoint of Envoy\&quot;s gRPC ALS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0</para>
        /// </summary>
        [NameInMap("AccessLogServiceHost")]
        [Validation(Required=false)]
        public string AccessLogServiceHost { get; set; }

        /// <summary>
        /// <para>The port of Envoy\&quot;s gRPC ALS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9999</para>
        /// </summary>
        [NameInMap("AccessLogServicePort")]
        [Validation(Required=false)]
        public int? AccessLogServicePort { get; set; }

        /// <summary>
        /// <para>The type of the Classic Load Balancer (CLB) instance that is bound to the API server. Valid values: <c>slb.s1.small</c>, <c>slb.s2.small</c>, <c>slb.s2.medium</c>, <c>slb.s3.small</c>, <c>slb.s3.medium</c>, and <c>slb.s3.large</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("ApiServerLoadBalancerSpec")]
        [Validation(Required=false)]
        public string ApiServerLoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to expose the API server to the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>If you set this parameter to <c>false</c>, the API server cannot be accessed over the Internet.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ApiServerPublicEip")]
        [Validation(Required=false)]
        public bool? ApiServerPublicEip { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for mesh audit.</para>
        /// <para>Default value: mesh-log-{ASM instance ID}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-log-xxxx</para>
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the CLB instance if the CLB instance uses the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period of the subscription CLB instance. This parameter is valid only if <c>ChargeType</c> is set to <c>PrePay</c>. If the original subscription period of the CLB instance is less than one year, the value of this parameter indicates the number of months for auto-renewal. If the original subscription period of the CLB instance is more than one year, the value of this parameter indicates the number of years for auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the Kubernetes API of clusters on the data plane to access Istio resources. The version of the ASM instance must be V1.9.7.93 or later. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CRAggregationEnabled")]
        [Validation(Required=false)]
        public bool? CRAggregationEnabled { get; set; }

        /// <summary>
        /// <para>The certificate chain from the CA certificate to the root certificate. At least two certificates are included in the chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64 encoded PEM certificate chain.</para>
        /// </summary>
        [NameInMap("CertChain")]
        [Validation(Required=false)]
        public string CertChain { get; set; }

        /// <summary>
        /// <para>The billing method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PayOnDemand</c>: pay-as-you-go</description></item>
        /// <item><description><c>PrePay</c>: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePay</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>ASM cluster domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster.local</para>
        /// </summary>
        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        /// <summary>
        /// <para>The edition of the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>standard</c>: Standard Edition</para>
        /// </description></item>
        /// <item><description><para><c>enterprise</c>: Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para><c>ultimate</c>: Ultimate Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the external service registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ConfigSourceEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSourceEnabled { get; set; }

        /// <summary>
        /// <para>The instance ID of the Nacos registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-tl326******</para>
        /// </summary>
        [NameInMap("ConfigSourceNacosID")]
        [Validation(Required=false)]
        public string ConfigSourceNacosID { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the collection of control plane logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ControlPlaneLogEnabled")]
        [Validation(Required=false)]
        public bool? ControlPlaneLogEnabled { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used to collect the logs of the control plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-log-cf245a429b6ff4b6e97f20797758*****</para>
        /// </summary>
        [NameInMap("ControlPlaneLogProject")]
        [Validation(Required=false)]
        public string ControlPlaneLogProject { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a custom Prometheus instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CustomizedPrometheus")]
        [Validation(Required=false)]
        public bool? CustomizedPrometheus { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a self-managed Zipkin system to collect tracing data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: uses a self-managed Zipkin system to collect tracing data.</description></item>
        /// <item><description><c>false</c>: uses Alibaba Cloud Tracing Analysis to collect tracing data.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CustomizedZipkin")]
        [Validation(Required=false)]
        public bool? CustomizedZipkin { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the DNS proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DNSProxyingEnabled")]
        [Validation(Required=false)]
        public bool? DNSProxyingEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Dubbo Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DubboFilterEnabled")]
        [Validation(Required=false)]
        public bool? DubboFilterEnabled { get; set; }

        /// <summary>
        /// <para>The edition of the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pro</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ACMG mode for the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableACMG")]
        [Validation(Required=false)]
        public bool? EnableACMG { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Ambient Mesh mode for the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAmbient")]
        [Validation(Required=false)]
        public bool? EnableAmbient { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the mesh audit feature. To enable this feature, make sure that you have activated <a href="https://sls.console.aliyun.com/">Log Service</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rollback feature for Istio resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCRHistory")]
        [Validation(Required=false)]
        public bool? EnableCRHistory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Secret Discovery Service (SDS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSDSServer")]
        [Validation(Required=false)]
        public bool? EnableSDSServer { get; set; }

        /// <summary>
        /// <para>The IP ranges in CIDR form to be excluded from redirection to the sidecar proxy in the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.100.10*.***</para>
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// <para>The inbound ports to be excluded from redirection to the sidecar proxy in the ASM instance. Separate multiple port numbers with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,81</para>
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// <para>The outbound ports to be excluded from redirection to the sidecar proxy in the ASM instance. Separate multiple port numbers with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,81</para>
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// <para>The existing CA certificate, which is encoded in Base64. This parameter is used in scenarios where you migrate open source Istio to ASM. It specifies the content of the ca-cert.pem file in the istio-ca-secret secret. The secret is in the istio-system namespace of the Kubernetes cluster where the open source Istio is installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA cert content, base64 encoded format.</para>
        /// </summary>
        [NameInMap("ExistingCaCert")]
        [Validation(Required=false)]
        public string ExistingCaCert { get; set; }

        /// <summary>
        /// <para>The existing CA key, which is encoded in Base64. This parameter is used in scenarios where you migrate open source Istio to ASM. It specifies the content of the ca-key.pem file in the istio-ca-secret secret. The secret is in the istio-system namespace of the Kubernetes cluster where the open source Istio is installed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA key content, base64 encoded format.</para>
        /// </summary>
        [NameInMap("ExistingCaKey")]
        [Validation(Required=false)]
        public string ExistingCaKey { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the existing CA certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Self-signed certificate generated by istiod. The certificate corresponds to the secret named istio-ca-secret in the istio-system namespace. If you use this type of certificate, you must set the <c>ExistingCaCert</c> and <c>ExistingCaKey</c> parameters.</description></item>
        /// <item><description>2: Administrator-specified certificate. For more information, see <a href="https://istio.io/latest/docs/tasks/security/cert-management/plugin-ca-cert/">plugin ca cert</a>. In most cases, the certificate corresponds to the secret named cacerts in the istio-system namespace. If you use this type of certificate, you must set the <c>ExisingRootCaCert</c> and <c>ExisingRootCaKey</c> parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExistingCaType")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExistingCaType { get; set; }

        /// <summary>
        /// <para>The existing root certificate, which is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Existing CA cert content, base64 encoded format.</para>
        /// </summary>
        [NameInMap("ExistingRootCaCert")]
        [Validation(Required=false)]
        public string ExistingRootCaCert { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The private key that corresponds to the root certificate, which is encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Existing CA key content, base64 encoded format.</para>
        /// </summary>
        [NameInMap("ExistingRootCaKey")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExistingRootCaKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable gateway configuration filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterGatewayClusterConfig")]
        [Validation(Required=false)]
        public bool? FilterGatewayClusterConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Gateway API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GatewayAPIEnabled")]
        [Validation(Required=false)]
        public bool? GatewayAPIEnabled { get; set; }

        /// <summary>
        /// <para>When you create an ASM instance, you can add a cluster to the ASM instance. If you do not specify this parameter, no cluster is added to the ASM instance. The cluster and the ASM instance must be in the same vSwitch of the same VPC and have the same domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACK cluster id</para>
        /// </summary>
        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        /// <summary>
        /// <para>The IP ranges in CIDR form for which traffic is to be redirected to the sidecar proxy in the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        /// <summary>
        /// <para>The Istio version of the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.5.4.1-g5960ec40-aliyun</para>
        /// </summary>
        [NameInMap("IstioVersion")]
        [Validation(Required=false)]
        public string IstioVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the mesh topology feature. To enable this feature, make sure that you have enabled Prometheus monitoring. If Prometheus monitoring is disabled, you must set this parameter to <c>false</c>.`` Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("KialiEnabled")]
        [Validation(Required=false)]
        public bool? KialiEnabled { get; set; }

        /// <summary>
        /// <para>The configurations for the access to the nearest instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failover&quot;:[{&quot;from&quot;:&quot;cn-hangzhou&quot;,&quot;to&quot;:&quot;cn-shanghai&quot;}]}</para>
        /// </summary>
        [NameInMap("LocalityLBConf")]
        [Validation(Required=false)]
        public string LocalityLBConf { get; set; }

        /// <summary>
        /// <para>Specifies whether to route traffic to the nearest instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Microservices Engine (MSE). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MSEEnabled")]
        [Validation(Required=false)]
        public bool? MSEEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable MultiBuffer-based Transport Layer Security (TLS) acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c></para>
        /// </description></item>
        /// <item><description><para><c>false</c></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MultiBufferEnabled")]
        [Validation(Required=false)]
        public bool? MultiBufferEnabled { get; set; }

        /// <summary>
        /// <para>The pull-request latency. Default value: 30. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30s</para>
        /// </summary>
        [NameInMap("MultiBufferPollDelay")]
        [Validation(Required=false)]
        public string MultiBufferPollDelay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable MySQL Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MysqlFilterEnabled")]
        [Validation(Required=false)]
        public bool? MysqlFilterEnabled { get; set; }

        /// <summary>
        /// <para>The name of the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the OPA container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the OPA container. You can specify the parameter value in the standard quantity representation form used by Kubernetes. 1 Mi equals 1,024 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        /// <summary>
        /// <para>The log level of the OPA container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores that are required by the OPA container. You can specify the parameter value in the standard representation form of CPUs in Kubernetes. For example, if you set the value to 1, one CPU core is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        /// <summary>
        /// <para>The minimum size of the memory that is required by the OPA container. You can specify the parameter value in the standard quantity representation form used by Kubernetes. 1 Mi equals 1,024 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512Mi</para>
        /// </summary>
        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the OPA plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpaEnabled")]
        [Validation(Required=false)]
        public bool? OpaEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to install the Open Policy Agent (OPA) plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        /// <summary>
        /// <para>The subscription period of the CLB instance. This parameter is valid only if <c>ChargeType</c> is set to <c>PrePay</c>. The value of this parameter indicates the subscription period of the CLB instance. Unit: month. For example, if the subscription period is one year, set this parameter to 12.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The type of the CLB instance that is bound to Istio Pilot. Valid values: <c>slb.s1.small</c>, <c>slb.s2.small</c>, <c>slb.s2.medium</c>, <c>slb.s3.small</c>, <c>slb.s3.medium</c>, and <c>slb.s3.large</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PilotLoadBalancerSpec")]
        [Validation(Required=false)]
        public string PilotLoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The playground scenario. If you specify this parameter, an ASM playground instance is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ewmaLb: the exponentially weighted moving average (EWMA) load balancing algorithm.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ewmaLb</para>
        /// </summary>
        [NameInMap("PlaygroundScene")]
        [Validation(Required=false)]
        public string PlaygroundScene { get; set; }

        /// <summary>
        /// <para>The endpoint of the custom Prometheus instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://prometheus:9090">http://prometheus:9090</a></para>
        /// </summary>
        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000m</para>
        /// </summary>
        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores that are required by the proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100m</para>
        /// </summary>
        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        /// <summary>
        /// <para>The minimum size of the memory that is required by the proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128Mi</para>
        /// </summary>
        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Redis Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the ASM instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Tag of the ASM instance. A tag contains the following information:</para>
        /// <list type="bullet">
        /// <item><description>key: the name of the tag</description></item>
        /// <item><description>value: the value of the tag</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceMeshRequestTag> Tag { get; set; }
        public class CreateServiceMeshRequestTag : TeaModel {
            /// <summary>
            /// <para>The name of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus monitoring. We recommend that you use Prometheus Service of <a href="https://arms.console.aliyun.com/">Application Real-Time Monitoring Service (ARMS)</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Thrift Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ThriftFilterEnabled")]
        [Validation(Required=false)]
        public bool? ThriftFilterEnabled { get; set; }

        /// <summary>
        /// <para>The sampling percentage of Tracing Analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Tracing Analysis feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an existing CA certificate and private key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseExistingCA")]
        [Validation(Required=false)]
        public bool? UseExistingCA { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the ASM instance is connected.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-xzegf5dndkbf4m6eg****&quot;]</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitches { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the ASM instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xzelac2tw4ic7wz31****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WebAssembly Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WebAssemblyFilterEnabled")]
        [Validation(Required=false)]
        public bool? WebAssemblyFilterEnabled { get; set; }

    }

}
