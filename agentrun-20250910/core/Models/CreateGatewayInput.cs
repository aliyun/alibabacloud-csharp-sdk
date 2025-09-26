// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateGatewayInput : TeaModel {
        [NameInMap("identityId")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public GatewayNetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
