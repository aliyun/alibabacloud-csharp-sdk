// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolClientRequest : TeaModel {
        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
