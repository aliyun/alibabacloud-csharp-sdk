// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshFeatureRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable Microservice Engine (MSE). Valid values:
        /// 
        /// *   `true`: MSE is enabled.
        /// *   `false`: MSE is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("AccessLogEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogEnabled { get; set; }

        /// <summary>
        /// The custom project on which the Log Service collects logs.
        /// </summary>
        [NameInMap("AccessLogFile")]
        [Validation(Required=false)]
        public string AccessLogFile { get; set; }

        /// <summary>
        /// Specifies whether to enable access logging. Valid values:
        /// 
        /// *   `""`: Access logging is disabled.
        /// *   `/dev/stdout`: Access logging is enabled. Access logs are written to /dev/stdout.
        /// </summary>
        [NameInMap("AccessLogFormat")]
        [Validation(Required=false)]
        public string AccessLogFormat { get; set; }

        /// <summary>
        /// The retention period for the access logs of the sidecar proxy. Unit: day. The logs are collected by using the Log Service. For example, `30` indicates 30 days.
        /// </summary>
        [NameInMap("AccessLogGatewayLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogGatewayLifecycle { get; set; }

        /// <summary>
        /// Specifies whether to enable the rollback feature for Istio resources.
        /// </summary>
        [NameInMap("AccessLogProject")]
        [Validation(Required=false)]
        public string AccessLogProject { get; set; }

        /// <summary>
        /// The endpoint of gRPC ALS for Envoy.
        /// </summary>
        [NameInMap("AccessLogServiceEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogServiceEnabled { get; set; }

        /// <summary>
        /// The port of gRPC ALS for Envoy.
        /// </summary>
        [NameInMap("AccessLogServiceHost")]
        [Validation(Required=false)]
        public string AccessLogServiceHost { get; set; }

        /// <summary>
        /// Specifies whether to enable Gateway API. Valid values:
        /// 
        /// *   `true`: Gateway API is enabled.
        /// *   `false`: Gateway API is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("AccessLogServicePort")]
        [Validation(Required=false)]
        public int? AccessLogServicePort { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic diagnosis for the ASM instance. If you enable this feature, the ASM instance is automatically diagnosed when you modify Istio resources in the ASM instance.
        /// </summary>
        [NameInMap("AccessLogSidecarLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogSidecarLifecycle { get; set; }

        /// <summary>
        /// Specifies whether to use a self-managed Zipkin system to collect tracing data. Valid values:
        /// 
        /// *   `true`: A self-managed Zipkin system is used.
        /// *   `false`: No self-managed Zipkin system is used.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// The number of CPU cores that are requested by the sidecar injector pod.
        /// </summary>
        [NameInMap("AutoInjectionPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AutoInjectionPolicyEnabled { get; set; }

        /// <summary>
        /// The maximum period of time that the sidecar proxy waits for requests to be processed before the proxy is stopped. For example, if you want to specify a period of 5 seconds, set this parameter to 5s.
        /// </summary>
        [NameInMap("CRAggregationEnabled")]
        [Validation(Required=false)]
        public bool? CRAggregationEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the feature of controlling the OPA injection scope. Valid values:
        /// 
        /// *   `true`: The feature is enabled.
        /// *   `false`: The feature is disabled.
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// The namespaces to be excluded for the CNI plug-in.
        /// </summary>
        [NameInMap("CniEnabled")]
        [Validation(Required=false)]
        public bool? CniEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the OPA plug-in. Valid values:
        /// 
        /// *   `true`: The OPA plug-in is enabled.
        /// *   `false`: The OPA plug-in is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("CniExcludeNamespaces")]
        [Validation(Required=false)]
        public string CniExcludeNamespaces { get; set; }

        /// <summary>
        /// Specifies whether to delay application container startup until the sidecar proxy container is started in a pod.
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// The instance ID of the Nacos registry.
        /// </summary>
        [NameInMap("ConfigSourceEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSourceEnabled { get; set; }

        /// <summary>
        /// The custom format of access logs. To set this parameter, make sure that you have enabled access log collection. The value must be a JSON string. The following key names must be contained: authority_for, bytes_received, bytes_sent, downstream_local_address, downstream_remote_address, duration, istio_policy_status, method, path, protocol, requested_server_name, response_code, response_flags, route_name, start_time, trace_id, upstream_cluster, upstream_host, upstream_local_address, upstream_service_time, upstream_transport_failure_reason, user_agent, and x_forwarded_for.
        /// </summary>
        [NameInMap("ConfigSourceNacosID")]
        [Validation(Required=false)]
        public string ConfigSourceNacosID { get; set; }

        /// <summary>
        /// The endpoint of Prometheus monitoring. If you use ARMS Prometheus, set this parameter to the endpoint of Prometheus provided by ARMS.
        /// </summary>
        [NameInMap("CustomizedPrometheus")]
        [Validation(Required=false)]
        public bool? CustomizedPrometheus { get; set; }

        /// <summary>
        /// The policy of handling outbound traffic. Valid values:
        /// 
        /// *   `ALLOW_ANY`: Outbound traffic to all external services is allowed.
        /// *   `REGISTRY_ONLY`: Outbound traffic is allowed to only external services that are defined in the service registry of the ASM instance.
        /// </summary>
        [NameInMap("CustomizedZipkin")]
        [Validation(Required=false)]
        public bool? CustomizedZipkin { get; set; }

        /// <summary>
        /// Specifies whether to enable Dubbo Filter. Valid values:
        /// 
        /// *   `true`: Dubbo Filter is enabled.
        /// *   `false`: Dubbo Filter is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("DNSProxyingEnabled")]
        [Validation(Required=false)]
        public bool? DNSProxyingEnabled { get; set; }

        [NameInMap("DefaultComponentsScheduleConfig")]
        [Validation(Required=false)]
        public string DefaultComponentsScheduleConfig { get; set; }

        /// <summary>
        /// Specifies whether to enable Application High Availability Service (AHAS)-based throttling. Valid values:
        /// 
        /// *   `true`: AHAS-based throttling is enabled.
        /// *   `false`: AHAS-based throttling is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("DiscoverySelectors")]
        [Validation(Required=false)]
        public string DiscoverySelectors { get; set; }

        /// <summary>
        /// Specifies whether to enable gateway configuration filtering. Valid values:
        /// 
        /// *   `true`: Gateway configuration filtering is enabled.
        /// *   `false`: Gateway configuration filtering is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("DubboFilterEnabled")]
        [Validation(Required=false)]
        public bool? DubboFilterEnabled { get; set; }

        /// <summary>
        /// The name of the Log Service project that is used for mesh audit.
        /// 
        /// Default value: `mesh-log-{ASM instance ID}`.
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// The outbound ports for which traffic is to be redirected to the sidecar proxy.
        /// </summary>
        [NameInMap("EnableAutoDiagnosis")]
        [Validation(Required=false)]
        public bool? EnableAutoDiagnosis { get; set; }

        [NameInMap("EnableBootstrapXdsAgent")]
        [Validation(Required=false)]
        public bool? EnableBootstrapXdsAgent { get; set; }

        /// <summary>
        /// Specifies whether to use the Kubernetes API of clusters on the data plane to access Istio resources. To use this feature, the version of the ASM instance must be V1.9.7.93 or later.
        /// </summary>
        [NameInMap("EnableCRHistory")]
        [Validation(Required=false)]
        public bool? EnableCRHistory { get; set; }

        /// <summary>
        /// Specifies whether automatic sidecar injection can be enabled by using pod annotations. Valid values:
        /// 
        /// *   `true`: Automatic sidecar injection can be enabled by using pod annotations.
        /// *   `false`: Automatic sidecar injection cannot be enabled by using pod annotations.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("EnableNamespacesByDefault")]
        [Validation(Required=false)]
        public bool? EnableNamespacesByDefault { get; set; }

        /// <summary>
        /// Specifies whether to enable gRPC Access Log Service (ALS) for Envoy. Valid values:
        /// 
        /// *   `true`: gRPC ALS for Envoy is enabled.
        /// *   `false`: gRPC ALS for Envoy is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("EnableSDSServer")]
        [Validation(Required=false)]
        public bool? EnableSDSServer { get; set; }

        /// <summary>
        /// The outbound ports. Separate multiple port numbers with commas (,).
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic sidecar injection for all namespaces. Valid values:
        /// 
        /// *   `true`: Automatic sidecar injection for all namespaces is enabled.
        /// *   `false`: Automatic sidecar injection for all namespaces is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// The inbound ports for which traffic is to be redirected to the sidecar proxy.
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// Specifies whether to enable Secret Discovery Service (SDS). Valid values:
        /// 
        /// *   `true`: SDS is enabled.
        /// *   `false`: SDS is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("FilterGatewayClusterConfig")]
        [Validation(Required=false)]
        public bool? FilterGatewayClusterConfig { get; set; }

        /// <summary>
        /// Specifies whether to enable the external service registry. Valid values:
        /// 
        /// *   `true`: The external service registry is enabled.
        /// *   `false`: The external service registry is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("GatewayAPIEnabled")]
        [Validation(Required=false)]
        public bool? GatewayAPIEnabled { get; set; }

        /// <summary>
        /// Other metrics of the sidecar proxy on the data plane.
        /// </summary>
        [NameInMap("HoldApplicationUntilProxyStarts")]
        [Validation(Required=false)]
        public bool? HoldApplicationUntilProxyStarts { get; set; }

        /// <summary>
        /// Specifies whether to enable Mesh Topology. To enable this feature, make sure that you have enabled Prometheus monitoring. If Prometheus monitoring is disabled, the value of this parameter must be `false`. Valid values:``
        /// 
        /// *   `true`: Mesh Topology is enabled.
        /// *   `false`: Mesh Topology is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("Http10Enabled")]
        [Validation(Required=false)]
        public bool? Http10Enabled { get; set; }

        /// <summary>
        /// The IP addresses of external services to which traffic is not intercepted.
        /// </summary>
        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        /// <summary>
        /// The inbound ports. Separate multiple port numbers with commas (,).
        /// </summary>
        [NameInMap("IncludeInboundPorts")]
        [Validation(Required=false)]
        public string IncludeInboundPorts { get; set; }

        /// <summary>
        /// The log level of the sidecar proxy on the data plane. Log levels include `none`, `error`, `warn`, `info`, and `debug`. The levels correspond to different amounts of information reported by the logs. For example, none-level logs report the least information while debug-level logs report the most information.
        /// </summary>
        [NameInMap("IncludeOutboundPorts")]
        [Validation(Required=false)]
        public string IncludeOutboundPorts { get; set; }

        /// <summary>
        /// Specifies whether to enable Node Feature Discovery (NFD).
        /// </summary>
        [NameInMap("IntegrateKiali")]
        [Validation(Required=false)]
        public bool? IntegrateKiali { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("InterceptionMode")]
        [Validation(Required=false)]
        public string InterceptionMode { get; set; }

        [NameInMap("KialiArmsAuthTokens")]
        [Validation(Required=false)]
        public string KialiArmsAuthTokens { get; set; }

        /// <summary>
        /// Specifies whether to use a custom Prometheus instance. Valid values:
        /// 
        /// *   `true`: A custom Prometheus instance is used.
        /// *   `false`: No custom Prometheus instance is used.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("KialiEnabled")]
        [Validation(Required=false)]
        public bool? KialiEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable Transport Layer Security (TLS) acceleration based on MultiBuffer.
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        /// <summary>
        /// Specifies whether to enable Prometheus monitoring. We recommend that you enable [ARMS Prometheus](https://arms.console.aliyun.com/). Valid values:
        /// 
        /// *   `true`: Prometheus monitoring is enabled.
        /// *   `false`: Prometheus monitoring is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("LocalityLBConf")]
        [Validation(Required=false)]
        public string LocalityLBConf { get; set; }

        /// <summary>
        /// The configurations of cross-region load balancing. Valid values:
        /// 
        /// *   `failover`: the configurations of cross-region failover. Example:
        /// 
        ///     ```
        /// 
        ///         failover: [// The struct that indicates the configurations of cross-region failover. 
        ///             {
        ///                 // If a service fails in the China (Beijing) region, the traffic is redirected to the same service in the China (Hangzhou) region. 
        ///                 from: "cn-beijing", 
        ///                 to: "cn-hangzhou",
        ///             }
        ///         ]
        ///     ```
        /// 
        /// *   `distribute`: the configurations of cross-region traffic distribution. Example:
        /// 
        /// ```
        /// 
        /// distribute: [ // The struct that indicates the configurations of cross-region traffic distribution. 
        ///         {
        ///             // For traffic that is routed to the China (Beijing) region, 70% of the traffic is allocated to the China (Beijing) region and the rest of the traffic is redirected to the China (Hangzhou) region. 
        ///             "from": "cn-beijing",
        ///             "to": {
        ///                 "cn-beijing": 70,
        ///                 "cn-hangzhou": 30,
        ///             }
        ///         }
        ///     ]
        /// ```
        /// </summary>
        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        /// <summary>
        /// The number of worker threads used by the sidecar proxy on the data plane.
        /// </summary>
        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        /// <summary>
        /// Specifies whether to enable Redis Filter. Valid values:
        /// 
        /// *   `true`: Redis Filter is enabled.
        /// 
        /// *   `false`: Redis Filter is disabled.
        /// 
        ///     Default value: `false`.
        /// </summary>
        [NameInMap("MSEEnabled")]
        [Validation(Required=false)]
        public bool? MSEEnabled { get; set; }

        /// <summary>
        /// The pull-request latency. By default, this parameter is left empty.
        /// </summary>
        [NameInMap("MultiBufferEnabled")]
        [Validation(Required=false)]
        public bool? MultiBufferEnabled { get; set; }

        /// <summary>
        /// The label selectors used to specify the namespaces of the clusters on the data plane for selective service discovery.
        /// </summary>
        [NameInMap("MultiBufferPollDelay")]
        [Validation(Required=false)]
        public string MultiBufferPollDelay { get; set; }

        /// <summary>
        /// Specifies whether to enable Thrift Filter. Valid values:
        /// 
        /// *   `true`: Thrift Filter is enabled.
        /// *   `false`: Thrift Filter is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("MysqlFilterEnabled")]
        [Validation(Required=false)]
        public bool? MysqlFilterEnabled { get; set; }

        /// <summary>
        /// Specifies whether to clear feature labels on nodes when NFD is disabled.
        /// 
        /// This parameter is valid only when the `NFDEnabled` parameter is set to `false`.
        /// </summary>
        [NameInMap("NFDEnabled")]
        [Validation(Required=false)]
        public bool? NFDEnabled { get; set; }

        /// <summary>
        /// The minimum number of CPU cores requested by the proxy that exports trace data. For example, `1000m` indicates one CPU core.
        /// </summary>
        [NameInMap("NFDLabelPruned")]
        [Validation(Required=false)]
        public bool? NFDLabelPruned { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the pod to which the OPA proxy container is injected. For example, `1024Mi` indicates 1024 MB.
        /// </summary>
        [NameInMap("OPAInjectorCPULimit")]
        [Validation(Required=false)]
        public string OPAInjectorCPULimit { get; set; }

        /// <summary>
        /// The minimum size of the memory requested by the pod to which the OPA proxy container is injected. For example, `50 Mi` indicates 50 MB.
        /// </summary>
        [NameInMap("OPAInjectorCPURequirement")]
        [Validation(Required=false)]
        public string OPAInjectorCPURequirement { get; set; }

        /// <summary>
        /// Specifies whether to create an SLB instance for accessing the ASM mesh topology.
        /// </summary>
        [NameInMap("OPAInjectorMemoryLimit")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryLimit { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the pod to which the OPA proxy container is injected. For example, `1000m` indicates one CPU core.
        /// </summary>
        [NameInMap("OPAInjectorMemoryRequirement")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryRequirement { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the OPA proxy container.
        /// </summary>
        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        /// <summary>
        /// Specifies whether to enable the mesh audit feature. To enable this feature, make sure that you have activated [Log Service](https://sls.console.aliyun.com/). Valid values:
        /// 
        /// *   `true`: The mesh audit feature is enabled.
        /// *   `false`: The mesh audit feature is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        /// <summary>
        /// The number of CPU cores that are requested by the OPA proxy container.
        /// </summary>
        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        /// <summary>
        /// The size of the memory that is requested by the OPA proxy container.
        /// </summary>
        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the OPA proxy container.
        /// </summary>
        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        /// <summary>
        /// The minimum number of CPU cores requested by the pod to which the OPA proxy container is injected. For example, `1000m` indicates one CPU core.
        /// </summary>
        [NameInMap("OPAScopeInjected")]
        [Validation(Required=false)]
        public bool? OPAScopeInjected { get; set; }

        /// <summary>
        /// Specifies whether to enable the support for HTTP 1.0. Valid values:
        /// 
        /// *   `true`: HTTP 1.0 is supported.
        /// *   `false`: HTTP 1.0 is not supported.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("OpaEnabled")]
        [Validation(Required=false)]
        public bool? OpaEnabled { get; set; }

        /// <summary>
        /// The log level of the OPA proxy container.
        /// 
        /// *   `info`: All information is reported.
        /// *   `debug`: Debugging and error information is reported.
        /// *   `error`: Only error information is reported.
        /// </summary>
        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        /// <summary>
        /// The number of CPU cores that are requested by the sidecar proxy container.
        /// </summary>
        [NameInMap("OutboundTrafficPolicy")]
        [Validation(Required=false)]
        public string OutboundTrafficPolicy { get; set; }

        /// <summary>
        /// Specifies whether to enable access log collection. Valid values:
        /// 
        /// *   `true`: Access log collection is enabled.
        /// *   `false`: Access log collection is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the istio-init container.
        /// </summary>
        [NameInMap("ProxyInitCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceLimit { get; set; }

        /// <summary>
        /// The size of the memory that is requested by the istio-init container.
        /// </summary>
        [NameInMap("ProxyInitCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceRequest { get; set; }

        /// <summary>
        /// The number of CPU cores that are requested by the istio-init container.
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceLimit { get; set; }

        /// <summary>
        /// The lifecycle of the sidecar proxy.
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceRequest { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the sidecar proxy container.
        /// </summary>
        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        /// <summary>
        /// The IP addresses of external services to which traffic is intercepted.
        /// </summary>
        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        /// <summary>
        /// The size of the memory that is requested by the sidecar proxy container.
        /// </summary>
        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the sidecar proxy container.
        /// </summary>
        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        /// <summary>
        /// The mode in which the sidecar proxy intercepts inbound traffic. Valid values:
        /// 
        /// *   `REDIRECT`: The sidecar proxy intercepts inbound traffic in the REDIRECT mode.
        /// *   `TPROXY`: The sidecar proxy intercepts inbound traffic in the TPROXY mode.
        /// </summary>
        [NameInMap("ProxyStatsMatcher")]
        [Validation(Required=false)]
        public string ProxyStatsMatcher { get; set; }

        /// <summary>
        /// Specifies whether to enable MySQL Filter. Valid values:
        /// 
        /// *   `true`: MySQL Filter is enabled.
        /// *   `false`: MySQL Filter is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable the Tracing Analysis feature. To enable this feature, make sure that you have activated [Tracing Analysis](https://tracing-analysis.console.aliyun.com/). Valid values:
        /// 
        /// *   `true`: The Tracing Analysis feature is enabled.
        /// *   `false`: The Tracing Analysis feature is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the sidecar injector pod.
        /// </summary>
        [NameInMap("SidecarInjectorLimitCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitCPU { get; set; }

        /// <summary>
        /// Other configurations of automatic sidecar injection, in the YAML format.
        /// </summary>
        [NameInMap("SidecarInjectorLimitMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitMemory { get; set; }

        /// <summary>
        /// The size of the memory that is requested by the sidecar injector pod.
        /// </summary>
        [NameInMap("SidecarInjectorRequestCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestCPU { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the sidecar injector pod.
        /// </summary>
        [NameInMap("SidecarInjectorRequestMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestMemory { get; set; }

        /// <summary>
        /// Specifies whether to enable the Container Network Interface (CNI) plug-in. Valid values:
        /// 
        /// *   `true`: The CNI plug-in is enabled.
        /// *   `false`: The CNI plug-in is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("SidecarInjectorWebhookAsYaml")]
        [Validation(Required=false)]
        public string SidecarInjectorWebhookAsYaml { get; set; }

        /// <summary>
        /// Specifies whether to install the Open Policy Agent (OPA) plug-in. Valid values:
        /// 
        /// *   `true`: The OPA plug-in is installed.
        /// *   `false`: The OPA plug-in is not installed.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the istio-init container.
        /// </summary>
        [NameInMap("TerminationDrainDuration")]
        [Validation(Required=false)]
        public string TerminationDrainDuration { get; set; }

        /// <summary>
        /// Specifies whether to enable WebAssembly Filter. Valid values:
        /// 
        /// *   `true`:WebAssembly Filter is enabled.
        /// *   `false`: WebAssembly Filter is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ThriftFilterEnabled")]
        [Validation(Required=false)]
        public bool? ThriftFilterEnabled { get; set; }

        /// <summary>
        /// The maximum length of the request path contained in the HttpUrl span tag. Default value: `256`.
        /// </summary>
        [NameInMap("TraceCustomTags")]
        [Validation(Required=false)]
        public string TraceCustomTags { get; set; }

        /// <summary>
        /// Specifies whether to enable cross-region load balancing. Valid values:
        /// 
        /// *   `true`: Cross-region load balancing is enabled.
        /// *   `false`: Cross-region load balancing is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("TraceMaxPathTagLength")]
        [Validation(Required=false)]
        public string TraceMaxPathTagLength { get; set; }

        /// <summary>
        /// The custom tag of Tracing Analysis. The value is in the JSON format.
        /// 
        /// ```
        /// 
        /// {
        ///     "name1": CustomTag,
        ///     "name2": CustomTag
        /// }
        /// ```
        /// 
        /// Tag structure: literal, header, or environment.
        /// 
        /// ```
        /// 
        /// {
        ///     "literal": {
        ///         "value": "Fixed value"
        ///     }
        ///     "header": {
        ///         "name": "Header name"
        ///         "defaultValue": "Default value that is used if the specified header does not exist"
        ///     }
        ///     "environment": {
        ///         "name": "Environment variable name"
        ///         "defaultValue": "Default value that is used if the specified environment variable does not exist"
        ///     }
        /// }
        /// ```
        /// </summary>
        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        /// <summary>
        /// The sampling percentage of Tracing Analysis.
        /// </summary>
        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the proxy that exports trace data. For example, `1Mi` indicates 1 MB.
        /// </summary>
        [NameInMap("TracingOnExtZipkinLimitCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitCPU { get; set; }

        /// <summary>
        /// The retention period for the access logs of the ingress gateway. Unit: day. The logs are collected by using the Log Service. For example, `30` indicates 30 days.
        /// </summary>
        [NameInMap("TracingOnExtZipkinLimitMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitMemory { get; set; }

        /// <summary>
        /// The minimum size of the memory requested by the proxy that exports trace data. For example, `1Mi` indicates 1 MB.
        /// </summary>
        [NameInMap("TracingOnExtZipkinRequestCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestCPU { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the proxy that exports trace data. For example, `1000m` indicates one CPU core.
        /// </summary>
        [NameInMap("TracingOnExtZipkinRequestMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestMemory { get; set; }

        /// <summary>
        /// Specifies whether to enable DNS proxying. Valid values:
        /// 
        /// *   `true`: DNS proxying is enabled.
        /// *   `false`: DNS proxying is disabled.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("WebAssemblyFilterEnabled")]
        [Validation(Required=false)]
        public bool? WebAssemblyFilterEnabled { get; set; }

    }

}
