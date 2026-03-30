// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateLoginProfileRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully enable multi-factor authentication (MFA) for the RAM user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcefully enables MFA for the RAM user. The RAM user must bind an MFA device upon the next logon.</description></item>
        /// <item><description>false (default): does not forcefully enable MFA for the RAM user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MFABindRequired")]
        [Validation(Required=false)]
        public bool? MFABindRequired { get; set; }

        /// <summary>
        /// <para>The password that the RAM user uses to log on to the console.</para>
        /// <para>The password must meet the complexity requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mypassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether the RAM user is required to reset the password upon the next logon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordResetRequired")]
        [Validation(Required=false)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-based logons to the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: Password-based logon is enabled. This is the default value.</description></item>
        /// <item><description>Inactive: Password-based logon is disabled.</description></item>
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
