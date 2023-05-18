// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForEnableRDRequest : TeaModel {
        /// <summary>
        /// The mobile phone number that is bound to the newly created account. If you leave this parameter empty, the mobile phone number that is bound to the current account is used.
        /// 
        /// Specify the mobile phone number in the `<Country code>-<Mobile phone number>` format.
        /// 
        /// >  Mobile phone numbers in the `86-<Mobile phone number>` format in the Chinese mainland are not supported.
        /// </summary>
        [NameInMap("SecureMobilePhone")]
        [Validation(Required=false)]
        public string SecureMobilePhone { get; set; }

    }

}
