// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateMeshMultiClusterNetworkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The network configuration descriptions of multiple Kubernetes clusters. The key in the map is the ID of a Kubernetes cluster, and the value is the network configuration of the cluster.</para>
        /// </summary>
        [NameInMap("MultiClusterNetworks")]
        [Validation(Required=false)]
        public string MultiClusterNetworksShrink { get; set; }

        /// <summary>
        /// <para>The ID of the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
