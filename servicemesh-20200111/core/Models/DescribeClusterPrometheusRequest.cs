// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterPrometheusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce3c25e247da24f3aab9b7edfae83****</para>
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cluster on the data plane resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("K8sClusterRegionId")]
        [Validation(Required=false)]
        public string K8sClusterRegionId { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
