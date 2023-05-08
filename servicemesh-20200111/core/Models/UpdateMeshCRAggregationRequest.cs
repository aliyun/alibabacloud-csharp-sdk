// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshCRAggregationRequest : TeaModel {
        /// <summary>
        /// The maximum number of CPU cores that are available for the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes.
        /// </summary>
        [NameInMap("CPULimit")]
        [Validation(Required=false)]
        public string CPULimit { get; set; }

        /// <summary>
        /// The number of CPU cores that are requested by the components installed in the Container Service for Kubernetes (ACK) cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes.
        /// </summary>
        [NameInMap("CPURequirement")]
        [Validation(Required=false)]
        public string CPURequirement { get; set; }

        /// <summary>
        /// Specifies whether to enable the Kubernetes API on the data plane to access Istio resources in the ASM instance. Valid values:
        /// 
        /// *   `true`: enables the Kubernetes API to access Istio resources in the ASM instance.
        /// *   `false`: does not enable the Kubernetes API to access Istio resources in the ASM instance.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available for the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes. 1 Mi equals 1,024 KB.
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// The size of the memory that is requested by the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes. 1 Mi equals 1,024 KB.
        /// </summary>
        [NameInMap("MemoryRequirement")]
        [Validation(Required=false)]
        public string MemoryRequirement { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud Service Mesh (ASM) instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// Specifies whether the Kubernetes API on the data plane uses the public endpoint of the API server to access Istio resources in the ASM instance. Valid values:
        /// 
        /// *   `true`: The Kubernetes API on the data plane uses the public endpoint of the API server to access Istio resources in the ASM instance.
        /// *   `false`: The Kubernetes API on the data plane uses the private endpoint of the API server to access Istio resources in the ASM instance.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("UsePublicApiServer")]
        [Validation(Required=false)]
        public bool? UsePublicApiServer { get; set; }

    }

}
