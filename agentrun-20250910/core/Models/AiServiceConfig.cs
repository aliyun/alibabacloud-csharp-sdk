// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AiServiceConfig : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("apiKeys")]
        [Validation(Required=false)]
        public List<string> ApiKeys { get; set; }

        [NameInMap("enableHealthCheck")]
        [Validation(Required=false)]
        public bool? EnableHealthCheck { get; set; }

        [NameInMap("protocols")]
        [Validation(Required=false)]
        public List<string> Protocols { get; set; }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
