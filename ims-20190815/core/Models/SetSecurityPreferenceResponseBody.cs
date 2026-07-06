// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class SetSecurityPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17494710-B4BA-4185-BBBB-C1A6ABDE1639</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security preferences.</para>
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public SetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class SetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// <para>The AccessKey preferences.</para>
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// <para>Specifies whether RAM users can manage their own AccessKeys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

                /// <summary>
                /// <para>Specifies whether RAM users can manage their own API keys. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: RAM users can manage their own API keys.</para>
                /// </description></item>
                /// <item><description><para>false: RAM users cannot manage their own API keys.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageServiceCredentials")]
                [Validation(Required=false)]
                public bool? AllowUserToManageServiceCredentials { get; set; }

            }

            /// <summary>
            /// <para>The login preferences.</para>
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// <para>Specifies whether RAM users can manage their own passwords.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowUserToChangePassword")]
                [Validation(Required=false)]
                public bool? AllowUserToChangePassword { get; set; }

                /// <summary>
                /// <para>Specifies whether RAM users can sign in with a passkey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToLoginWithPasskey")]
                [Validation(Required=false)]
                public bool? AllowUserToLoginWithPasskey { get; set; }

                /// <summary>
                /// <para>Specifies whether to save the verification status for seven days after a RAM user completes multi-factor authentication (MFA) during sign-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                /// <summary>
                /// <para>The login network mask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// <para>The duration of the login session for a RAM user, in hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

                /// <summary>
                /// <para>The MFA policy for user sign-in. This parameter is the recommended replacement for <c>EnforceMFAForLogin</c>, which is still supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adaptive</para>
                /// </summary>
                [NameInMap("MFAOperationForLogin")]
                [Validation(Required=false)]
                public string MFAOperationForLogin { get; set; }

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

            }

            /// <summary>
            /// <para>The MFA (multi-factor authentication) preferences.</para>
            /// </summary>
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// <para>Specifies whether RAM users can manage their own MFA devices.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            /// <summary>
            /// <para>Settings for the maximum idle period in days.</para>
            /// </summary>
            [NameInMap("MaxIdleDays")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays MaxIdleDays { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays : TeaModel {
                /// <summary>
                /// <para>The maximum idle period, in days, for an AccessKey of a RAM user. If an AccessKey is not used within the specified period, the system automatically disables it the next day.</para>
                /// <para>Default value: 730.</para>
                /// 
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("MaxIdleDaysForAccessKeys")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForAccessKeys { get; set; }

                /// <summary>
                /// <para>The maximum idle period, in days, for a RAM user. If a RAM user with console sign-in enabled does not sign in within this period, the system automatically disables their console sign-in the next day. This setting does not apply to single sign-on (SSO).</para>
                /// <para>Default value: 730.</para>
                /// 
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("MaxIdleDaysForUsers")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForUsers { get; set; }

            }

            /// <summary>
            /// <para>The personal information preferences.</para>
            /// </summary>
            [NameInMap("PersonalInfoPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference PersonalInfoPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference : TeaModel {
                /// <summary>
                /// <para>Specifies whether RAM users can attach or detach their personal DingTalk accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowUserToManagePersonalDingTalk")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePersonalDingTalk { get; set; }

            }

            /// <summary>
            /// <para>The preferences for MFA methods.</para>
            /// </summary>
            [NameInMap("VerificationPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference VerificationPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference : TeaModel {
                /// <summary>
                /// <para>The allowed MFA methods.</para>
                /// </summary>
                [NameInMap("VerificationTypes")]
                [Validation(Required=false)]
                public List<string> VerificationTypes { get; set; }

            }

        }

    }

}
