// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyUserRequest : TeaModel {
        /// <summary>
        /// The new description of the user. The description can be up to 500 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The new display name of the user. This display name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The end of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public long? EffectiveEndTime { get; set; }

        /// <summary>
        /// The beginning of the validity period of the user. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public long? EffectiveStartTime { get; set; }

        /// <summary>
        /// The new email address of the user.
        /// 
        /// > This parameter is required when the TwoFactorStatus parameter is set to Enable and the TwoFactorMethods parameter is set to email.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The ID of the bastion host where you want to modify user information.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The new mobile number of the user.
        /// 
        /// > This parameter is required when the TwoFactorStatus parameter is set to Enable and the TwoFactorMethods parameter is set to sms or dingtalk.
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// The country where the new mobile number of the user is registered. Valid values:
        /// 
        /// *   **CN:** the Chinese mainland, whose country calling code is +86
        /// *   **HK:** Hong Kong (China), whose country calling code is +852
        /// *   **MO:** Macao (China), whose country calling code is +853
        /// *   **TW:** Taiwan (China), whose country calling code is +886
        /// *   **RU:** Russia, whose country calling code is +7
        /// *   **SG:** Singapore, whose country calling code is +65
        /// *   **MY:** Malaysia, whose country calling code is +60
        /// *   **ID:** Indonesia, whose country calling code is +62
        /// *   **DE:** Germany, whose country calling code is +49
        /// *   **AU:** Australia, whose country calling code is +61
        /// *   **US:** US, whose country calling code is +1
        /// *   **AE:** United Arab Emirates, whose country calling code is +971
        /// *   **JP:** Japan, whose country calling code is +81
        /// *   **GB:** UK, whose country calling code is +44
        /// *   **IN:** India, whose country calling code is +91
        /// *   **KR:** Republic of Korea, whose country calling code is +82
        /// *   **PH:** Philippines, whose country calling code is +63
        /// *   **CH:** Switzerland, whose country calling code is +41
        /// *   **SE:** Sweden, whose country calling code is +46
        /// *   **SA:** Saudi Arabia, whose country calling code is +966
        /// </summary>
        [NameInMap("MobileCountryCode")]
        [Validation(Required=false)]
        public string MobileCountryCode { get; set; }

        /// <summary>
        /// The original password of the user. The password must be 8 to 128 characters in length and must contain lowercase letters, uppercase letters, digits, and special characters.
        /// </summary>
        [NameInMap("NeedResetPassword")]
        [Validation(Required=false)]
        public bool? NeedResetPassword { get; set; }

        /// <summary>
        /// The new password of the user. The password must be 8 to 128 characters in length and must contain lowercase letters, uppercase letters, digits, and special characters.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The region ID of the bastion host where you want to modify user information.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The two-factor authentication method. You can select only one method. Valid values:
        /// 
        /// *   **sms:** text message
        /// *   **email:** email
        /// *   **dingtalk:** DingTalk
        /// *   **totp OTP:** time-based one-time password (TOTP) app
        /// 
        /// > 
        /// 
        /// *   When the TwoFactorStatus parameter is set to Enable, you must specify one of the preceding values.
        /// </summary>
        [NameInMap("TwoFactorMethods")]
        [Validation(Required=false)]
        public string TwoFactorMethods { get; set; }

        /// <summary>
        /// The two-factor authentication status of the user. Valid values:
        /// 
        /// *   **Global:** follows the global settings
        /// *   **Disable:** disables two-factor authentication
        /// *   **Enable:** enable two-factor authentication and follows settings of the single user
        /// </summary>
        [NameInMap("TwoFactorStatus")]
        [Validation(Required=false)]
        public string TwoFactorStatus { get; set; }

        /// <summary>
        /// The ID of the user whose information you want to modify.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
