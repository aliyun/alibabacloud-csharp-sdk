// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordExpirationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The list of IDs of authentication sources that take effect.</para>
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
        /// <para>The action to be performed when a password expires. This parameter is required when PasswordExpirationStatus is set to enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>forbid_login: Prohibit logon.</description></item>
        /// <item><description>force_update_password: Force the user to change the password.</description></item>
        /// <item><description>remind_update_password: Remind the user to change the password.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>force_update_password</para>
        /// </summary>
        [NameInMap("PasswordExpirationAction")]
        [Validation(Required=false)]
        public string PasswordExpirationAction { get; set; }

        /// <summary>
        /// <para>The list of notification channels for password expiration. This parameter is required when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationChannels")]
        [Validation(Required=false)]
        public List<string> PasswordExpirationNotificationChannels { get; set; }

        /// <summary>
        /// <para>The time when a password expiration notification is sent. Unit: days. This parameter is required when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationDuration")]
        [Validation(Required=false)]
        public int? PasswordExpirationNotificationDuration { get; set; }

        /// <summary>
        /// <para>The status of the password expiration notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: The password expiration notification is enabled.</description></item>
        /// <item><description>disabled: The password expiration notification is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationNotificationStatus { get; set; }

        /// <summary>
        /// <para>The status of the password expiration configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled: The password expiration configuration is enabled.</description></item>
        /// <item><description>disabled: The password expiration configuration is disabled.</description></item>
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
        /// <para>The time when a user is forced to change the password. Unit: days. The value of this parameter must be greater than the value of PasswordExpirationNotificationDuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordForcedUpdateDuration")]
        [Validation(Required=false)]
        public int? PasswordForcedUpdateDuration { get; set; }

        /// <summary>
        /// <para>The validity period of a password in days. This parameter is required when PasswordExpirationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("PasswordValidMaxDay")]
        [Validation(Required=false)]
        public int? PasswordValidMaxDay { get; set; }

    }

}
