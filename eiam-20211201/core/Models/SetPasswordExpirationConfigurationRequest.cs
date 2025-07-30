// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordExpirationConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>Effective authentication sourceIds</para>
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
        /// <para>The action to take upon password expiration. This parameter must be specified when PasswordExpirationStatus is set to enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>forbid_login: Users cannot log on to IDaaS.</description></item>
        /// <item><description>force_update_password: Users must change the password.</description></item>
        /// <item><description>remind_update_password: IDaaS reminds users to change the password upon each logon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>force_update_password</para>
        /// </summary>
        [NameInMap("PasswordExpirationAction")]
        [Validation(Required=false)]
        public string PasswordExpirationAction { get; set; }

        /// <summary>
        /// <para>The methods for receiving password expiration notifications. This parameter must be specified when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationChannels")]
        [Validation(Required=false)]
        public List<string> PasswordExpirationNotificationChannels { get; set; }

        /// <summary>
        /// <para>The number of days before the expiration date during which password expiration notifications are sent. Unit: day. This parameter must be specified when PasswordExpirationNotificationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationDuration")]
        [Validation(Required=false)]
        public int? PasswordExpirationNotificationDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the password expiration notification feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("PasswordExpirationNotificationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationNotificationStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the password expiration feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
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
        /// <para>The number of days before which users must change the password to prevent password expiration. Unit: day. You must set this parameter to a value greater than the value of PasswordExpirationNotificationDuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PasswordForcedUpdateDuration")]
        [Validation(Required=false)]
        public int? PasswordForcedUpdateDuration { get; set; }

        /// <summary>
        /// <para>The validity period of a password. Unit: day. This parameter must be specified when PasswordExpirationStatus is set to enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("PasswordValidMaxDay")]
        [Validation(Required=false)]
        public int? PasswordValidMaxDay { get; set; }

    }

}
