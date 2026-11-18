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
            /// <item><description>ia_all: All. If you specify this value, you cannot specify other values.</description></item>
            /// <item><description>ia_password: Account password logon.</description></item>
            /// <item><description>ia_otp_sms: SMS verification code logon.</description></item>
            /// <item><description>ia_webauthn: WebAuthn authenticator logon.</description></item>
            /// <item><description>idp_xxx: A specific identity provider (IdP) authentication method.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("EffectiveAuthenticationSourceIds")]
            [Validation(Required=false)]
            public List<string> EffectiveAuthenticationSourceIds { get; set; }

            /// <summary>
            /// <para>The password expiration action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>forbid_login: Prohibits logon.</description></item>
            /// <item><description>force_update_password: Forces a password change.</description></item>
            /// <item><description>remind_update_password: Reminds the user to change the password.</description></item>
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
            /// <para>[&quot;login&quot;]</para>
            /// </summary>
            [NameInMap("PasswordExpirationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordExpirationNotificationChannels { get; set; }

            /// <summary>
            /// <para>The password expiration notification period, in days.</para>
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
            /// <para>The password expiration status. Valid values:</para>
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
            /// <para>The forced password change period, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateDuration")]
            [Validation(Required=false)]
            public int? PasswordForcedUpdateDuration { get; set; }

            /// <summary>
            /// <para>The password validity period, in days.</para>
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
