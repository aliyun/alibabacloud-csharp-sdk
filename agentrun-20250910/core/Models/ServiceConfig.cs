// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ServiceConfig : TeaModel {
        [NameInMap("aiServiceConfig")]
        [Validation(Required=false)]
        public AiServiceConfig AiServiceConfig { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
