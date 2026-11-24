// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class KubeletConfig : TeaModel {
        /// <summary>
        /// <para>The whitelist of allowed unsafe sysctl patterns.</para>
        /// </summary>
        [NameInMap("allowedUnsafeSysctls")]
        [Validation(Required=false)]
        public List<string> AllowedUnsafeSysctls { get; set; }

        /// <summary>
        /// <para>The list of IP addresses of cluster DNS servers.</para>
        /// </summary>
        [NameInMap("clusterDNS")]
        [Validation(Required=false)]
        public List<string> ClusterDNS { get; set; }

        /// <summary>
        /// <para>The maximum number of log files that can exist for each container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("containerLogMaxFiles")]
        [Validation(Required=false)]
        public long? ContainerLogMaxFiles { get; set; }

        /// <summary>
        /// <para>The maximum size that a log file can reach before it is rotated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10Mi</para>
        /// </summary>
        [NameInMap("containerLogMaxSize")]
        [Validation(Required=false)]
        public string ContainerLogMaxSize { get; set; }

        /// <summary>
        /// <para>Specifies the maximum number of concurrent workers required to perform log rotation operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("containerLogMaxWorkers")]
        [Validation(Required=false)]
        public int? ContainerLogMaxWorkers { get; set; }

        /// <summary>
        /// <para>Specifies the duration for monitoring container logs to perform log rotation operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("containerLogMonitorInterval")]
        [Validation(Required=false)]
        public string ContainerLogMonitorInterval { get; set; }

        /// <summary>
        /// <para>The switch for CPU CFS quota enforcement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cpuCFSQuota")]
        [Validation(Required=false)]
        public bool? CpuCFSQuota { get; set; }

        /// <summary>
        /// <para>The CPU CFS quota period value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100ms</para>
        /// </summary>
        [NameInMap("cpuCFSQuotaPeriod")]
        [Validation(Required=false)]
        public string CpuCFSQuotaPeriod { get; set; }

        /// <summary>
        /// <para>The CPU manager policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpuManagerPolicy")]
        [Validation(Required=false)]
        public string CpuManagerPolicy { get; set; }

        /// <summary>
        /// <para>The burst limit for the number of event records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("eventBurst")]
        [Validation(Required=false)]
        public long? EventBurst { get; set; }

        /// <summary>
        /// <para>The number of events that can be generated per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("eventRecordQPS")]
        [Validation(Required=false)]
        public long? EventRecordQPS { get; set; }

        /// <summary>
        /// <para>The set of hard thresholds that trigger pod eviction.</para>
        /// </summary>
        [NameInMap("evictionHard")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionHard { get; set; }

        /// <summary>
        /// <para>The set of soft eviction thresholds.</para>
        /// </summary>
        [NameInMap("evictionSoft")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoft { get; set; }

        /// <summary>
        /// <para>The set of soft eviction grace periods.</para>
        /// </summary>
        [NameInMap("evictionSoftGracePeriod")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoftGracePeriod { get; set; }

        /// <summary>
        /// <para>The feature gates used to enable experimental features.</para>
        /// </summary>
        [NameInMap("featureGates")]
        [Validation(Required=false)]
        public Dictionary<string, object> FeatureGates { get; set; }

        /// <summary>
        /// <para>The threshold above which image garbage collection is continuously performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("imageGCHighThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCHighThresholdPercent { get; set; }

        /// <summary>
        /// <para>The threshold below which image garbage collection is not performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("imageGCLowThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCLowThresholdPercent { get; set; }

        /// <summary>
        /// <para>The burst limit for the number of requests sent to the API server per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("kubeAPIBurst")]
        [Validation(Required=false)]
        public long? KubeAPIBurst { get; set; }

        /// <summary>
        /// <para>The number of queries per second for communication with the API server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("kubeAPIQPS")]
        [Validation(Required=false)]
        public long? KubeAPIQPS { get; set; }

        /// <summary>
        /// <para>The resource configuration reserved for the Kubernetes system.</para>
        /// </summary>
        [NameInMap("kubeReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> KubeReserved { get; set; }

        /// <summary>
        /// <para>The maximum number of running pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("maxPods")]
        [Validation(Required=false)]
        public long? MaxPods { get; set; }

        /// <summary>
        /// <para>The memory management policy to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("memoryManagerPolicy")]
        [Validation(Required=false)]
        public string MemoryManagerPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of PIDs that can be used in a pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("podPidsLimit")]
        [Validation(Required=false)]
        public long? PodPidsLimit { get; set; }

        /// <summary>
        /// <para>The read-only port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("readOnlyPort")]
        [Validation(Required=false)]
        public long? ReadOnlyPort { get; set; }

        /// <summary>
        /// <para>The burst limit for the number of image pulls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("registryBurst")]
        [Validation(Required=false)]
        public long? RegistryBurst { get; set; }

        /// <summary>
        /// <para>The QPS limit for the image registry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("registryPullQPS")]
        [Validation(Required=false)]
        public long? RegistryPullQPS { get; set; }

        /// <summary>
        /// <para>The memory reserved for NUMA nodes.</para>
        /// </summary>
        [NameInMap("reservedMemory")]
        [Validation(Required=false)]
        public List<KubeletConfigReservedMemory> ReservedMemory { get; set; }
        public class KubeletConfigReservedMemory : TeaModel {
            /// <summary>
            /// <para>The limits on memory resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;memory&quot;: &quot;1Gi&quot;}</para>
            /// </summary>
            [NameInMap("limits")]
            [Validation(Required=false)]
            public Dictionary<string, object> Limits { get; set; }

            /// <summary>
            /// <para>The NUMA node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("numaNode")]
            [Validation(Required=false)]
            public int? NumaNode { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to pull images one by one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serializeImagePulls")]
        [Validation(Required=false)]
        public bool? SerializeImagePulls { get; set; }

        /// <summary>
        /// <para>Enables the automatic issuance and rotation of Kubelet server certificates. When enabled, you must also configure &quot;RotateKubeletServerCertificate&quot;: true in the featureGates of the Kubelet.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only applicable to clusters of version 1.30 and later.</description></item>
        /// <item><description>Clusters of versions 1.30 to v1.33 must commit a ticket to apply.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serverTLSBootstrap")]
        [Validation(Required=false)]
        public bool? ServerTLSBootstrap { get; set; }

        /// <summary>
        /// <para>The resource configuration reserved for the system.</para>
        /// </summary>
        [NameInMap("systemReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> SystemReserved { get; set; }

        /// <summary>
        /// <para>The topology manager policy name to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>restricted</para>
        /// </summary>
        [NameInMap("topologyManagerPolicy")]
        [Validation(Required=false)]
        public string TopologyManagerPolicy { get; set; }

        /// <summary>
        /// <para>The versioned configuration information for OpenTelemetry tracing client settings.</para>
        /// </summary>
        [NameInMap("tracing")]
        [Validation(Required=false)]
        public KubeletConfigTracing Tracing { get; set; }
        public class KubeletConfigTracing : TeaModel {
            /// <summary>
            /// <para>The endpoint of the collector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>localhost:4317</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The number of samples to collect per million spans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200000</para>
            /// </summary>
            [NameInMap("samplingRatePerMillion")]
            [Validation(Required=false)]
            public int? SamplingRatePerMillion { get; set; }

        }

    }

}
