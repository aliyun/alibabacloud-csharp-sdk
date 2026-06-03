// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SearchAgent20260515.Models
{
    public class ExecuteAcpCommandRequest : TeaModel {
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

    }

}
