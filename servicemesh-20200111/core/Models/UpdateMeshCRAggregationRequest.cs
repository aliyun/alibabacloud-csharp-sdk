// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshCRAggregationRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of CPU cores that are available for the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CPULimit")]
        [Validation(Required=false)]
        public string CPULimit { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that are requested by the components installed in the Container Service for Kubernetes (ACK) cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CPURequirement")]
        [Validation(Required=false)]
        public string CPURequirement { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Kubernetes API on the data plane to access Istio resources in the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the Kubernetes API to access Istio resources in the ASM instance.</description></item>
        /// <item><description><c>false</c>: disables the Kubernetes API to access Istio resources in the ASM instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The maximum size of the memory that is available for the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes. 1 Mi equals 1,024 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500Mi</para>
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// <para>The size of the memory that is requested by the components installed in the ACK cluster on the data plane if you enable the Kubernetes API to access Istio resources in the ASM instance. You can specify the parameter value in the standard quantity representation used by Kubernetes. 1 Mi equals 1,024 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500Mi</para>
        /// </summary>
        [NameInMap("MemoryRequirement")]
        [Validation(Required=false)]
        public string MemoryRequirement { get; set; }

        /// <summary>
        /// <para>The Service Mesh (ASM) instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>Specifies whether the Kubernetes API on the data plane uses the public endpoint of the API server to access Istio resources in the ASM instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The Kubernetes API on the data plane uses the public endpoint of the API server to access Istio resources in the ASM instance.</description></item>
        /// <item><description><c>false</c>: The Kubernetes API on the data plane uses the private endpoint of the API server to access Istio resources in the ASM instance.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UsePublicApiServer")]
        [Validation(Required=false)]
        public bool? UsePublicApiServer { get; set; }

    }

}
