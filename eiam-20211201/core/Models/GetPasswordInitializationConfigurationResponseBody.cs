// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordInitializationConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The password initialization configurations.
        /// </summary>
        [NameInMap("PasswordInitializationConfiguration")]
        [Validation(Required=false)]
        public GetPasswordInitializationConfigurationResponseBodyPasswordInitializationConfiguration PasswordInitializationConfiguration { get; set; }
        public class GetPasswordInitializationConfigurationResponseBodyPasswordInitializationConfiguration : TeaModel {
            /// <summary>
            /// Indicates whether forcible password change upon first logon is enabled. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// </summary>
            [NameInMap("PasswordForcedUpdateStatus")]
            [Validation(Required=false)]
            public string PasswordForcedUpdateStatus { get; set; }

            /// <summary>
            /// The methods for receiving password initialization notifications.
            /// </summary>
            [NameInMap("PasswordInitializationNotificationChannels")]
            [Validation(Required=false)]
            public List<string> PasswordInitializationNotificationChannels { get; set; }

            /// <summary>
            /// Indicates whether the password initialization feature is enabled. Valid values:
            /// 
            /// *   enabled
            /// *   disabled
            /// </summary>
            [NameInMap("PasswordInitializationStatus")]
            [Validation(Required=false)]
            public string PasswordInitializationStatus { get; set; }

            /// <summary>
            /// The password initialization method. Set the value to random.
            /// 
            /// *   random: A randomly generated password is used.
            /// </summary>
            [NameInMap("PasswordInitializationType")]
            [Validation(Required=false)]
            public string PasswordInitializationType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
