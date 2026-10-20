// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class AssumeRoleForWorkloadIdentityRequest : TeaModel {
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
