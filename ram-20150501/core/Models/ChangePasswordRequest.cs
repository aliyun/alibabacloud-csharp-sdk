// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ChangePasswordRequest : TeaModel {
        /// <summary>
        /// <para>The new console logon password of the Resource Access Management (RAM) user.</para>
        /// <para>The password must meet the password strength requirements. For more information, see <a href="https://help.aliyun.com/document_detail/28739.html">SetPasswordPolicy</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aw$2****</para>
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// <para>The old console logon password of the Resource Access Management (RAM) user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

    }

}
