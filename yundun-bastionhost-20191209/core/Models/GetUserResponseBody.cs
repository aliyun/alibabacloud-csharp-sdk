// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the user that was queried.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// The description of the user.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The display name of the user.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("EffectiveEndTime")]
            [Validation(Required=false)]
            public long? EffectiveEndTime { get; set; }

            [NameInMap("EffectiveStartTime")]
            [Validation(Required=false)]
            public long? EffectiveStartTime { get; set; }

            /// <summary>
            /// The email address of the user.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The mobile number of the user.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// The country where the mobile number of the user is registered. Valid values:
            /// 
            /// *   **CN**: the Chinese mainland, whose country calling code is +86
            /// *   **HK**: Hong Kong (China), whose country calling code is +852
            /// *   **MO**: Macau (China), whose country calling code is +853
            /// *   **TW**: Taiwan (China), whose country calling code is +886
            /// *   **RU**: Russia, whose country calling code is +7
            /// *   **SG**: Singapore, whose country calling code is +65
            /// *   **MY**: Malaysia, whose country calling code is +60
            /// *   **ID**: Indonesia, whose country calling code is +62
            /// *   **DE**: Germany, whose country calling code is +49
            /// *   **AU**: Australia, whose country calling code is +61
            /// *   **US**: United States, whose country calling code is +1
            /// *   **AE**: United Arab Emirates, whose country calling code is +971
            /// *   **JP**: Japan, whose country calling code is +81
            /// *   **GB**: United Kingdom, whose country calling code is +44
            /// *   **IN**: India, whose country calling code is +91
            /// *   **KR**: South Korea, whose country calling code is +82
            /// *   **PH**: Philippines, whose country calling code is +63
            /// *   **CH**: Switzerland, whose country calling code is +41
            /// *   **SE**: Sweden, whose country calling code is +46
            /// </summary>
            [NameInMap("MobileCountryCode")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            [NameInMap("NeedResetPassword")]
            [Validation(Required=false)]
            public bool? NeedResetPassword { get; set; }

            /// <summary>
            /// The source of the user. Valid values:
            /// 
            /// *   **Local**: a local user
            /// *   **Ram**: a RAM user
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The unique ID of the user.
            /// 
            /// >  This parameter uniquely identifies a RAM user of the Bastionhost instance. A value is returned for this parameter if the **Source** parameter is set to **Ram**. No value is returned for this parameter if the **Source** parameter is set to **Local**.
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public string SourceUserId { get; set; }

            [NameInMap("TwoFactorMethods")]
            [Validation(Required=false)]
            public List<string> TwoFactorMethods { get; set; }

            [NameInMap("TwoFactorStatus")]
            [Validation(Required=false)]
            public string TwoFactorStatus { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The logon name of the user.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The statuses of the user.
            /// </summary>
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public List<string> UserState { get; set; }

        }

    }

}
