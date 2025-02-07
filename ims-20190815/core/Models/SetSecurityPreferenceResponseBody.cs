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
        /// <para>The details of security preferences.</para>
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public SetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class SetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// <para>The AccessKey pair preference.</para>
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their AccessKey pairs.</para>
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
            public SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can change their passwords.</para>
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
                /// <para>Indicates whether RAM users can remember the MFA devices for seven days.</para>
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
                /// <para>The validity period of the logon session of RAM users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

                /// <summary>
                /// <para>Indicates whether MFA is required for all RAM users when they log on to the Alibaba Cloud Management Console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adaptive</para>
                /// </summary>
                [NameInMap("MFAOperationForLogin")]
                [Validation(Required=false)]
                public string MFAOperationForLogin { get; set; }

                /// <summary>
                /// <para>Indicates whether to enable MFA for RAM users who initiated unusual logons.</para>
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
            public SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their MFA devices.</para>
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
            public SetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays MaxIdleDays { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMaxIdleDays : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("MaxIdleDaysForAccessKeys")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForAccessKeys { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>730</para>
                /// </summary>
                [NameInMap("MaxIdleDaysForUsers")]
                [Validation(Required=false)]
                public int? MaxIdleDaysForUsers { get; set; }

            }

            /// <summary>
            /// <para>The personal information preference.</para>
            /// </summary>
            [NameInMap("PersonalInfoPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference PersonalInfoPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference : TeaModel {
                /// <summary>
                /// <para>Indicates whether RAM users can manage their personal DingTalk accounts, such as binding and unbinding of the accounts.</para>
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
            public SetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference VerificationPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceVerificationPreference : TeaModel {
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
