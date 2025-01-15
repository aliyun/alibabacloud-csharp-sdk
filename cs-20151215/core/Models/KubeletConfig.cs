// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class KubeletConfig : TeaModel {
        [NameInMap("allowedUnsafeSysctls")]
        [Validation(Required=false)]
        public List<string> AllowedUnsafeSysctls { get; set; }

        [NameInMap("clusterDNS")]
        [Validation(Required=false)]
        public List<string> ClusterDNS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("containerLogMaxFiles")]
        [Validation(Required=false)]
        public long? ContainerLogMaxFiles { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10Mi</para>
        /// </summary>
        [NameInMap("containerLogMaxSize")]
        [Validation(Required=false)]
        public string ContainerLogMaxSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("containerLogMaxWorkers")]
        [Validation(Required=false)]
        public int? ContainerLogMaxWorkers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10s</para>
        /// </summary>
        [NameInMap("containerLogMonitorInterval")]
        [Validation(Required=false)]
        public string ContainerLogMonitorInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("cpuCFSQuota")]
        [Validation(Required=false)]
        public bool? CpuCFSQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100ms</para>
        /// </summary>
        [NameInMap("cpuCFSQuotaPeriod")]
        [Validation(Required=false)]
        public string CpuCFSQuotaPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("cpuManagerPolicy")]
        [Validation(Required=false)]
        public string CpuManagerPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("eventBurst")]
        [Validation(Required=false)]
        public long? EventBurst { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("eventRecordQPS")]
        [Validation(Required=false)]
        public long? EventRecordQPS { get; set; }

        [NameInMap("evictionHard")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionHard { get; set; }

        [NameInMap("evictionSoft")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoft { get; set; }

        [NameInMap("evictionSoftGracePeriod")]
        [Validation(Required=false)]
        public Dictionary<string, object> EvictionSoftGracePeriod { get; set; }

        [NameInMap("featureGates")]
        [Validation(Required=false)]
        public Dictionary<string, object> FeatureGates { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("imageGCHighThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCHighThresholdPercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("imageGCLowThresholdPercent")]
        [Validation(Required=false)]
        public int? ImageGCLowThresholdPercent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("kubeAPIBurst")]
        [Validation(Required=false)]
        public long? KubeAPIBurst { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("kubeAPIQPS")]
        [Validation(Required=false)]
        public long? KubeAPIQPS { get; set; }

        [NameInMap("kubeReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> KubeReserved { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110</para>
        /// </summary>
        [NameInMap("maxPods")]
        [Validation(Required=false)]
        public long? MaxPods { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("memoryManagerPolicy")]
        [Validation(Required=false)]
        public string MemoryManagerPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("podPidsLimit")]
        [Validation(Required=false)]
        public long? PodPidsLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("readOnlyPort")]
        [Validation(Required=false)]
        public long? ReadOnlyPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("registryBurst")]
        [Validation(Required=false)]
        public long? RegistryBurst { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("registryPullQPS")]
        [Validation(Required=false)]
        public long? RegistryPullQPS { get; set; }

        [NameInMap("reservedMemory")]
        [Validation(Required=false)]
        public List<KubeletConfigReservedMemory> ReservedMemory { get; set; }
        public class KubeletConfigReservedMemory : TeaModel {
            [NameInMap("limits")]
            [Validation(Required=false)]
            public Dictionary<string, object> Limits { get; set; }

            [NameInMap("numaNode")]
            [Validation(Required=false)]
            public int? NumaNode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("serializeImagePulls")]
        [Validation(Required=false)]
        public bool? SerializeImagePulls { get; set; }

        [NameInMap("systemReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> SystemReserved { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>restricted</para>
        /// </summary>
        [NameInMap("topologyManagerPolicy")]
        [Validation(Required=false)]
        public string TopologyManagerPolicy { get; set; }

        [NameInMap("tracing")]
        [Validation(Required=false)]
        public KubeletConfigTracing Tracing { get; set; }
        public class KubeletConfigTracing : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>localhost:4317</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("samplingRatePerMillion")]
            [Validation(Required=false)]
            public int? SamplingRatePerMillion { get; set; }

        }

    }

}
