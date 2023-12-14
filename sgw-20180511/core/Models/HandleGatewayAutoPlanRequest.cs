// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class HandleGatewayAutoPlanRequest : TeaModel {
        [NameInMap("Cancel")]
        [Validation(Required=false)]
        public bool? Cancel { get; set; }

        [NameInMap("DelayHours")]
        [Validation(Required=false)]
        public int? DelayHours { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
