// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetSecurityPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether RAM users can change their own passwords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Allowed.</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToChangePassword")]
        [Validation(Required=false)]
        public bool? AllowUserToChangePassword { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can use passkeys to log on to the console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Allowed.</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToLoginWithPasskey")]
        [Validation(Required=false)]
        public bool? AllowUserToLoginWithPasskey { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their own AccessKeys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allowed.</para>
        /// </description></item>
        /// <item><description><para>false (default): Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserToManageAccessKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManageAccessKeys { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their own MFA devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Allowed.</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToManageMFADevices")]
        [Validation(Required=false)]
        public bool? AllowUserToManageMFADevices { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can link or unlink their personal DingTalk accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Allowed.</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToManagePersonalDingTalk")]
        [Validation(Required=false)]
        public bool? AllowUserToManagePersonalDingTalk { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their own API keys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allowed.</para>
        /// </description></item>
        /// <item><description><para>false: Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserToManageServiceCredentials")]
        [Validation(Required=false)]
        public bool? AllowUserToManageServiceCredentials { get; set; }

        /// <summary>
        /// <para>Specifies whether a RAM user who logs on with multi-factor authentication (MFA) can skip MFA for the next seven days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Allowed.</para>
        /// </description></item>
        /// <item><description><para>false (default): Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSaveMFATicket")]
        [Validation(Required=false)]
        public bool? EnableSaveMFATicket { get; set; }

        /// <summary>
        /// <para>The IP address mask that is used to log on to the console. This mask applies to password-based logons and single sign-on (SSO) logons, but does not affect API calls that are initiated by using an AccessKey pair.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify a mask, RAM users can log on to the console only from the specified IP addresses.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify a mask, RAM users can log on to the console from all IP addresses.</para>
        /// </description></item>
        /// </list>
        /// <para>If you need to specify multiple masks, separate them with semicolons (<c>;</c>). Example: <c>192.168.0.0/16;10.0.0.0/8</c>.</para>
        /// <para>You can specify up to 40 masks. The total length cannot exceed 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

        /// <summary>
        /// <para>The session duration of a RAM user who logs on to the console. Unit: hours.</para>
        /// <para>Valid values: 1 to 24.</para>
        /// <para>Default value: 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("LoginSessionDuration")]
        [Validation(Required=false)]
        public int? LoginSessionDuration { get; set; }

        /// <summary>
        /// <para>Specifies the MFA policy for user logon. This parameter replaces <c>EnforceMFAForLogin</c>. We recommend that you use this parameter. <c>EnforceMFAForLogin</c> is still valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>mandatory</c>: enforces MFA for all RAM users. This is equivalent to setting <c>EnforceMFAForLogin</c> to <c>true</c>.</para>
        /// </description></item>
        /// <item><description><para><c>independent</c> (default): The MFA settings for each RAM user are not affected. This is equivalent to setting <c>EnforceMFAForLogin</c> to <c>false</c>.</para>
        /// </description></item>
        /// <item><description><para><c>adaptive</c>: enforces MFA only for unusual logons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("MFAOperationForLogin")]
        [Validation(Required=false)]
        public string MFAOperationForLogin { get; set; }

        /// <summary>
        /// <para>The maximum idle period of the AccessKey pairs of RAM users. An AccessKey pair that is not used for the specified period of time is automatically disabled on the next day. You can set the value to one of the following numbers:</para>
        /// <list type="bullet">
        /// <item><description><para>90</para>
        /// </description></item>
        /// <item><description><para>180</para>
        /// </description></item>
        /// <item><description><para>365</para>
        /// </description></item>
        /// <item><description><para>730 (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("MaxIdleDaysForAccessKeys")]
        [Validation(Required=false)]
        public int? MaxIdleDaysForAccessKeys { get; set; }

        /// <summary>
        /// <para>The maximum idle period of RAM users. If a RAM user who can log on to the console does not log on to the console for the specified period of time (SSO logons are not included), the console logon feature of the RAM user is disabled on the next day. You can set the value to one of the following numbers:</para>
        /// <list type="bullet">
        /// <item><description><para>90</para>
        /// </description></item>
        /// <item><description><para>180</para>
        /// </description></item>
        /// <item><description><para>365</para>
        /// </description></item>
        /// <item><description><para>730 (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("MaxIdleDaysForUsers")]
        [Validation(Required=false)]
        public int? MaxIdleDaysForUsers { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autonomous</para>
        /// </summary>
        [NameInMap("OperationForRiskLogin")]
        [Validation(Required=false)]
        [Obsolete]
        public string OperationForRiskLogin { get; set; }

        /// <summary>
        /// <para>The MFA methods.</para>
        /// </summary>
        [NameInMap("VerificationTypes")]
        [Validation(Required=false)]
        public List<string> VerificationTypes { get; set; }

    }

}
