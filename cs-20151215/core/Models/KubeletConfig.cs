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

        [NameInMap("containerLogMaxFiles")]
        [Validation(Required=false)]
        public long? ContainerLogMaxFiles { get; set; }

        [NameInMap("containerLogMaxSize")]
        [Validation(Required=false)]
        public string ContainerLogMaxSize { get; set; }

        [NameInMap("cpuManagerPolicy")]
        [Validation(Required=false)]
        public string CpuManagerPolicy { get; set; }

        [NameInMap("eventBurst")]
        [Validation(Required=false)]
        public long? EventBurst { get; set; }

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

        [NameInMap("kubeAPIBurst")]
        [Validation(Required=false)]
        public long? KubeAPIBurst { get; set; }

        [NameInMap("kubeAPIQPS")]
        [Validation(Required=false)]
        public long? KubeAPIQPS { get; set; }

        [NameInMap("kubeReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> KubeReserved { get; set; }

        [NameInMap("maxPods")]
        [Validation(Required=false)]
        public long? MaxPods { get; set; }

        [NameInMap("readOnlyPort")]
        [Validation(Required=false)]
        public long? ReadOnlyPort { get; set; }

        [NameInMap("registryBurst")]
        [Validation(Required=false)]
        public long? RegistryBurst { get; set; }

        [NameInMap("registryPullQPS")]
        [Validation(Required=false)]
        public long? RegistryPullQPS { get; set; }

        [NameInMap("serializeImagePulls")]
        [Validation(Required=false)]
        public bool? SerializeImagePulls { get; set; }

        [NameInMap("systemReserved")]
        [Validation(Required=false)]
        public Dictionary<string, object> SystemReserved { get; set; }

    }

}
