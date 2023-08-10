// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordExpirationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The password expiration configurations.
        /// </summary>
        [NameInMap("PasswordExpirationConfiguration")]
        [Validation(Required=false)]
        public GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration PasswordExpirationConfiguration { get; set; }
        public class GetPasswordExpirationConfigurationResponseBodyPasswordExpirationConfiguration : TeaModel {
            /// <summary>
            /// The action to take when a password expires. Valid values:
            /// 
            /// *   forbid_login: Prohibit the user from using the password to log on to IDaaS.
            /// *   force_update_password: Force the user to change the password.
            /// *   remind_update_password: Remind the user to change the password.
            /// </summary>
            [NameInMap("PasswordExpirationAction")]
            [Validation(Required=false)]
            public string PasswordExpirationAction { get; set; }

            /// <summary>
            /// The methods for receiving password expiration notifications.
            /// </summary>
            [NameInMap("PasswordExpirationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordExpirationNotificationChannels { get; set; }

            /// <summary>
            /// The number of days before the expiration date during which password expiration notifications are sent. Unit: day.
            /// </summary>
            [NameInMap("PasswordExpirationNotificationDuration")]
            [Validation(Required=false)]
            public int? PasswordExpirationNotificationDuration { get; set; }

            /// <summary>
            /// Indicates whether the password expiration notification feature is enabled. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// </summary>
            [NameInMap("PasswordExpirationNotificationStatus")]
            [Validation(Required=false)]
            public string PasswordExpirationNotificationStatus { get; set; }

            /// <summary>
            /// Indicates whether the password expiration feature is enabled. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// </summary>
            [NameInMap("PasswordExpirationStatus")]
            [Validation(Required=false)]
            public string PasswordExpirationStatus { get; set; }

            /// <summary>
            /// The number of days before which users must change the password to prevent password expiration. Unit: day.
            /// </summary>
            [NameInMap("PasswordForcedUpdateDuration")]
            [Validation(Required=false)]
            public int? PasswordForcedUpdateDuration { get; set; }

            /// <summary>
            /// The validity period of a password. Unit: day.
            /// </summary>
            [NameInMap("PasswordValidMaxDay")]
            [Validation(Required=false)]
            public int? PasswordValidMaxDay { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
