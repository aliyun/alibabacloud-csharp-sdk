// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class TriggerConfig : TeaModel {
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

    }

}
