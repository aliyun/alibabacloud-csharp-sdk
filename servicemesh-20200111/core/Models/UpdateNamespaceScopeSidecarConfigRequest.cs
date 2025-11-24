// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateNamespaceScopeSidecarConfigRequest : TeaModel {
        /// <summary>
        /// <para>The number of worker threads to run in Istio Proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the core dump feature for the sidecar proxy containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCoreDump")]
        [Validation(Required=false)]
        public bool? EnableCoreDump { get; set; }

        /// <summary>
        /// <para>The range of IP addresses that are allowed to access external services. (<c>global.proxy.excludelPRanges</c>)</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// <para>The port that the inbound traffic of the sidecar proxy does not pass through.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82</para>
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// <para>The port that the outbound traffic of the sidecar proxy does not pass through.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// <para>Specifies whether applications can be started only after Istio Proxy starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Applications can be started only after Istio Proxy starts.</description></item>
        /// <item><description><c>false</c>: Applications can be started before Istio Proxy starts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HoldApplicationUntilProxyStarts")]
        [Validation(Required=false)]
        public bool? HoldApplicationUntilProxyStarts { get; set; }

        /// <summary>
        /// <para>The range of IP addresses that are denied to access external services. (<c>global.proxy.includelPRanges</c>)</para>
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
        /// <para>The port that the inbound traffic of the sidecar proxy passes through.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83</para>
        /// </summary>
        [NameInMap("IncludeInboundPorts")]
        [Validation(Required=false)]
        public string IncludeInboundPorts { get; set; }

        /// <summary>
        /// <para>The port that the outbound traffic of the sidecar proxy passes through.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84</para>
        /// </summary>
        [NameInMap("IncludeOutboundPorts")]
        [Validation(Required=false)]
        public string IncludeOutboundPorts { get; set; }

        /// <summary>
        /// <para>The mode in which the sidecar proxy intercepts inbound traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REDIRECT</c>: The sidecar proxy intercepts inbound traffic in the REDIRECT mode.</description></item>
        /// <item><description><c>TPROXY</c>: The sidecar proxy intercepts inbound traffic in the TPROXY mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TPROXY</para>
        /// </summary>
        [NameInMap("InterceptionMode")]
        [Validation(Required=false)]
        public string InterceptionMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Domain Name System (DNS) proxy feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The DNS proxy feature is enabled.</description></item>
        /// <item><description><c>false</c>: The DNS proxy feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IstioDNSProxyEnabled")]
        [Validation(Required=false)]
        public bool? IstioDNSProxyEnabled { get; set; }

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
        /// <para>The log level. Valid values: <c>info</c>, <c>debug</c>, <c>tracing</c>, and <c>error</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>info</para>
        /// </summary>
        [NameInMap("LogLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        /// <summary>
        /// <para>The namespace for which you want to update the sidecar proxy configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The post-start parameters of Istio Proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;pilot-agent&quot;,&quot;wait&quot;]}}</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The pre-close parameters of Istio Proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;exec&quot;:{&quot;command&quot;:[&quot;/bin/sh&quot;,&quot;-c&quot;,&quot;sleep 15&quot;]}}</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the privileged mode in the security context of the sidecar proxy containers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the privileged mode. This means that the sidecar proxy containers run in privileged mode.</description></item>
        /// <item><description><c>false</c>: does not enable the privileged mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Privileged")]
        [Validation(Required=false)]
        public bool? Privileged { get; set; }

        /// <summary>
        /// <para>The maximum number of reclaimed CPU cores provided by Container Service for Kubernetes (ACK) that are available to the istio-init container. Reclaimed resources, including CPU cores and memory, are resources that can be dynamically overcommitted. This configuration item is used to set the maximum number of CPU cores that are available to the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>. Unit: millicore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("ProxyInitAckSloCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitAckSloCPUResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of reclaimed CPU cores provided by ACK that the istio-init container requires at runtime. This configuration item is used to set the minimum number of reclaimed CPU cores for the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>. Unit: millicore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProxyInitAckSloCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitAckSloCPUResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of reclaimed memory resources provided by ACK that are available to the istio-init container. This configuration item is used to set the maximum size of memory that is available to the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048Mi</para>
        /// </summary>
        [NameInMap("ProxyInitAckSloMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitAckSloMemoryResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum size of reclaimed memory provided by ACK that the istio-init container requires at runtime. This configuration item is used to set the minimum size of reclaimed memory for the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128Mi</para>
        /// </summary>
        [NameInMap("ProxyInitAckSloMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitAckSloMemoryResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the sidecar proxy init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000 m</para>
        /// </summary>
        [NameInMap("ProxyInitCPUResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores that are requested by the sidecar proxy init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60 m</para>
        /// </summary>
        [NameInMap("ProxyInitCPUResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitCPUResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of memory that is available to the sidecar proxy init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50 Mi</para>
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceLimit")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum size of memory that is requested by the sidecar proxy init container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30 Mi</para>
        /// </summary>
        [NameInMap("ProxyInitMemoryResourceRequest")]
        [Validation(Required=false)]
        public string ProxyInitMemoryResourceRequest { get; set; }

        /// <summary>
        /// <para>The environment variables that are added to a sidecar proxy. The environment variables are represented as JSON objects. The keys and values in the JSON objects represent the keys and values added to the environment variables of the sidecar proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EXIT_ON_ZERO_ACTIVE_CONNECTIONS&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("ProxyMetadata")]
        [Validation(Required=false)]
        public string ProxyMetadata { get; set; }

        /// <summary>
        /// <para>The monitoring metrics for data collected by Envoy proxies. The value is in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;inclusionPrefixes&quot;: [ &quot;cluster.outbound&quot;, &quot;cluster_manager&quot;, &quot;listener_manager&quot;, &quot;server&quot;, &quot;cluster.xds-grpc&quot; ], &quot;inclusionRegexps&quot;: [ &quot;listener.<em>.downstream_cx_total&quot;, &quot;listener.</em>.downstream_cx_active&quot; ] }</para>
        /// </summary>
        [NameInMap("ProxyStatsMatcher")]
        [Validation(Required=false)]
        public string ProxyStatsMatcher { get; set; }

        /// <summary>
        /// <para>The number of readiness check failures required before marking a sidecar proxy container as not ready.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ReadinessFailureThreshold")]
        [Validation(Required=false)]
        public int? ReadinessFailureThreshold { get; set; }

        /// <summary>
        /// <para>The amount of time to wait before the first readiness check of a sidecar proxy container is performed. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadinessInitialDelaySeconds")]
        [Validation(Required=false)]
        public int? ReadinessInitialDelaySeconds { get; set; }

        /// <summary>
        /// <para>The interval between two readiness checks of a sidecar proxy container. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ReadinessPeriodSeconds")]
        [Validation(Required=false)]
        public int? ReadinessPeriodSeconds { get; set; }

        /// <summary>
        /// <para>Indicates the runtime parameters of Envoy proxy processes in the sidecar proxy container. This parameter is a serialized JSON string. The keys and values of a JSON object are the keys and the values of a Envoy Runtime Parameter respectively.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global_downstream_max_connections: indicates that the limits on the number of connections from downstream to Envoy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;overload.global_downstream_max_connections&quot;:&quot;65536&quot;}</para>
        /// </summary>
        [NameInMap("RuntimeValues")]
        [Validation(Required=false)]
        public string RuntimeValues { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Shared Memory Communications over Remote Direct Memory Access (SMC-R) optimization. The SMC-R optimization feature uses Alibaba Cloud Linux 3 and elastic remote direct memory access (eRDMA) network devices, which optimizes cross-node communication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SMCEnabled")]
        [Validation(Required=false)]
        public bool? SMCEnabled { get; set; }

        [NameInMap("ScaledSidecarResource")]
        [Validation(Required=false)]
        public UpdateNamespaceScopeSidecarConfigRequestScaledSidecarResource ScaledSidecarResource { get; set; }
        public class UpdateNamespaceScopeSidecarConfigRequestScaledSidecarResource : TeaModel {
            [NameInMap("ContainerRef")]
            [Validation(Required=false)]
            public string ContainerRef { get; set; }

            [NameInMap("ResourceCalculationStrategy")]
            [Validation(Required=false)]
            public string ResourceCalculationStrategy { get; set; }

            [NameInMap("ResourcePercentage")]
            [Validation(Required=false)]
            public int? ResourcePercentage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca04bc38979214bf2882be79d39b4****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The maximum number of reclaimed CPU cores provided by ACK that are available to the sidecar proxy container. This configuration item is used to set the maximum number of CPU cores that are available to the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>. Unit: millicore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SidecarProxyAckSloCPUResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloCPUResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of reclaimed CPU cores provided by ACK that the sidecar proxy container requires at runtime. This configuration item is used to set the minimum number of reclaimed CPU cores for the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>. Unit: millicore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SidecarProxyAckSloCPUResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloCPUResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of reclaimed memory resources provided by ACK that are available to the sidecar proxy container. This configuration item is used to set the maximum size of memory that is available to the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048Mi</para>
        /// </summary>
        [NameInMap("SidecarProxyAckSloMemoryResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloMemoryResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum size of reclaimed memory provided by ACK that the sidecar proxy container requires at runtime. This configuration item is used to set the minimum size of reclaimed memory for the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128Mi</para>
        /// </summary>
        [NameInMap("SidecarProxyAckSloMemoryResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyAckSloMemoryResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum number of CPU cores that are available to the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000 m</para>
        /// </summary>
        [NameInMap("SidecarProxyCPUResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyCPUResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum number of CPU cores that are requested by the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60 m</para>
        /// </summary>
        [NameInMap("SidecarProxyCPUResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyCPUResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum size of memory that is available to the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50 Mi</para>
        /// </summary>
        [NameInMap("SidecarProxyMemoryResourceLimit")]
        [Validation(Required=false)]
        public string SidecarProxyMemoryResourceLimit { get; set; }

        /// <summary>
        /// <para>The minimum size of memory that is requested by the sidecar proxy container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30 Mi</para>
        /// </summary>
        [NameInMap("SidecarProxyMemoryResourceRequest")]
        [Validation(Required=false)]
        public string SidecarProxyMemoryResourceRequest { get; set; }

        /// <summary>
        /// <para>The maximum period of time that the sidecar proxy waits for a request to end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6s</para>
        /// </summary>
        [NameInMap("TerminationDrainDuration")]
        [Validation(Required=false)]
        public string TerminationDrainDuration { get; set; }

        /// <summary>
        /// <para>The custom configurations of Tracing Analysis. The configurations must be serialized into JSON strings. The configurations contain the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>sampling</c>: The sampling rate, which is of the DOUBLE type.</para>
        /// </description></item>
        /// <item><description><para><c>custom_tags</c>: The custom tags added to reported spans, which are of the MAP type. The key of a tag is of the string type. The value of a tag is in the JSON format. A custom tag can belong to one of the following types:</para>
        /// <list type="bullet">
        /// <item><description><c>literal</c>: The tag value is a fixed value in the JSON format. This tag must contain the <c>value</c> field that specifies a literal. Example: <c>{&quot;value&quot;:&quot;test&quot;}</c>.</description></item>
        /// <item><description><c>header</c>: The tag value is a request header in the JSON format. This tag must contain the <c>name</c> field and <c>defaultValue</c> field.The name field indicates the name of the request header. The defaultValue field indicates the default value that is used when no request header is available. Example: <c>{&quot;name&quot;:&quot;test&quot;,&quot;defaultValue&quot;:&quot;test&quot;}</c>.</description></item>
        /// <item><description><c>environment</c>: The tag value is an environment variable in the JSON format. This tag must contain the <c>name</c> field and <c>defaultValue</c> field. The name field indicates the name of the environment variable. The defaultValue field indicates the environment variable that is used when no environment variable is available. Example: <c>{&quot;name&quot;:&quot;test&quot;,&quot;defaultValue&quot;:&quot;test&quot;}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sampling&quot;:99.8,&quot;custom_tags&quot;:{&quot;test&quot;:{&quot;literal&quot;:{&quot;value&quot;:&quot;testnamespace&quot;}}}}</para>
        /// </summary>
        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public string Tracing { get; set; }

    }

}
