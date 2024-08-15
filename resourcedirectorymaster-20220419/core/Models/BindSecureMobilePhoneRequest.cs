// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class BindSecureMobilePhoneRequest : TeaModel {
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
        /// The mobile phone number you specify must be the same as the mobile phone number that you specify when you call the [SendVerificationCodeForBindSecureMobilePhone](~~SendVerificationCodeForBindSecureMobilePhone~~) operation to obtain a verification code.
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

        /// <summary>
        /// The verification code.
        /// 
        /// You can call the [SendVerificationCodeForBindSecureMobilePhone](~~SendVerificationCodeForBindSecureMobilePhone~~) operation to obtain the verification code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
