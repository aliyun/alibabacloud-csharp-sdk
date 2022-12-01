// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshFeatureRequest : TeaModel {
        [NameInMap("AccessLogEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogEnabled { get; set; }

        [NameInMap("AccessLogFile")]
        [Validation(Required=false)]
        public string AccessLogFile { get; set; }

        [NameInMap("AccessLogFormat")]
        [Validation(Required=false)]
        public string AccessLogFormat { get; set; }

        [NameInMap("AccessLogGatewayLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogGatewayLifecycle { get; set; }

        [NameInMap("AccessLogProject")]
        [Validation(Required=false)]
        public string AccessLogProject { get; set; }

        [NameInMap("AccessLogServiceEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogServiceEnabled { get; set; }

        [NameInMap("AccessLogServiceHost")]
        [Validation(Required=false)]
        public string AccessLogServiceHost { get; set; }

        [NameInMap("AccessLogServicePort")]
        [Validation(Required=false)]
        public int? AccessLogServicePort { get; set; }

        [NameInMap("AccessLogSidecarLifecycle")]
        [Validation(Required=false)]
        public int? AccessLogSidecarLifecycle { get; set; }

        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        [NameInMap("AutoInjectionPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AutoInjectionPolicyEnabled { get; set; }

        [NameInMap("CRAggregationEnabled")]
        [Validation(Required=false)]
        public bool? CRAggregationEnabled { get; set; }

        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        [NameInMap("CniEnabled")]
        [Validation(Required=false)]
        public bool? CniEnabled { get; set; }

        [NameInMap("CniExcludeNamespaces")]
        [Validation(Required=false)]
        public string CniExcludeNamespaces { get; set; }

        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        [NameInMap("ConfigSourceEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSourceEnabled { get; set; }

        [NameInMap("ConfigSourceNacosID")]
        [Validation(Required=false)]
        public string ConfigSourceNacosID { get; set; }

        [NameInMap("CustomizedPrometheus")]
        [Validation(Required=false)]
        public bool? CustomizedPrometheus { get; set; }

        [NameInMap("CustomizedZipkin")]
        [Validation(Required=false)]
        public bool? CustomizedZipkin { get; set; }

        [NameInMap("DNSProxyingEnabled")]
        [Validation(Required=false)]
        public bool? DNSProxyingEnabled { get; set; }

        [NameInMap("DiscoverySelectors")]
        [Validation(Required=false)]
        public string DiscoverySelectors { get; set; }

        [NameInMap("DubboFilterEnabled")]
        [Validation(Required=false)]
        public bool? DubboFilterEnabled { get; set; }

        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        [NameInMap("EnableAutoDiagnosis")]
        [Validation(Required=false)]
        public bool? EnableAutoDiagnosis { get; set; }

        [NameInMap("EnableCRHistory")]
        [Validation(Required=false)]
        public bool? EnableCRHistory { get; set; }

        [NameInMap("EnableNamespacesByDefault")]
        [Validation(Required=false)]
        public bool? EnableNamespacesByDefault { get; set; }

        [NameInMap("EnableSDSServer")]
        [Validation(Required=false)]
        public bool? EnableSDSServer { get; set; }

        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        [NameInMap("FilterGatewayClusterConfig")]
        [Validation(Required=false)]
        public bool? FilterGatewayClusterConfig { get; set; }

        [NameInMap("GatewayAPIEnabled")]
        [Validation(Required=false)]
        public bool? GatewayAPIEnabled { get; set; }

        [NameInMap("GlobalRateLimitEnabled")]
        [Validation(Required=false)]
        public bool? GlobalRateLimitEnabled { get; set; }

        [NameInMap("HoldApplicationUntilProxyStarts")]
        [Validation(Required=false)]
        public bool? HoldApplicationUntilProxyStarts { get; set; }

        [NameInMap("Http10Enabled")]
        [Validation(Required=false)]
        public bool? Http10Enabled { get; set; }

        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        [NameInMap("IncludeInboundPorts")]
        [Validation(Required=false)]
        public string IncludeInboundPorts { get; set; }

        [NameInMap("IncludeOutboundPorts")]
        [Validation(Required=false)]
        public string IncludeOutboundPorts { get; set; }

        [NameInMap("IntegrateKiali")]
        [Validation(Required=false)]
        public bool? IntegrateKiali { get; set; }

        [NameInMap("InterceptionMode")]
        [Validation(Required=false)]
        public string InterceptionMode { get; set; }

        [NameInMap("KialiEnabled")]
        [Validation(Required=false)]
        public bool? KialiEnabled { get; set; }

        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        [NameInMap("LocalityLBConf")]
        [Validation(Required=false)]
        public string LocalityLBConf { get; set; }

        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        [NameInMap("MSEEnabled")]
        [Validation(Required=false)]
        public bool? MSEEnabled { get; set; }

        [NameInMap("MultiBufferEnabled")]
        [Validation(Required=false)]
        public bool? MultiBufferEnabled { get; set; }

        [NameInMap("MultiBufferPollDelay")]
        [Validation(Required=false)]
        public string MultiBufferPollDelay { get; set; }

        [NameInMap("MysqlFilterEnabled")]
        [Validation(Required=false)]
        public bool? MysqlFilterEnabled { get; set; }

        [NameInMap("NFDEnabled")]
        [Validation(Required=false)]
        public bool? NFDEnabled { get; set; }

        [NameInMap("NFDLabelPruned")]
        [Validation(Required=false)]
        public bool? NFDLabelPruned { get; set; }

        [NameInMap("OPAInjectorCPULimit")]
        [Validation(Required=false)]
        public string OPAInjectorCPULimit { get; set; }

        [NameInMap("OPAInjectorCPURequirement")]
        [Validation(Required=false)]
        public string OPAInjectorCPURequirement { get; set; }

        [NameInMap("OPAInjectorMemoryLimit")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryLimit { get; set; }

        [NameInMap("OPAInjectorMemoryRequirement")]
        [Validation(Required=false)]
        public string OPAInjectorMemoryRequirement { get; set; }

        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        [NameInMap("OPAScopeInjected")]
        [Validation(Required=false)]
        public bool? OPAScopeInjected { get; set; }

        [NameInMap("OpaEnabled")]
        [Validation(Required=false)]
        public bool? OpaEnabled { get; set; }

        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        [NameInMap("OutboundTrafficPolicy")]
        [Validation(Required=false)]
        public string OutboundTrafficPolicy { get; set; }

        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        [NameInMap("ProxyInitCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceLimit { get; set; }

        [NameInMap("ProxyInitCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceRequest { get; set; }

        [NameInMap("ProxyInitMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceLimit { get; set; }

        [NameInMap("ProxyInitMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceRequest { get; set; }

        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        [NameInMap("ProxyStatsMatcher")]
        [Validation(Required=false)]
        public string ProxyStatsMatcher { get; set; }

        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("SidecarInjectorLimitCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitCPU { get; set; }

        [NameInMap("SidecarInjectorLimitMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitMemory { get; set; }

        [NameInMap("SidecarInjectorRequestCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestCPU { get; set; }

        [NameInMap("SidecarInjectorRequestMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestMemory { get; set; }

        [NameInMap("SidecarInjectorWebhookAsYaml")]
        [Validation(Required=false)]
        public string SidecarInjectorWebhookAsYaml { get; set; }

        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        [NameInMap("TerminationDrainDuration")]
        [Validation(Required=false)]
        public string TerminationDrainDuration { get; set; }

        [NameInMap("ThriftFilterEnabled")]
        [Validation(Required=false)]
        public bool? ThriftFilterEnabled { get; set; }

        [NameInMap("TraceCustomTags")]
        [Validation(Required=false)]
        public string TraceCustomTags { get; set; }

        [NameInMap("TraceMaxPathTagLength")]
        [Validation(Required=false)]
        public string TraceMaxPathTagLength { get; set; }

        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        [NameInMap("TracingOnExtZipkinLimitCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitCPU { get; set; }

        [NameInMap("TracingOnExtZipkinLimitMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinLimitMemory { get; set; }

        [NameInMap("TracingOnExtZipkinRequestCPU")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestCPU { get; set; }

        [NameInMap("TracingOnExtZipkinRequestMemory")]
        [Validation(Required=false)]
        public string TracingOnExtZipkinRequestMemory { get; set; }

        [NameInMap("WebAssemblyFilterEnabled")]
        [Validation(Required=false)]
        public bool? WebAssemblyFilterEnabled { get; set; }

    }

}
