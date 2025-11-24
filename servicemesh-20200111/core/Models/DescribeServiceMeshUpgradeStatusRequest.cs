// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusRequest : TeaModel {
        /// <summary>
        /// <para>The fully qualified names of ingress gateways in the ASM instance. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>istio-system:ingressgateway1,istio-system:ingressgateway2</para>
        /// </summary>
        [NameInMap("AllIstioGatewayFullNames")]
        [Validation(Required=false)]
        public string AllIstioGatewayFullNames { get; set; }

        /// <summary>
        /// <para>The IDs of the clusters on the data plane of the ASM instance. Separate multiple clusters with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeac85a793c94afbbb0a4bb20320****</para>
        /// </summary>
        [NameInMap("GuestClusterIds")]
        [Validation(Required=false)]
        public string GuestClusterIds { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11fd0027-c27e-41bb-a565-75583054****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
