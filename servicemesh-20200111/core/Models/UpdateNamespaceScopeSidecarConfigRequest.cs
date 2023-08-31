// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateNamespaceScopeSidecarConfigRequest : TeaModel {
        /// <summary>
        /// The number of worker threads to run in Istio Proxy.
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        [NameInMap("EnableCoreDump")]
        [Validation(Required=false)]
        public bool? EnableCoreDump { get; set; }

        /// <summary>
        /// The range of IP addresses that are allowed to access external services. (`global.proxy.excludelPRanges`)
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// The port that the inbound traffic of the sidecar proxy does not pass through.
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// The port that the outbound traffic of the sidecar proxy does not pass through.
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// Specifies whether applications can be started only after Istio Proxy starts. Valid values:
        /// 
        /// *   `true`: Applications can be started only after Istio Proxy starts.
        /// *   `false`: Applications can be started before Istio Proxy starts.
        /// </summary>
        [NameInMap("HoldApplicationUntilProxyStarts")]
        [Validation(Required=false)]
        public bool? HoldApplicationUntilProxyStarts { get; set; }

        /// <summary>
        /// The range of IP addresses that are denied to access external services. (`global.proxy.includelPRanges`)
        /// </summary>
        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        /// <summary>
        /// The port that the inbound traffic of the sidecar proxy passes through.
        /// </summary>
        [NameInMap("IncludeInboundPorts")]
        [Validation(Required=false)]
        public string IncludeInboundPorts { get; set; }

        /// <summary>
        /// The port that the outbound traffic of the sidecar proxy passes through.
        /// </summary>
        [NameInMap("IncludeOutboundPorts")]
        [Validation(Required=false)]
        public string IncludeOutboundPorts { get; set; }

        /// <summary>
        /// The mode in which the sidecar proxy intercepts inbound traffic. Valid values:
        /// 
        /// *   `REDIRECT`: The sidecar proxy intercepts inbound traffic in the REDIRECT mode.
        /// *   `TPROXY`: The sidecar proxy intercepts inbound traffic in the TPROXY mode.
        /// </summary>
        [NameInMap("InterceptionMode")]
        [Validation(Required=false)]
        public string InterceptionMode { get; set; }

        /// <summary>
        /// Specifies whether to enable the Domain Name System (DNS) proxy feature. Valid values:
        /// 
        /// *   `true`: The DNS proxy feature is enabled.
        /// *   `false`: The DNS proxy feature is disabled.
        /// </summary>
        [NameInMap("IstioDNSProxyEnabled")]
        [Validation(Required=false)]
        public bool? IstioDNSProxyEnabled { get; set; }

        /// <summary>
        /// The lifecycle of the sidecar proxy.
        /// </summary>
        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        /// <summary>
        /// The log level. Valid values: `info`, `debug`, `tracing`, and `error`.
        /// </summary>
        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        /// <summary>
        /// The namespace for which you want to update the sidecar proxy configurations.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The post-start parameters of Istio Proxy.
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// The pre-close parameters of Istio Proxy.
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        [NameInMap("Privileged")]
        [Validation(Required=false)]
        public bool? Privileged { get; set; }

        [NameInMap("ProxyInitAckSloCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitAckSloCPUResourceLimit { get; set; }

        [NameInMap("ProxyInitAckSloCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitAckSloCPUResourceRequest { get; set; }

        [NameInMap("ProxyInitAckSloMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitAckSloMemoryResourceLimit { get; set; }

        [NameInMap("ProxyInitAckSloMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitAckSloMemoryResourceRequest { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the sidecar proxy init container.
        /// </summary>
        [NameInMap("ProxyInitCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceLimit { get; set; }

        /// <summary>
        /// The minimum number of CPU cores that are requested by the sidecar proxy init container.
        /// </summary>
        [NameInMap("ProxyInitCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceRequest { get; set; }

        /// <summary>
        /// The maximum size of memory that is available to the sidecar proxy init container.
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceLimit { get; set; }

        /// <summary>
        /// The minimum size of memory that is requested by the sidecar proxy init container.
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceRequest { get; set; }

        /// <summary>
        /// The environment variables that are added to a sidecar proxy. The environment variables are represented as JSON objects. The keys and values in the JSON objects represent the keys and values added to the environment variables of the sidecar proxy.
        /// </summary>
        [NameInMap("ProxyMetadata")]
        [Validation(Required=false)]
        public string ProxyMetadata { get; set; }

        /// <summary>
        /// The monitoring metrics for data collected by Envoy proxies. The value is in the JSON format.
        /// </summary>
        [NameInMap("ProxyStatsMatcher")]
        [Validation(Required=false)]
        public string ProxyStatsMatcher { get; set; }

        [NameInMap("ReadinessFailureThreshold")]
        [Validation(Required=false)]
        public int? ReadinessFailureThreshold { get; set; }

        [NameInMap("ReadinessInitialDelaySeconds")]
        [Validation(Required=false)]
        public int? ReadinessInitialDelaySeconds { get; set; }

        [NameInMap("ReadinessPeriodSeconds")]
        [Validation(Required=false)]
        public int? ReadinessPeriodSeconds { get; set; }

        /// <summary>
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("SidecarProxyAckSloCPUResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloCPUResourceLimit { get; set; }

        [NameInMap("SidecarProxyAckSloCPUResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloCPUResourceRequest { get; set; }

        [NameInMap("SidecarProxyAckSloMemoryResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloMemoryResourceLimit { get; set; }

        [NameInMap("SidecarProxyAckSloMemoryResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloMemoryResourceRequest { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the sidecar proxy container.
        /// </summary>
        [NameInMap("SidecarProxyCPUResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyCPUResourceLimit { get; set; }

        /// <summary>
        /// The minimum number of CPU cores that are requested by the sidecar proxy container.
        /// </summary>
        [NameInMap("SidecarProxyCPUResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyCPUResourceRequest { get; set; }

        /// <summary>
        /// The maximum size of memory that is available to the sidecar proxy container.
        /// </summary>
        [NameInMap("SidecarProxyMemoryResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyMemoryResourceLimit { get; set; }

        /// <summary>
        /// The minimum size of memory that is requested by the sidecar proxy container.
        /// </summary>
        [NameInMap("SidecarProxyMemoryResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyMemoryResourceRequest { get; set; }

        /// <summary>
        /// The maximum period of time that the sidecar proxy waits for a request to end.
        /// </summary>
        [NameInMap("TerminationDrainDuration")]
        [Validation(Required=false)]
        public string TerminationDrainDuration { get; set; }

        /// <summary>
        /// The custom configurations of Tracing Analysis. The configurations must be serialized into JSON strings. The configurations contain the following parameters:
        /// 
        /// *   `sampling`: The sampling rate, which is of the DOUBLE type.
        /// 
        /// *   `custom_tags`: The custom tags added to reported spans, which are of the MAP type. The key of a tag is of the string type. The value of a tag is in the JSON format. A custom tag can belong to one of the following types:
        /// 
        ///     *   `literal`: The tag value is a fixed value in the JSON format. This tag must contain the `value` field that specifies a literal. Example: `{"value":"test"}`.
        ///     *   `header`: The tag value is a request header in the JSON format. This tag must contain the `name` field and `defaultValue` field.The name field indicates the name of the request header. The defaultValue field indicates the default value that is used when no request header is available. Example: `{"name":"test","defaultValue":"test"}`.
        ///     *   `environment`: The tag value is an environment variable in the JSON format. This tag must contain the `name` field and `defaultValue` field. The name field indicates the name of the environment variable. The defaultValue field indicates the environment variable that is used when no environment variable is available. Example: `{"name":"test","defaultValue":"test"}`.
        /// </summary>
        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public string Tracing { get; set; }

    }

}
