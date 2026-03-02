// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetSecurityPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30C9068D-FBAA-4998-9986-8A562FED0BC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about security preferences.</para>
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public GetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class GetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// <para>The AccessKey preference.</para>
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their own AccessKey pairs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// </description></item>
                /// <item><description><para>false</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }

            /// <summary>
            /// <para>The logon preferences.</para>
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their own passwords. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
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
                /// <para>Indicates whether RAM users can log on using passkeys. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
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
                /// <para>Indicates whether to save the multi-factor authentication (MFA) status for seven days after a RAM user logs on using MFA. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// </description></item>
                /// <item><description><para>false</para>
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
                /// <para>The the IP addresses or CIDR blocks from which RAM users are allowed to sign in to the Alibaba Cloud console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// <para>The duration of a logon session for a RAM user. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

                /// <summary>
                /// <para>Indicates whether MFA is required for logon. This parameter replaces <c>EnforceMFAForLogin</c>. The <c>EnforceMFAForLogin</c> parameter is still valid, but using this new parameter is recommended. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>mandatory: MFA is required for all RAM users. This value corresponds to <c>true</c> for the <c>EnforceMFAForLogin</c> parameter.</para>
                /// </description></item>
                /// <item><description><para>independent (default): The MFA configuration of each RAM user is used. This value corresponds to <c>false</c> for the <c>EnforceMFAForLogin</c> parameter.</para>
                /// </description></item>
                /// <item><description><para>adaptive: MFA is required only for abnormal logons.</para>
                /// </description></item>
                /// </list>
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
                /// <para>Indicates whether to use MFA for secondary authentication during an abnormal logon. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>autonomous (default): The secondary authentication can be skipped. The attachment of an MFA device is not required.</para>
                /// </description></item>
                /// <item><description><para>enforceVerify: The secondary authentication is required.</para>
                /// </description></item>
                /// </list>
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
            /// <para>The MFA preferences.</para>
            /// </summary>
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their own MFA devices. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
                /// </description></item>
                /// <item><description><para>false</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the maximum idle period.</para>
            /// </summary>
            [NameInMap("MaxIdleDays")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays MaxIdleDays { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays : TeaModel {
                /// <summary>
                /// <para>The maximum idle period for the AccessKey pair of a RAM user. If an AccessKey pair remains unused for this period, it is automatically disabled the next day.</para>
                /// <para>Default value: 730.</para>
                /// <para>Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("MaxIdleDaysForAccessKeys")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForAccessKeys { get; set; }

                /// <summary>
                /// <para>The maximum idle period for RAM users. If a RAM user with console logon enabled remains inactive for this period, their console logon is automatically disabled the next day. This does not apply to single sign-on (SSO) logons.</para>
                /// <para>Default value: 730.</para>
                /// <para>Unit: days.</para>
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
            public GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference PersonalInfoPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can attach or detach their personal DingTalk accounts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true</para>
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

            }

            /// <summary>
            /// <para>The preferences for MFA methods.</para>
            /// </summary>
            [NameInMap("VerificationPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference VerificationPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference : TeaModel {
                /// <summary>
                /// <para>The MFA methods.</para>
                /// </summary>
                [NameInMap("VerificationTypes")]
                [Validation(Required=false)]
                public List<string> VerificationTypes { get; set; }

            }

        }

    }

}
