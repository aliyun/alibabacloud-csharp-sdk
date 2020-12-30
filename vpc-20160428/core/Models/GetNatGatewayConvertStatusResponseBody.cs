// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatGatewayConvertStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DstNatType")]
        [Validation(Required=false)]
        public string DstNatType { get; set; }

        [NameInMap("ConvertSteps")]
        [Validation(Required=false)]
        public List<GetNatGatewayConvertStatusResponseBodyConvertSteps> ConvertSteps { get; set; }
        public class GetNatGatewayConvertStatusResponseBodyConvertSteps : TeaModel {
            [NameInMap("StepStartTime")]
            [Validation(Required=false)]
            public string StepStartTime { get; set; }

            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

        }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
