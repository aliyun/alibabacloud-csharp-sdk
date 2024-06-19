// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ResetAccountPasswordRequest : TeaModel {
        /// <summary>
        /// The name of the account. You can call the [DescribeAccounts](~~DescribeAccounts~~) operation to obtain the name of the account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The new password for the account. The password must be 8 to 32 characters in length. It must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include `!@ # $ % ^ & * ( ) _ + - =`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The ID of the instance to which the account belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
