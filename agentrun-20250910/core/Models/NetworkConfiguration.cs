// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class NetworkConfiguration : TeaModel {
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("vswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
