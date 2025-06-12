// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreateLoginProfileRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the RAM user must bind a multi-factor authentication (MFA) device upon the next logon. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// <para>The logon password of the RAM user. The password must meet the password strength requirements. For more information, see <a href="https://help.aliyun.com/document_detail/2337691.html">GetPasswordPolicy</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mypassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether the RAM user has to change the password upon logon. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// <para>The name of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangq****</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
