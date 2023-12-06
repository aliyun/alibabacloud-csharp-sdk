// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckAccountNameAvailableRequest : TeaModel {
        /// <summary>
        /// The username of the account.
        /// 
        /// *   The value must be unique.
        /// 
        /// *   The value must start with a lowercase letter, and end with a lowercase letter or a digit.
        /// 
        /// *   The value can contain lowercase letters, digits, and underscores (\_).
        /// 
        /// *   The length of the value must meet the following requirements:
        /// 
        ///     *   If the instance runs MySQL 5.7 or MySQL 8.0, the value must be 2 to 32 characters in length.
        ///     *   If the instance runs MySQL 5.6, the value must be 2 to 16 characters in length.
        ///     *   If the instance runs SQL Server, the value must be 2 to 64 characters in length.
        ///     *   If the instance runs PostgreSQL with cloud disks, the value must be 2 to 63 characters in length.
        ///     *   If the instance runs PostgreSQL with local disks, the value must be 2 to 16 characters in length.
        ///     *   If the instance runs MariaDB, the value must be 2 to 16 characters in length.
        /// 
        /// *   For more information about invalid characters, see [Forbidden keywords table](~~26317~~).
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
