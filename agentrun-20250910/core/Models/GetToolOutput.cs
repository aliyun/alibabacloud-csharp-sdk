// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetToolOutput : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ToolInfo Data { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
