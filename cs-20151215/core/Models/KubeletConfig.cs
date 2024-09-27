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

    }

}
