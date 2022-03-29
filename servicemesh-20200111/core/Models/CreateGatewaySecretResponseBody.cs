// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateGatewaySecretResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretCreateRecord")]
        [Validation(Required=false)]
        public Dictionary<string, SecretCreateRecordValue> SecretCreateRecord { get; set; }

    }

}
