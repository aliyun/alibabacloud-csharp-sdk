// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class EnableResourceDirectoryRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The mode in which you enable a resource directory. Valid values:
        /// 
        /// *   CurrentAccount: The current account is used to enable a resource directory.
        /// *   NewManagementAccount: A newly created account is used to enable a resource directory. If you select this mode, you must configure the `MAName`, `MASecureMobilePhone`, and `VerificationCode` parameters.
        /// </summary>
        [NameInMap("EnableMode")]
        [Validation(Required=false)]
        public string EnableMode { get; set; }

        /// <summary>
        /// The name of the newly created account.
        /// 
        /// Specify the name in the `<Prefix>@rdadmin.aliyunid.com` format. The prefix can contain letters, digits, and special characters but cannot contain consecutive special characters. The prefix must start and end with a letter or digit. Valid special characters include underscores (`_`), periods (.), and hyphens (-). The prefix must be 2 to 50 characters in length.
        /// </summary>
        [NameInMap("MAName")]
        [Validation(Required=false)]
        public string MAName { get; set; }

        /// <summary>
        /// The mobile phone number that is bound to the newly created account.
        /// 
        /// If you leave this parameter empty, the mobile phone number that is bound to the current account is used. The mobile phone number you specify must be the same as the mobile phone number that you specify when you call the [SendVerificationCodeForEnableRD](~~SendVerificationCodeForEnableRD~~) operation to obtain a verification code.
        /// 
        /// Specify the mobile phone number in the `<Country code>-<Mobile phone number>` format.
        /// 
        /// > Mobile phone numbers in the `86-<Mobile phone number>` format in the Chinese mainland are not supported.
        /// </summary>
        [NameInMap("MASecureMobilePhone")]
        [Validation(Required=false)]
        public string MASecureMobilePhone { get; set; }

        /// <summary>
        /// The verification code.
        /// 
        /// You can call the [SendVerificationCodeForEnableRD](~~SendVerificationCodeForEnableRD~~) operation to obtain the verification code.
        /// </summary>
        [NameInMap("VerificationCode")]
        [Validation(Required=false)]
        public string VerificationCode { get; set; }

    }

}
