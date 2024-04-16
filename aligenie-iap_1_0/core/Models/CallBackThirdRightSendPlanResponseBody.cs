// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CallBackThirdRightSendPlanResponseBody : TeaModel {
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public string RetCode { get; set; }

        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public bool? RetValue { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
