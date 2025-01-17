// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetSecurityPreferenceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether RAM users can change their passwords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToChangePassword")]
        [Validation(Required=false)]
        public bool? AllowUserToChangePassword { get; set; }

        [NameInMap("AllowUserToLoginWithPasskey")]
        [Validation(Required=false)]
        public bool? AllowUserToLoginWithPasskey { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their AccessKey pairs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUserToManageAccessKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManageAccessKeys { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their MFA devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToManageMFADevices")]
        [Validation(Required=false)]
        public bool? AllowUserToManageMFADevices { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can manage their personal DingTalk accounts, such as binding and unbinding of the accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUserToManagePersonalDingTalk")]
        [Validation(Required=false)]
        public bool? AllowUserToManagePersonalDingTalk { get; set; }

        /// <summary>
        /// <para>Specifies whether RAM users can remember the MFA devices for seven days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSaveMFATicket")]
        [Validation(Required=false)]
        public bool? EnableSaveMFATicket { get; set; }

        /// <summary>
        /// <para>The subnet mask that specifies the IP addresses from which you can log on to the Alibaba Cloud Management Console. This parameter takes effect on password-based logon and single sign-on (SSO). This parameter does not take effect on API calls that are authenticated by using AccessKey pairs.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a subnet mask, RAM users can use only the IP addresses in the subnet mask to log on to the Alibaba Cloud Management Console.</description></item>
        /// <item><description>If you do not specify a subnet mask, RAM users can use all IP addresses to log on to the Alibaba Cloud Management Console.</description></item>
        /// </list>
        /// <para>If you need to specify multiple subnet masks, separate the subnet masks with semicolons (;). Example: 192.168.0.0/16;10.0.0.0/8.</para>
        /// <para>You can specify up to 40 subnet masks. The total length of the subnet masks can be a maximum of 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

        /// <summary>
        /// <para>The validity period of the logon session of RAM users.</para>
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
        /// <para>Specifies whether MFA is required for all RAM users when they log on to the Alibaba Cloud Management Console. This parameter is used to replace EnforceMFAForLogin. EnforceMFAForLogin is still valid. However, we recommend that you use MFAOperationForLogin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mandatory: MFA is required for all RAM users. If you use EnforceMFAForLogin, set the value to true.</description></item>
        /// <item><description>independent (default): User-specific settings are applied. If you use EnforceMFAForLogin, set the value to false.</description></item>
        /// <item><description>adaptive: MFA is required only for RAM users who initiated unusual logons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>adaptive</para>
        /// </summary>
        [NameInMap("MFAOperationForLogin")]
        [Validation(Required=false)]
        public string MFAOperationForLogin { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable MFA for RAM users who initiated unusual logons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>autonomous (default): yes. MFA is prompted for RAM users who initiated unusual logons. However, the RAM users are allowed to skip MFA.</description></item>
        /// <item><description>enforceVerify: MFA is prompted for RAM users who initiated unusual logons and the RAM users cannot skip MFA.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>autonomous</para>
        /// </summary>
        [NameInMap("OperationForRiskLogin")]
        [Validation(Required=false)]
        public string OperationForRiskLogin { get; set; }

        /// <summary>
        /// <para>The MFA methods.</para>
        /// </summary>
        [NameInMap("VerificationTypes")]
        [Validation(Required=false)]
        public List<string> VerificationTypes { get; set; }

    }

}
