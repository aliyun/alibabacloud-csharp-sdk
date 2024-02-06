// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// The key pair name. The name must conform to the following naming conventions:
        /// 
        /// *   The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// *   It can contain letters, digits, colons (:), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// *   It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// Before you delete a key pair, you can call the DescribeKeyPairs operation to query existing key pairs.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
