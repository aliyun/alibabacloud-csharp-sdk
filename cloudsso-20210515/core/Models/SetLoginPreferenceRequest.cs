// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetLoginPreferenceRequest : TeaModel {
        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The IP address whitelist. CloudSSO users can log on to the CloudSSO user portal only by using the IP addresses in the whitelist. Limits:
        /// 
        /// *   You can enter IP addresses or CIDR blocks. IPv4 addresses are supported.
        /// *   You can enter up to 100 IP addresses or CIDR blocks. Separate multiple IP addresses or CIDR blocks with semicolons `(;)`.
        /// *   If you do not specify this parameter, the original settings are retained.
        /// *   If you set this parameter to a semicolon (`;`), the value of this parameter is cleared.
        /// *   The IP address whitelist takes effect only on CloudSSO users who want to log on to the CloudSSO user portal by using the username-password logon or single sign-on (SSO) method. The IP address whitelist does not take effect on CloudSSO users who access accounts in a resource directory from the CloudSSO user portal.
        /// </summary>
        [NameInMap("LoginNetworkMasks")]
        [Validation(Required=false)]
        public string LoginNetworkMasks { get; set; }

    }

}
