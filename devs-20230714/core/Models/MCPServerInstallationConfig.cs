// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class MCPServerInstallationConfig : TeaModel {
        [NameInMap("args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("env")]
        [Validation(Required=false)]
        public Dictionary<string, string> Env { get; set; }

        [NameInMap("transportType")]
        [Validation(Required=false)]
        public string TransportType { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
