// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateLoginProfileRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the RAM user must enable multi-factor authentication (MFA). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: MFA is required. The RAM user must bind an MFA device at the next logon.</para>
        /// </description></item>
        /// <item><description><para>false (default): MFA is not required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// <para>The logon password for the RAM user.</para>
        /// <para>The password must meet the password strength requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mypassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether the RAM user must reset the password at the next logon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-based logon for the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Active (default): Enables logon.</para>
        /// </description></item>
        /// <item><description><para>Inactive: Disables logon.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
