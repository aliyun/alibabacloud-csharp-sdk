// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateKeyPairRequest : TeaModel {
        /// <summary>
        /// The name of the key pair. The name must conform to the following naming conventions:
        /// 
        /// *   The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// *   It must start with a letter but cannot start with `http://` or `https://`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
