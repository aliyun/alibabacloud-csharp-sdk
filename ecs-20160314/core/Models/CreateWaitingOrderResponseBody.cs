// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateWaitingOrderResponseBody : TeaModel {
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public string DryRunResult { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WaitTimeCycle")]
        [Validation(Required=false)]
        public string WaitTimeCycle { get; set; }

        [NameInMap("WaitTimeValue")]
        [Validation(Required=false)]
        public int? WaitTimeValue { get; set; }

        [NameInMap("WaitingOrderId")]
        [Validation(Required=false)]
        public string WaitingOrderId { get; set; }

    }

}
