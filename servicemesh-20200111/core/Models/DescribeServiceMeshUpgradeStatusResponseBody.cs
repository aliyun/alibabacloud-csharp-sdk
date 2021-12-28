// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UpgradeDetail")]
        [Validation(Required=false)]
        public DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail UpgradeDetail { get; set; }
        public class DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail : TeaModel {
            [NameInMap("FinishedGatewaysNum")]
            [Validation(Required=false)]
            public long? FinishedGatewaysNum { get; set; }
            [NameInMap("GatewayStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, string> GatewayStatusRecord { get; set; }
            [NameInMap("MeshStatus")]
            [Validation(Required=false)]
            public string MeshStatus { get; set; }
            [NameInMap("TotalGatewaysNum")]
            [Validation(Required=false)]
            public long? TotalGatewaysNum { get; set; }
        };

    }

}
