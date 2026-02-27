// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class KubeletConfig : TeaModel {
        /// <summary>
        /// <para>The whitelisted unsafe sysctls.</para>
        /// </summary>
        [NameInMap("allowedUnsafeSysctls")]
        [Validation(Required=false)]
        public List<string> AllowedUnsafeSysctls { get; set; }

        /// <summary>
        /// <para>The list of IP addresses of the DNS servers.</para>
        /// </summary>
        [NameInMap("clusterDNS")]
        [Validation(Required=false)]
        public List<string> ClusterDNS { get; set; }

        /// <summary>
        /// <para>The maximum number of log files that can be stored in each container.</para>
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
        /// <para>The maximum number of concurrent programs that rotate logs</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("containerLogMaxWorkers")]
        [Validation(Required=false)]
        public int? ContainerLogMaxWorkers { get; set; }

        /// <summary>
        /// <para>The duration at which the container logs are monitored for rotating logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("containerLogMonitorInterval")]
        [Validation(Required=false)]
        public string ContainerLogMonitorInterval { get; set; }

        /// <summary>
        /// <para>Specifies whether to use Completely Fair Scheduler (CFS) quota to enforce pod CPU limits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cpuCFSQuota")]
        [Validation(Required=false)]
        public bool? CpuCFSQuota { get; set; }

        /// <summary>
        /// <para>The duration for the CPU CFS quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100ms</para>
        /// </summary>
        [NameInMap("cpuCFSQuotaPeriod")]
        [Validation(Required=false)]
        public string CpuCFSQuotaPeriod { get; set; }

        /// <summary>
        /// <para>The CPU management policy used by kubelet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpuManagerPolicy")]
        [Validation(Required=false)]
        public string CpuManagerPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of burst peaks for the event records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("eventBurst")]
        [Validation(Required=false)]
        public long? EventBurst { get; set; }

        /// <summary>
        /// <para>Specifies the maximum number of events that can be generated per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("eventRecordQPS")]
        [Validation(Required=false)]
        public long? EventRecordQPS { get; set; }

        /// <summary>
        /// <para>A set of eviction thresholds that will trigger a pod eviction if met.</para>
        /// </summary>
        [NameInMap("evictionHard")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionHard { get; set; }

        /// <summary>
        /// <para>A set of eviction thresholds that will trigger a pod eviction if met over a corresponding grace period.</para>
        /// </summary>
        [NameInMap("evictionSoft")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoft { get; set; }

        /// <summary>
        /// <para>A set of grace periods for eviction thresholds.</para>
        /// </summary>
        [NameInMap("evictionSoftGracePeriod")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoftGracePeriod { get; set; }

        /// <summary>
        /// <para>A feature gate that is used to enable an experimental feature.</para>
        /// </summary>
        [NameInMap("featureGates")]
        [Validation(Required=false)]
        public Dictionary<string, object> FeatureGates { get; set; }

        /// <summary>
        /// <para>The percentage of disk usage after which image garbage collection always runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("imageGCHighThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCHighThresholdPercent { get; set; }

        /// <summary>
        /// <para>The percentage of disk usage before which image garbage collection never runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("imageGCLowThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCLowThresholdPercent { get; set; }

        /// <summary>
        /// <para>The maximum number of burst requests sent to the API server per second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("kubeAPIBurst")]
        [Validation(Required=false)]
        public long? KubeAPIBurst { get; set; }

        /// <summary>
        /// <para>The QPS when kubelet communicates with the Kubernetes API server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("kubeAPIQPS")]
        [Validation(Required=false)]
        public long? KubeAPIQPS { get; set; }

        /// <summary>
        /// <para>A set of configurations that specify resources reserved for the Kubernetes system.</para>
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
        /// <para>The name of the policy to be used by the memory manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("memoryManagerPolicy")]
        [Validation(Required=false)]
        public string MemoryManagerPolicy { get; set; }

        /// <summary>
        /// <para>The maximum number of processes per pod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("podPidsLimit")]
        [Validation(Required=false)]
        public long? PodPidsLimit { get; set; }

        /// <summary>
        /// <para>The read-only port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("readOnlyPort")]
        [Validation(Required=false)]
        public long? ReadOnlyPort { get; set; }

        /// <summary>
        /// <para>The maximum number of images that can be pulled from bursty image pulls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("registryBurst")]
        [Validation(Required=false)]
        public long? RegistryBurst { get; set; }

        /// <summary>
        /// <para>The maximum queries per second (QPS) of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("registryPullQPS")]
        [Validation(Required=false)]
        public long? RegistryPullQPS { get; set; }

        /// <summary>
        /// <para>A list of configurations that specify memory reservations for non-uniform memory access (NUMA) nodes.</para>
        /// </summary>
        [NameInMap("reservedMemory")]
        [Validation(Required=false)]
        public List<KubeletConfigReservedMemory> ReservedMemory { get; set; }
        public class KubeletConfigReservedMemory : TeaModel {
            /// <summary>
            /// <para>The memory limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;memory&quot;: &quot;1Gi&quot;}</para>
            /// </summary>
            [NameInMap("limits")]
            [Validation(Required=false)]
            public Dictionary<string, object> Limits { get; set; }

            /// <summary>
            /// <para>The NUMA node identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("numaNode")]
            [Validation(Required=false)]
            public int? NumaNode { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to pull one image at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serializeImagePulls")]
        [Validation(Required=false)]
        public bool? SerializeImagePulls { get; set; }

        [NameInMap("serverTLSBootstrap")]
        [Validation(Required=false)]
        public bool? ServerTLSBootstrap { get; set; }

        /// <summary>
        /// <para>A set of configurations that specify reserved resources for the system.</para>
        /// </summary>
        [NameInMap("systemReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> SystemReserved { get; set; }

        /// <summary>
        /// <para>The name of the Topology Manager policy that you want to use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>restricted</para>
        /// </summary>
        [NameInMap("topologyManagerPolicy")]
        [Validation(Required=false)]
        public string TopologyManagerPolicy { get; set; }

        /// <summary>
        /// <para>The versioned configuration information for the Managed Service for OpenTelemetry client.</para>
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
            /// <para>The number of samples to be collected per million spans.</para>
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
