// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateGatewaySecretResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The record of creating the secret.
        /// </summary>
        [NameInMap("SecretCreateRecord")]
        [Validation(Required=false)]
        public Dictionary<string, SecretCreateRecordValue> SecretCreateRecord { get; set; }

    }

}
