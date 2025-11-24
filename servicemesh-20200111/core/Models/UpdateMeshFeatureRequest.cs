// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshFeatureRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable access log collection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables access log collection.</description></item>
        /// <item><description><c>false</c>: disables access log collection.</description></item>
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
        /// <para>Specifies whether to enable access logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>&quot;&quot;</c>: disables access logging.</description></item>
        /// <item><description><c>/dev/stdout</c>: enables access logging. Access logs are written to /dev/stdout.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("AccessLogFile")]
        [Validation(Required=false)]
        public string AccessLogFile { get; set; }

        /// <summary>
        /// <para>The custom format of access logs. To set this parameter, make sure that you have enabled access log collection. The value must be a JSON string. The following key names must be contained: authority_for, bytes_received, bytes_sent, downstream_local_address, downstream_remote_address, duration, istio_policy_status, method, path, protocol, requested_server_name, response_code, response_flags, route_name, start_time, trace_id, upstream_cluster, upstream_host, upstream_local_address, upstream_service_time, upstream_transport_failure_reason, user_agent, and x_forwarded_for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;authority_for&quot;:&quot;%REQ(:AUTHORITY)%&quot;,&quot;bytes_received&quot;:&quot;%BYTES_RECEIVED%&quot;,&quot;bytes_sent&quot;:&quot;%BYTES_SENT%&quot;,&quot;downstream_local_address&quot;:&quot;%DOWNSTREAM_LOCAL_ADDRESS%&quot;,&quot;downstream_remote_address&quot;:&quot;%DOWNSTREAM_REMOTE_ADDRESS%&quot;,&quot;duration&quot;:&quot;%DURATION%&quot;,&quot;istio_policy_status&quot;:&quot;%DYNAMIC_METADATA(istio.mixer:status)%&quot;,&quot;method&quot;:&quot;%REQ(:METHOD)%&quot;,&quot;path&quot;:&quot;%REQ(X-ENVOY-ORIGINAL-PATH?:PATH)%&quot;,&quot;protocol&quot;:&quot;%PROTOCOL%&quot;,&quot;request_id&quot;:&quot;%REQ(X-REQUEST-ID)%&quot;,&quot;requested_server_name&quot;:&quot;%REQUESTED_SERVER_NAME%&quot;,&quot;response_code&quot;:&quot;%RESPONSE_CODE%&quot;,&quot;response_flags&quot;:&quot;%RESPONSE_FLAGS%&quot;,&quot;route_name&quot;:&quot;%ROUTE_NAME%&quot;,&quot;start_time&quot;:&quot;%START_TIME%&quot;,&quot;trace_id&quot;:&quot;%REQ(X-B3-TRACEID)%&quot;,&quot;upstream_cluster&quot;:&quot;%UPSTREAM_CLUSTER%&quot;,&quot;upstream_host&quot;:&quot;%UPSTREAM_HOST%&quot;,&quot;upstream_local_address&quot;:&quot;%UPSTREAM_LOCAL_ADDRESS%&quot;,&quot;upstream_service_time&quot;:&quot;%RESP(X-ENVOY-UPSTREAM-SERVICE-TIME)%&quot;,&quot;upstream_transport_failure_reason&quot;:&quot;%UPSTREAM_TRANSPORT_FAILURE_REASON%&quot;,&quot;user_agent&quot;:&quot;%REQ(USER-AGENT)%&quot;,&quot;x_forwarded_for&quot;:&quot;%REQ(X-FORWARDED-FOR)%&quot;}</para>
        /// </summary>
        [NameInMap("AccessLogFormat")]
        [Validation(Required=false)]
        public string AccessLogFormat { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the collection of access logs of ASM gateways to Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccessLogGatewayEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogGatewayEnabled { get; set; }

        /// <summary>
        /// <para>The retention period for the access logs of the sidecar proxy. Unit: day. The logs are collected by using Log Service. For example, <c>30</c> indicates 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AccessLogGatewayLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogGatewayLifecycle { get; set; }

        /// <summary>
        /// <para>The custom project on which the Log Service collects logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-log-cf245a429b6ff4b6e97f20797758e****</para>
        /// </summary>
        [NameInMap("AccessLogProject")]
        [Validation(Required=false)]
        public string AccessLogProject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable gRPC Access Log Service (ALS) for Envoy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables gRPC ALS for Envoy.</description></item>
        /// <item><description><c>false</c>: disables gRPC ALS for Envoy.</description></item>
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
        /// <para>The endpoint of gRPC ALS for Envoy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0</para>
        /// </summary>
        [NameInMap("AccessLogServiceHost")]
        [Validation(Required=false)]
        public string AccessLogServiceHost { get; set; }

        /// <summary>
        /// <para>The port of gRPC ALS for Envoy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9999</para>
        /// </summary>
        [NameInMap("AccessLogServicePort")]
        [Validation(Required=false)]
        public int? AccessLogServicePort { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the collection of access logs of sidecar proxies to Simple Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AccessLogSidecarEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogSidecarEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic diagnostics for the ASM instance. If you enable this feature, the ASM instance is automatically diagnosed when you modify Istio resources in the ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AccessLogSidecarLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogSidecarLifecycle { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for mesh audit.</para>
        /// <para>Default value: <c>mesh-log-{ASM instance ID}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mesh-log-c08ba3fd1e64xxb0f8cc1ad8****</para>
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic sidecar proxy injection by using pod annotations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables automatic sidecar proxy injection by using pod annotations.</description></item>
        /// <item><description><c>false</c>: disables automatic sidecar proxy injection by using pod annotations.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoInjectionPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AutoInjectionPolicyEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Kubernetes API of clusters on the data plane to access Istio resources. To use this feature, the version of the ASM instance must be V1.9.7.93 or later.</para>
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
        /// <para>Base64 encoded PEM cert chain.</para>
        /// </summary>
        [NameInMap("CertChain")]
        [Validation(Required=false)]
        public string CertChain { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the feature of controlling the OPA injection scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the feature.</description></item>
        /// <item><description><c>false</c>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Container Network Interface (CNI) plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the CNI plug-in.</description></item>
        /// <item><description><c>false</c>: disables the CNI plug-in.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CniEnabled")]
        [Validation(Required=false)]
        public bool? CniEnabled { get; set; }

        /// <summary>
        /// <para>The namespaces to be excluded for the CNI plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kube-system</para>
        /// </summary>
        [NameInMap("CniExcludeNamespaces")]
        [Validation(Required=false)]
        public string CniExcludeNamespaces { get; set; }

        /// <summary>
        /// <para>Specifies whether to delay application container startup until the sidecar proxy container is started in a pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the external service registry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the external service registry.</description></item>
        /// <item><description><c>false</c>: disables the external service registry.</description></item>
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
        /// <para>Specifies whether to use a custom Prometheus instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: uses a custom Prometheus instance.</description></item>
        /// <item><description><c>false</c>: does not use a custom Prometheus instance.</description></item>
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
        /// <item><description><c>true</c>: uses a self-managed Zipkin system.</description></item>
        /// <item><description><c>false</c>: does not use a self-managed Zipkin system.</description></item>
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
        /// <para>Specifies whether to enable DNS proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the DNS proxy feature.</description></item>
        /// <item><description><c>false</c>: disables the DNS proxy feature.</description></item>
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
        /// <para>Specifies the default scheduling configurations that ASM delivers to components on the data plane. You can configure <c>nodeSelector</c> and <c>tolerations</c> in the JSON format.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Modifying the value of this parameter is a high-risk operation. The modification will cause all components on the data plane of ASM to restart. Exercise caution before modifying the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>The configurations specified by this parameter do not apply to ASM gateways. You can configure gateway-specific scheduling on ASM gateways.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tolerations&quot;:[{&quot;key&quot;:&quot;test-taints&quot;, &quot;operator&quot;:&quot;Exists&quot;, &quot;effect&quot;:&quot;NoSchedule&quot;}], &quot;nodeSelector&quot;:{&quot;kubernetes.io/hostname&quot;:&quot;test-nodes&quot;}}</para>
        /// </summary>
        [NameInMap("DefaultComponentsScheduleConfig")]
        [Validation(Required=false)]
        public string DefaultComponentsScheduleConfig { get; set; }

        /// <summary>
        /// <para>The label selectors used to specify the namespaces of the clusters on the data plane for selective service discovery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;matchExpressions&quot;:[{&quot;key&quot;:&quot;asm-discovery&quot;,&quot;operator&quot;:&quot;Exists&quot;}]}]</para>
        /// </summary>
        [NameInMap("DiscoverySelectors")]
        [Validation(Required=false)]
        public string DiscoverySelectors { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Dubbo Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Dubbo Filter.</description></item>
        /// <item><description><c>false</c>: disables Dubbo Filter.</description></item>
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
        /// <para>Specifies whether to enable the mesh audit feature. To enable this feature, make sure that you have activated <a href="https://sls.console.aliyun.com/">Log Service</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the mesh audit feature.</description></item>
        /// <item><description><c>false</c>: disables the mesh audit feature.</description></item>
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
        /// <para>The ports for which outbound traffic is redirected to the sidecar proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutoDiagnosis")]
        [Validation(Required=false)]
        public bool? EnableAutoDiagnosis { get; set; }

        /// <summary>
        /// <para>Specifies the authentication token of an ARMS Prometheus instance when the Mesh Topology feature is enabled and ARMS Prometheus is used to collect monitoring metrics. The token is used to allow Mesh Topology to access the ARMS Prometheus instance. The token is in the JSON format. The key in the JSON object is the ID of the cluster on the data plane, and the value is the authentication token of the ARMS Prometheus instance deployed in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBootstrapXdsAgent")]
        [Validation(Required=false)]
        public bool? EnableBootstrapXdsAgent { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rollback feature for Istio resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCRHistory")]
        [Validation(Required=false)]
        public bool? EnableCRHistory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic sidecar proxy injection for all namespaces. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables automatic sidecar proxy injection for all namespaces.</description></item>
        /// <item><description><c>false</c>: disables automatic sidecar proxy injection for all namespaces.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableNamespacesByDefault")]
        [Validation(Required=false)]
        public bool? EnableNamespacesByDefault { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Secret Discovery Service (SDS). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables SDS.</description></item>
        /// <item><description><c>false</c>: disables SDS.</description></item>
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
        /// <para>The IP addresses of external services to which traffic is not intercepted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.100.XXX.XXX</para>
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// <para>The ports for which inbound traffic is not redirected to the sidecar proxy. Separate multiple ports with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,81</para>
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// <para>The ports for which outbound traffic is not redirected to the sidecar proxy. Separate multiple ports with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,81</para>
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// <para>The updated certificate authority (CA) certificate. You can modify this parameter only if you use a custom certificate when you create an ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64 encoded PEM certificate.</para>
        /// </summary>
        [NameInMap("ExistingCaCert")]
        [Validation(Required=false)]
        public string ExistingCaCert { get; set; }

        /// <summary>
        /// <para>The updated CA certificate key. You can modify this parameter only if you use a custom certificate when you create an ASM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64 encoded PEM
        ///  private key.</para>
        /// </summary>
        [NameInMap("ExistingCaKey")]
        [Validation(Required=false)]
        public string ExistingCaKey { get; set; }

        /// <summary>
        /// <para>The updated root certificate. You can modify this parameter only if you use a custom certificate when you create a Service Mesh (ASM) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64 encoded PEM certificate.</para>
        /// </summary>
        [NameInMap("ExistingRootCaCert")]
        [Validation(Required=false)]
        public string ExistingRootCaCert { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable gateway configuration filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables gateway configuration filtering.</description></item>
        /// <item><description><c>false</c>: disables gateway configuration filtering.</description></item>
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
        /// <item><description><c>true</c>: enables Gateway API.</description></item>
        /// <item><description><c>false</c>: disables Gateway API.</description></item>
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
        /// <para>Other metrics of the sidecar proxy on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HoldApplicationUntilProxyStarts")]
        [Validation(Required=false)]
        public bool? HoldApplicationUntilProxyStarts { get; set; }

        /// <summary>
        /// <para>Specifies whether to support HTTP 1.0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: supports HTTP 1.0.</description></item>
        /// <item><description><c>false</c>: does not support HTTP 1.0.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Http10Enabled")]
        [Validation(Required=false)]
        public bool? Http10Enabled { get; set; }

        /// <summary>
        /// <para>The IP addresses of external services to which traffic is intercepted.</para>
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
        /// <para>The ports for which inbound traffic is redirected to the sidecar proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,81</para>
        /// </summary>
        [NameInMap("IncludeInboundPorts")]
        [Validation(Required=false)]
        public string IncludeInboundPorts { get; set; }

        /// <summary>
        /// <para>The log level of the sidecar proxy on the data plane. Log levels include <c>none</c>, <c>error</c>, <c>warn</c>, <c>info</c>, and <c>debug</c>. The levels correspond to different amounts of information reported by the logs. For example, none-level logs report the least information, while debug-level logs report the most information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000,8001</para>
        /// </summary>
        [NameInMap("IncludeOutboundPorts")]
        [Validation(Required=false)]
        public string IncludeOutboundPorts { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a Classic Load Balancer (CLB) instance for accessing Mesh Topology of Service Mesh (ASM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IntegrateKiali")]
        [Validation(Required=false)]
        public bool? IntegrateKiali { get; set; }

        /// <summary>
        /// <para>Specifies whether to load the bootstrap configuration before the sidecar proxy is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TPROXY</para>
        /// </summary>
        [NameInMap("InterceptionMode")]
        [Validation(Required=false)]
        public string InterceptionMode { get; set; }

        /// <summary>
        /// <para>Specifies the default scheduling configurations that ASM delivers to components on the data plane. You can configure <c>nodeSelector</c> and tolerations in the JSON format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Modifying the value of this parameter is a high-risk operation. The modification will cause all components on the data plane of ASM to restart. Exercise caution before modifying the value of this parameter.</description></item>
        /// <item><description>The configurations specified by this parameter do not apply to the ASM gateway. You can configure gateway-specific scheduling on the ASM gateway.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;c31e3b******5634b&quot;:&quot;token_example&quot;}</para>
        /// </summary>
        [NameInMap("KialiArmsAuthTokens")]
        [Validation(Required=false)]
        public string KialiArmsAuthTokens { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Mesh Topology feature. To enable this feature, make sure that you have enabled Prometheus monitoring. If Prometheus monitoring is disabled, the Mesh Topology feature must be disabled. Valid values:````</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the Mesh Topology feature.</description></item>
        /// <item><description><c>false</c>: disables the Mesh Topology feature.</description></item>
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
        /// <para>Specifies Classic Load Balancer (CLB) instances by using annotations when the Mesh Topology feature is enabled. These CLB instances are used to access the Mesh Topology feature in different clusters.</para>
        /// <para>This parameter is a JSON-encoded string. The key in the JSON object is the ID of a cluster on the data plane, and the value is the annotation content of the Mesh Topology service in the cluster.</para>
        /// <para>For more information about how to configure CLB instances by using annotations, see <a href="https://www.alibabacloud.com/help/container-service-for-kubernetes/latest/use-annotations-to-configure-load-balancing-1">Add annotations to the YAML file of a Service to configure CLB instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;c31e3b******5634b&quot;:{&quot;service.beta.kubernetes.io/alibaba-cloud-loadbalancer-address-type&quot;:&quot;intranet&quot;}}</para>
        /// </summary>
        [NameInMap("KialiServiceAnnotations")]
        [Validation(Required=false)]
        public string KialiServiceAnnotations { get; set; }

        /// <summary>
        /// <para>The labels for isolated workloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name=xx,region=xx</para>
        /// </summary>
        [NameInMap("LabelsForOffloadedWorkloads")]
        [Validation(Required=false)]
        public string LabelsForOffloadedWorkloads { get; set; }

        /// <summary>
        /// <para>The lifecycle of the sidecar proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;postStart&quot;:{&quot;exec&quot;:{&quot;command&quot;:[&quot;pilot-agent&quot;,&quot;wait&quot;]}},&quot;preStop&quot;:{&quot;exec&quot;:{&quot;command&quot;:[&quot;/bin/sh&quot;,&quot;-c&quot;,&quot;sleep 15&quot;]}}}</para>
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        /// <summary>
        /// <para>The configurations of cross-region load balancing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>failover</c>: the configurations of cross-region failover. Example:</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>failover: [// Cross-region failover configurations of the struct type. 
        ///         {
        ///             // If a service fails in the China (Beijing) region, the traffic is redirected to the same service in the China (Hangzhou) region. 
        ///             from: &quot;cn-beijing&quot;, 
        ///             to: &quot;cn-hangzhou&quot;,
        ///         }
        ///     ]
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><c>distribute</c>: the configurations of cross-region traffic distribution. Example:</description></item>
        /// </list>
        /// <!---->
        /// 
        /// <pre><c>distribute: [// Cross-region traffic distribution configurations of the struct type. 
        ///         {
        ///             // For traffic that is routed to the China (Beijing) region, 70% of the traffic is allocated to the China (Beijing) region and the rest of the traffic is redirected to the China (Hangzhou) region. 
        ///             &quot;from&quot;: &quot;cn-beijing&quot;,
        ///             &quot;to&quot;: {
        ///                 &quot;cn-beijing&quot;: 70,
        ///                 &quot;cn-hangzhou&quot;: 30,
        ///             }
        ///         }
        ///     ]
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;failover&quot;:[{&quot;from&quot;:&quot;cn-hangzhou&quot;,&quot;to&quot;:&quot;cn-shanghai&quot;}]}</para>
        /// </summary>
        [NameInMap("LocalityLBConf")]
        [Validation(Required=false)]
        public string LocalityLBConf { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-region load balancing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables cross-region load balancing.</description></item>
        /// <item><description><c>false</c>: disables cross-region load balancing.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        /// <summary>
        /// <para>The number of worker threads used by the sidecar proxy on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
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
        [Obsolete]
        public bool? MSEEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Transport Layer Security (TLS) acceleration based on MultiBuffer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MultiBufferEnabled")]
        [Validation(Required=false)]
        public bool? MultiBufferEnabled { get; set; }

        /// <summary>
        /// <para>The pull-request latency. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.02s</para>
        /// </summary>
        [NameInMap("MultiBufferPollDelay")]
        [Validation(Required=false)]
        public string MultiBufferPollDelay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable MySQL Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables MySQL Filter.</description></item>
        /// <item><description><c>false</c>: disables MySQL Filter.</description></item>
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
        /// <para>Specifies whether to clear feature labels on nodes when NFD is disabled.</para>
        /// <para>This parameter is valid only when the <c>NFDEnabled</c> parameter is set to <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NFDEnabled")]
        [Validation(Required=false)]
        public bool? NFDEnabled { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores requested by the proxy service that exports Tracing Analysis data. For example, <c>1000m</c> indicates one CPU core.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NFDLabelPruned")]
        [Validation(Required=false)]
        public bool? NFDLabelPruned { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the pod that injects OPA proxies into application pods. For example, <c>1024Mi</c> indicates 1024 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000m</para>
        /// </summary>
        [NameInMap("OPAInjectorCPULimit")]
        [Validation(Required=false)]
        public string OPAInjectorCPULimit { get; set; }

        /// <summary>
        /// <para>The minimum size of the memory requested by the pod that injects OPA proxies into application pods. For example, <c>50 Mi</c> indicates 50 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80m</para>
        /// </summary>
        [NameInMap("OPAInjectorCPURequirement")]
        [Validation(Required=false)]
        public string OPAInjectorCPURequirement { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a CLB instance for accessing the ASM mesh topology.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("OPAInjectorMemoryLimit")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryLimit { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the pod that injects OPA proxies into application pods. For example, <c>1000m</c> indicates one CPU core.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50Mi</para>
        /// </summary>
        [NameInMap("OPAInjectorMemoryRequirement")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryRequirement { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the OPA proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the OPA proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        /// <summary>
        /// <para>The log level of the OPA proxy container.</para>
        /// <list type="bullet">
        /// <item><description><c>info</c>: outputs all information.</description></item>
        /// <item><description><c>debug</c>: outputs debugging and error information.</description></item>
        /// <item><description><c>error</c>: outputs only error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that are requested by the OPA proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        /// <summary>
        /// <para>The size of the memory that is requested by the OPA proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512Mi</para>
        /// </summary>
        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores requested by the pod that injects OPA proxies into application pods. For example, <c>1000m</c> indicates one CPU core.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OPAScopeInjected")]
        [Validation(Required=false)]
        public bool? OPAScopeInjected { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the OPA plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the OPA plug-in.</description></item>
        /// <item><description><c>false</c>: disables the OPA plug-in.</description></item>
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
        /// <item><description><c>true</c>: installs the OPA plug-in.</description></item>
        /// <item><description><c>false</c>: does not install the OPA plug-in.</description></item>
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
        /// <para>The policy for accessing external services. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ALLOW_ANY</c>: allows access to all external services.</description></item>
        /// <item><description><c>REGISTRY_ONLY</c>: allows access to only the external services that are defined in the ServiceEntry of the ASM instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALLOW_ANY</para>
        /// </summary>
        [NameInMap("OutboundTrafficPolicy")]
        [Validation(Required=false)]
        public string OutboundTrafficPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to support HTTP/3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PilotEnableQuicListeners")]
        [Validation(Required=false)]
        public bool? PilotEnableQuicListeners { get; set; }

        /// <summary>
        /// <para>The endpoint of Prometheus monitoring. If you use ARMS Prometheus, set this parameter to the endpoint of Prometheus provided by ARMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://prometheus:9090">http://prometheus:9090</a></para>
        /// </summary>
        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the istio-init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000m</para>
        /// </summary>
        [NameInMap("ProxyInitCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceLimit { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that are requested by the istio-init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10m</para>
        /// </summary>
        [NameInMap("ProxyInitCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the istio-init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceLimit { get; set; }

        /// <summary>
        /// <para>The size of the memory that is requested by the istio-init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10Mi</para>
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000m</para>
        /// </summary>
        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that are requested by the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100m</para>
        /// </summary>
        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        /// <summary>
        /// <para>The size of the memory that is requested by the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128Mi</para>
        /// </summary>
        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        /// <summary>
        /// <para>The mode in which the sidecar proxy intercepts inbound traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REDIRECT</c>: The sidecar proxy intercepts inbound traffic in the REDIRECT mode.</description></item>
        /// <item><description><c>TPROXY</c>: The sidecar proxy intercepts inbound traffic in the TPROXY mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;inclusionRegexps&quot;:&quot;.<em>adaptive_concurrency.</em>&quot;}</para>
        /// </summary>
        [NameInMap("ProxyStatsMatcher")]
        [Validation(Required=false)]
        public string ProxyStatsMatcher { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Redis Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Redis Filter.</description></item>
        /// <item><description><c>false</c>: disables Redis Filter.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SMC optimization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SMCEnabled")]
        [Validation(Required=false)]
        public bool? SMCEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the pod where a sidecar proxy injector resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000m</para>
        /// </summary>
        [NameInMap("SidecarInjectorLimitCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitCPU { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available to the pod where a sidecar proxy injector resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048Mi</para>
        /// </summary>
        [NameInMap("SidecarInjectorLimitMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitMemory { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that are requested by the pod where a sidecar proxy injector resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000m</para>
        /// </summary>
        [NameInMap("SidecarInjectorRequestCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestCPU { get; set; }

        /// <summary>
        /// <para>The size of the memory that is requested by the pod where a sidecar proxy injector resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512Mi</para>
        /// </summary>
        [NameInMap("SidecarInjectorRequestMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestMemory { get; set; }

        /// <summary>
        /// <para>Other configurations of automatic sidecar proxy injection, in the YAML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;injectedAnnotations&quot;:{&quot;test/istio-init&quot;:&quot;runtime/default2&quot;,&quot;test/istio-proxy&quot;:&quot;runtime/default&quot;},&quot;replicaCount&quot;:2,&quot;nodeSelector&quot;:{&quot;beta.kubernetes.io/os&quot;:&quot;linux&quot;}}</para>
        /// </summary>
        [NameInMap("SidecarInjectorWebhookAsYaml")]
        [Validation(Required=false)]
        public string SidecarInjectorWebhookAsYaml { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus monitoring. We recommend that you enable <a href="https://arms.console.aliyun.com/">ARMS Prometheus</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Prometheus monitoring.</description></item>
        /// <item><description><c>false</c>: disables Prometheus monitoring.</description></item>
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
        /// <para>The maximum period of time that the sidecar proxy waits for requests to be processed before the proxy is stopped. For example, if you want to specify a period of 5 seconds, set this parameter to 5s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5s</para>
        /// </summary>
        [NameInMap("TerminationDrainDuration")]
        [Validation(Required=false)]
        public string TerminationDrainDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Thrift Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Thrift Filter.</description></item>
        /// <item><description><c>false</c>: disables Thrift Filter.</description></item>
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
        /// <para>The custom tag of Tracing Analysis. Specify this parameter in the JSON format.</para>
        /// <pre><c>{
        ///     &quot;name1&quot;: CustomTag,
        ///     &quot;name2&quot;: CustomTag
        /// }
        /// </c></pre>
        /// <para>Tag key: literal, header, or environment.</para>
        /// <pre><c>{
        ///     &quot;literal&quot;: {
        ///         &quot;value&quot;: &quot;Fixed value&quot;
        ///     }
        ///     &quot;header&quot;: {
        ///         &quot;name&quot;: &quot;Header name&quot;
        ///         &quot;defaultValue&quot;: &quot;Default value that is used if the specified header does not exist&quot;
        ///     }
        ///     &quot;environment&quot;: {
        ///         &quot;name&quot;: &quot;Environment variable name&quot;
        ///         &quot;defaultValue&quot;: &quot;Default value that is used if the specified environment variable does not exist&quot;
        ///     }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mytag&quot;: {&quot;literal&quot;:{&quot;value&quot;:&quot;test&quot;}}}</para>
        /// </summary>
        [NameInMap("TraceCustomTags")]
        [Validation(Required=false)]
        public string TraceCustomTags { get; set; }

        /// <summary>
        /// <para>The maximum length of the request path contained in the HttpUrl span tag. Default value: <c>256</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("TraceMaxPathTagLength")]
        [Validation(Required=false)]
        public string TraceMaxPathTagLength { get; set; }

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
        /// <para>Specifies whether to enable Managed Service for OpenTelemetry. (Before you enable <a href="https://tracing-analysis.console.aliyun.com/">Managed Service for OpenTelemetry</a>, make sure that you have activated it.) Valid values:</para>
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
        /// <para>The maximum size of the memory that is available to the proxy service that exports Tracing Analysis data. For example, <c>1Mi</c> indicates 1 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000Mi</para>
        /// </summary>
        [NameInMap("TracingOnExtZipkinLimitCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitCPU { get; set; }

        /// <summary>
        /// <para>The retention period for the access logs of the ingress gateway. Unit: day. The logs are collected by using Log Service. For example, <c>30</c> indicates 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024Mi</para>
        /// </summary>
        [NameInMap("TracingOnExtZipkinLimitMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitMemory { get; set; }

        /// <summary>
        /// <para>The number of replicas that are available to the proxy service that exports Managed Service for OpenTelemetry data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TracingOnExtZipkinReplicaCount")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinReplicaCount { get; set; }

        /// <summary>
        /// <para>The minimum size of the memory requested by the proxy service that exports Tracing Analysis data. For example, <c>1Mi</c> indicates 1 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200m</para>
        /// </summary>
        [NameInMap("TracingOnExtZipkinRequestCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestCPU { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the proxy service that exports Tracing Analysis data. For example, <c>1000m</c> indicates one CPU core.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200Mi</para>
        /// </summary>
        [NameInMap("TracingOnExtZipkinRequestMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestMemory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable WebAssembly Filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables WebAssembly Filter.</description></item>
        /// <item><description><c>false</c>: disables WebAssembly Filter.</description></item>
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
