// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetSecurityPreferenceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public SetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class SetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }
            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                [NameInMap("AllowUserToChangePassword")]
                [Validation(Required=false)]
                public bool? AllowUserToChangePassword { get; set; }

                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

            }
            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }
            [NameInMap("PublicKeyPreference")]
            [Validation(Required=false)]
            public SetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference PublicKeyPreference { get; set; }
            public class SetSecurityPreferenceResponseBodySecurityPreferencePublicKeyPreference : TeaModel {
                [NameInMap("AllowUserToManagePublicKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePublicKeys { get; set; }

            }
        };

    }

}
