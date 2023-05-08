// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// The upgrade results.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of ingress gateways that are upgraded.
        /// </summary>
        [NameInMap("UpgradeDetail")]
        [Validation(Required=false)]
        public DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail UpgradeDetail { get; set; }
        public class DescribeServiceMeshUpgradeStatusResponseBodyUpgradeDetail : TeaModel {
            /// <summary>
            /// The status of the ASM instance. Valid values:
            /// 
            /// *   running: The instance is running.
            /// *   `upgrading`: The instance is being upgraded.
            /// *   `upgrading_failed`: The upgrade of the instance fails.
            /// </summary>
            [NameInMap("FinishedGatewaysNum")]
            [Validation(Required=false)]
            public long? FinishedGatewaysNum { get; set; }

            [NameInMap("GatewayStatusRecord")]
            [Validation(Required=false)]
            public Dictionary<string, UpgradeDetailGatewayStatusRecordValue> GatewayStatusRecord { get; set; }

            /// <summary>
            /// The total number of ingress gateways in the ASM instance.
            /// </summary>
            [NameInMap("MeshStatus")]
            [Validation(Required=false)]
            public string MeshStatus { get; set; }

            /// <summary>
            /// The information about the status of the ingress gateways.
            /// </summary>
            [NameInMap("TotalGatewaysNum")]
            [Validation(Required=false)]
            public long? TotalGatewaysNum { get; set; }

        }

    }

}
