// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshFeatureRequest : TeaModel {
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        [NameInMap("PilotPublicEip")]
        [Validation(Required=false)]
        public bool? PilotPublicEip { get; set; }

        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        [NameInMap("CADisableSecretAutoGeneration")]
        [Validation(Required=false)]
        public bool? CADisableSecretAutoGeneration { get; set; }

        [NameInMap("CAListenedNamespaces")]
        [Validation(Required=false)]
        public string CAListenedNamespaces { get; set; }

        [NameInMap("AppNamespaces")]
        [Validation(Required=false)]
        public string AppNamespaces { get; set; }

        [NameInMap("ClusterDomain")]
        [Validation(Required=false)]
        public string ClusterDomain { get; set; }

        [NameInMap("CustomizedZipkin")]
        [Validation(Required=false)]
        public bool? CustomizedZipkin { get; set; }

        [NameInMap("OutboundTrafficPolicy")]
        [Validation(Required=false)]
        public string OutboundTrafficPolicy { get; set; }

        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        [NameInMap("EnableNamespacesByDefault")]
        [Validation(Required=false)]
        public bool? EnableNamespacesByDefault { get; set; }

        [NameInMap("AutoInjectionPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AutoInjectionPolicyEnabled { get; set; }

        [NameInMap("SidecarInjectorRequestCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestCPU { get; set; }

        [NameInMap("SidecarInjectorRequestMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorRequestMemory { get; set; }

        [NameInMap("SidecarInjectorLimitCPU")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitCPU { get; set; }

        [NameInMap("SidecarInjectorLimitMemory")]
        [Validation(Required=false)]
        public string SidecarInjectorLimitMemory { get; set; }

        [NameInMap("SidecarInjectorWebhookAsYaml")]
        [Validation(Required=false)]
        public string SidecarInjectorWebhookAsYaml { get; set; }

        [NameInMap("CniEnabled")]
        [Validation(Required=false)]
        public bool? CniEnabled { get; set; }

        [NameInMap("CniExcludeNamespaces")]
        [Validation(Required=false)]
        public string CniExcludeNamespaces { get; set; }

        [NameInMap("OpaEnabled")]
        [Validation(Required=false)]
        public bool? OpaEnabled { get; set; }

        [NameInMap("Http10Enabled")]
        [Validation(Required=false)]
        public bool? Http10Enabled { get; set; }

        [NameInMap("KialiEnabled")]
        [Validation(Required=false)]
        public bool? KialiEnabled { get; set; }

        [NameInMap("CustomizedPrometheus")]
        [Validation(Required=false)]
        public bool? CustomizedPrometheus { get; set; }

        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        [NameInMap("AccessLogEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogEnabled { get; set; }

        [NameInMap("MSEEnabled")]
        [Validation(Required=false)]
        public bool? MSEEnabled { get; set; }

        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        [NameInMap("MysqlFilterEnabled")]
        [Validation(Required=false)]
        public bool? MysqlFilterEnabled { get; set; }

        [NameInMap("ThriftFilterEnabled")]
        [Validation(Required=false)]
        public bool? ThriftFilterEnabled { get; set; }

        [NameInMap("WebAssemblyFilterEnabled")]
        [Validation(Required=false)]
        public bool? WebAssemblyFilterEnabled { get; set; }

        [NameInMap("DNSProxyingEnabled")]
        [Validation(Required=false)]
        public bool? DNSProxyingEnabled { get; set; }

    }

}
