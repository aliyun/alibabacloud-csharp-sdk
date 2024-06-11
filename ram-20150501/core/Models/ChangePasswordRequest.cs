// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ChangePasswordRequest : TeaModel {
        /// <summary>
        /// The new password that is used to log on to the Alibaba Cloud Management Console.
        /// 
        /// The password must meet the complexity requirements. For more information, see [SetPasswordPolicy](https://help.aliyun.com/document_detail/28739.html).
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// The old password that is used to log on to the Alibaba Cloud Management Console.
        /// </summary>
        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

    }

}
