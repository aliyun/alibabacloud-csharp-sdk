// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetSecurityPreferenceResponseBody : TeaModel {
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
        public SetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class SetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            /// <summary>
            /// The AccessKey pair preference.
            /// </summary>
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their AccessKey pairs.
                /// </summary>
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }

            /// <summary>
            /// The logon preference.
            /// </summary>
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can change their passwords.
                /// </summary>
                [NameInMap("AllowUserToChangePassword")]
                [Validation(Required=false)]
                public bool? AllowUserToChangePassword { get; set; }

                /// <summary>
                /// Indicates whether the MFA devices of RAM users are remembered.
                /// </summary>
                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                /// <summary>
                /// The subnet mask.
                /// </summary>
                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                /// <summary>
                /// The validity period of the logon session of RAM users.
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
            public SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their MFA devices.
                /// </summary>
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            /// <summary>
            /// The public key preference.
            /// 
            /// >  This parameter is valid only for the Japan site.
            /// </summary>
            [NameInMap("PublicKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference PublicKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference : TeaModel {
                /// <summary>
                /// Indicates whether RAM users can manage their public keys.
                /// </summary>
                [NameInMap("AllowUserToManagePublicKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePublicKeys { get; set; }

            }

        }

    }

}
