// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the database account.
        /// 
        /// > 
        /// 
        /// *   The description cannot start with http:// or https://.
        /// 
        /// *   The description must be 0 to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// 
        /// > 
        /// 
        /// *   The name must be unique in the cluster.
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (\_).
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name must be 2 to 64 characters in length.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the database account.
        /// 
        /// > 
        /// 
        /// *   The password must contain at least three types of the following characters: uppercase letters, lowercase letters, digits, and special characters.
        /// 
        /// *   The password can contain the following special characters: ! @ # $ % ^ & \* ( ) \_ + - =
        /// *   The password must be 8 to 32 characters in length.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
