// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyInstanceTwoFactorRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable two-factor authentication. Valid values:
        /// 
        /// *   **true**: enables two-factor authentication.
        /// *   **false**: disables two-factor authentication.
        /// </summary>
        [NameInMap("EnableTwoFactor")]
        [Validation(Required=false)]
        public string EnableTwoFactor { get; set; }

        /// <summary>
        /// The ID of the bastion host.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the bastion host.
        /// 
        /// >  For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The duration within which two-factor authentication is not required after a local user passes two-factor authentication. Valid values: 0 to 168. Unit: hours. If you set this parameter to 0, the local user must pass two-factor authentication every time the local user logs on to the bastion host.
        /// </summary>
        [NameInMap("SkipTwoFactorTime")]
        [Validation(Required=false)]
        public string SkipTwoFactorTime { get; set; }

        /// <summary>
        /// One or more methods that are used to send a verification code if two-factor authentication is enabled. If you set the EnableTwoFactor parameter to true, you must specify at least one method. Valid values:
        /// 
        /// *   **sms**: text message
        /// *   **email**: email
        /// *   **dingtalk**: Notice in DingTalk
        /// </summary>
        [NameInMap("TwoFactorMethods")]
        [Validation(Required=false)]
        public string TwoFactorMethods { get; set; }

    }

}
