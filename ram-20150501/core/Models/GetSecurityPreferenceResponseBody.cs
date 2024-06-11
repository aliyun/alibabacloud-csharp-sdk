// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetSecurityPreferenceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The security preferences.
        /// </summary>
        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public GetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class GetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// The AccessKey pair preference.
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their AccessKey pairs. Valid values:
                /// 
                /// *   true: RAM users can manage their AccessKey pairs.
                /// *   false: RAM users cannot manage their AccessKey pairs.
                /// </summary>
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }

            /// <summary>
            /// The logon preferences.
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can change their passwords. Valid values:
                /// 
                /// *   true: RAM users can change their passwords.
                /// *   false: RAM users cannot change their passwords.
                /// </summary>
                [NameInMap("AllowUserToChangePassword")]
                [Validation(Required=false)]
                public bool? AllowUserToChangePassword { get; set; }

                /// <summary>
                /// Indicates whether RAM users can save security codes for multi-factor authentication (MFA) during logon. Each security code is valid for seven days. Valid values:
                /// 
                /// *   true: RAM users can save MFA security codes during logon.
                /// *   false: RAM users cannot save MFA security codes during logon.
                /// </summary>
                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                /// <summary>
                /// The subnet mask that indicates the IP addresses from which logon to the Alibaba Cloud Management Console is allowed. This parameter applies to password-based logon and single sign-on (SSO). However, this parameter does not apply to API calls that are authenticated based on AccessKey pairs.
                /// 
                /// *   If a subnet mask is specified, RAM users can log on to the Alibaba Cloud Management Console only by using the IP addresses in the subnetwork.
                /// *   If no subnet mask is specified, RAM users can log on to the Alibaba Cloud Management Console by using all IP addresses.
                /// 
                /// If more than one subnet mask is specified, the masks are separated with semicolons (;), for example, 192.168.0.0/16;10.0.0.0/8.
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// The validity period of a logon session of a RAM user. Unit: hours.
                /// </summary>
                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

            }

            /// <summary>
            /// The MFA preference.
            /// </summary>
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their MFA devices. Valid values:
                /// 
                /// *   true: RAM users can manage their MFA devices.
                /// *   false: RAM users cannot manage their MFA devices.
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            /// <summary>
            /// The public key preference.
            /// 
            /// >  The public key preference is valid only for the Japan site.
            /// </summary>
            [NameInMap("PublicKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference PublicKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their public keys. Valid values:
                /// 
                /// *   true: RAM users can manage their public keys.
                /// *   false: RAM users cannot manage their public keys.
                /// </summary>
                [NameInMap("AllowUserToManagePublicKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePublicKeys { get; set; }

            }

        }

    }

}
