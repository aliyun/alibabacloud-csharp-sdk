// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayRoutesResponseBody : TeaModel {
        [NameInMap("ManagementRoutes")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayRoutesResponseBodyManagementRoutes> ManagementRoutes { get; set; }
        public class DescribeIstioGatewayRoutesResponseBodyManagementRoutes : TeaModel {
            [NameInMap("ASMGatewayName")]
            [Validation(Required=false)]
            public string ASMGatewayName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RouteName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

            [NameInMap("RoutePath")]
            [Validation(Required=false)]
            public string RoutePath { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
