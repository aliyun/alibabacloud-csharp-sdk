// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioGatewayRoutesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo route</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the routing rule to be updated for the ASM gateway.</para>
        /// </summary>
        [NameInMap("GatewayRoute")]
        [Validation(Required=false)]
        public string GatewayRouteShrink { get; set; }

        /// <summary>
        /// <para>The name of the ASM gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// <para>The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The status of the routing rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c>: The routing rule is valid.</description></item>
        /// <item><description><c>1</c>: The routing rule is invalid.</description></item>
        /// <item><description><c>2</c>: An error occurs during the creation or update of the routing rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
