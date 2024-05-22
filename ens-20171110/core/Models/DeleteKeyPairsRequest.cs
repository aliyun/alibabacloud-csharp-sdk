// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        /// <summary>
        /// The ID of the SSH key pair.
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// The name of the key pair. The name must conform to the following naming conventions:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter and cannot start with `http://` or `https://`.
        /// *   The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// 
        /// Before you delete a key pair, you can call the DescribeKeyPairs operation to query existing key pairs.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
