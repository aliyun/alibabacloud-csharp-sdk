// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordExpirationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The list of effective authentication source IDs.</para>
        /// </summary>
        [NameInMap("EffectiveAuthenticationSourceIds")]
        [Validation(Required=false)]
        public List<string> EffectiveAuthenticationSourceIds { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The action to take when a password expires. This parameter is required when PasswordExpirationStatus is set to enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>forbid_login: Prohibit logon.</description></item>
        /// <item><description>force_update_password: Force password change.</description></item>
        /// <item><description>remind_update_password: Remind to change password.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>force_update_password</para>
        /// </summary>
        [NameInMap("PasswordExpirationAction")]
        [Validation(Required=false)]
        public string PasswordExpirationAction { get; set; }

        /// <summary>
        /// <para>The list of password expiration notification channels. This parameter is required when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationChannels")]
        [Validation(Required=false)]
        public List<string> PasswordExpirationNotificationChannels { get; set; }

        /// <summary>
        /// <para>The password expiration notification time, in days. This parameter is required when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationDuration")]
        [Validation(Required=false)]
        public int? PasswordExpirationNotificationDuration { get; set; }

        /// <summary>
        /// <para>The password expiration notification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationNotificationStatus { get; set; }

        /// <summary>
        /// <para>The password expiration configuration status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: Enabled.</description></item>
        /// <item><description>disabled: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordExpirationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationStatus { get; set; }

        /// <summary>
        /// <para>The forced password change time, in days. The value of this parameter must be greater than the value of PasswordExpirationNotificationDuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordForcedUpdateDuration")]
        [Validation(Required=false)]
        public int? PasswordForcedUpdateDuration { get; set; }

        /// <summary>
        /// <para>The validity period of a password, in days. This parameter is required when PasswordExpirationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("PasswordValidMaxDay")]
        [Validation(Required=false)]
        public int? PasswordValidMaxDay { get; set; }

    }

}
