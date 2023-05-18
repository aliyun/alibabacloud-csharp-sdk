// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForBindSecureMobilePhoneRequest : TeaModel {
        /// <summary>
        /// The ID of the resource account.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The mobile phone number that you want to bind to the resource account.
        /// 
        /// Specify the mobile phone number in the \<Country code>-\<Mobile phone number> format.
        /// 
        /// >  Mobile phone numbers in the `86-<Mobile phone number>` format in the Chinese mainland are not supported.
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
