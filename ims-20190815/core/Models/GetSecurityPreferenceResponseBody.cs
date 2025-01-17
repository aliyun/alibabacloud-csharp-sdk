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
        /// <para>The details of security preferences.</para>
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public GetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class GetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// <para>The AccessKey pair preference.</para>
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their AccessKey pairs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
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
            /// <para>The logon preference.</para>
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can change their passwords. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
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
                /// <para>Indicates whether RAM users can remember the multi-factor authentication (MFA) devices for seven days. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                /// <summary>
                /// <para>The subnet mask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/8</para>
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// <para>The validity period of the logon session of RAM users. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

                /// <summary>
                /// <para>Indicates whether MFA is required for all RAM users when they log on to the Alibaba Cloud Management Console. Valid values:</para>
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
                /// <para>Indicates whether to enable MFA for RAM users who initiated unusual logons. Valid values:</para>
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

            }

            /// <summary>
            /// <para>The MFA preference.</para>
            /// </summary>
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their MFA devices. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            [NameInMap("MaxIdleDays")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays MaxIdleDays { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays : TeaModel {
                [NameInMap("MaxIdleDaysForAccessKeys")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForAccessKeys { get; set; }

                [NameInMap("MaxIdleDaysForUsers")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForUsers { get; set; }

            }

            /// <summary>
            /// <para>The personal information preference.</para>
            /// </summary>
            [NameInMap("PersonalInfoPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference PersonalInfoPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their personal DingTalk accounts, such as binding and unbinding of the accounts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
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
            /// <para>The MFA method preference.</para>
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
