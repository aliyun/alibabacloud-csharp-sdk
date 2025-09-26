// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CustomRuntimeConfig : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
