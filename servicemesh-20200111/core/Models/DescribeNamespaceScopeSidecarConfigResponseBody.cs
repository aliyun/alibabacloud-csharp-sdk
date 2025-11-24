// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNamespaceScopeSidecarConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The namespace-level sidecar configurations.</para>
        /// </summary>
        [NameInMap("ConfigPatches")]
        [Validation(Required=false)]
        public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches ConfigPatches { get; set; }
        public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches : TeaModel {
            /// <summary>
            /// <para>The number of worker threads to run in the istio-proxy container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// <para>Indicates whether the core dump feature is enabled for the sidecar proxy containers. Valid values:</para>
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
            /// <para>The inbound ports to be excluded from redirection to the sidecar proxy in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82</para>
            /// </summary>
            [NameInMap("ExcludeInboundPorts")]
            [Validation(Required=false)]
            public string ExcludeInboundPorts { get; set; }

            /// <summary>
            /// <para>The outbound IP ranges in CIDR form to be excluded from redirection to the sidecar proxy in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.3/31</para>
            /// </summary>
            [NameInMap("ExcludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string ExcludeOutboundIPRanges { get; set; }

            /// <summary>
            /// <para>The outbound ports to be excluded from redirection to the sidecar proxy in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("ExcludeOutboundPorts")]
            [Validation(Required=false)]
            public string ExcludeOutboundPorts { get; set; }

            /// <summary>
            /// <para>Indicates whether applications can be started only after the istio-proxy container starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Applications can be started only after the istio-proxy container starts.</description></item>
            /// <item><description><c>false</c>: Applications can be started before the istio-proxy container starts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HoldApplicationUntilProxyStarts")]
            [Validation(Required=false)]
            public bool? HoldApplicationUntilProxyStarts { get; set; }

            /// <summary>
            /// <para>The inbound ports for which traffic is to be redirected to the sidecar proxy in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("IncludeInboundPorts")]
            [Validation(Required=false)]
            public string IncludeInboundPorts { get; set; }

            /// <summary>
            /// <para>The outbound IP ranges in CIDR form for which traffic is to be redirected to the sidecar proxy in the ASM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.4/31</para>
            /// </summary>
            [NameInMap("IncludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string IncludeOutboundIPRanges { get; set; }

            /// <summary>
            /// <para>The outbound ports for which traffic is to be redirected to the sidecar proxy in the ASM instance.</para>
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
            /// <item><description><c>REDIRECT</c> (default): In this mode, source IP addresses are lost during traffic redirection to the sidecar proxy.</description></item>
            /// <item><description><c>TPROXY</c>: In this mode, both the source and destination IP addresses and ports are preserved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TPROXY</para>
            /// </summary>
            [NameInMap("InterceptionMode")]
            [Validation(Required=false)]
            public string InterceptionMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the Domain Name System (DNS) proxy feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c></description></item>
            /// <item><description><c>false</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IstioDNSProxyEnabled")]
            [Validation(Required=false)]
            public bool? IstioDNSProxyEnabled { get; set; }

            /// <summary>
            /// <para>The JSON string that describes the lifecycle of the sidecar proxy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;postStart&quot;:{&quot;exec&quot;:{&quot;command&quot;:[&quot;pilot-agent&quot;,&quot;wait&quot;]}},&quot;preStop&quot;:{&quot;exec&quot;:{&quot;command&quot;:[&quot;/bin/sh&quot;,&quot;-c&quot;,&quot;sleep 15&quot;]}}}</para>
            /// </summary>
            [NameInMap("LifecycleStr")]
            [Validation(Required=false)]
            public string LifecycleStr { get; set; }

            /// <summary>
            /// <para>The log level. Valid values: <c>info</c>, <c>debug</c>, <c>trace</c>, and <c>error</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>info</para>
            /// </summary>
            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

            /// <summary>
            /// <para>Indicates whether the privileged mode is enabled in the security context of the sidecar proxy containers. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The privileged mode is enabled, that is, the sidecar proxy containers run in privileged mode.</description></item>
            /// <item><description><c>false</c>: The privileged mode is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Privileged")]
            [Validation(Required=false)]
            public bool? Privileged { get; set; }

            [NameInMap("ProxyMetadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProxyMetadata { get; set; }

            /// <summary>
            /// <para>The custom Envoy statistics that are reported by the sidecar proxy.</para>
            /// </summary>
            [NameInMap("ProxyStatsMatcher")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher ProxyStatsMatcher { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher : TeaModel {
                /// <summary>
                /// <para>The prefixes of the custom Envoy statistics that are reported by the sidecar proxy.</para>
                /// </summary>
                [NameInMap("InclusionPrefixes")]
                [Validation(Required=false)]
                public List<string> InclusionPrefixes { get; set; }

                /// <summary>
                /// <para>The regular expressions for specifying the custom Envoy statistics that are reported by the sidecar proxy.</para>
                /// </summary>
                [NameInMap("InclusionRegexps")]
                [Validation(Required=false)]
                public List<string> InclusionRegexps { get; set; }

                /// <summary>
                /// <para>The suffixes of the custom Envoy statistics that are reported by the sidecar proxy.</para>
                /// </summary>
                [NameInMap("InclusionSuffixes")]
                [Validation(Required=false)]
                public List<string> InclusionSuffixes { get; set; }

            }

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
            /// <para>2</para>
            /// </summary>
            [NameInMap("ReadinessInitialDelaySeconds")]
            [Validation(Required=false)]
            public int? ReadinessInitialDelaySeconds { get; set; }

            /// <summary>
            /// <para>The interval between two readiness checks of a sidecar proxy container. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReadinessPeriodSeconds")]
            [Validation(Required=false)]
            public int? ReadinessPeriodSeconds { get; set; }

            /// <summary>
            /// <para>Indicates the runtime parameters of Envoy proxy processes in the sidecar proxy container.</para>
            /// </summary>
            [NameInMap("RuntimeValues")]
            [Validation(Required=false)]
            public Dictionary<string, string> RuntimeValues { get; set; }

            /// <summary>
            /// <para>The configurations of the Shared Memory Communications over Remote Direct Memory Access (SMC-R) optimization feature.</para>
            /// </summary>
            [NameInMap("SMCConfiguration")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSMCConfiguration SMCConfiguration { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSMCConfiguration : TeaModel {
                /// <summary>
                /// <para>Indicates whether the SMC-R optimization feature is enabled. The SMC-R optimization feature uses Alibaba Cloud Linux 3 and elastic remote direct memory access (eRDMA) network devices, which optimizes cross-node communication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            [NameInMap("ScaledSidecarResource")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesScaledSidecarResource ScaledSidecarResource { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesScaledSidecarResource : TeaModel {
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
            /// <para>The maximum size of reclaimed ACK resources that are available to the sidecar proxy container. This configuration item indicates the maximum size of resources that are available to the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>.</para>
            /// </summary>
            [NameInMap("SidecarProxyAckSloResource")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyAckSloResource SidecarProxyAckSloResource { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyAckSloResource : TeaModel {
                /// <summary>
                /// <para>The maximum size of reclaimed ACK resources that are available to the sidecar proxy container. This configuration item indicates the maximum size of resources that are available to the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>. The object can contain the following two types of keys, which indicate two types of resources:</para>
                /// <list type="bullet">
                /// <item><description><c>kubernetes.io/batch-cpu</c>: CPU resources that can be dynamically overcommitted. Unit: millicore.</description></item>
                /// <item><description><c>kubernetes.io/batch-memory</c>: memory resources that can be dynamically overcommitted.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Limits")]
                [Validation(Required=false)]
                public Dictionary<string, string> Limits { get; set; }

                /// <summary>
                /// <para>The minimum size of reclaimed ACK resources that the sidecar proxy container needs to use at runtime. This configuration item indicates the minimum size of reclaimed ACK resources for the sidecar proxy container in a pod labeled with <c>koordinator.sh/qosClass</c>. The object can contain the following two types of keys, which indicate two types of resources:</para>
                /// <list type="bullet">
                /// <item><description><c>kubernetes.io/batch-cpu</c>: CPU resources that can be dynamically overcommitted. Unit: millicore.</description></item>
                /// <item><description><c>kubernetes.io/batch-memory</c>: memory resources that can be dynamically overcommitted.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Requests")]
                [Validation(Required=false)]
                public Dictionary<string, string> Requests { get; set; }

            }

            /// <summary>
            /// <para>The reclaimed Container Service for Kubernetes (ACK) resources for the istio-init container. This configuration item indicates the resources of the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>. Reclaimed ACK resources are resources that can be dynamically overcommitted.</para>
            /// </summary>
            [NameInMap("SidecarProxyInitAckSloResource")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitAckSloResource SidecarProxyInitAckSloResource { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitAckSloResource : TeaModel {
                /// <summary>
                /// <para>The maximum size of reclaimed ACK resources that are available to the istio-init container. This configuration item indicates the maximum size of resources that are available to the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>. The object can contain the following two types of keys, which indicate two types of resources:</para>
                /// <list type="bullet">
                /// <item><description><c>kubernetes.io/batch-cpu</c>: CPU resources that can be dynamically overcommitted. Unit: millicore.</description></item>
                /// <item><description><c>kubernetes.io/batch-memory</c>: memory resources that can be dynamically overcommitted.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Limits")]
                [Validation(Required=false)]
                public Dictionary<string, string> Limits { get; set; }

                /// <summary>
                /// <para>The minimum size of reclaimed ACK resources that the istio-init container needs to use at runtime. This configuration item indicates the minimum size of reclaimed ACK resources for the istio-init container in a pod labeled with <c>koordinator.sh/qosClass</c>. The object can contain the following two types of keys, which indicate two types of resources:</para>
                /// <list type="bullet">
                /// <item><description><c>kubernetes.io/batch-cpu</c>: CPU resources that can be dynamically overcommitted. Unit: millicore.</description></item>
                /// <item><description><c>kubernetes.io/batch-memory</c>: memory resources that can be dynamically overcommitted.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Requests")]
                [Validation(Required=false)]
                public Dictionary<string, string> Requests { get; set; }

            }

            /// <summary>
            /// <para>The maximum size of resources that are available to the istio-init container in the pod into which the sidecar proxy is injected. The istio-init container is used in this topic.</para>
            /// </summary>
            [NameInMap("SidecarProxyInitResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit : TeaModel {
                /// <summary>
                /// <para>The maximum number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000 m</para>
                /// </summary>
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                /// <summary>
                /// <para>The maximum size of the memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50 Mi</para>
                /// </summary>
                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            /// <summary>
            /// <para>The minimum size of resources that are required by the istio-init container.</para>
            /// </summary>
            [NameInMap("SidecarProxyInitResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest : TeaModel {
                /// <summary>
                /// <para>The minimum number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60 m</para>
                /// </summary>
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                /// <summary>
                /// <para>The minimum size of the memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30 Mi</para>
                /// </summary>
                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            /// <summary>
            /// <para>The maximum size of resources that are available to the sidecar proxy container.</para>
            /// </summary>
            [NameInMap("SidecarProxyResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit SidecarProxyResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit : TeaModel {
                /// <summary>
                /// <para>The maximum number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000 m</para>
                /// </summary>
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                /// <summary>
                /// <para>The maximum size of the memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50 Mi</para>
                /// </summary>
                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            /// <summary>
            /// <para>The minimum size of resources that are required by the sidecar proxy container.</para>
            /// </summary>
            [NameInMap("SidecarProxyResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest SidecarProxyResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest : TeaModel {
                /// <summary>
                /// <para>The minimum number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60 m</para>
                /// </summary>
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                /// <summary>
                /// <para>The minimum size of the memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30 Mi</para>
                /// </summary>
                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            /// <summary>
            /// <para>The maximum period of time allowed for connections to complete on sidecar proxy shutdown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6s</para>
            /// </summary>
            [NameInMap("TerminationDrainDuration")]
            [Validation(Required=false)]
            public string TerminationDrainDuration { get; set; }

            /// <summary>
            /// <para>The custom configurations of Tracing Analysis.</para>
            /// </summary>
            [NameInMap("Tracing")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesTracing Tracing { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesTracing : TeaModel {
                /// <summary>
                /// <para>The custom tags added to reported spans. The key of a tag is of the string type. The value of a tag is in the JSON format. A custom tag can belong to one of the following types:</para>
                /// <list type="bullet">
                /// <item><description><c>literal</c>: The tag value is a fixed value in the JSON format. This tag must contain the <c>value</c> field that specifies a literal. Example: <c>{&quot;value&quot;:&quot;test&quot;}</c>.</description></item>
                /// <item><description><c>header</c>: The tag value is a request header in the JSON format. This tag must contain the <c>name</c> field and the <c>defaultValue</c> field. The name field indicates the name of the request header. The defaultValue field indicates the default value that is used when no request header is available. Example: <c>{&quot;name&quot;:&quot;test&quot;,&quot;defaultValue&quot;:&quot;test&quot;}</c>.</description></item>
                /// <item><description><c>environment</c>: The tag value is an environment variable in the JSON format. This tag must contain the <c>name</c> field and the <c>defaultValue</c> field. The name field indicates the name of the environment variable. The defaultValue field indicates the environment variable that is used when no environment variable is available. Example: <c>{&quot;name&quot;:&quot;test&quot;,&quot;defaultValue&quot;:&quot;test&quot;}</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;test&quot;:{&quot;literal&quot;:{&quot;value&quot;:&quot;test&quot;}}}</para>
                /// </summary>
                [NameInMap("CustomTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomTags { get; set; }

                /// <summary>
                /// <para>The maximum tag length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxPathTagLength")]
                [Validation(Required=false)]
                public int? MaxPathTagLength { get; set; }

                /// <summary>
                /// <para>The sampling rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.8</para>
                /// </summary>
                [NameInMap("Sampling")]
                [Validation(Required=false)]
                public double? Sampling { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
