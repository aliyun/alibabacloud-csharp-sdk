// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordExpirationConfigurationRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The action to take upon password expiration. This parameter must be specified when PasswordExpirationStatus is set to enabled. Valid values:
        /// 
        /// *   forbid_login: Users cannot log on to IDaaS.
        /// *   force_update_password: Users must change the password.
        /// *   remind_update_password: IDaaS reminds users to change the password upon each logon.
        /// </summary>
        [NameInMap("PasswordExpirationAction")]
        [Validation(Required=false)]
        public string PasswordExpirationAction { get; set; }

        /// <summary>
        /// The methods for receiving password expiration notifications. This parameter must be specified when PasswordExpirationNotificationStatus is set to enabled.
        /// </summary>
        [NameInMap("PasswordExpirationNotificationChannels")]
        [Validation(Required=false)]
        public List<string> PasswordExpirationNotificationChannels { get; set; }

        /// <summary>
        /// The number of days before the expiration date during which password expiration notifications are sent. Unit: day. This parameter must be specified when PasswordExpirationNotificationStatus is set to enabled.
        /// </summary>
        [NameInMap("PasswordExpirationNotificationDuration")]
        [Validation(Required=false)]
        public int? PasswordExpirationNotificationDuration { get; set; }

        /// <summary>
        /// Specifies whether to enable the password expiration notification feature. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// </summary>
        [NameInMap("PasswordExpirationNotificationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationNotificationStatus { get; set; }

        /// <summary>
        /// Specifies whether to enable the password expiration feature. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// </summary>
        [NameInMap("PasswordExpirationStatus")]
        [Validation(Required=false)]
        public string PasswordExpirationStatus { get; set; }

        /// <summary>
        /// The number of days before which users must change the password to prevent password expiration. Unit: day. You must set this parameter to a value greater than the value of PasswordExpirationNotificationDuration.
        /// </summary>
        [NameInMap("PasswordForcedUpdateDuration")]
        [Validation(Required=false)]
        public int? PasswordForcedUpdateDuration { get; set; }

        /// <summary>
        /// The validity period of a password. Unit: day. This parameter must be specified when PasswordExpirationStatus is set to enabled.
        /// </summary>
        [NameInMap("PasswordValidMaxDay")]
        [Validation(Required=false)]
        public int? PasswordValidMaxDay { get; set; }

    }

}
