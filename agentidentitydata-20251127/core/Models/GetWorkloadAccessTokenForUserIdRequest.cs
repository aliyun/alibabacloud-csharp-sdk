// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetWorkloadAccessTokenForUserIdRequest : TeaModel {
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WorkloadIdentityName")]
        [Validation(Required=false)]
        public string WorkloadIdentityName { get; set; }

    }

}
