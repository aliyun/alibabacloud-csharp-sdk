// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeSecretRequest : TeaModel {
        /// <summary>
        /// The ID of the namespace in which the Secret instance resides. By default, the namespace ID is the same as the region ID.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The ID of the Secret instance to be queried. You can call the [ListSecrets](~~466929~~) operation to view the IDs of Secrete instances.
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public long? SecretId { get; set; }

    }

}
