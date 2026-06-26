// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class DeleteClientSecretRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        [NameInMap("ClientSecretId")]
        [Validation(Required=false)]
        public string ClientSecretId { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
