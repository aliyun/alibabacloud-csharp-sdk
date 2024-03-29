// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetLoginPreferenceResponseBody : TeaModel {
        /// <summary>
        /// The logon preference.
        /// </summary>
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyLoginPreference LoginPreference { get; set; }
        public class GetLoginPreferenceResponseBodyLoginPreference : TeaModel {
            /// <summary>
            /// The IP address whitelist. CloudSSO users can log on to the CloudSSO user portal only by using the IP addresses in the whitelist.
            /// 
            /// The IP address whitelist takes effect only on CloudSSO users who want to log on to the CloudSSO user portal by using the username-password logon or single sign-on (SSO) method. The IP address whitelist does not take effect on CloudSSO users who access accounts in a resource directory from the CloudSSO user portal.
            /// 
            /// If the return value of this parameter is empty, no IP address whitelists are configured.
            /// </summary>
            [NameInMap("LoginNetworkMasks")]
            [Validation(Required=false)]
            public string LoginNetworkMasks { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
