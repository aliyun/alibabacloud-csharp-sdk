// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNamespaceScopeSidecarConfigResponseBody : TeaModel {
        [NameInMap("ConfigPatches")]
        [Validation(Required=false)]
        public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches ConfigPatches { get; set; }
        public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatches : TeaModel {
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }

            [NameInMap("ExcludeInboundPorts")]
            [Validation(Required=false)]
            public string ExcludeInboundPorts { get; set; }

            [NameInMap("ExcludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string ExcludeOutboundIPRanges { get; set; }

            [NameInMap("ExcludeOutboundPorts")]
            [Validation(Required=false)]
            public string ExcludeOutboundPorts { get; set; }

            [NameInMap("HoldApplicationUntilProxyStarts")]
            [Validation(Required=false)]
            public bool? HoldApplicationUntilProxyStarts { get; set; }

            [NameInMap("IncludeInboundPorts")]
            [Validation(Required=false)]
            public string IncludeInboundPorts { get; set; }

            [NameInMap("IncludeOutboundIPRanges")]
            [Validation(Required=false)]
            public string IncludeOutboundIPRanges { get; set; }

            [NameInMap("IncludeOutboundPorts")]
            [Validation(Required=false)]
            public string IncludeOutboundPorts { get; set; }

            [NameInMap("IstioDNSProxyEnabled")]
            [Validation(Required=false)]
            public bool? IstioDNSProxyEnabled { get; set; }

            [NameInMap("LifecycleStr")]
            [Validation(Required=false)]
            public string LifecycleStr { get; set; }

            [NameInMap("LogLevel")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

            [NameInMap("ProxyStatsMatcher")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher ProxyStatsMatcher { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesProxyStatsMatcher : TeaModel {
                [NameInMap("InclusionPrefixes")]
                [Validation(Required=false)]
                public List<string> InclusionPrefixes { get; set; }

                [NameInMap("InclusionRegexps")]
                [Validation(Required=false)]
                public List<string> InclusionRegexps { get; set; }

                [NameInMap("InclusionSuffixes")]
                [Validation(Required=false)]
                public List<string> InclusionSuffixes { get; set; }

            }

            [NameInMap("SidecarProxyInitResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit SidecarProxyInitResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceLimit : TeaModel {
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            [NameInMap("SidecarProxyInitResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest SidecarProxyInitResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyInitResourceRequest : TeaModel {
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            [NameInMap("SidecarProxyResourceLimit")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit SidecarProxyResourceLimit { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceLimit : TeaModel {
                [NameInMap("ResourceCPULimit")]
                [Validation(Required=false)]
                public string ResourceCPULimit { get; set; }

                [NameInMap("ResourceMemoryLimit")]
                [Validation(Required=false)]
                public string ResourceMemoryLimit { get; set; }

            }

            [NameInMap("SidecarProxyResourceRequest")]
            [Validation(Required=false)]
            public DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest SidecarProxyResourceRequest { get; set; }
            public class DescribeNamespaceScopeSidecarConfigResponseBodyConfigPatchesSidecarProxyResourceRequest : TeaModel {
                [NameInMap("ResourceCPURequest")]
                [Validation(Required=false)]
                public string ResourceCPURequest { get; set; }

                [NameInMap("ResourceMemoryRequest")]
                [Validation(Required=false)]
                public string ResourceMemoryRequest { get; set; }

            }

            [NameInMap("TerminationDrainDuration")]
            [Validation(Required=false)]
            public string TerminationDrainDuration { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
