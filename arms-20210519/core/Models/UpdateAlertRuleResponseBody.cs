// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class UpdateAlertRuleResponseBody : TeaModel {
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
