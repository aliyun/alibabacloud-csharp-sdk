// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentEndpointConfig : TeaModel {
        [NameInMap("agentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("customDomainUrl")]
        [Validation(Required=false)]
        public string CustomDomainUrl { get; set; }

        [NameInMap("endpointUrl")]
        [Validation(Required=false)]
        public string EndpointUrl { get; set; }

    }

}
