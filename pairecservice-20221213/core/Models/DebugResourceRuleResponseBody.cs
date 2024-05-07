// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class DebugResourceRuleResponseBody : TeaModel {
        [NameInMap("CurrentValues")]
        [Validation(Required=false)]
        public Dictionary<string, object> CurrentValues { get; set; }

        [NameInMap("OutputValues")]
        [Validation(Required=false)]
        public Dictionary<string, object> OutputValues { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
