// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportKeyPairRequest : TeaModel {
        /// <summary>
        /// The name of the key pair. The name must conform to the following naming conventions:
        /// 
        /// *   The name must be 2 to 128 characters in length.
        /// *   The name must start with a letter but cannot start with `http://` or `https://`.
        /// *   The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// 
        /// You can specify the name of only one key pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// The public key of the key pair. You can specify only one public key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PublicKeyBody")]
        [Validation(Required=false)]
        public string PublicKeyBody { get; set; }

    }

}
