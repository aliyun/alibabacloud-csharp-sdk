// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordInitializationConfigurationRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable forcible password change upon first logon. Valid values:
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
        /// Specifies whether to enable password initialization. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// </summary>
        [NameInMap("PasswordInitializationStatus")]
        [Validation(Required=false)]
        public string PasswordInitializationStatus { get; set; }

        /// <summary>
        /// The password initialization method. This parameter is required when PasswordInitializationStatus is set to enabled. Set the value to random.
        /// 
        /// *   random: A randomly generated password is used.
        /// </summary>
        [NameInMap("PasswordInitializationType")]
        [Validation(Required=false)]
        public string PasswordInitializationType { get; set; }

    }

}
