// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetSecurityPreferenceRequest : TeaModel {
        /// <summary>
        /// Specifies whether RAM users can change their passwords. Valid values:
        /// 
        /// *   true: RAM users can change their passwords. This is the default value.
        /// *   false: RAM users cannot change their passwords.
        /// </summary>
        [NameInMap("AllowUserToChangePassword")]
        [Validation(Required=false)]
        public bool? AllowUserToChangePassword { get; set; }

        /// <summary>
        /// Specifies whether RAM users can manage their AccessKey pairs. Valid values:
        /// 
        /// *   true: RAM users can manage their AccessKey pairs.
        /// *   false: RAM users cannot manage their AccessKey pairs. This is the default value.
        /// </summary>
        [NameInMap("AllowUserToManageAccessKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManageAccessKeys { get; set; }

        /// <summary>
        /// Specifies whether RAM users can manage their MFA devices. Valid values:
        /// 
        /// *   true: RAM users can manage their MFA devices. This is the default value.
        /// *   false: RAM users cannot manage their MFA devices.
        /// </summary>
        [NameInMap("AllowUserToManageMFADevices")]
        [Validation(Required=false)]
        public bool? AllowUserToManageMFADevices { get; set; }

        /// <summary>
        /// Specifies whether RAM users can manage their public keys. Valid values:
        /// 
        /// *   true: RAM users can manage their public keys.
        /// *   false: RAM users cannot manage their public keys. This is the default value.
        /// 
        /// >  This parameter is valid only for the Japan site.
        /// </summary>
        [NameInMap("AllowUserToManagePublicKeys")]
        [Validation(Required=false)]
        public bool? AllowUserToManagePublicKeys { get; set; }

        /// <summary>
        /// Specifies whether to remember the multi-factor authentication (MFA) devices of Resource Access Management (RAM) users for seven days. Valid values:
        /// 
        /// *   true: remembers the MFA devices of RAM users for seven days.
        /// *   false: does not remember the MFA devices of RAM users for seven days.
        /// </summary>
        [NameInMap("EnableSaveMFATicket")]
        [Validation(Required=false)]
        public bool? EnableSaveMFATicket { get; set; }

        /// <summary>
        /// The subnet mask that specifies the IP addresses from which you can log on to the Alibaba Cloud Management Console. This parameter takes effect on password-based logon and single sign-on (SSO). However, this parameter does not take effect on API calls that are authenticated by using AccessKey pairs.
        /// 
        /// *   If you specify a subnet mask, RAM users can use only the IP addresses in the subnet mask to log on to the Alibaba Cloud Management Console.
        /// *   If you do not specify a subnet mask, RAM users can use all IP addresses to log on to the Alibaba Cloud Management Console.
        /// 
        /// If you need to specify multiple subnet masks, separate the subnet masks with semicolons (;). Example: 192.168.0.0/16;10.0.0.0/8.
        /// 
        /// You can specify up to 25 subnet masks. The total length of the subnet masks can be a maximum of 512 characters.
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

        /// <summary>
        /// The validity period of the logon session of RAM users.
        /// 
        /// Valid values: 1 to 24. Default value: 6. Unit: hours.
        /// </summary>
        [NameInMap("LoginSessionDuration")]
        [Validation(Required=false)]
        public int? LoginSessionDuration { get; set; }

    }

}
