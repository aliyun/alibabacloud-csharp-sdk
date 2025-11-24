// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServiceEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the registered service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8b054ee8c3914d079b5ce9733328****,c58faedb8a78640d3aeb0372e4c02****</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        /// <summary>
        /// <para>The type of the registered service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ServiceEntry</c>: indicates that the service is registered by creating a service entry.</description></item>
        /// <item><description><c>Kubernetes</c>: indicates that the service is registered on a Kubernetes cluster on the data plane.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>reviews</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of clusters in the ASM instance. Separate multiple cluster IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The endpoints of the registered service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

    }

}
