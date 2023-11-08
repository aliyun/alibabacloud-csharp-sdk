// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateIstioRouteAdditionalStatusRequest : TeaModel {
        /// <summary>
        /// The description of the routing rule.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// The priority of the routing rule. The value of this parameter is an integer. A smaller value indicates a higher priority.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The name of the routing rule.
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// The status of the routing rule. Valid values: 0: The routing rule is valid. 1: The routing rule is invalid. 2: An error occurs during the creation or update of the routing rule.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
