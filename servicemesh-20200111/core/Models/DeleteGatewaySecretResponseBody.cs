// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DeleteGatewaySecretResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The records of deleting the secret in all clusters.
        /// </summary>
        [NameInMap("SecretDeleteRecord")]
        [Validation(Required=false)]
        public Dictionary<string, SecretDeleteRecordValue> SecretDeleteRecord { get; set; }

    }

}
