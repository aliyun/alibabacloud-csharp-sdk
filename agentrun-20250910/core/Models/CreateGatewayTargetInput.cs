// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateGatewayTargetInput : TeaModel {
        [NameInMap("domainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("targetConfiguration")]
        [Validation(Required=false)]
        public TargetConfiguration TargetConfiguration { get; set; }

    }

}
