// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordExpirationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password expiration configuration.</para>
        /// </summary>
        [NameInMap("PasswordExpirationConfiguration")]
        [Validation(Required=false)]
        public GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration PasswordExpirationConfiguration { get; set; }
        public class GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of effective authentication source IDs. Default value: [&quot;ia_all&quot;].</para>
            /// <list type="bullet">
            /// <item><description>ia_all: All authentication sources. If this value is specified, no other values can be specified.</description></item>
            /// <item><description>ia_password: Account password logon.</description></item>
            /// <item><description>ia_otp_sms: SMS verification code logon.</description></item>
            /// <item><description>ia_webauthn: WebAuthn authenticator logon.</description></item>
            /// <item><description>idp_xxx: Authentication method of a specific identity provider.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("EffectiveAuthenticationSourceIds")]
            [Validation(Required=false)]
            public List<string> EffectiveAuthenticationSourceIds { get; set; }

            /// <summary>
            /// <para>The action to take when a password expires. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>forbid_login: Forbid logon.</description></item>
            /// <item><description>force_update_password: Force password change.</description></item>
            /// <item><description>remind_update_password: Remind password change.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>forbid_login</para>
            /// </summary>
            [NameInMap("PasswordExpirationAction")]
            [Validation(Required=false)]
            public string PasswordExpirationAction { get; set; }

            /// <summary>
            /// <para>The list of password expiration notification channels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login</para>
            /// </summary>
            [NameInMap("PasswordExpirationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordExpirationNotificationChannels { get; set; }

            /// <summary>
            /// <para>The advance notice period before password expiration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("PasswordExpirationNotificationDuration")]
            [Validation(Required=false)]
            public int? PasswordExpirationNotificationDuration { get; set; }

            /// <summary>
            /// <para>The status of password expiration notification. Valid values:</para>
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
            /// <para>The status of the password expiration configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordExpirationStatus")]
            [Validation(Required=false)]
            public string PasswordExpirationStatus { get; set; }

            /// <summary>
            /// <para>The grace period for forced password change after expiration. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateDuration")]
            [Validation(Required=false)]
            public int? PasswordForcedUpdateDuration { get; set; }

            /// <summary>
            /// <para>The maximum validity period of a password. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("PasswordValidMaxDay")]
            [Validation(Required=false)]
            public int? PasswordValidMaxDay { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
