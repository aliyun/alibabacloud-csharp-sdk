// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ChangePasswordRequest : TeaModel {
        /// <summary>
        /// The new password that is used to log on to the console.
        /// 
        /// The password must meet the complexity requirements. For more information, see [GetPasswordPolicy](~~186691~~).
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// The old password that is used to log on to the console.
        /// </summary>
        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

    }

}
