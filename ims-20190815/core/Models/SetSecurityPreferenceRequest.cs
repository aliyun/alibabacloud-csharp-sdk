// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetSecurityPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether RAM users can manage their own passwords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default)</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <para>Specifies whether RAM users can log on using passkeys. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default)</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <para>Specifies whether RAM users can manage their own AccessKey pairs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true:</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
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
        /// <item><description><para>true (default)</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <para>Specifies whether RAM users can attach or detach their personal DingTalk accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default)</para>
        /// </description></item>
        /// <item><description><para>false</para>
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
        /// <para>Specifies whether to save the multi-factor authentication (MFA) status for seven days after a RAM user logs on using MFA. Valid values:</para>
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
        [NameInMap("EnableSaveMFATicket")]
        [Validation(Required=false)]
        public bool? EnableSaveMFATicket { get; set; }

        /// <summary>
        /// <para>Specifies the IP addresses or CIDR blocks from which RAM users are allowed to sign in to the Alibaba Cloud console.</para>
        /// <list type="bullet">
        /// <item><description><para>This restriction applies to both password-based and single sign-on (SSO) logons.</para>
        /// </description></item>
        /// <item><description><para>It does not affect API calls made with an AccessKey pair.</para>
        /// </description></item>
        /// <item><description><para>If a mask is not configured, logons are allowed from any IP address.</para>
        /// </description></item>
        /// </list>
        /// <para>Separate multiple entries with a semicolon (<c>;</c>). For example: 192.168.0.0/16;10.0.0.0/8.</para>
        /// <para>The mask is limited to a maximum of 40 entries and a total length of 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

        /// <summary>
        /// <para>The duration of a logon session for a RAM user.</para>
        /// <para>Valid values: 1 to 24. Unit: hours.</para>
        /// <para>Default value: 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("LoginSessionDuration")]
        [Validation(Required=false)]
        public int? LoginSessionDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether MFA is required for logon. This parameter replaces <c>EnforceMFAForLogin</c>. The <c>EnforceMFAForLogin</c> parameter is still valid, but using this new parameter is recommended. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>mandatory: Enforces MFA for all RAM users. This value corresponds to <c>true</c> for the <c>EnforceMFAForLogin</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>independent (default): The MFA requirement depends on the configuration of each RAM user. This value corresponds to <c>false</c> for the <c>EnforceMFAForLogin</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>adaptive: Enforces MFA only for abnormal logons.</para>
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
        /// <para>The maximum number of days that a RAM user\&quot;s AccessKey pair can be idle. If an AccessKey pair is not used within the specified period, it is automatically disabled the next day. Valid values:</para>
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
        /// <para>The maximum number of days that a RAM user can be idle. If a RAM user with console logon enabled does not log on within this period, their console logon is automatically disabled the next day. This setting does not apply to single sign-on (SSO) logons. Valid values:</para>
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
