// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordExpirationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password expiration configurations.</para>
        /// </summary>
        [NameInMap("PasswordExpirationConfiguration")]
        [Validation(Required=false)]
        public GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration PasswordExpirationConfiguration { get; set; }
        public class GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration : TeaModel {
            /// <summary>
            /// <para>The list of valid authentication IDs. The default is all [&quot;ia_all&quot;]</para>
            /// <para>ia_all: All. If you fill in this value, you cannot fill in other values</para>
            /// <para>ia_password: Account password login</para>
            /// <para>ia_otp_sms: SMS verification code login method</para>
            /// <para>ia_webauthn: WebAuthn authenticator login method</para>
            /// <para>idp_xxx: Specific identity provider authentication method</para>
            /// </summary>
            [NameInMap("EffectiveAuthenticationSourceIds")]
            [Validation(Required=false)]
            public List<string> EffectiveAuthenticationSourceIds { get; set; }

            /// <summary>
            /// <para>The action to take when a password expires. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>forbid_login: Prohibit the user from using the password to log on to IDaaS.</description></item>
            /// <item><description>force_update_password: Force the user to change the password.</description></item>
            /// <item><description>remind_update_password: Remind the user to change the password.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>forbid_login</para>
            /// </summary>
            [NameInMap("PasswordExpirationAction")]
            [Validation(Required=false)]
            public string PasswordExpirationAction { get; set; }

            /// <summary>
            /// <para>The methods for receiving password expiration notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login</para>
            /// </summary>
            [NameInMap("PasswordExpirationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordExpirationNotificationChannels { get; set; }

            /// <summary>
            /// <para>The number of days before the expiration date during which password expiration notifications are sent. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("PasswordExpirationNotificationDuration")]
            [Validation(Required=false)]
            public int? PasswordExpirationNotificationDuration { get; set; }

            /// <summary>
            /// <para>Indicates whether the password expiration notification feature is enabled. Valid values:</para>
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
            /// <para>Indicates whether the password expiration feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled</description></item>
            /// <item><description>disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordExpirationStatus")]
            [Validation(Required=false)]
            public string PasswordExpirationStatus { get; set; }

            /// <summary>
            /// <para>The number of days before which users must change the password to prevent password expiration. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PasswordForcedUpdateDuration")]
            [Validation(Required=false)]
            public int? PasswordForcedUpdateDuration { get; set; }

            /// <summary>
            /// <para>The validity period of a password. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("PasswordValidMaxDay")]
            [Validation(Required=false)]
            public int? PasswordValidMaxDay { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
