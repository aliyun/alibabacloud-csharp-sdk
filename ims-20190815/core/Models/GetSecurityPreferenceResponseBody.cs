// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetSecurityPreferenceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityPreference")]
        [Validation(Required=false)]
        public GetSecurityPreferenceResponseBodySecurityPreference SecurityPreference { get; set; }
        public class GetSecurityPreferenceResponseBodySecurityPreference : TeaModel {
            [NameInMap("AccessKeyPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference AccessKeyPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceAccessKeyPreference : TeaModel {
                [NameInMap("AllowUserToManageAccessKeys")]
                [Validation(Required=false)]
                public bool? AllowUserToManageAccessKeys { get; set; }

            }

            [NameInMap("LoginProfilePreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference LoginProfilePreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceLoginProfilePreference : TeaModel {
                [NameInMap("AllowUserToChangePassword")]
                [Validation(Required=false)]
                public bool? AllowUserToChangePassword { get; set; }

                [NameInMap("EnableSaveMFATicket")]
                [Validation(Required=false)]
                public bool? EnableSaveMFATicket { get; set; }

                [NameInMap("EnforceMFAForLogin")]
                [Validation(Required=false)]
                public bool? EnforceMFAForLogin { get; set; }

                [NameInMap("LoginNetworkMasks")]
                [Validation(Required=false)]
                public string LoginNetworkMasks { get; set; }

                [NameInMap("LoginSessionDuration")]
                [Validation(Required=false)]
                public int? LoginSessionDuration { get; set; }

            }

            [NameInMap("MFAPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference MFAPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferenceMFAPreference : TeaModel {
                [NameInMap("AllowUserToManageMFADevices")]
                [Validation(Required=false)]
                public bool? AllowUserToManageMFADevices { get; set; }

            }

            [NameInMap("PersonalInfoPreference")]
            [Validation(Required=false)]
            public GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference PersonalInfoPreference { get; set; }
            public class GetSecurityPreferenceResponseBodySecurityPreferencePersonalInfoPreference : TeaModel {
                [NameInMap("AllowUserToManagePersonalDingTalk")]
                [Validation(Required=false)]
                public bool? AllowUserToManagePersonalDingTalk { get; set; }

            }

        }

    }

}
