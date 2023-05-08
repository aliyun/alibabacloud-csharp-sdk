// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNamespaceScopeSidecarConfigResponseBody : TeaModel {
        /// <summary>
        /// The namespace-level sidecar configurations.
        /// </summary>
        [NameInMap("ConfigPatches")]
        [Validation(Required=false)]
        public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches ConfigPatches { get; set; }
        public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches : TeaModel {
            /// <summary>
            /// The number of worker threads running in the sidecar proxy.
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            /// <summary>
            /// The port that the inbound traffic of the sidecar proxy does not pass through.
            /// </summary>
            [NameInMap("ExcludeInboundPorts")]
            [Validation(Required=false)]
            public string ExcludeInboundPorts { get; set; }

            /// <summary>
            /// The IP address from which the outbound traffic does not pass through the sidecar proxy.
            /// </summary>
            [NameInMap("ExcludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string ExcludeOutboundIPRanges { get; set; }

            /// <summary>
            /// The port that the outbound traffic of the sidecar proxy does not pass through.
            /// </summary>
            [NameInMap("ExcludeOutboundPorts")]
            [Validation(Required=false)]
            public string ExcludeOutboundPorts { get; set; }

            /// <summary>
            /// Indicates whether applications can be started only after Istio Proxy starts. Valid values:
            /// 
            /// *   `true`: Applications can be started only after Istio Proxy starts.
            /// *   false: Applications can be started before Istio Proxy starts.
            /// </summary>
            [NameInMap("HoldApplicationUntilProxyStarts")]
            [Validation(Required=false)]
            public bool? HoldApplicationUntilProxyStarts { get; set; }

            /// <summary>
            /// The port that the inbound traffic of the sidecar proxy passes through.
            /// </summary>
            [NameInMap("IncludeInboundPorts")]
            [Validation(Required=false)]
            public string IncludeInboundPorts { get; set; }

            /// <summary>
            /// The IP address from which the outbound traffic passes through the sidecar proxy.
            /// </summary>
            [NameInMap("IncludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string IncludeOutboundIPRanges { get; set; }

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
            /// Indicates whether the Domain Name System (DNS) proxy feature is enabled. Valid values:
            /// 
            /// *   `true`: The DNS proxy feature is enabled.
            /// *   `false`: The DNS proxy feature is disabled.
            /// </summary>
            [NameInMap("IstioDNSProxyEnabled")]
            [Validation(Required=false)]
            public bool? IstioDNSProxyEnabled { get; set; }

            /// <summary>
            /// The JSON string that describes the lifecycle of the sidecar proxy.
            /// </summary>
            [NameInMap("LifecycleStr")]
            [Validation(Required=false)]
            public string LifecycleStr { get; set; }

            /// <summary>
            /// The log level. Valid values: `info`, `debug`, `trace`, and `error`.
            /// </summary>
            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

            [NameInMap("ProxyMetadata")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProxyMetadata { get; set; }

            /// <summary>
            /// The monitoring metrics for data collected by Envoy proxies.
            /// </summary>
            [NameInMap("ProxyStatsMatcher")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher ProxyStatsMatcher { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher : TeaModel {
                /// <summary>
                /// The prefix of the monitoring metrics for data collected by Envoy proxies.
                /// </summary>
                [NameInMap("InclusionPrefixes")]
                [Validation(Required=false)]
                public List<string> InclusionPrefixes { get; set; }

                /// <summary>
                /// The regular expression of the monitoring metrics for data collected by Envoy proxies.
                /// </summary>
                [NameInMap("InclusionRegexps")]
                [Validation(Required=false)]
                public List<string> InclusionRegexps { get; set; }

                /// <summary>
                /// The suffix of the monitoring metrics for data collected by Envoy proxies.
                /// </summary>
                [NameInMap("InclusionSuffixes")]
                [Validation(Required=false)]
                public List<string> InclusionSuffixes { get; set; }

            }

            [NameInMap("SidecarProxyAckSloResource")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyAckSloResource SidecarProxyAckSloResource { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyAckSloResource : TeaModel {
                [NameInMap("Limits")]
                [Validation(Required=false)]
                public Dictionary<string, string> Limits { get; set; }

                [NameInMap("Requests")]
                [Validation(Required=false)]
                public Dictionary<string, string> Requests { get; set; }

            }

            [NameInMap("SidecarProxyInitAckSloResource")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitAckSloResource SidecarProxyInitAckSloResource { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitAckSloResource : TeaModel {
                [NameInMap("Limits")]
                [Validation(Required=false)]
                public Dictionary<string, string> Limits { get; set; }

                [NameInMap("Requests")]
                [Validation(Required=false)]
                public Dictionary<string, string> Requests { get; set; }

            }

            /// <summary>
            /// The maximum size of resources that are available to the sidecar proxy init container.
            /// </summary>
            [NameInMap("SidecarProxyInitResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit : TeaModel {
                /// <summary>
                /// The maximum number of CPU cores.
                /// </summary>
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                /// <summary>
                /// The maximum size of the memory.
                /// </summary>
                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            /// <summary>
            /// The minimum size of resources that are requested by the sidecar proxy init container.
            /// </summary>
            [NameInMap("SidecarProxyInitResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest : TeaModel {
                /// <summary>
                /// The minimum number of CPU cores.
                /// </summary>
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                /// <summary>
                /// The minimum size of the memory.
                /// </summary>
                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            /// <summary>
            /// The maximum size of resources that are available to the sidecar proxy container.
            /// </summary>
            [NameInMap("SidecarProxyResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit SidecarProxyResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit : TeaModel {
                /// <summary>
                /// The maximum number of CPU cores.
                /// </summary>
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                /// <summary>
                /// The maximum size of the memory.
                /// </summary>
                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            /// <summary>
            /// The minimum size of resources that are requested by the sidecar proxy container.
            /// </summary>
            [NameInMap("SidecarProxyResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest SidecarProxyResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest : TeaModel {
                /// <summary>
                /// The minimum number of CPU cores.
                /// </summary>
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                /// <summary>
                /// The minimum size of the memory.
                /// </summary>
                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            /// <summary>
            /// The maximum period of time that the sidecar proxy waits for a request to end.
            /// </summary>
            [NameInMap("TerminationDrainDuration")]
            [Validation(Required=false)]
            public string TerminationDrainDuration { get; set; }

            /// <summary>
            /// The custom configurations of Tracing Analysis.
            /// </summary>
            [NameInMap("Tracing")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesTracing Tracing { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesTracing : TeaModel {
                /// <summary>
                /// The custom tags added to reported spans. The key of a tag is of the string type. The value of a tag is in the JSON format. A custom tag can belong to one of the following types:
                /// 
                /// *   `literal`: The tag value is a fixed value in the JSON format. This tag must contain the `value` field that specifies a literal. Example: `{"value":"test"}`.
                /// 
                /// <!---->
                /// 
                /// *   `header`: The tag value is a request header in the JSON format. This tag must contain the `name` field and `defaultValue` field.The name field indicates the name of the request header. The defaultValue field indicates the default value that is used when no request header is available. Example: `{"name":"test","defaultValue":"test"}`.
                /// *   `environment`: The tag value is an environment variable in the JSON format. This tag must contain the `name` field and `defaultValue` field. The name field indicates the name of the environment variable. The defaultValue field indicates the environment variable that is used when no environment variable is available. Example: `{"name":"test","defaultValue":"test"}`.
                /// </summary>
                [NameInMap("CustomTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomTags { get; set; }

                /// <summary>
                /// The maximum tag length.
                /// </summary>
                [NameInMap("MaxPathTagLength")]
                [Validation(Required=false)]
                public int? MaxPathTagLength { get; set; }

                /// <summary>
                /// The sampling rate.
                /// </summary>
                [NameInMap("Sampling")]
                [Validation(Required=false)]
                public double? Sampling { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
