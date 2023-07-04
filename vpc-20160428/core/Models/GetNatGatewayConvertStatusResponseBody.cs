// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayConvertStatusResponseBody : TeaModel {
        /// <summary>
        /// The status during the switch.
        /// </summary>
        [NameInMap("ConvertSteps")]
        [Validation(Required=false)]
        public List<GetNatGatewayConvertStatusResponseBodyConvertSteps> ConvertSteps { get; set; }
        public class GetNatGatewayConvertStatusResponseBodyConvertSteps : TeaModel {
            /// <summary>
            /// Valid values:
            /// 
            /// *   **init**: initializing
            /// *   **check**: checking configurations
            /// *   **configure**: pushing configurations
            /// *   **activate**: switching
            /// *   **conf_delete**: deleting configurations
            /// *   **rollback**: rolling back
            /// *   **end_success**: switched
            /// *   **end_fail**: failed
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// The time when the switch started.
            /// </summary>
            [NameInMap("StepStartTime")]
            [Validation(Required=false)]
            public string StepStartTime { get; set; }

            /// <summary>
            /// The switch status. Valid values:
            /// 
            /// *   **processing**: switching
            /// *   **successful**: switched
            /// *   **failed**: failed
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

        /// <summary>
        /// The type of the NAT gateway. Set the value to **Enhanced**, which specifies an enhanced Internet NAT gateway.
        /// </summary>
        [NameInMap("DstNatType")]
        [Validation(Required=false)]
        public string DstNatType { get; set; }

        /// <summary>
        /// The ID of the Internet NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
