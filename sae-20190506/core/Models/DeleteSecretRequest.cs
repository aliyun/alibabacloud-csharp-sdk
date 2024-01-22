// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteSecretRequest : TeaModel {
        /// <summary>
        /// The ID of the namespace in which the Secret resides. By default, the namespace ID is the same as the region ID.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The ID of the Secret to be deleted. You can call the [ListSecrets](~~466929~~) operation to view the Secret IDs.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public long? SecretId { get; set; }

    }

}
