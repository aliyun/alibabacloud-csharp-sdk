// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateUserPasswordRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new password of the account. For more information about the password format, see the "Password Policies" topic.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to enable forcible password change upon first logon. Default value: disabled. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// </summary>
        [NameInMap("PasswordForcedUpdateStatus")]
        [Validation(Required=false)]
        public string PasswordForcedUpdateStatus { get; set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The methods for receiving password notifications.
        /// </summary>
        [NameInMap("UserNotificationChannels")]
        [Validation(Required=false)]
        public List<string> UserNotificationChannels { get; set; }

    }

}
