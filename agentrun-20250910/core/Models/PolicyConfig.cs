// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PolicyConfig : TeaModel {
        [NameInMap("aiFallbackConfig")]
        [Validation(Required=false)]
        public AiFallbackConfig AiFallbackConfig { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
