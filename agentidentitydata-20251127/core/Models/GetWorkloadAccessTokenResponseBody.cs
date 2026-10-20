// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetWorkloadAccessTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

        [NameInMap("WorkloadIdentityArn")]
        [Validation(Required=false)]
        public string WorkloadIdentityArn { get; set; }

    }

}
