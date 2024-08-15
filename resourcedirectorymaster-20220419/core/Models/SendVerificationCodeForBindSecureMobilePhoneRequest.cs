// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SendVerificationCodeForBindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud account ID of the member.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The mobile phone number that you want to bind to the member for security purposes.
        /// 
        /// Specify the mobile phone number in the \\<Country code>-\\<Mobile phone number> format.
        /// 
        /// > Mobile phone numbers in the `86-<Mobile phone number>` format in the Chinese mainland are not supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
